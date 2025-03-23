using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MemoryItemControl : UserControl
    {
        private Label valueLabel;

        public MemoryItemControl()
        {
            InitializeComponent();
            this.Size = new Size(100, 30); // Adjust size as needed
            valueLabel = new Label
            {
                Location = new Point(10, 10),
                AutoSize = true
            };
            this.Controls.Add(valueLabel);
        }

        public void SetValue(decimal value)
        {
            valueLabel.Text = value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
