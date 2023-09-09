using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_Login : Form
    {
        //Criando um objeto do Form1 pra poder manipular ele aqui
        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string senha = tb_senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Algum campo está vazio");
                tb_username.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='" + username + "' AND T_SENHAUSUARIO='" + senha + "'";
            dt = Banco.dql(sql);
            //Verificando se retornou uma linha
            if (dt.Rows.Count == 1)
            {
                //Cada item da tabela é um elemento do array, Rows[0] pq retornou 1 linha
                //Lembrando que os acessos dele estao publico
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_nomeUsuario.Text = dt.Rows[0].ItemArray[1].ToString();
                form1.pb_ledLogado.Image = Properties.Resources.verde;
                Globais.nivel = int.Parse(dt.Rows[0].ItemArray[5].ToString());
                Globais.logado = true;
                //Fechar a janela
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario não encontrado");
            }
        }
    }
}
