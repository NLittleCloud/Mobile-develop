namespace wfaСollectionPostmarks
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            btn_OpenF = new Button();
            btn_SaveF = new Button();
            btn_Save = new Button();
            btn_Delete = new Button();
            btn_Clear = new Button();
            pb_Page = new PictureBox();
            lb_str = new ListBox();
            tabPage3 = new TabPage();
            btn_CreatePage = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tb_Columns = new TextBox();
            label9 = new Label();
            tb_Padding = new TextBox();
            cb_Design = new ComboBox();
            cb_Color = new ComboBox();
            tb_Height = new TextBox();
            tb_Width = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_Rows = new TextBox();
            label8 = new Label();
            label7 = new Label();
            pb_PagePreview = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Page).BeginInit();
            tabPage3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_PagePreview).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(1, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1113, 742);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(btn_OpenF);
            tabPage1.Controls.Add(btn_SaveF);
            tabPage1.Controls.Add(btn_Save);
            tabPage1.Controls.Add(btn_Delete);
            tabPage1.Controls.Add(btn_Clear);
            tabPage1.Controls.Add(pb_Page);
            tabPage1.Controls.Add(lb_str);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1105, 714);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Просмотр";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_OpenF
            // 
            btn_OpenF.Location = new Point(6, 303);
            btn_OpenF.Name = "btn_OpenF";
            btn_OpenF.Size = new Size(166, 23);
            btn_OpenF.TabIndex = 6;
            btn_OpenF.Text = "Загрузить коллекцию";
            btn_OpenF.UseVisualStyleBackColor = true;
            btn_OpenF.Click += btn_OpenF_Click;
            // 
            // btn_SaveF
            // 
            btn_SaveF.Location = new Point(6, 274);
            btn_SaveF.Name = "btn_SaveF";
            btn_SaveF.Size = new Size(166, 23);
            btn_SaveF.TabIndex = 5;
            btn_SaveF.Text = "Сохранить колекцию";
            btn_SaveF.UseVisualStyleBackColor = true;
            btn_SaveF.Click += btn_SaveF_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(6, 225);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(166, 23);
            btn_Save.TabIndex = 4;
            btn_Save.Text = "Сохранить bitmap";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(6, 196);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(166, 23);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "Удалить страницу";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(178, 6);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(120, 23);
            btn_Clear.TabIndex = 2;
            btn_Clear.Text = "Отчистить страницу";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // pb_Page
            // 
            pb_Page.BackColor = Color.Transparent;
            pb_Page.BorderStyle = BorderStyle.FixedSingle;
            pb_Page.Location = new Point(359, 16);
            pb_Page.Name = "pb_Page";
            pb_Page.Size = new Size(362, 397);
            pb_Page.SizeMode = PictureBoxSizeMode.AutoSize;
            pb_Page.TabIndex = 1;
            pb_Page.TabStop = false;
            // 
            // lb_str
            // 
            lb_str.FormattingEnabled = true;
            lb_str.ItemHeight = 15;
            lb_str.Location = new Point(6, 6);
            lb_str.Name = "lb_str";
            lb_str.Size = new Size(166, 169);
            lb_str.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BorderStyle = BorderStyle.FixedSingle;
            tabPage3.Controls.Add(btn_CreatePage);
            tabPage3.Controls.Add(tableLayoutPanel1);
            tabPage3.Controls.Add(pb_PagePreview);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1105, 714);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Новая страница";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_CreatePage
            // 
            btn_CreatePage.Location = new Point(15, 348);
            btn_CreatePage.Name = "btn_CreatePage";
            btn_CreatePage.Size = new Size(283, 23);
            btn_CreatePage.TabIndex = 2;
            btn_CreatePage.Text = "Создать страницу";
            btn_CreatePage.UseVisualStyleBackColor = true;
            btn_CreatePage.Click += btn_CreatePage_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tb_Columns, 1, 3);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(tb_Padding, 1, 7);
            tableLayoutPanel1.Controls.Add(cb_Design, 1, 6);
            tableLayoutPanel1.Controls.Add(cb_Color, 1, 5);
            tableLayoutPanel1.Controls.Add(tb_Height, 1, 2);
            tableLayoutPanel1.Controls.Add(tb_Width, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(tb_Rows, 1, 4);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Location = new Point(16, 28);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(282, 290);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tb_Columns
            // 
            tb_Columns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Columns.BorderStyle = BorderStyle.None;
            tb_Columns.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Columns.Location = new Point(151, 112);
            tb_Columns.Margin = new Padding(10, 3, 10, 3);
            tb_Columns.MaxLength = 1;
            tb_Columns.Name = "tb_Columns";
            tb_Columns.Size = new Size(120, 18);
            tb_Columns.TabIndex = 11;
            tb_Columns.Text = "2";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(4, 109);
            label9.Name = "label9";
            label9.Size = new Size(133, 51);
            label9.TabIndex = 5;
            label9.Text = "Кол-во столбцов";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tb_Padding
            // 
            tb_Padding.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Padding.BorderStyle = BorderStyle.None;
            tb_Padding.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Padding.Location = new Point(151, 265);
            tb_Padding.Margin = new Padding(10, 3, 10, 3);
            tb_Padding.MaxLength = 2;
            tb_Padding.Name = "tb_Padding";
            tb_Padding.Size = new Size(120, 18);
            tb_Padding.TabIndex = 10;
            tb_Padding.Text = "15";
            // 
            // cb_Design
            // 
            cb_Design.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_Design.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Design.FlatStyle = FlatStyle.Popup;
            cb_Design.FormattingEnabled = true;
            cb_Design.Location = new Point(144, 229);
            cb_Design.Name = "cb_Design";
            cb_Design.Size = new Size(134, 23);
            cb_Design.TabIndex = 8;
            // 
            // cb_Color
            // 
            cb_Color.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_Color.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Color.FlatStyle = FlatStyle.Popup;
            cb_Color.FormattingEnabled = true;
            cb_Color.Location = new Point(144, 202);
            cb_Color.Name = "cb_Color";
            cb_Color.Size = new Size(134, 23);
            cb_Color.TabIndex = 0;
            // 
            // tb_Height
            // 
            tb_Height.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Height.BorderStyle = BorderStyle.None;
            tb_Height.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Height.Location = new Point(151, 76);
            tb_Height.Margin = new Padding(10, 3, 10, 3);
            tb_Height.MaxLength = 3;
            tb_Height.Name = "tb_Height";
            tb_Height.Size = new Size(120, 18);
            tb_Height.TabIndex = 2;
            tb_Height.Text = "390";
            // 
            // tb_Width
            // 
            tb_Width.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Width.BorderStyle = BorderStyle.None;
            tb_Width.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Width.Location = new Point(151, 40);
            tb_Width.Margin = new Padding(10, 3, 10, 3);
            tb_Width.MaxLength = 3;
            tb_Width.Name = "tb_Width";
            tb_Width.Size = new Size(120, 18);
            tb_Width.TabIndex = 2;
            tb_Width.Text = "360";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1, 1);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(139, 35);
            label1.TabIndex = 0;
            label1.Text = "Параметры";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(141, 1);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(140, 35);
            label2.TabIndex = 1;
            label2.Text = "Значение";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(4, 37);
            label3.Name = "label3";
            label3.Size = new Size(133, 35);
            label3.TabIndex = 2;
            label3.Text = "Ширина";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(4, 73);
            label4.Name = "label4";
            label4.Size = new Size(133, 35);
            label4.TabIndex = 3;
            label4.Text = "Высота";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(4, 161);
            label5.Name = "label5";
            label5.Size = new Size(133, 37);
            label5.TabIndex = 4;
            label5.Text = "Кол-во рядов";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(4, 199);
            label6.Name = "label6";
            label6.Size = new Size(133, 26);
            label6.TabIndex = 5;
            label6.Text = "Задний фон";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tb_Rows
            // 
            tb_Rows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Rows.BorderStyle = BorderStyle.None;
            tb_Rows.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Rows.Location = new Point(151, 164);
            tb_Rows.Margin = new Padding(10, 3, 10, 3);
            tb_Rows.MaxLength = 1;
            tb_Rows.Name = "tb_Rows";
            tb_Rows.Size = new Size(120, 18);
            tb_Rows.TabIndex = 7;
            tb_Rows.Text = "3";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(4, 262);
            label8.Name = "label8";
            label8.Size = new Size(133, 27);
            label8.TabIndex = 9;
            label8.Text = "Отступ";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(4, 226);
            label7.Name = "label7";
            label7.Size = new Size(133, 35);
            label7.TabIndex = 6;
            label7.Text = "Узор";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pb_PagePreview
            // 
            pb_PagePreview.BackColor = Color.Transparent;
            pb_PagePreview.BorderStyle = BorderStyle.FixedSingle;
            pb_PagePreview.Location = new Point(350, 16);
            pb_PagePreview.Name = "pb_PagePreview";
            pb_PagePreview.Size = new Size(360, 390);
            pb_PagePreview.TabIndex = 0;
            pb_PagePreview.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 755);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Page).EndInit();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_PagePreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private PictureBox pb_PagePreview;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cb_Color;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_Width;
        private TextBox tb_Height;
        private TextBox tb_Rows;
        private ComboBox cb_Design;
        private Label label7;
        private Button btn_CreatePage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox lb_str;
        private PictureBox pb_Page;
        private Label label8;
        private TextBox tb_Padding;
        private TextBox tb_Columns;
        private Label label9;
        private Button btn_Save;
        private Button btn_Delete;
        private Button btn_Clear;
        private Button btn_OpenF;
        private Button btn_SaveF;
    }
}