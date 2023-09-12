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
    public partial class F_Gestaoturmas : Form
    {
        string idSelecionado;
        public F_Gestaoturmas()
        {
            InitializeComponent();
        }

        private void F_Gestaoturmas_Load(object sender, EventArgs e)
        {
            try
            {
                string vqueryDGV = @"
                    SELECT 
                        tbt.N_IDTURMA as 'ID', 
                        tbt.T_DSCTURMA as 'Turma',
                        tbh.N_IDHORARIO as 'Horário'
                    FROM
                        tb_turmas as 'tbt'
                    INNER JOIN
                        tb_horario as 'tbh' on tbh.N_IDHORARIO = tbt.N_IDHORARIO
                    ";
                dgv_turmas.DataSource = Banco.dql(vqueryDGV);
                dgv_turmas.Columns[0].Width = 40;
                dgv_turmas.Columns[1].Width = 120;
                dgv_turmas.Columns[2].Width = 85;

                //POPULAR COMBOBOX PROFESSOR
                string vqueyProfessores = @"
                    SELECT 
                        N_IDPROFESSOR,
                        N_NOMEPROFESSOR
                    FROM
                        tb_professores
                    ORDER BY
                        N_IDPROFESSOR
                ";
                cb_professor.Items.Clear(); //só pra garantir
                cb_professor.DataSource = Banco.dql(vqueyProfessores);
                cb_professor.DisplayMember = "N_NOMEPROFESSOR";
                cb_professor.ValueMember = "N_IDPROFESSOR";

                //POPULAR COMBOBOX STATUS
                Dictionary<string, string> st = new Dictionary<string, string>();
                st.Add("A", "Ativa");
                st.Add("P", "Paralisada");
                st.Add("C", "Cancelada");
                cb_status.Items.Clear();
                cb_status.DataSource = new BindingSource(st, null);
                cb_status.DisplayMember = "Value";
                cb_status.ValueMember = "Key";

                //POPULAR COMBOBOX HORARIO
                string vqueyHorario = @"
                    SELECT 
                        N_IDHORARIO,
                        T_DSCHORARIO
                    FROM
                        tb_horario
                    ORDER BY
                        T_DSCHORARIO
                ";
                cb_horario.Items.Clear();
                cb_horario.DataSource = Banco.dql(vqueyHorario);
                cb_horario.DisplayMember = "T_DSCHORARIO";
                cb_horario.ValueMember = "N_IDHORARIO";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_turmas.SelectedRows.Count == 1)
                {
                    idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                    string vqueryCampos = String.Format(@"
                        SELECT 
                            T_DSCTURMA,
                            N_IDPROFESSOR,
                            N_MAXALUNOS,
                            T_STATUS,
                            N_IDHORARIO
                        FROM
                            tb_turmas
                        WHERE
                            N_IDTURMA={0}
                    ", idSelecionado);
                    DataTable dt = Banco.dql(vqueryCampos);
                    tb_descricao.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                    cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                    n_maxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                    cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                    cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            tb_descricao.Clear();
            cb_professor.SelectedItem = null; //ou  cb_professor.SelectedIndex = -1;
            n_maxAlunos.Value = 0;
            cb_status.SelectedItem = null;
            cb_horario.SelectedItem = null;
            tb_descricao.Focus();
        }

        private void btn_salvarEdicoes_Click(object sender, EventArgs e)
        {
            int linha = dgv_turmas.SelectedRows[0].Index;

            string queryAlterarTurma = String.Format(@"
                UPDATE 
                    tb_turmas
                SET 
                    T_DSCTURMA='{0}',
                    N_IDPROFESSOR={1},
                    N_MAXALUNOS={2},
                    T_STATUS='{3}',
                    N_IDHORARIO={4}
                WHERE
                    N_IDTURMA={5}
            ", tb_descricao.Text, cb_professor.SelectedValue, Convert.ToInt32(n_maxAlunos.Value), 
            cb_status.SelectedValue, cb_horario.SelectedValue, Convert.ToInt32(idSelecionado));

            Banco.dml(queryAlterarTurma, "Turma alterada com sucesso", "ERRO: ");

            dgv_turmas[1, linha].Value = tb_descricao.Text;
            dgv_turmas[2, linha].Value = cb_horario.Text;
        }
    }
}
