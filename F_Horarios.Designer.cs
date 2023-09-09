namespace Academia
{
    partial class F_Horarios
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
            tb_idHorario = new TextBox();
            label2 = new Label();
            dgv_horarios = new DataGridView();
            panel1 = new Panel();
            btn_fechar = new Button();
            btn_excluirHorario = new Button();
            btn_SalvarHorario = new Button();
            btn_novoHorario = new Button();
            mtb_dscHorario = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_horarios).BeginInit();
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
            // tb_idHorario
            // 
            tb_idHorario.Location = new Point(12, 27);
            tb_idHorario.Name = "tb_idHorario";
            tb_idHorario.ReadOnly = true;
            tb_idHorario.Size = new Size(69, 23);
            tb_idHorario.TabIndex = 1;
            tb_idHorario.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 9);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Horário";
            // 
            // dgv_horarios
            // 
            dgv_horarios.AllowUserToAddRows = false;
            dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_horarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_horarios.EnableHeadersVisualStyles = false;
            dgv_horarios.Location = new Point(12, 56);
            dgv_horarios.MultiSelect = false;
            dgv_horarios.Name = "dgv_horarios";
            dgv_horarios.ReadOnly = true;
            dgv_horarios.RowHeadersVisible = false;
            dgv_horarios.RowTemplate.Height = 25;
            dgv_horarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_horarios.Size = new Size(383, 321);
            dgv_horarios.TabIndex = 3;
            dgv_horarios.SelectionChanged += dgv_horarios_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_fechar);
            panel1.Controls.Add(btn_excluirHorario);
            panel1.Controls.Add(btn_SalvarHorario);
            panel1.Controls.Add(btn_novoHorario);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 383);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 30);
            panel1.TabIndex = 4;
            // 
            // btn_fechar
            // 
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.Location = new Point(305, 3);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(90, 23);
            btn_fechar.TabIndex = 3;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_excluirHorario
            // 
            btn_excluirHorario.Cursor = Cursors.Hand;
            btn_excluirHorario.Location = new Point(204, 3);
            btn_excluirHorario.Name = "btn_excluirHorario";
            btn_excluirHorario.Size = new Size(95, 23);
            btn_excluirHorario.TabIndex = 2;
            btn_excluirHorario.Text = "Excluir horário";
            btn_excluirHorario.UseVisualStyleBackColor = true;
            btn_excluirHorario.Click += btn_excluirHorario_Click;
            // 
            // btn_SalvarHorario
            // 
            btn_SalvarHorario.Cursor = Cursors.Hand;
            btn_SalvarHorario.Location = new Point(108, 3);
            btn_SalvarHorario.Name = "btn_SalvarHorario";
            btn_SalvarHorario.Size = new Size(90, 23);
            btn_SalvarHorario.TabIndex = 1;
            btn_SalvarHorario.Text = "Salvar horário";
            btn_SalvarHorario.UseVisualStyleBackColor = true;
            btn_SalvarHorario.Click += btn_SalvarHorario_Click;
            // 
            // btn_novoHorario
            // 
            btn_novoHorario.Cursor = Cursors.Hand;
            btn_novoHorario.Location = new Point(12, 3);
            btn_novoHorario.Name = "btn_novoHorario";
            btn_novoHorario.Size = new Size(90, 23);
            btn_novoHorario.TabIndex = 0;
            btn_novoHorario.Text = "Novo horário";
            btn_novoHorario.UseVisualStyleBackColor = true;
            btn_novoHorario.Click += btn_novoHorario_Click;
            // 
            // mtb_dscHorario
            // 
            mtb_dscHorario.Location = new Point(87, 27);
            mtb_dscHorario.Mask = "99:99 \\até 99:99";
            mtb_dscHorario.Name = "mtb_dscHorario";
            mtb_dscHorario.Size = new Size(83, 23);
            mtb_dscHorario.TabIndex = 5;
            // 
            // F_Horarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 413);
            Controls.Add(mtb_dscHorario);
            Controls.Add(panel1);
            Controls.Add(dgv_horarios);
            Controls.Add(label2);
            Controls.Add(tb_idHorario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Horarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Horários";
            Load += F_Horarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_horarios).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_idHorario;
        private Label label2;
        private DataGridView dgv_horarios;
        private Panel panel1;
        private Button button2;
        private Button btn_novoHorario;
        private Button btn_fechar;
        private Button btn_excluirHorario;
        private Button btn_SalvarHorario;
        private MaskedTextBox mtb_dscHorario;
    }
}