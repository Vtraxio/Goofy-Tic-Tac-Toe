using System.Diagnostics;

namespace WinFormsApp1 {
	public partial class Form1 : Form {
		private new enum Move {
			None = 0,
			X,
			O
		}

		private          Move         _currentMove = Move.None;
		private readonly List<Button> _buttons;

		// Nie wyczytujemy stanu gry z przycisków, tylko z tej tabeli
		private readonly Move[] _moves = new Move[9];

		// Wygrywalne pozycje na planszy 0..=8 (indeksy)
		private readonly int[][] _winPos = [[0, 1, 2], [3, 4, 5], [6, 7, 8], [0, 3, 6], [1, 4, 7], [2, 5, 8], [0, 4, 8], [2, 4, 6]];

		public Form1() {
			InitializeComponent();
			// Lista przycisków, aby mo¿na by³o otrzymaæ ich index (FindIndex)
			_buttons = [button1, button2, button3, button4, button5, button6, button7, button8, button9];
			Reset();
		}

		private void MainButtonClick(object sender, EventArgs e) {
			var button   = (Button)sender;
			var currText = button.Text;

			if (currText != "") { // Jest zape³niony
				return;
			}

			button.Text = MoveChr(_currentMove);
			var btnIndex = _buttons.FindIndex((x) => x.Name == button.Name);
			_moves[btnIndex] = _currentMove;

			if (_moves.All(x => x != Move.None)) { // Remis, wszystkie pola s¹ wype³nione (nie s¹ puste)
				MessageBox.Show("Remis", "Kó³ko i krzy¿yk");
				Reset();
				return;
			}

			if (CheckWin())
				return;

			_currentMove = _currentMove == Move.X ? Move.O : Move.X;
			status.Text  = $"Ruch {MoveChr(_currentMove)}";
		}

		// Bombowy "algorytm", który kiedyœ znalaz³em,
		// w 2 klasie u¿y³em go do kó³ka i krzy¿yk na stronach internetowych
		// wieæ postanowi³em ponownie tu go wstawiæ, ¿eby nie robiæ milliard if`ów
		// True-wygrana; False-kontynuuj
		private bool CheckWin() {
			foreach (var pos in _winPos) {
				Debug.Assert(pos.Length <= 3); // ;)

				// _moves[pos[0]] == _currentMove && _moves[pos[1]] == _currentMove && _moves[pos[2]] == _currentMove
				if (pos.All(x => _moves[x] == _currentMove)) { // Lepsza wersja if`a z trzema równaniami
					foreach (var btnIndex in pos) {
						_buttons[btnIndex].BackColor = Color.DarkOrange;
					}

					MessageBox.Show($"{MoveChr(_currentMove)} wygrywa", "Kó³ko i krzy¿yk");

					Reset();

					return true;
				}
			}

			return false;
		}

		private void Reset() {
			_currentMove = Move.O;
			status.Text  = "Ruch O";

			for (var j = 0; j < _buttons.Count; j++) {
				_buttons[j].Text      = "";
				_buttons[j].BackColor = DefaultBackColor;
				_moves[j]             = Move.None;
			}
		}

		private string MoveChr(Move move) {
			return move switch {
				Move.X => "X",
				Move.O => "O",
				_      => "?"
			};
		}
	}
}