namespace Academia
{
    partial class F_GestaoProfessores
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
            label1 = new Label();
            tb_id = new TextBox();
            tb_nomeProfessor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dgv_professores = new DataGridView();
            panel1 = new Panel();
            btn_fechar = new Button();
            btn_excluir = new Button();
            btn_salvar = new Button();
            btn_novoProfessor = new Button();
            mtb_telProfessor = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_professores).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(12, 27);
            tb_id.Name = "tb_id";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(69, 23);
            tb_id.TabIndex = 1;
            tb_id.TabStop = false;
            // 
            // tb_nomeProfessor
            // 
            tb_nomeProfessor.Location = new Point(87, 27);
            tb_nomeProfessor.Name = "tb_nomeProfessor";
            tb_nomeProfessor.Size = new Size(246, 23);
            tb_nomeProfessor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 9);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Professor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 9);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefone";
            // 
            // dgv_professores
            // 
            dgv_professores.AllowUserToAddRows = false;
            dgv_professores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_professores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_professores.Location = new Point(12, 56);
            dgv_professores.MultiSelect = false;
            dgv_professores.Name = "dgv_professores";
            dgv_professores.ReadOnly = true;
            dgv_professores.RowHeadersVisible = false;
            dgv_professores.RowTemplate.Height = 25;
            dgv_professores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_professores.Size = new Size(430, 339);
            dgv_professores.TabIndex = 6;
            dgv_professores.TabStop = false;
            dgv_professores.SelectionChanged += dgv_professores_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_fechar);
            panel1.Controls.Add(btn_excluir);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(btn_novoProfessor);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 403);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 30);
            panel1.TabIndex = 7;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(339, 3);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(103, 23);
            btn_fechar.TabIndex = 3;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(230, 3);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(103, 23);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(121, 3);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(103, 23);
            btn_salvar.TabIndex = 1;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_novoProfessor
            // 
            btn_novoProfessor.Location = new Point(12, 3);
            btn_novoProfessor.Name = "btn_novoProfessor";
            btn_novoProfessor.Size = new Size(103, 23);
            btn_novoProfessor.TabIndex = 0;
            btn_novoProfessor.Text = "Novo professor";
            btn_novoProfessor.UseVisualStyleBackColor = true;
            btn_novoProfessor.Click += btn_novoProfessor_Click;
            // 
            // mtb_telProfessor
            // 
            mtb_telProfessor.Location = new Point(339, 27);
            mtb_telProfessor.Mask = "(99) 00000-0000";
            mtb_telProfessor.Name = "mtb_telProfessor";
            mtb_telProfessor.Size = new Size(103, 23);
            mtb_telProfessor.TabIndex = 8;
            // 
            // F_GestaoProfessores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 433);
            Controls.Add(mtb_telProfessor);
            Controls.Add(panel1);
            Controls.Add(dgv_professores);
            Controls.Add(label3);
            Controls.Add(tb_nomeProfessor);
            Controls.Add(label2);
            Controls.Add(tb_id);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_GestaoProfessores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de professores";
            Load += F_GestaoProfessores_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_professores).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_id;
        private TextBox tb_nomeProfessor;
        private Label label2;
        private Label label3;
        private DataGridView dgv_professores;
        private Panel panel1;
        private Button btn_fechar;
        private Button btn_excluir;
        private Button btn_salvar;
        private Button btn_novoProfessor;
        private MaskedTextBox mtb_telProfessor;
    }
}