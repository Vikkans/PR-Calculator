namespace PR_Calculator
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
            Forre = new Label();
            label1 = new Label();
            button1 = new Button();
            Pr = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Forre
            // 
            Forre.AutoSize = true;
            Forre.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Forre.ImageAlign = ContentAlignment.TopCenter;
            Forre.Location = new Point(118, 9);
            Forre.Name = "Forre";
            Forre.Size = new Size(161, 40);
            Forre.TabIndex = 0;
            Forre.Text = "FORTNITE";
            Forre.Click += Forre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(205, 44);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "PR CALCULATOR";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(146, 318);
            button1.Name = "button1";
            button1.Size = new Size(85, 50);
            button1.TabIndex = 2;
            button1.Text = "CALCULATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Pr
            // 
            Pr.AutoSize = true;
            Pr.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Pr.Location = new Point(118, 374);
            Pr.Name = "Pr";
            Pr.RightToLeft = RightToLeft.Yes;
            Pr.Size = new Size(105, 32);
            Pr.TabIndex = 3;
            Pr.Text = "0000,00";
            Pr.Click += Pr_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.power_ranking_icon_simple__4_;
            pictureBox1.Location = new Point(222, 371);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(137, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 35);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(155, 87);
            label3.Name = "label3";
            label3.Size = new Size(88, 17);
            label3.TabIndex = 6;
            label3.Text = "PLACEMENT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 158);
            label4.Name = "label4";
            label4.Size = new Size(103, 17);
            label4.TabIndex = 7;
            label4.Text = "TOURNAMENT:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(80, 193);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(114, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Duos Cash Cup";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(222, 193);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Eval Cup";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(80, 227);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(125, 19);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "Solo Victory Cup";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.Location = new Point(222, 227);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(56, 19);
            radioButton4.TabIndex = 11;
            radioButton4.TabStop = true;
            radioButton4.Text = "FNCS";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton5.Location = new Point(80, 268);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(109, 19);
            radioButton5.TabIndex = 12;
            radioButton5.TabStop = true;
            radioButton5.Text = "FNCS Round 2";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(384, 461);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(Pr);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Forre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Forre;
        private Label label1;
        private Button button1;
        private Label Pr;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
    }
}