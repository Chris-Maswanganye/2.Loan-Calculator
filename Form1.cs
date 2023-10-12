using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Loan_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double loanAmount = 0.0;
            double downPayment = 0.0; 
            double interestRate = 0.0; 
            double monthlyPayment = 0.0;
            int terms = 0;

            
            if (!string.IsNullOrEmpty(txtloanAmount.Text))
                loanAmount = Convert.ToDouble(txtloanAmount.Text);
            if
                (!string.IsNullOrEmpty(txtDownPayment.Text))
                downPayment = Convert.ToDouble(txtDownPayment.Text);
            if
                (!string.IsNullOrEmpty(txtInterestRate.Text))
                interestRate = Convert.ToDouble(txtinterestRate.Text);

            if(!string.IsNullOrEmpty(txtTermsInYears.Text))
                terms = Convert.ToInt32(txtTerms.Text);

            int termsinMonths = terms * 12;
            monthlyPayment = (loanAmount - downPayment) * (Math.Pow((1 + interestRate / 12),
                termsinMonths) * interestRate) / (12 * (Math.Pow((2 + interestRate / 12),
                termsinMonths) - 1));
            monthlyPayment= Math.Round(monthlyPayment, 2);

            lblMonthlyPayment.Text =
                string.Format("Monthly Payment: R {0}", monthlyPayment.ToString());




        }
    }
}
