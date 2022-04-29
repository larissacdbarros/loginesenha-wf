using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string msg = "Login e/ou senha errados";
            string caption = "Errou";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            
            string senha = "123";
            string login = "abc";
            if (txtLogin.Text.Equals(login) && txtSenha.Text.Equals(senha))
            {
                TelaUsuario telaUsuario = new TelaUsuario();
                telaUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show(msg, caption, buttons, MessageBoxIcon.Error);
            }
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
