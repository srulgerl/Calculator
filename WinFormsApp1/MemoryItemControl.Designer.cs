namespace WinFormsApp1
{
    partial class MemoryItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_mem = new Label();
            btn_mplus = new Button();
            btn_sub = new Button();
            btn_mc = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_mem
            // 
            lbl_mem.AutoSize = true;
            lbl_mem.BackColor = SystemColors.ControlLight;
            lbl_mem.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_mem.Location = new Point(385, 10);
            lbl_mem.Name = "lbl_mem";
            lbl_mem.Size = new Size(43, 50);
            lbl_mem.TabIndex = 30;
            lbl_mem.Text = "0";
            // 
            // btn_mplus
            // 
            btn_mplus.Location = new Point(271, 72);
            btn_mplus.Name = "btn_mplus";
            btn_mplus.Size = new Size(75, 54);
            btn_mplus.TabIndex = 29;
            btn_mplus.Text = "M+";
            btn_mplus.UseVisualStyleBackColor = true;
            // 
            // btn_sub
            // 
            btn_sub.Location = new Point(354, 72);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(75, 54);
            btn_sub.TabIndex = 28;
            btn_sub.Text = "M-";
            btn_sub.UseVisualStyleBackColor = true;
            // 
            // btn_mc
            // 
            btn_mc.Location = new Point(188, 72);
            btn_mc.Name = "btn_mc";
            btn_mc.Size = new Size(74, 54);
            btn_mc.TabIndex = 27;
            btn_mc.Text = "MC";
            btn_mc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(lbl_mem);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 143);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // MemoryItemControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_mplus);
            Controls.Add(btn_sub);
            Controls.Add(btn_mc);
            Controls.Add(groupBox1);
            Name = "MemoryItemControl";
            Size = new Size(446, 143);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_mem;
        private Button btn_mplus;
        private Button btn_sub;
        private Button btn_mc;
        private GroupBox groupBox1;
    }
}
