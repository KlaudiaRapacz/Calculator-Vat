using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Vat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtAmount.Text, out decimal amt);
            char[] charTrim = { '%' };
            string intResult = boxVat.Text.Trim(charTrim);
            int.TryParse(intResult, out int vat);

            if (amt > 0)
            {
                if (rbtnBrutto.Checked)
                {

                    for (int i = 0; i <= boxVat.SelectedIndex; i++)
                    {
                        var vatAmt = Math.Round(amt * vat / 100, 2);
                        Result.Text = $"Kwota netto: {amt:C}\r\nVat: {vat}%\r\nKwota brutto: {amt + vatAmt:C}";
                    }
                }
                else
                {
                    for (int i = 0; i <= boxVat.SelectedIndex; i++)
                    {
                        var vatAmt = Math.Round(amt * vat / (vat + 100), 2);
                        Result.Text = $"Kwota brutto: {amt:C}\r\nVat: {vat}%\r\nKwota netto: {amt - vatAmt:C}";
                    }
                }
            }
            else
                MessageBox.Show("Sprawdź wartości!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            Result.Clear();
            boxVat.SelectedIndex = 2;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boxVat.SelectedIndex = 2;
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnCalc.PerformClick();
        }
    }
}
