namespace Project_Outline
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 400);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Amount: ";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(289, 253);
            button1.Name = "button1";
            button1.Size = new Size(153, 76);
            button1.TabIndex = 1;
            button1.Text = "Display Balance ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(290, 131);
            button2.Name = "button2";
            button2.Size = new Size(152, 76);
            button2.TabIndex = 2;
            button2.Text = "Deposit ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(530, 253);
            button3.Name = "button3";
            button3.Size = new Size(152, 76);
            button3.TabIndex = 3;
            button3.Text = "Transfer ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(530, 131);
            button4.Name = "button4";
            button4.Size = new Size(153, 76);
            button4.TabIndex = 4;
            button4.Text = "Withdraw";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(256, 58);
            label2.Name = "label2";
            label2.Size = new Size(287, 54);
            label2.TabIndex = 5;
            label2.Text = "Initial Balance: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(530, 58);
            label3.Name = "label3";
            label3.Size = new Size(198, 54);
            label3.TabIndex = 6;
            label3.Text = "$XXXX.XX";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(426, 397);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 31);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(205, 431);
            label4.Name = "label4";
            label4.Size = new Size(377, 54);
            label4.TabIndex = 8;
            label4.Text = "Remaining Balance: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(549, 431);
            label5.Name = "label5";
            label5.Size = new Size(198, 54);
            label5.TabIndex = 9;
            label5.Text = "$XXXX.XX";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(371, 351);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 29);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Checkings";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(496, 351);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 29);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Savings ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 515);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
