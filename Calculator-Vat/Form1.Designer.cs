
namespace Calculator_Vat
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxVat = new System.Windows.Forms.ComboBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbtnNetto = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.rbtnBrutto = new System.Windows.Forms.RadioButton();
            this.Vat = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxVat
            // 
            this.boxVat.BackColor = System.Drawing.SystemColors.Window;
            this.boxVat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxVat.Font = new System.Drawing.Font("Rockwell", 15F);
            this.boxVat.FormattingEnabled = true;
            this.boxVat.Items.AddRange(new object[] {
            "5%",
            "8%",
            "23%"});
            this.boxVat.Location = new System.Drawing.Point(176, 186);
            this.boxVat.Name = "boxVat";
            this.boxVat.Size = new System.Drawing.Size(109, 37);
            this.boxVat.TabIndex = 19;
            this.boxVat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.White;
            this.Result.Font = new System.Drawing.Font("Rockwell", 15F);
            this.Result.Location = new System.Drawing.Point(33, 248);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(312, 105);
            this.Result.TabIndex = 14;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Rockwell", 15F);
            this.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReset.Location = new System.Drawing.Point(42, 372);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 54);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbtnNetto
            // 
            this.rbtnNetto.AutoSize = true;
            this.rbtnNetto.Font = new System.Drawing.Font("Rockwell", 16F);
            this.rbtnNetto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnNetto.Location = new System.Drawing.Point(66, 62);
            this.rbtnNetto.Name = "rbtnNetto";
            this.rbtnNetto.Size = new System.Drawing.Size(213, 35);
            this.rbtnNetto.TabIndex = 18;
            this.rbtnNetto.TabStop = true;
            this.rbtnNetto.Text = "brutto na netto";
            this.rbtnNetto.UseVisualStyleBackColor = true;
            this.rbtnNetto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalc.Font = new System.Drawing.Font("Rockwell", 15F);
            this.btnCalc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCalc.Location = new System.Drawing.Point(199, 372);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(134, 54);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Policz";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // rbtnBrutto
            // 
            this.rbtnBrutto.AutoSize = true;
            this.rbtnBrutto.Checked = true;
            this.rbtnBrutto.Font = new System.Drawing.Font("Rockwell", 16F);
            this.rbtnBrutto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtnBrutto.Location = new System.Drawing.Point(66, 12);
            this.rbtnBrutto.Name = "rbtnBrutto";
            this.rbtnBrutto.Size = new System.Drawing.Size(213, 35);
            this.rbtnBrutto.TabIndex = 17;
            this.rbtnBrutto.TabStop = true;
            this.rbtnBrutto.Text = "netto na brutto";
            this.rbtnBrutto.UseVisualStyleBackColor = true;
            this.rbtnBrutto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // Vat
            // 
            this.Vat.AutoSize = true;
            this.Vat.Font = new System.Drawing.Font("Rockwell", 15F);
            this.Vat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Vat.Location = new System.Drawing.Point(70, 186);
            this.Vat.Name = "Vat";
            this.Vat.Size = new System.Drawing.Size(69, 29);
            this.Vat.TabIndex = 13;
            this.Vat.Text = "VAT:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Rockwell", 15F);
            this.txtAmount.Location = new System.Drawing.Point(176, 127);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(109, 37);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Rockwell", 15F);
            this.Amount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Amount.Location = new System.Drawing.Point(61, 127);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(90, 29);
            this.Amount.TabIndex = 12;
            this.Amount.Text = "Kwota:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.boxVat);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.rbtnNetto);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.rbtnBrutto);
            this.Controls.Add(this.Vat);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.Amount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Kalkulator VAT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxVat;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbtnNetto;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton rbtnBrutto;
        private System.Windows.Forms.Label Vat;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label Amount;
    }
}

