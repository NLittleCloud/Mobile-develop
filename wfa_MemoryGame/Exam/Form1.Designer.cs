namespace Exam
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
            table_panel = new TableLayoutPanel();
            btn_Turn = new Button();
            l_time = new Label();
            cmb_level = new ComboBox();
            label1 = new Label();
            l_score = new Label();
            SuspendLayout();
            // 
            // table_panel
            // 
            table_panel.ColumnCount = 2;
            table_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_panel.Location = new Point(160, 80);
            table_panel.Name = "table_panel";
            table_panel.RowCount = 2;
            table_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 47.9865761F));
            table_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 52.0134239F));
            table_panel.Size = new Size(429, 298);
            table_panel.TabIndex = 0;
            // 
            // btn_Turn
            // 
            btn_Turn.Location = new Point(234, 400);
            btn_Turn.Name = "btn_Turn";
            btn_Turn.Size = new Size(285, 23);
            btn_Turn.TabIndex = 1;
            btn_Turn.Text = "Я запомнил";
            btn_Turn.UseVisualStyleBackColor = true;
            btn_Turn.Click += btn_Turn_Click;
            // 
            // l_time
            // 
            l_time.AutoSize = true;
            l_time.Font = new Font("BankGothic Lt BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            l_time.Location = new Point(323, 35);
            l_time.Name = "l_time";
            l_time.Size = new Size(112, 30);
            l_time.TabIndex = 2;
            l_time.Text = "00:00";
            // 
            // cmb_level
            // 
            cmb_level.FormattingEnabled = true;
            cmb_level.Location = new Point(12, 120);
            cmb_level.Name = "cmb_level";
            cmb_level.Size = new Size(121, 23);
            cmb_level.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("BankGothic Lt BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 4;
            label1.Text = "Уровень";
            // 
            // l_score
            // 
            l_score.AutoSize = true;
            l_score.Font = new Font("BankGothic Lt BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            l_score.Location = new Point(12, 152);
            l_score.Name = "l_score";
            l_score.Size = new Size(80, 22);
            l_score.TabIndex = 5;
            l_score.Text = "Счет: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(672, 450);
            Controls.Add(l_score);
            Controls.Add(label1);
            Controls.Add(cmb_level);
            Controls.Add(l_time);
            Controls.Add(btn_Turn);
            Controls.Add(table_panel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel table_panel;
        private Button btn_Turn;
        private Label l_time;
        private ComboBox cmb_level;
        private Label label1;
        private Label l_score;
    }
}