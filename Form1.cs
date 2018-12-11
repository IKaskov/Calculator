using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPNLibrary;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private string t = "0";
        private List<string> q = new List<string>();
        private double memory = 0.0;
        private bool n = false,point =false;

        public MainForm()
        {
            InitializeComponent();
            labelPrim.Text = t;
            labelM.Hide();
        }

        private void CorrectNumber()
        {
            if (labelPrim.Text == string.Empty)
                labelPrim.Text = "0";

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (labelPrim.Text.Length > 1 && labelPrim.Text[0] == '0' && (labelPrim.Text.IndexOf(",") != 1))
                labelPrim.Text = labelPrim.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (labelPrim.Text.Length > 1 && labelPrim.Text[0] == '-')
                if (labelPrim.Text[1] == '0' && (labelPrim.Text.IndexOf(",") != 2))
                    labelPrim.Text = labelPrim.Text.Remove(1, 1);
        }

        private void labelPrim_TextChanged(object sender, EventArgs e)
        {
            CorrectNumber();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // + - * /
            if (e.KeyChar == 43)
                buttonPlus_Click(null, null);
            if (e.KeyChar == 45)
                buttonMinus_Click(null, null);
            if (e.KeyChar == 42)
                buttonMult_Click(null, null);
            if (e.KeyChar == 47)
                buttonDiv_Click(null, null);

            // . ,
            if (e.KeyChar == 44 || e.KeyChar == 46)
                buttonPoint_Click(null, null);


            if (e.KeyChar != 8 && Char.IsNumber(e.KeyChar))
            {
                labelPrim.Text += e.KeyChar.ToString();
            }

        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
                BS();
        }

        private void buttonCulc_LostFocus(object sender, EventArgs e)
        {
            buttonCulc.Focus();
        }

        private void buttonBS_Click(object sender, EventArgs e)
        {
            BS();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            labelPrim.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            labelPrim.Text = "0";
            label3.Text = string.Empty;
            q.Clear();
        }

        private void buttonCulc_Click(object sender, EventArgs e)
        {
            t = labelPrim.Text;

            q.Add(t);

            label3.Text = string.Empty;

            labelPrim.Text = (RPN.CalculateRPN(q)).ToString();
            q.Clear();
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (labelPrim.Text == "0")
                return;

            if (labelPrim.Text[0] == '-')
                labelPrim.Text = labelPrim.Text.Remove(0, 1);
            else
                labelPrim.Text = "-" + labelPrim.Text;
        }

        private void BS()
        {
            labelPrim.Text = labelPrim.Text.Remove(labelPrim.Text.Length - 1);

            //if (labelPrim.Text.Last() == ',' || labelPrim.Text.Last() == '.')
            //    labelPrim.Text.Remove(labelPrim.Text.Length-1);
        }

        #region buttons 0-9
        private void button0_Click(object sender, EventArgs e)
        {
            labelPrim.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelPrim.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelPrim.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelPrim.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelPrim.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelPrim.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelPrim.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelPrim.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelPrim.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelPrim.Text += "9";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (!point)
            {
                labelPrim.Text += ",";
                point = true;
            }
        }

        #endregion

        #region Operation
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            ExtOperation("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            ExtOperation("-");
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            ExtOperation("*");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            //if (labelPrim.Text != "0")
                ExtOperation("/");
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(labelPrim.Text);
            if (a >= 0)
            {
                double b = Math.Sqrt(a);
                labelPrim.Text = b.ToString();
                if (q.Count == 0)
                    q.Add(labelPrim.Text);
                label3.Text += $"Sqrt({a})";
                n = true;
            }
        }

        private void buttonSqr_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(labelPrim.Text);

            double b = Math.Pow(a, 2);
            labelPrim.Text = b.ToString();
            if (q.Count == 0)
                q.Add(labelPrim.Text);
            label3.Text += $"{a}^2";
            n = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ExtOperation("^");
        }

        private void ExtOperation(string op)
        {
            if (label3.Text.Length > 0 && n)
            {
                label3.Text += op;
                q.Add(op);
                n = false;
            }
            else
                Operation(op);
        }

        private void Operation(string op)
        {
            point = false;

            StringBuilder s = new StringBuilder(labelPrim.Text);
            if (s[s.Length - 1] == ',' || s[s.Length - 1] == '.')
                s.Remove(s.Length - 1, 1);
            labelPrim.Text = s.ToString();

            if (label3.Text.Length > 0 && labelPrim.Text == "0" && label3.Text.Last() != op[0])
            {
                label3.Text = label3.Text.Remove(label3.Text.Length - 1) + op;
                q.RemoveAt(q.Count - 1);
                q.Add(op);
            }
            else if (labelPrim.Text != "0")
            {
                t = labelPrim.Text;
                q.Add(t);
                q.Add(op);
                label3.Text += t + op;
                labelPrim.Text = "0";
            }
        }
        #endregion

        #region Memory
        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            if (labelPrim.Text == "0")
                return;

            memory += Convert.ToDouble(labelPrim.Text);
            labelM.Show();
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            if (labelPrim.Text == "0")
                return;

            memory -= Convert.ToDouble(labelPrim.Text);
            labelM.Show();
        }

        private void buttonMRC_Click(object sender, EventArgs e)
        {
            if (labelPrim.Text == memory.ToString())
            {
                memory = 0.0;
                labelM.Hide();
            }
            else
                labelPrim.Text = memory.ToString();
        }

        #endregion

    }
}
