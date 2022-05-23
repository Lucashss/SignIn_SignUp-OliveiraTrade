using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn_SignUp
{
    class Registra
    {

        #region Atributos
        private string nome;
        private string email;
        private string senha;
        #endregion


        #region Construtores
        public Registra(string email, string senha, string nome)
        {
            this.email = email;
            this.senha = senha;
            this.nome = nome;
        }
        public Registra() : this("", "", "")
        {
        }

        #endregion
        #region SetsGets
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        public string getNome()
        {
            return nome;
        }
        public string getEmail()
        {
            return email;
        }
        public string getSenha()
        {
            return senha;
        }
        #endregion
    }
}
