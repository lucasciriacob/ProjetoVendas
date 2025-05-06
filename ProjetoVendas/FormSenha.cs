using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProjetoVendas
{
    public partial class FormSenha : Form
    {
        public FormSenha()
        {
            InitializeComponent();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            string connectionString = "dataSource=localhost;username=root;password=;database=bd_vendas";
            string usuario = txtUser.Text.Trim();
            string email = txtEmail.Text.Trim();

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string sql = "SELECT COUNT(*) FROM usuarios WHERE TRIM(nome) = @usuario AND TRIM(email) = @email";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@email", email);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {

                        MessageBox.Show("Dados confirmados. Insira a nova senha.");
                        txtUser.Visible = false;
                        txtEmail.Visible = false;
                        btnEmail.Visible = false;
                        txtSenha.Visible = true;
                        btnSenha.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou e-mail incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void FormSenha_Load(object sender, EventArgs e)
        {
            txtSenha.Visible = false;
            btnSenha.Visible = false;
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string novaSenha = txtSenha.Text.Trim();
            string usuario = txtUser.Text.Trim();

            string connectionString = "dataSource=localhost;username=root;password=;database=bd_vendas";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string sql = "UPDATE usuarios SET senha = @senha WHERE nome = @usuario";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@senha", novaSenha);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Senha atualizada com sucesso!");
                        this.Close(); // Fecha o form de recuperação
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar a senha.");
                    }
                }
            }
        }
    }
}
