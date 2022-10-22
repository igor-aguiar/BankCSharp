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
        private Account acc;
        private Account[] accs;
        private int numberOfAccounts = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void addAccount(Account account)
        {
            this.accs[numberOfAccounts] = account;
            accountsBox.Items.Add(account.Owner.Name);
            numberOfAccounts++;
        }

        private void owner_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accs = new Account[10];
            Account a1 = new SavingsAccount();
            a1.Owner = new Client("Elayne");
            a1.Number = 1;
            addAccount(a1);

            Account a2 = new SavingsAccount();
            a2.Owner = new Client("Almir");
            a2.Number = 2;
            addAccount(a2);

            Account a3 = new CurrentAccount();
            a3.Owner = new Client("Georgia");
            a3.Number = 3;
            addAccount(a3);
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
            string operationIsOk;
            try
            {
                operationIsOk = acc.Withdraw(withdraw) ? "Withdraw complete!" : "Insufficient funds!";
            } 
            catch (Exception ex)
            {
                operationIsOk = ex.Message;
            }
            MessageBox.Show(operationIsOk);
            balance.Text = Convert.ToString(acc.Balance);
            withdrawValue.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void accountsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            acc = this.accs[accountsBox.SelectedIndex];
            owner.Text = acc.Owner.Name;
            balance.Text = acc.Balance.ToString();
            number.Text = acc.Number.ToString();
        }

        private void registerAccountBtn_Click(object sender, EventArgs e)
        {
            FormCadastroConta registerForm = new FormCadastroConta(this);
            registerForm.ShowDialog();
        }

        private void calculateTaxBtn_Click(object sender, EventArgs e)
        {
                   
        }
    }
}
