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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            try
            {
                string vquery = @"
                    SELECT
                        N_IDHORARIO as 'ID',
                        T_DSCHORARIO as 'Horário'
                    FROM
                        tb_horario
                    ORDER BY
                        T_DSCHORARIO
                ";
                dgv_horarios.DataSource = Banco.dql(vquery);
                dgv_horarios.Columns[0].Width = 60;
                dgv_horarios.Columns[1].Width = 170;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_horarios.SelectedRows.Count > 0)
                {
                    tb_idHorario.Text = dgv_horarios.SelectedRows[0].Cells[0].Value.ToString();
                    mtb_dscHorario.Text = dgv_horarios.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_novoHorario_Click(object sender, EventArgs e)
        {
            tb_idHorario.Clear();
            mtb_dscHorario.Clear();
            mtb_dscHorario.Focus();
        }

        private void btn_SalvarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                if(tb_idHorario.Text == "")
                {
                    sql = "INSERT INTO tb_horario (T_DSCHORARIO) VALUES ('" + mtb_dscHorario.Text + "')";
                    Banco.dml(sql, "Horário adicionado com sucesso", "ERRO");
                }
                else
                {
                    sql = "UPDATE tb_horario SET T_DSCHORARIO='"+mtb_dscHorario.Text+ "' WHERE N_IDHORARIO="+tb_idHorario.Text+"";
                    Banco.dml(sql, "Horário alterado com sucesso", "ERRO");
                }
                
                string vquery = @"
                    SELECT
                        N_IDHORARIO as 'ID',
                        T_DSCHORARIO as 'Horário'
                    FROM
                        tb_horario
                    ORDER BY
                        T_DSCHORARIO
                ";
                dgv_horarios.DataSource = Banco.dql(vquery);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_excluirHorario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string sql = "DELETE FROM tb_horario WHERE N_IDHORARIO='" + tb_idHorario.Text + "'";
                Banco.dml(sql, "Horário excluído com sucesso", "ERRO");
                string vquery = @"
                    SELECT
                        N_IDHORARIO as 'ID',
                        T_DSCHORARIO as 'Horário'
                    FROM
                        tb_horario
                    ORDER BY
                        T_DSCHORARIO
                ";
                dgv_horarios.DataSource = Banco.dql(vquery);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
