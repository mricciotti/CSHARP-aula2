using System.Text.Json;
using System.Threading.Tasks;

namespace Fiap.Aula02
{
    public partial class Form1 : Form
    {
        List<Aluno> listaAlunos = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.id = int.Parse(txtCodigo.Text);
            aluno.nome = txtNome.Text;
            //aluno.RM = txtRM.Text;

            listaAlunos.Add(aluno);

            txtCodigo.Text = string.Empty;
            txtNome.Text = "";

            MessageBox.Show("Aluno cadastrado", "FIAP");
            dgvAlunos.DataSource = null;
            dgvAlunos.DataSource = listaAlunos;
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void BtnBuscarCep_Click(object sender, EventArgs e)
        {
            string url = $"https://viacep.com.br/ws/{txtCep.Text}/json/";

            HttpClient cliente = new HttpClient();
            var json = await cliente.GetStringAsync(url);

            AlunoEndereco alunoEnd = new AlunoEndereco();

            alunoEnd = JsonSerializer.Deserialize<AlunoEndereco>(json);

            txtRua.Text = alunoEnd.LogradouroAluno;
            txtBairro.Text = alunoEnd.BairroAluno;

            MessageBox.Show(alunoEnd.LogradouroAluno);
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
