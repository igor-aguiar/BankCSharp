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
    public partial class FormCadastroConta : Form
    {
        private Form1 mainForm;
        public FormCadastroConta(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void registerAccountBtn_Click(object sender, EventArgs e)
        {
            Account newAcc = new CurrentAccount();
            newAcc.Owner = new Client(owner.Text);
            newAcc.Number = Convert.ToInt32(number.Text);
            mainForm.addAccount(newAcc);
            this.Close();
        }
    }
}
