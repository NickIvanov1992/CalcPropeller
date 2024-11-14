namespace CalcPropeller
{
    partial class CalcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label3 = new Label();
            TableA = new DataGridView();
            CordinateName = new DataGridViewTextBoxColumn();
            A = new DataGridViewTextBoxColumn();
            B = new DataGridViewTextBoxColumn();
            C = new DataGridViewTextBoxColumn();
            D = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TableA).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(32, 9);
            label2.Name = "label2";
            label2.Size = new Size(273, 32);
            label2.TabIndex = 3;
            label2.Text = "Результат расчета";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.ImeMode = ImeMode.On;
            tabControl1.Location = new Point(39, 98);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(704, 164);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(TableA);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(696, 136);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Сечение A (14.7R)";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(696, 136);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Сечение B (30R)";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(696, 136);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Сечение С (45R)";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(696, 136);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Сечение D (60R)";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(696, 136);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Сечение E (75R)";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(696, 136);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Сечение F (90R)";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(43, 279);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 287);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(511, 465);
            button1.Name = "button1";
            button1.Size = new Size(228, 42);
            button1.TabIndex = 6;
            button1.Text = "Сохранить изображение";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(511, 526);
            button2.Name = "button2";
            button2.Size = new Size(228, 40);
            button2.TabIndex = 7;
            button2.Text = "Сохранить координаты";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 23);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 8;
            label1.Text = "Предмет расчета:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(540, 28);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 9;
            label3.Text = "...Данные воздушного винта";
            // 
            // TableA
            // 
            TableA.AllowUserToDeleteRows = false;
            TableA.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            TableA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableA.Columns.AddRange(new DataGridViewColumn[] { CordinateName, A, B, C, D });
            TableA.GridColor = SystemColors.ActiveCaptionText;
            TableA.Location = new Point(23, 22);
            TableA.Name = "TableA";
            TableA.RowTemplate.Height = 25;
            TableA.Size = new Size(543, 114);
            TableA.TabIndex = 0;
            // 
            // CordinateName
            // 
            CordinateName.HeaderText = "Координаты";
            CordinateName.Name = "CordinateName";
            // 
            // A
            // 
            A.HeaderText = "A";
            A.Name = "A";
            // 
            // B
            // 
            B.HeaderText = "B";
            B.Name = "B";
            // 
            // C
            // 
            C.HeaderText = "C";
            C.Name = "C";
            // 
            // D
            // 
            D.HeaderText = "D";
            D.Name = "D";
            // 
            // CalcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 578);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Name = "CalcForm";
            Text = "CalcForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TableA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label3;
        private DataGridView TableA;
        private DataGridViewTextBoxColumn CordinateName;
        private DataGridViewTextBoxColumn A;
        private DataGridViewTextBoxColumn B;
        private DataGridViewTextBoxColumn C;
        private DataGridViewTextBoxColumn D;
    }
}