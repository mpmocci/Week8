
namespace Equazioni_grado2.WinForms
{
    partial class Equazioni_grado2
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
            this.lblRisultato = new System.Windows.Forms.Label();
            this.tbRisultato = new System.Windows.Forms.TextBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.btnAzzera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblRisultato.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRisultato.Location = new System.Drawing.Point(257, 131);
            this.lblRisultato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(78, 21);
            this.lblRisultato.TabIndex = 3;
            this.lblRisultato.Text = "Risultato:";
            // 
            // tbRisultato
            // 
            this.tbRisultato.Location = new System.Drawing.Point(257, 154);
            this.tbRisultato.Margin = new System.Windows.Forms.Padding(2);
            this.tbRisultato.Name = "tbRisultato";
            this.tbRisultato.ReadOnly = true;
            this.tbRisultato.Size = new System.Drawing.Size(130, 23);
            this.tbRisultato.TabIndex = 4;
            // 
            // btnCalcola
            // 
            this.btnCalcola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalcola.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcola.Location = new System.Drawing.Point(253, 47);
            this.btnCalcola.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(111, 45);
            this.btnCalcola.TabIndex = 5;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = false;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblA.Location = new System.Drawing.Point(12, 54);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(24, 30);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "a";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblB.Location = new System.Drawing.Point(12, 128);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(24, 30);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "b";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblC.Location = new System.Drawing.Point(12, 201);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(22, 30);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "c";
            // 
            // tbA
            // 
            this.tbA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbA.Location = new System.Drawing.Point(59, 63);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(64, 23);
            this.tbA.TabIndex = 9;
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // tbB
            // 
            this.tbB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbB.Location = new System.Drawing.Point(59, 133);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(64, 23);
            this.tbB.TabIndex = 10;
            this.tbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbB_KeyPress);
            // 
            // tbC
            // 
            this.tbC.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbC.Location = new System.Drawing.Point(59, 201);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(64, 23);
            this.tbC.TabIndex = 11;
            this.tbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbC_KeyPress);
            // 
            // btnAzzera
            // 
            this.btnAzzera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAzzera.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAzzera.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAzzera.Location = new System.Drawing.Point(257, 214);
            this.btnAzzera.Name = "btnAzzera";
            this.btnAzzera.Size = new System.Drawing.Size(129, 56);
            this.btnAzzera.TabIndex = 12;
            this.btnAzzera.Text = "Azzera";
            this.btnAzzera.UseVisualStyleBackColor = false;
            this.btnAzzera.Click += new System.EventHandler(this.btnAzzera_Click);
            // 
            // Equazioni_grado2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::Equazioni_grado2.WinForms.Properties.Resources.maths;
            this.ClientSize = new System.Drawing.Size(622, 375);
            this.Controls.Add(this.btnAzzera);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.tbRisultato);
            this.Controls.Add(this.lblRisultato);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Equazioni_grado2";
            this.Text = "Equazioni di Secondo Grado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.TextBox tbRisultato;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Button btnAzzera;
    }
}

