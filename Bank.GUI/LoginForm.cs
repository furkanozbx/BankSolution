using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.GUI.BankServiceReference;

namespace Bank.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        BankServiceClient client = new BankServiceClient();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = client.Login(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                MessageBox.Show("Giriş başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı!!!!");
            }
        }
    }
}
