namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            status = new Label();
            buttonsLayout = new TableLayoutPanel();
            button1 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonsLayout.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // status
            // 
            status.Anchor = AnchorStyles.Bottom;
            status.AutoSize = true;
            status.Location = new Point(235, 399);
            status.Name = "status";
            status.Size = new Size(38, 15);
            status.TabIndex = 10;
            status.Text = "label1";
            // 
            // buttonsLayout
            // 
            buttonsLayout.ColumnCount = 3;
            buttonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            buttonsLayout.Controls.Add(button1, 0, 0);
            buttonsLayout.Controls.Add(button9, 2, 2);
            buttonsLayout.Controls.Add(button8, 1, 2);
            buttonsLayout.Controls.Add(button7, 0, 2);
            buttonsLayout.Controls.Add(button2, 1, 0);
            buttonsLayout.Controls.Add(button3, 2, 0);
            buttonsLayout.Controls.Add(button4, 0, 1);
            buttonsLayout.Controls.Add(button6, 2, 1);
            buttonsLayout.Controls.Add(button5, 1, 1);
            buttonsLayout.Dock = DockStyle.Fill;
            buttonsLayout.Location = new Point(3, 3);
            buttonsLayout.Name = "buttonsLayout";
            buttonsLayout.RowCount = 3;
            buttonsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            buttonsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            buttonsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            buttonsLayout.Size = new Size(502, 393);
            buttonsLayout.TabIndex = 9;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 24F);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(161, 125);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += MainButtonClick;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Segoe UI", 24F);
            button9.Location = new Point(337, 265);
            button9.Name = "button9";
            button9.Size = new Size(162, 125);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            button9.Click += MainButtonClick;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Segoe UI", 24F);
            button8.Location = new Point(170, 265);
            button8.Name = "button8";
            button8.Size = new Size(161, 125);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += MainButtonClick;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Segoe UI", 24F);
            button7.Location = new Point(3, 265);
            button7.Name = "button7";
            button7.Size = new Size(161, 125);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            button7.Click += MainButtonClick;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 24F);
            button2.Location = new Point(170, 3);
            button2.Name = "button2";
            button2.Size = new Size(161, 125);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += MainButtonClick;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI", 24F);
            button3.Location = new Point(337, 3);
            button3.Name = "button3";
            button3.Size = new Size(162, 125);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += MainButtonClick;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Segoe UI", 24F);
            button4.Location = new Point(3, 134);
            button4.Name = "button4";
            button4.Size = new Size(161, 125);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += MainButtonClick;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 24F);
            button6.Location = new Point(337, 134);
            button6.Name = "button6";
            button6.Size = new Size(162, 125);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            button6.Click += MainButtonClick;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI", 24F);
            button5.Location = new Point(170, 134);
            button5.Name = "button5";
            button5.Size = new Size(161, 125);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += MainButtonClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(status, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonsLayout, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(508, 414);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 414);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(250, 250);
            Name = "Form1";
            Text = "Kółko i krzyżyk";
            buttonsLayout.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label status;
        private TableLayoutPanel buttonsLayout;
        private Button button1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
