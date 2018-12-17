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
        private bool sqrt = false, unaryOp = false;

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
            labelStatus.Text = string.Empty;
            q.Clear();
        }

        private void buttonCulc_Click(object sender, EventArgs e)
        {
            if (unaryOp)
                unaryOp = false;
            else
                labelStatus.Text += labelPrim.Text;


            labelPrim.Text = (RPN.CalculateRPN(labelStatus.Text)).ToString();

            labelStatus.Text = string.Empty;
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
            if (!labelPrim.Text.Contains(","))
            {
                labelPrim.Text += ",";
            }
        }

        #endregion

        #region Operation
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            TempOperation("+");
        }

        private void TempOperation(string op)
        {
            if (labelPrim.Text == "0")
                ChangeOperationSign(op);
            else
            {
                RemovePoint();

                if (unaryOp)
                {
                    labelStatus.Text += op;
                    labelPrim.Text = string.Empty;
                    unaryOp = false;
                }
                else
                {
                    labelStatus.Text += labelPrim.Text + op;
                    labelPrim.Text = string.Empty;
                }
            }

        }

        private void ChangeOperationSign(string op)
        {
            if (labelStatus.Text.Count() > 0
                && (!Char.IsNumber(labelStatus.Text.Last())
                && labelStatus.Text.Last() != ')')
                && labelStatus.Text.Last() != op[0])
                labelStatus.Text = labelStatus.Text.TrimEnd(labelStatus.Text.Last()) + op;
        }

        private void RemovePoint()
        {
            if (labelPrim.Text.Last() == ',' || labelPrim.Text.Last() == '.')
            {
                //    StringBuilder s = new StringBuilder(labelPrim.Text);
                //    s.Remove(s.Length - 1, 1);
                //    labelPrim.Text = s.ToString();

                labelPrim.Text = labelPrim.Text.Remove(labelPrim.Text.Length - 1);
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            TempOperation("-");
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            TempOperation("*");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            TempOperation("/");
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(labelPrim.Text);
            if (a >= 0)
            {
                labelStatus.Text += $"Sqrt({a})";
                labelPrim.Text = Math.Sqrt(a).ToString();
                unaryOp = true;
            }
        }

        private void buttonSqr_Click(object sender, EventArgs e)
        {
            TempOperation("^2");
            unaryOp = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TempOperation("^");
        }

        private void ExtOperation(string op)
        {
            if (labelStatus.Text.Length > 0 && sqrt)
            {
                labelStatus.Text += op;
                q.Add(op);
                sqrt = false;
            }
            else
                Operation(op);
        }

        private void Operation(string op)
        {
            RemovePoint();

            if (labelStatus.Text.Length > 0 && labelPrim.Text == "0" && labelStatus.Text.Last() != op[0])
            {
                labelStatus.Text = labelStatus.Text.Remove(labelStatus.Text.Length - 1) + op;
                q.RemoveAt(q.Count - 1);
                q.Add(op);
            }
            else if (labelPrim.Text != "0")
            {
                t = labelPrim.Text;
                q.Add(t);
                q.Add(op);
                labelStatus.Text += t + op;
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
