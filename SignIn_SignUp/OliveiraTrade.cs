using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn_SignUp
{

    public partial class OliveiraTrade : Form
    {

        public OliveiraTrade()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Registra contas;
            contas = new Registra();

            try
            {
                if (textBoxEmailNome.Text.Equals(contas.getEmail()) && textBoxSenhaIn.Text.Equals(contas.getSenha()))
                {
                    MessageBox.Show("Login efetuado com sucesso!");

                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Desculpe", erro.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCria_Click(object sender, EventArgs e)
        {
            Registra conta;
            conta = new Registra();


            conta.setNome(textBoxNome.Text);
            conta.setEmail(textBoxEmail.Text);
            conta.setSenha(textBoxSenha.Text);

            MessageBox.Show("Cadastro realizado com sucesso!.", conta.getNome());

        }


    }
}

