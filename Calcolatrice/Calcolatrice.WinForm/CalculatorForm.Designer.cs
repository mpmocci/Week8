
namespace Calcolatrice.WinForm
{
    partial class CalculatorForm
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
            this.textValue = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btncomma = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnSomma = new System.Windows.Forms.Button();
            this.btnSottrazione = new System.Windows.Forms.Button();
            this.btnMoltiplicazione = new System.Windows.Forms.Button();
            this.btnDivisione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textValue
            // 
            this.textValue.BackColor = System.Drawing.Color.AliceBlue;
            this.textValue.Location = new System.Drawing.Point(56, 34);
            this.textValue.Name = "textValue";
            this.textValue.ReadOnly = true;
            this.textValue.Size = new System.Drawing.Size(134, 23);
            this.textValue.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(67, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 15);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Value";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(63, 113);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(38, 42);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(107, 113);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(38, 42);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(152, 113);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(38, 42);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(63, 161);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(38, 42);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(107, 161);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(38, 42);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(151, 161);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(38, 42);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(64, 209);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(38, 42);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(108, 209);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(38, 42);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(151, 209);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(38, 42);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(107, 257);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(38, 42);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btncomma
            // 
            this.btncomma.Location = new System.Drawing.Point(63, 257);
            this.btncomma.Name = "btncomma";
            this.btncomma.Size = new System.Drawing.Size(38, 42);
            this.btncomma.TabIndex = 12;
            this.btncomma.Text = ",";
            this.btncomma.UseVisualStyleBackColor = true;
            this.btncomma.Click += new System.EventHandler(this.btncomma_Click);
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(152, 257);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(38, 42);
            this.btnequal.TabIndex = 13;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(230, 34);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(38, 42);
            this.btnC.TabIndex = 14;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(230, 113);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(38, 42);
            this.btnSomma.TabIndex = 15;
            this.btnSomma.Text = "+";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.btnSomma_Click);
            // 
            // btnSottrazione
            // 
            this.btnSottrazione.Location = new System.Drawing.Point(230, 161);
            this.btnSottrazione.Name = "btnSottrazione";
            this.btnSottrazione.Size = new System.Drawing.Size(38, 42);
            this.btnSottrazione.TabIndex = 16;
            this.btnSottrazione.Text = "-";
            this.btnSottrazione.UseVisualStyleBackColor = true;
            this.btnSottrazione.Click += new System.EventHandler(this.btnSottrazione_Click);
            // 
            // btnMoltiplicazione
            // 
            this.btnMoltiplicazione.Location = new System.Drawing.Point(230, 209);
            this.btnMoltiplicazione.Name = "btnMoltiplicazione";
            this.btnMoltiplicazione.Size = new System.Drawing.Size(38, 42);
            this.btnMoltiplicazione.TabIndex = 17;
            this.btnMoltiplicazione.Text = "x";
            this.btnMoltiplicazione.UseVisualStyleBackColor = true;
            this.btnMoltiplicazione.Click += new System.EventHandler(this.btnMoltiplicazione_Click);
            // 
            // btnDivisione
            // 
            this.btnDivisione.Location = new System.Drawing.Point(230, 257);
            this.btnDivisione.Name = "btnDivisione";
            this.btnDivisione.Size = new System.Drawing.Size(38, 42);
            this.btnDivisione.TabIndex = 18;
            this.btnDivisione.Text = ":";
            this.btnDivisione.UseVisualStyleBackColor = true;
            this.btnDivisione.Click += new System.EventHandler(this.btnDivisione_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.btnDivisione);
            this.Controls.Add(this.btnMoltiplicazione);
            this.Controls.Add(this.btnSottrazione);
            this.Controls.Add(this.btnSomma);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btncomma);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.textValue);
            this.Name = "CalculatorForm";
            this.Text = "MyCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btncomma;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.Button btnSottrazione;
        private System.Windows.Forms.Button btnMoltiplicazione;
        private System.Windows.Forms.Button btnDivisione;
    }
}

