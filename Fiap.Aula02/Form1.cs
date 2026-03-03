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
    }
}
