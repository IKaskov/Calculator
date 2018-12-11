using System;
using System.Drawing;

namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMRC = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMMinus = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonChangeSign = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonBS = new System.Windows.Forms.Button();
            this.buttonSqr = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCulc = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.labelM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrim = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMRC
            // 
            this.buttonMRC.Location = new System.Drawing.Point(0, 3);
            this.buttonMRC.Name = "buttonMRC";
            this.buttonMRC.Size = new System.Drawing.Size(67, 45);
            this.buttonMRC.TabIndex = 4;
            this.buttonMRC.Text = "MRC";
            this.buttonMRC.UseVisualStyleBackColor = true;
            this.buttonMRC.Click += new System.EventHandler(this.buttonMRC_Click);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.Location = new System.Drawing.Point(71, 3);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(67, 45);
            this.buttonMPlus.TabIndex = 5;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = true;
            this.buttonMPlus.Click += new System.EventHandler(this.buttonMPlus_Click);
            // 
            // buttonMMinus
            // 
            this.buttonMMinus.Location = new System.Drawing.Point(142, 3);
            this.buttonMMinus.Name = "buttonMMinus";
            this.buttonMMinus.Size = new System.Drawing.Size(67, 45);
            this.buttonMMinus.TabIndex = 6;
            this.buttonMMinus.Text = "M-";
            this.buttonMMinus.UseVisualStyleBackColor = true;
            this.buttonMMinus.Click += new System.EventHandler(this.buttonMMinus_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Location = new System.Drawing.Point(284, 54);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(67, 45);
            this.buttonSqrt.TabIndex = 13;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonChangeSign
            // 
            this.buttonChangeSign.Location = new System.Drawing.Point(213, 54);
            this.buttonChangeSign.Name = "buttonChangeSign";
            this.buttonChangeSign.Size = new System.Drawing.Size(67, 45);
            this.buttonChangeSign.TabIndex = 12;
            this.buttonChangeSign.Text = "+/-";
            this.buttonChangeSign.UseVisualStyleBackColor = true;
            this.buttonChangeSign.Click += new System.EventHandler(this.buttonChangeSign_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(142, 54);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(67, 45);
            this.buttonC.TabIndex = 11;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(71, 54);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(67, 45);
            this.buttonCE.TabIndex = 10;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonBS
            // 
            this.buttonBS.Location = new System.Drawing.Point(0, 54);
            this.buttonBS.Name = "buttonBS";
            this.buttonBS.Size = new System.Drawing.Size(67, 45);
            this.buttonBS.TabIndex = 9;
            this.buttonBS.Text = "<-";
            this.buttonBS.UseVisualStyleBackColor = true;
            this.buttonBS.Click += new System.EventHandler(this.buttonBS_Click);
            // 
            // buttonSqr
            // 
            this.buttonSqr.Location = new System.Drawing.Point(284, 105);
            this.buttonSqr.Name = "buttonSqr";
            this.buttonSqr.Size = new System.Drawing.Size(67, 45);
            this.buttonSqr.TabIndex = 18;
            this.buttonSqr.Text = "x^2";
            this.buttonSqr.UseVisualStyleBackColor = true;
            this.buttonSqr.Click += new System.EventHandler(this.buttonSqr_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(213, 105);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(67, 45);
            this.buttonDiv.TabIndex = 17;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(142, 105);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 45);
            this.button9.TabIndex = 16;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(71, 105);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 45);
            this.button8.TabIndex = 15;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 105);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 45);
            this.button7.TabIndex = 14;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(284, 156);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(67, 45);
            this.button16.TabIndex = 23;
            this.button16.Text = "x^y";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(213, 156);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(67, 45);
            this.buttonMult.TabIndex = 22;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(142, 156);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 45);
            this.button6.TabIndex = 21;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(71, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 45);
            this.button5.TabIndex = 20;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 45);
            this.button4.TabIndex = 19;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(213, 207);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(67, 45);
            this.buttonMinus.TabIndex = 27;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(142, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 45);
            this.button3.TabIndex = 26;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 45);
            this.button2.TabIndex = 25;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonMRC);
            this.panel1.Controls.Add(this.buttonCulc);
            this.panel1.Controls.Add(this.buttonMPlus);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Controls.Add(this.buttonMinus);
            this.panel1.Controls.Add(this.buttonMMinus);
            this.panel1.Controls.Add(this.buttonPoint);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.buttonChangeSign);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonBS);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.buttonCE);
            this.panel1.Controls.Add(this.buttonMult);
            this.panel1.Controls.Add(this.buttonC);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.buttonSqrt);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.buttonSqr);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.buttonDiv);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 320);
            this.panel1.TabIndex = 29;
            // 
            // buttonCulc
            // 
            this.buttonCulc.Location = new System.Drawing.Point(284, 207);
            this.buttonCulc.Name = "buttonCulc";
            this.buttonCulc.Size = new System.Drawing.Size(67, 96);
            this.buttonCulc.TabIndex = 0;
            this.buttonCulc.Text = "=";
            this.buttonCulc.UseVisualStyleBackColor = true;
            this.buttonCulc.Click += new System.EventHandler(this.buttonCulc_Click);
            this.buttonCulc.LostFocus += new System.EventHandler(this.buttonCulc_LostFocus);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(213, 258);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(67, 45);
            this.buttonPlus.TabIndex = 27;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(142, 258);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(67, 45);
            this.buttonPoint.TabIndex = 26;
            this.buttonPoint.Text = ",";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(0, 258);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(136, 45);
            this.button0.TabIndex = 24;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.BackColor = System.Drawing.Color.Transparent;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelM.Location = new System.Drawing.Point(0, 24);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(29, 25);
            this.labelM.TabIndex = 30;
            this.labelM.Text = "M";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.labelPrim);
            this.groupBox1.Controls.Add(this.labelM);
            this.groupBox1.Location = new System.Drawing.Point(12, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 74);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(24, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 23);
            this.panel2.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(318, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 32;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrim
            // 
            this.labelPrim.AutoSize = true;
            this.labelPrim.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrim.Location = new System.Drawing.Point(317, 18);
            this.labelPrim.Name = "labelPrim";
            this.labelPrim.Size = new System.Drawing.Size(31, 32);
            this.labelPrim.TabIndex = 40;
            this.labelPrim.Text = "0";
            this.labelPrim.TextChanged += new System.EventHandler(this.labelPrim_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(377, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMRC;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMMinus;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonChangeSign;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonBS;
        private System.Windows.Forms.Button buttonSqr;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCulc;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPrim;
        private System.Windows.Forms.Panel panel2;
    }
}

