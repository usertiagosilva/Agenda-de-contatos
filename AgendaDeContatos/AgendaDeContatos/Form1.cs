namespace AgendaDeContatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(telefone) && !string.IsNullOrEmpty(email))
            {
                string contato = $"{nome} - {telefone} - {email}";
                lstContatos.Items.Add(contato);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstContatos.SelectedItem != null)
            {
                string contatoAtual = lstContatos.SelectedItem.ToString();
                string[] dados = contatoAtual.Split(" - ");

                txtNome.Text = dados[0];
                txtTelefone.Text = dados[1];
                txtEmail.Text = dados[2];

                lstContatos.Items.Remove(lstContatos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um contato para editar.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstContatos.SelectedItem != null)
            {
                lstContatos.Items.Remove(lstContatos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um contato para remover.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
