using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace salvar_imagem
{
    class imagem : conexao
    {
        private string caminho;
        public string _caminho
        {
            get
            {
                return caminho;
            }
            set
            {
                caminho = value;
            }
        }
        public void inserir()
        {
            string query = "INSERT INTO imagem (caminho) VALUES ('" + caminho + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}