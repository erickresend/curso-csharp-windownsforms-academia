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
                if(dgv_turmas.SelectedRows.Count == 1)
                {
                    string vquery = "SELECT N_IDPROFESSOR, N_MAXALUNOS, T_STATUS, N_IDHORARIO CASE WHEN FROM tb_turmas WHERE N_IDTURMA=" + dgv_turmas.SelectedRows[0].Cells[0].Value;
                    DataTable dt = Banco.dql(vquery);
                    cb_professor.Text = dt.Rows[0].ItemArray[0].ToString();
                    n_maxAlunos.Text = dt.Rows[0].ItemArray[1].ToString();
                    cb_status.Text = dt.Rows[0].ItemArray[2].ToString();
                    cb_horario.Text = dt.Rows[0].ItemArray[3].ToString();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
