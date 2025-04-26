namespace WinFormsApp1
{
    partial class Form1
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
            result = new Label();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btn_minus = new Button();
            btn_plus = new Button();
            btn_equal = new Button();
            btn_c = new Button();
            btn_ms = new Button();
            btn_mplus = new Button();
            btn_msub = new Button();
            button1 = new Button();
            btn_sub = new Button();
            btn_mc = new Button();
            lbl_mem = new Label();
            memoryItem = new Panel();
            SuspendLayout();
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            result.Location = new Point(519, 137);
            result.Name = "result";
            result.Size = new Size(74, 86);
            result.TabIndex = 0;
            result.Text = "0";
            result.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn7
            // 
            btn7.Location = new Point(51, 389);
            btn7.Name = "btn7";
            btn7.Size = new Size(164, 98);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnDigit_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(237, 389);
            btn8.Name = "btn8";
            btn8.Size = new Size(164, 98);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnDigit_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(427, 389);
            btn9.Name = "btn9";
            btn9.Size = new Size(164, 98);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnDigit_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(51, 510);
            btn4.Name = "btn4";
            btn4.Size = new Size(164, 98);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnDigit_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(237, 510);
            btn5.Name = "btn5";
            btn5.Size = new Size(164, 98);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnDigit_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(427, 510);
            btn6.Name = "btn6";
            btn6.Size = new Size(164, 98);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnDigit_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(51, 630);
            btn1.Name = "btn1";
            btn1.Size = new Size(164, 98);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnDigit_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(237, 630);
            btn2.Name = "btn2";
            btn2.Size = new Size(164, 98);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnDigit_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(427, 630);
            btn3.Name = "btn3";
            btn3.Size = new Size(164, 98);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnDigit_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(51, 760);
            btn0.Name = "btn0";
            btn0.Size = new Size(540, 98);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnDigit_Click;
            // 
            // btn_minus
            // 
            btn_minus.Location = new Point(615, 389);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(170, 98);
            btn_minus.TabIndex = 12;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += btn_minus_Click;
            // 
            // btn_plus
            // 
            btn_plus.Location = new Point(615, 510);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(170, 98);
            btn_plus.TabIndex = 13;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += btn_plus_Click;
            // 
            // btn_equal
            // 
            btn_equal.Location = new Point(615, 630);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(170, 228);
            btn_equal.TabIndex = 15;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_c
            // 
            btn_c.Location = new Point(51, 266);
            btn_c.Name = "btn_c";
            btn_c.Size = new Size(350, 98);
            btn_c.TabIndex = 14;
            btn_c.Text = "C";
            btn_c.UseVisualStyleBackColor = true;
            btn_c.Click += btn_c_Click;
            // 
            // btn_ms
            // 
            btn_ms.Location = new Point(421, 266);
            btn_ms.Name = "btn_ms";
            btn_ms.Size = new Size(364, 98);
            btn_ms.TabIndex = 17;
            btn_ms.Text = "MS";
            btn_ms.UseVisualStyleBackColor = true;
            btn_ms.Click += btn_ms_Click;
            // 
            // btn_mplus
            // 
            btn_mplus.Location = new Point(0, 0);
            btn_mplus.Name = "btn_mplus";
            btn_mplus.Size = new Size(75, 23);
            btn_mplus.TabIndex = 0;
            // 
            // btn_msub
            // 
            btn_msub.Location = new Point(0, 0);
            btn_msub.Name = "btn_msub";
            btn_msub.Size = new Size(75, 23);
            btn_msub.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // btn_sub
            // 
            btn_sub.Location = new Point(0, 0);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(75, 23);
            btn_sub.TabIndex = 0;
            // 
            // btn_mc
            // 
            btn_mc.Location = new Point(0, 0);
            btn_mc.Name = "btn_mc";
            btn_mc.Size = new Size(75, 23);
            btn_mc.TabIndex = 0;
            // 
            // lbl_mem
            // 
            lbl_mem.Location = new Point(0, 0);
            lbl_mem.Name = "lbl_mem";
            lbl_mem.Size = new Size(100, 23);
            lbl_mem.TabIndex = 0;
            // 
            // memoryItem
            // 
            memoryItem.Location = new Point(0, 0);
            memoryItem.Name = "memoryItem";
            memoryItem.Size = new Size(200, 100);
            memoryItem.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 910);
            Controls.Add(memoryItem);
            Controls.Add(btn_ms);
            Controls.Add(btn_c);
            Controls.Add(btn_equal);
            Controls.Add(btn_plus);
            Controls.Add(btn_minus);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(result);
            Name = "Form1";
            Text = "=";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label result;
        private Label lbl_mmry;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btn_minus;
        private Button btn_plus;
        private Button btn_equal;
        private Button btn_c;
        private Button btn_ms;
        private Button btn_mc;
        private Button btn_mplus;
        private Button btn_msub;
        private Label lbl_mem;
        private Button button1;
        private Button btn_sub;
        private Panel memoryItem;
    }
}