using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        Account acc;
        public Form1()
        {
            InitializeComponent();
        }

        private void owner_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acc = new Account();
            acc.Number = 1234;
            Client c = new Client("Igor");
            acc.Owner = c;

            owner.Text = acc.Owner.Name;
            number.Text = acc.Number.ToString();
            balance.Text = Convert.ToString(acc.Balance);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            double depValue = Convert.ToDouble(depositValue.Text);
            acc.Deposit(depValue);
            MessageBox.Show("Successful deposit!");
            balance.Text = Convert.ToString(acc.Balance);
            depositValue.Text = "";
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            double withdraw = Convert.ToDouble(withdrawValue.Text);
            string operationIsOk = acc.Withdraw(withdraw) ? "Withdraw complete!" : "Insufficient funds!";
            MessageBox.Show(operationIsOk);
            balance.Text = Convert.ToString(acc.Balance);
            withdrawValue.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
