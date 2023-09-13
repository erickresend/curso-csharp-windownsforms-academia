namespace Academia
{
    partial class F_Gestaoturmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv_turmas = new DataGridView();
            panel1 = new Panel();
            btn_fechar = new Button();
            btn_salvarEdicoes = new Button();
            btn_imprimirTurma = new Button();
            btn_excluirTurma = new Button();
            btn_novaTurma = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cb_professor = new ComboBox();
            cb_status = new ComboBox();
            cb_horario = new ComboBox();
            n_maxAlunos = new NumericUpDown();
            label5 = new Label();
            tb_descricao = new TextBox();
            tb_vagas = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_turmas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)n_maxAlunos).BeginInit();
            SuspendLayout();
            // 
            // dgv_turmas
            // 
            dgv_turmas.AllowUserToAddRows = false;
            dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_turmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_turmas.Location = new Point(12, 12);
            dgv_turmas.MultiSelect = false;
            dgv_turmas.Name = "dgv_turmas";
            dgv_turmas.ReadOnly = true;
            dgv_turmas.RowHeadersVisible = false;
            dgv_turmas.RowTemplate.Height = 25;
            dgv_turmas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_turmas.Size = new Size(369, 384);
            dgv_turmas.TabIndex = 7;
            dgv_turmas.TabStop = false;
            dgv_turmas.SelectionChanged += dgv_turmas_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_fechar);
            panel1.Controls.Add(btn_salvarEdicoes);
            panel1.Controls.Add(btn_imprimirTurma);
            panel1.Controls.Add(btn_excluirTurma);
            panel1.Controls.Add(btn_novaTurma);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 403);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 31);
            panel1.TabIndex = 8;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(523, 3);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(91, 23);
            btn_fechar.TabIndex = 10;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_salvarEdicoes
            // 
            btn_salvarEdicoes.Location = new Point(138, 3);
            btn_salvarEdicoes.Name = "btn_salvarEdicoes";
            btn_salvarEdicoes.Size = new Size(91, 23);
            btn_salvarEdicoes.TabIndex = 7;
            btn_salvarEdicoes.Text = "Salvar edições";
            btn_salvarEdicoes.UseVisualStyleBackColor = true;
            btn_salvarEdicoes.Click += btn_salvarEdicoes_Click;
            // 
            // btn_imprimirTurma
            // 
            btn_imprimirTurma.Location = new Point(398, 3);
            btn_imprimirTurma.Name = "btn_imprimirTurma";
            btn_imprimirTurma.Size = new Size(97, 23);
            btn_imprimirTurma.TabIndex = 9;
            btn_imprimirTurma.Text = "Imprimir turma";
            btn_imprimirTurma.UseVisualStyleBackColor = true;
            // 
            // btn_excluirTurma
            // 
            btn_excluirTurma.Location = new Point(265, 3);
            btn_excluirTurma.Name = "btn_excluirTurma";
            btn_excluirTurma.Size = new Size(91, 23);
            btn_excluirTurma.TabIndex = 8;
            btn_excluirTurma.Text = "Excluir turma";
            btn_excluirTurma.UseVisualStyleBackColor = true;
            btn_excluirTurma.Click += btn_excluirTurma_Click;
            // 
            // btn_novaTurma
            // 
            btn_novaTurma.Location = new Point(12, 3);
            btn_novaTurma.Name = "btn_novaTurma";
            btn_novaTurma.Size = new Size(91, 23);
            btn_novaTurma.TabIndex = 6;
            btn_novaTurma.Text = "Nova turma";
            btn_novaTurma.UseVisualStyleBackColor = true;
            btn_novaTurma.Click += btn_novaTurma_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 80);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 9;
            label1.Text = "Professor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 150);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 10;
            label2.Text = "Máximo alunos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 150);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 11;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 226);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 12;
            label4.Text = "Horário";
            // 
            // cb_professor
            // 
            cb_professor.FormattingEnabled = true;
            cb_professor.Items.AddRange(new object[] { "Fulano, Ciclano, Beltrano" });
            cb_professor.Location = new Point(387, 98);
            cb_professor.Name = "cb_professor";
            cb_professor.Size = new Size(227, 23);
            cb_professor.TabIndex = 2;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(493, 168);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(121, 23);
            cb_status.TabIndex = 4;
            // 
            // cb_horario
            // 
            cb_horario.FormattingEnabled = true;
            cb_horario.Location = new Point(387, 244);
            cb_horario.Name = "cb_horario";
            cb_horario.Size = new Size(227, 23);
            cb_horario.TabIndex = 5;
            // 
            // n_maxAlunos
            // 
            n_maxAlunos.Location = new Point(387, 169);
            n_maxAlunos.Name = "n_maxAlunos";
            n_maxAlunos.Size = new Size(100, 23);
            n_maxAlunos.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 12);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 13;
            label5.Text = "Descrição";
            // 
            // tb_descricao
            // 
            tb_descricao.Location = new Point(387, 30);
            tb_descricao.Name = "tb_descricao";
            tb_descricao.Size = new Size(227, 23);
            tb_descricao.TabIndex = 1;
            // 
            // tb_vagas
            // 
            tb_vagas.Location = new Point(387, 324);
            tb_vagas.Name = "tb_vagas";
            tb_vagas.Size = new Size(100, 23);
            tb_vagas.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(387, 306);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 15;
            label6.Text = "Vagas";
            // 
            // F_Gestaoturmas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 434);
            Controls.Add(label6);
            Controls.Add(tb_vagas);
            Controls.Add(tb_descricao);
            Controls.Add(label5);
            Controls.Add(n_maxAlunos);
            Controls.Add(cb_horario);
            Controls.Add(cb_status);
            Controls.Add(cb_professor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dgv_turmas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Gestaoturmas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de turmas";
            Load += F_Gestaoturmas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_turmas).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)n_maxAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_turmas;
        private Panel panel1;
        private Button btn_fechar;
        private Button btn_salvarEdicoes;
        private Button btn_imprimirTurma;
        private Button btn_excluirTurma;
        private Button btn_novaTurma;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cb_professor;
        private ComboBox cb_status;
        private ComboBox cb_horario;
        private NumericUpDown n_maxAlunos;
        private Label label5;
        private TextBox tb_descricao;
        private TextBox tb_vagas;
        private Label label6;
    }
}