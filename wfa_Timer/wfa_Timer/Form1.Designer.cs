namespace wfa_Timer
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
            CheckBox cbox;
            butUp = new Button();
            label1 = new Label();
            but_start_pause = new Button();
            but_h = new Button();
            but_m = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            but_s = new Button();
            but_clear = new Button();
            label5 = new Label();
            prog_1 = new ProgressBar();
            label6 = new Label();
            cbox = new CheckBox();
            SuspendLayout();
            // 
            // cbox
            // 
            cbox.AutoSize = true;
            cbox.Font = new Font("BankGothic Lt BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbox.Location = new Point(52, 269);
            cbox.Name = "cbox";
            cbox.Size = new Size(158, 26);
            cbox.TabIndex = 11;
            cbox.Text = "CountDown";
            cbox.UseVisualStyleBackColor = true;
            cbox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // butUp
            // 
            butUp.BackColor = Color.Transparent;
            butUp.FlatStyle = FlatStyle.Popup;
            butUp.Font = new Font("BankGothic Lt BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            butUp.ForeColor = SystemColors.ActiveCaptionText;
            butUp.Location = new Point(52, 74);
            butUp.Name = "butUp";
            butUp.Size = new Size(237, 60);
            butUp.TabIndex = 0;
            butUp.Text = "00.00.00";
            butUp.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("BankGothic Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 208);
            label1.Name = "label1";
            label1.Size = new Size(153, 19);
            label1.TabIndex = 1;
            label1.Text = "START/PAUSE";
            // 
            // but_start_pause
            // 
            but_start_pause.FlatStyle = FlatStyle.System;
            but_start_pause.Location = new Point(136, 230);
            but_start_pause.Name = "but_start_pause";
            but_start_pause.Size = new Size(153, 23);
            but_start_pause.TabIndex = 2;
            but_start_pause.UseVisualStyleBackColor = true;
            but_start_pause.Click += but_start_pause_Click;
            // 
            // but_h
            // 
            but_h.Location = new Point(52, 175);
            but_h.Name = "but_h";
            but_h.Size = new Size(71, 23);
            but_h.TabIndex = 3;
            but_h.UseVisualStyleBackColor = true;
            but_h.Click += but_h_Click;
            // 
            // but_m
            // 
            but_m.Location = new Point(134, 175);
            but_m.Name = "but_m";
            but_m.Size = new Size(71, 23);
            but_m.TabIndex = 4;
            but_m.UseVisualStyleBackColor = true;
            but_m.Click += but_m_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("BankGothic Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 153);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 5;
            label2.Text = "HOUR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("BankGothic Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(136, 153);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 6;
            label3.Text = "MIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("BankGothic Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(220, 153);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 8;
            label4.Text = "SEC";
            // 
            // but_s
            // 
            but_s.Location = new Point(220, 175);
            but_s.Name = "but_s";
            but_s.Size = new Size(71, 23);
            but_s.TabIndex = 7;
            but_s.UseVisualStyleBackColor = true;
            but_s.Click += but_s_Click;
            // 
            // but_clear
            // 
            but_clear.FlatStyle = FlatStyle.System;
            but_clear.Location = new Point(52, 230);
            but_clear.Name = "but_clear";
            but_clear.Size = new Size(71, 23);
            but_clear.TabIndex = 10;
            but_clear.UseVisualStyleBackColor = true;
            but_clear.Click += but_clear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("BankGothic Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 208);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 9;
            label5.Text = "CLEAR";
            // 
            // prog_1
            // 
            prog_1.Location = new Point(47, 326);
            prog_1.Name = "prog_1";
            prog_1.Size = new Size(239, 23);
            prog_1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("BankGothic Lt BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 304);
            label6.Name = "label6";
            label6.Size = new Size(108, 19);
            label6.TabIndex = 14;
            label6.Text = "Progress";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 375);
            Controls.Add(label6);
            Controls.Add(prog_1);
            Controls.Add(cbox);
            Controls.Add(but_clear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(but_s);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(but_m);
            Controls.Add(but_h);
            Controls.Add(but_start_pause);
            Controls.Add(label1);
            Controls.Add(butUp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butUp;
        private Label label1;
        private Button but_start_pause;
        private Button but_h;
        private Button but_m;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button but_s;
        private Button but_clear;
        private Label label5;
        private ProgressBar prog_1;
        private Label label6;
    }
}