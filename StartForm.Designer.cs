namespace CalcPropeller
{
    partial class StartForm
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.IBeam;
            button1.Location = new Point(505, 49);
            button1.Name = "button1";
            button1.Size = new Size(205, 36);
            button1.TabIndex = 0;
            button1.Text = "Выполнить расчет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 60);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Шаг винта (мм)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(32, 9);
            label2.Name = "label2";
            label2.Size = new Size(355, 32);
            label2.TabIndex = 2;
            label2.Text = "Расчет воздушного винта ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 56);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "шаг в мм";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 90);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 4;
            label3.Text = "Диаметр винта (мм)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 90);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "диаметр в мм";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Расчет_сечений_винта;
            pictureBox1.Location = new Point(37, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(716, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "StartForm";
            Text = "Расчет воздушного винта";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}