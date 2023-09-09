namespace Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        //Metodo para facilitar verificar o nivel do usuario e chamar o formulario
        private void abreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso negado para seu usuario");
                }
            }
            else
            {
                MessageBox.Show("É nescessario ter um usuario logado");
            }
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "...";
            pb_ledLogado.Image = Properties.Resources.vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreForm(1, new F_NovoUsuario());
        }

        private void gestãoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreForm(1, new F_GestaoUsuarios());
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {

            }
            else
            {
                MessageBox.Show("É nescessario ter um usuario logado");
            }
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreForm(2, new F_Horarios());

        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreForm(2, new F_GestaoProfessores());
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreForm(2, new F_Gestaoturmas());
        }
    }
}