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

        private string operation;
        private int leftValue;

       

        public Form1()

        {
            InitializeComponent();

            calc = new Calculator();

            result.Text = "0";

        }


        private void btnDigit_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (result.Text == "0")
            {
                result.Text = btn.Text;
            }
            else
            {
                result.Text += btn.Text;
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
           
            leftValue = int.Parse(result.Text);
            operation = "+";
            result.Text = "0";

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            leftValue = int.Parse(result.Text);
            operation = "-";
            result.Text = "0";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            int right = int.Parse(result.Text);
            if (calc.Result == 0)
            {
                calc.Add(leftValue);
            }

            if (operation == "+")
            {
                calc.Add(right);
            }
            else if (operation == "-")
            {
                calc.Subtract(right);
            }

            result.Text = ((int)calc.Result).ToString();
   
        }

        private void btn_ms_Click(object sender, EventArgs e)
        {
            calc.SaveToMemory();
            UpdateMemoryList();
            calc.Subtract(calc.Result);
            result.Text = "0";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            calc.Subtract(calc.Result);
            result.Text = "0";
            leftValue = 0;
            operation = null;

        }
    



        private int memoryDisplayY = 20;     // эхний панелийн Y байрлал
        private const int PanelWidth = 442;
        private const int PanelHeight = 144;
        private const int PanelGap = 10;  

        private void UpdateMemoryList()
        {
            // Хуучин Memory панельүүдээ устгах
            var oldPanels = this.Controls
                .OfType<Panel>()
                .Where(p => p.Tag is MemoryItem)
                .ToList();
            foreach (var p in oldPanels)
                this.Controls.Remove(p);

            memoryDisplayY = 82;

            foreach (var memItem in calc.GetMemoryItems())
            {
                var panel = new Panel
                {
                    Size = new Size(PanelWidth, PanelHeight),
                    Location = new Point(867, memoryDisplayY),
                    BackColor = SystemColors.ControlLight,
                    Tag = memItem    
                };


                var lbl = new Label
                {
                    AutoSize = true,
                    
                    Text = memItem.Value.ToString("G"),
                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                    Location = new Point(10, 7),
                    BackColor = SystemColors.ControlLight,
                    Size = new Size(43, 50),
                    TabIndex = 30,
                };
                panel.Controls.Add(lbl);

          
                var btnMC = new Button
                {
                    Text = "MC",
                    Size = new Size(75, 54),
                    
                    Location = new Point(179, 68)
                };
                btnMC.Click += (_, __) =>
                {
                    calc.ClearMemory(memItem);  
                    UpdateMemoryList();
                };
                panel.Controls.Add(btnMC);


                var btnMPlus = new Button
                {
                    Text = "M+",
                    Size = new Size(75, 54),
                    Location = new Point(271, 72)
                };
                btnMPlus.Click += (_, __) =>
                {
                    int currentValue = int.Parse(result.Text);
                    
                        memItem.AddResult(currentValue);
                        UpdateMemoryList();
                    
                };
                panel.Controls.Add(btnMPlus);

                var btnMSub = new Button
                {
                    Text = "M-",
                    Size = new Size(75, 54),
                    Location = new Point(354, 72)
                };
                btnMSub.Click += (_, __) =>
                {
                    int currentValue = int.Parse(result.Text);
                    
                    memItem.substractResult(currentValue); 
                    UpdateMemoryList();
                    
                };
                panel.Controls.Add(btnMSub);

                this.Controls.Add(panel);

               
                memoryDisplayY += PanelHeight + PanelGap;
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

