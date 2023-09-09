using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void btc_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            dgv_usuarios.Columns[0].Width = 90;
            dgv_usuarios.Columns[1].Width = 170;
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_usuarios.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv_usuarios.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO").ToString();
                n_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");
            }

        }

        private void btn_novoUsuario_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
        }

        private void btn_salvarAlteracoes_Click(object sender, EventArgs e)
        {
            //Pegando a linha que esta selecionada
            int linha = dgv_usuarios.SelectedRows[0].Index;
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt32(tb_id.Text);
            usuario.nome = tb_nome.Text;
            usuario.username = tb_username.Text;
            usuario.senha = tb_senha.Text;
            usuario.status = cb_status.Text;
            usuario.nivel = Convert.ToInt32(n_nivel.Value);
            Banco.AlterarDadosUsuario(usuario);
            //Atualizar apenas o item modificado é mais util pq nao precisar atualizar tuddo,
            //caso tenha muitos usuarios cadastrados
            //dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            dgv_usuarios[1, linha].Value = tb_nome.Text;
            //Deixar a linha selecionada apos atualizar
            dgv_usuarios.CurrentCell = dgv_usuarios[0, linha];
        }

        private void btn_excluirUsuario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusao", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.DeletarUsuario(tb_id.Text);
                //Remover apenas a linha, pra nao precisar atualizar tudo
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }
        }
    }
}
