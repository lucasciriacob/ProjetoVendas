using MySql.Data.MySqlClient;

namespace ProjetoVendas
{
    public partial class FormAuth : Form
    {

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void LimparCampos()
        {
            txtEmail.Clear();
            txtSenha.Clear();
            chkSenha.Checked = false;
        }
        public FormAuth()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "dataSource = localhost; username = root; password =; database = bd_vendas";
            string usuario = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                string queryLogin = "SELECT id, tipo FROM usuarios WHERE TRIM(nome) = @nome AND TRIM(senha) = @senha";

                using (MySqlCommand cmdLogin = new MySqlCommand(queryLogin, conexao))
                {
                    cmdLogin.Parameters.AddWithValue("@nome", usuario);
                    cmdLogin.Parameters.AddWithValue("@senha", senha);

                    using (MySqlDataReader reader = cmdLogin.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idUsuario = reader.GetInt32("id");
                            string tipoUsuario = reader.GetString("tipo");

                            Sessao.UsuarioId = idUsuario;

                            LimparCampos();

                            if (tipoUsuario == "admin" )
                            {
                                FormAdmin telaADM = new FormAdmin();
                                telaADM.Show();
                            }
                            else
                            {
                                FormVendedor telaVendas = new FormVendedor();
                                telaVendas.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos.");
                        }
                    }
                }
            }

        }

        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';

            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
            FormSenha senha = new FormSenha();
            senha.Show();
        }
    }
}
