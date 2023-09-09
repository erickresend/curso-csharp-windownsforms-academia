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
    public partial class F_GestaoProfessores : Form
    {
        public F_GestaoProfessores()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_GestaoProfessores_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT N_IDPROFESSOR as 'ID', N_NOMEPROFESSOR as 'Professor', N_TELEFONE as 'Telefone' FROM tb_professores";
                dgv_professores.DataSource = Banco.dql(sql);
                dgv_professores.Columns[0].Width = 50;
                dgv_professores.Columns[1].Width = 200;
                dgv_professores.Columns[2].Width = 130;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_professores.SelectedRows.Count == 1)
                {
                    tb_id.Text = dgv_professores.SelectedRows[0].Cells[0].Value.ToString();
                    tb_nomeProfessor.Text = dgv_professores.SelectedRows[0].Cells[1].Value.ToString();
                    mtb_telProfessor.Text = dgv_professores.SelectedRows[0].Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_novoProfessor_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            tb_nomeProfessor.Clear();
            mtb_telProfessor.Clear();
            tb_nomeProfessor.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                if (tb_id.Text == "")
                {
                    sql = "INSERT INTO tb_professores (N_NOMEPROFESSOR, N_TELEFONE) VALUES ('" + tb_nomeProfessor.Text + "', '" + mtb_telProfessor.Text + "')";
                    Banco.dml(sql, "Professor adicionado com sucesso", "ERRO: ");
                    string atualizar = "SELECT N_IDPROFESSOR as 'ID', N_NOMEPROFESSOR as 'Professor', N_TELEFONE as 'Telefone' FROM tb_professores";
                    dgv_professores.DataSource = Banco.dql(atualizar);
                }
                else
                {
                    sql = "UPDATE tb_professores SET N_NOMEPROFESSOR='" + tb_nomeProfessor.Text + "', N_TELEFONE='" + mtb_telProfessor.Text + "' WHERE N_IDPROFESSOR=" + tb_id.Text + "";
                    Banco.dml(sql, "Professor alterado com sucesso", "ERRO: ");
                    string atualizar = "SELECT N_IDPROFESSOR as 'ID', N_NOMEPROFESSOR as 'Professor', N_TELEFONE as 'Telefone' FROM tb_professores";
                    dgv_professores.DataSource = Banco.dql(atualizar);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Confirma exclusão", "Excluir", MessageBoxButtons.YesNo);
                string sql;
                if(res == DialogResult.Yes)
                {
                    sql = "DELETE FROM tb_professores WHERE N_IDPROFESSOR=" + tb_id.Text;
                    Banco.dml(sql, "Professor deletado com sucesso", "ERRO: ");
                    string atualizar = "SELECT N_IDPROFESSOR as 'ID', N_NOMEPROFESSOR as 'Professor', N_TELEFONE as 'Telefone' FROM tb_professores";
                    dgv_professores.DataSource = Banco.dql(atualizar);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
