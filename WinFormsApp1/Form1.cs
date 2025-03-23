using CalculatorLibrary;

using System;

using System.Collections.Generic;

using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WinFormsApp1

{

    public partial class Form1 : Form

    {

        private Calculator calc;

        private string currentOperation = "";

        private bool isNewNumber = true;

        private int memoryDisplayY = 82;

        private List<Label> memoryLabels = new List<Label>();

        private List<decimal> memoryList = new List<decimal>();

        public Form1()

        {

            InitializeComponent();

            calc = new Calculator();

            result.Text = "0";

        }

        private void NumberButton_Click(object sender, EventArgs e)

        {

            Button button = (Button)sender;

            if (isNewNumber || result.Text == "0")

            {

                result.Text = button.Text;

                isNewNumber = false;

            }

            else

            {

                result.Text += button.Text;

            }

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            currentOperation = "+";            
            ExecuteOperation();

            isNewNumber = true;
            result.Text = calc.Result.ToString("G");
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
           
            currentOperation = "-"; 
            ExecuteOperation();
            isNewNumber = true;
            result.Text = calc.Result.ToString("G");
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            ExecuteOperation();
            currentOperation = "";
            isNewNumber = true;
            result.Text = calc.Result.ToString();
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            calc = new Calculator();
            result.Text = "0";
            currentOperation = "";
            isNewNumber = true;
            result.Text = "0";
        }

        private void btn_mc_Click(object sender, EventArgs e)
        {
            foreach (var label in memoryLabels)
            {
                this.Controls.Remove(label);
            }
            memoryLabels.Clear();
            memoryList.Clear();
            memoryDisplayY = 82;
        }

        private void btn_mplus_Click(object sender, EventArgs e)
        {
            if (memoryList.Count > 0)
            {
                memoryList[memoryList.Count - 1] += calc.Result;
                UpdateMemoryDisplay();
            }
        }

        private void btn_msub_Click(object sender, EventArgs e)
        {
            if (memoryList.Count > 0)
            {
                memoryList[memoryList.Count - 1] -= calc.Result;
                UpdateMemoryDisplay();
            }
        }


        private void btn_ms_Click(object sender, EventArgs e)
        {
            memoryList.Add(calc.Result);
            AddMemoryLabel(calc.Result);
        }

        private void ExecuteOperation()
        {
            decimal number;
            if (!decimal.TryParse(result.Text, out number))
                return;
            switch (currentOperation)
            {
                case "+":
                    calc.Add(number);
                    break;
                case "-":
                    calc.Subtract(number);
                    break;
            }
        }

        private void UpdateMemoryDisplay()
        {
            if (memoryLabels.Count > 0 && memoryList.Count > 0)
            {
                memoryLabels[^1].Text = memoryList[^1].ToString("G");
            }
        }

        private void AddMemoryLabel(decimal value)

        {

            Panel panel = new Panel

            {

                Size = new Size(442, 144),

                Location = new Point(867, memoryDisplayY),
                BackColor = SystemColors.ControlLight

            };

            Label lbl_mem = new Label

            {

                AutoSize = true,

                Text = value.ToString("G"),
                BackColor = SystemColors.ControlLight,
                Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Location = new Point(384, 7),
                Name = "lbl_mem",
                Size = new Size(43, 50),
                TabIndex = 30
               

            };

            Button btn_mc = new Button

            {

               Location = new Point(179, 68),
               Name = "btn_mc",
               Size = new Size(75, 54),
               TabIndex = 31,
               Text = "MC",
               UseVisualStyleBackColor = true

            };

            Button btn_mplus = new Button

            {

                Location = new Point(271, 72),
                Name = "btn_mplus",
                Size = new Size(75, 54),
                TabIndex = 29,
                Text = "M+",
                UseVisualStyleBackColor = true

            };

            Button btn_msub = new Button

            {

               Location = new Point(354, 72),
               Name = "btn_msub",
               Size = new Size(75, 54),
               TabIndex = 28,
               Text = "M-",
               UseVisualStyleBackColor = true

            };

            // Events

            btn_mc.Click += (s, e) =>

            {

                this.Controls.Remove(panel);

                memoryLabels.Remove(lbl_mem);

                memoryList.Remove(value);

                memoryDisplayY -= 60;

            };

            btn_mplus.Click += (s, e) =>

            {

                value += value;

                lbl_mem.Text = value.ToString("G");

            };

            btn_msub.Click += (s, e) =>

            {

                value -= value;

                lbl_mem.Text = value.ToString("G");

            };

            panel.Controls.Add(lbl_mem);

            panel.Controls.Add(btn_mc);

            panel.Controls.Add(btn_mplus);

            panel.Controls.Add(btn_msub);

            this.Controls.Add(panel);

            memoryLabels.Add(lbl_mem);

            memoryDisplayY += 150;

        }


        private void result_Click(object sender, EventArgs e) { }

    }

}

