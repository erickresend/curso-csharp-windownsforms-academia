namespace Academia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lb_nomeUsuario = new Label();
            label2 = new Label();
            lb_acesso = new Label();
            label1 = new Label();
            pb_ledLogado = new PictureBox();
            menuStrip1 = new MenuStrip();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            novoAlunoToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            novoUsuarioToolStripMenuItem = new ToolStripMenuItem();
            gestãoDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            manutençãoToolStripMenuItem = new ToolStripMenuItem();
            bancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            horáriosToolStripMenuItem = new ToolStripMenuItem();
            professoresToolStripMenuItem = new ToolStripMenuItem();
            lOGINToolStripMenuItem = new ToolStripMenuItem();
            logonToolStripMenuItem = new ToolStripMenuItem();
            logoffToolStripMenuItem = new ToolStripMenuItem();
            turmasToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ledLogado).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(lb_nomeUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lb_acesso);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pb_ledLogado);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 421);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 29);
            panel1.TabIndex = 0;
            // 
            // lb_nomeUsuario
            // 
            lb_nomeUsuario.AutoSize = true;
            lb_nomeUsuario.Location = new Point(161, 5);
            lb_nomeUsuario.Name = "lb_nomeUsuario";
            lb_nomeUsuario.Size = new Size(16, 15);
            lb_nomeUsuario.TabIndex = 4;
            lb_nomeUsuario.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 5);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // lb_acesso
            // 
            lb_acesso.AutoSize = true;
            lb_acesso.Location = new Point(86, 5);
            lb_acesso.Name = "lb_acesso";
            lb_acesso.Size = new Size(13, 15);
            lb_acesso.TabIndex = 2;
            lb_acesso.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 5);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Acesso";
            // 
            // pb_ledLogado
            // 
            pb_ledLogado.Image = Properties.Resources.vermelho;
            pb_ledLogado.Location = new Point(0, 0);
            pb_ledLogado.Name = "pb_ledLogado";
            pb_ledLogado.Size = new Size(30, 27);
            pb_ledLogado.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_ledLogado.TabIndex = 0;
            pb_ledLogado.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { alunosToolStripMenuItem, usuariosToolStripMenuItem, manutençãoToolStripMenuItem, lOGINToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(409, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoAlunoToolStripMenuItem });
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(56, 20);
            alunosToolStripMenuItem.Text = "Alunos";
            // 
            // novoAlunoToolStripMenuItem
            // 
            novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            novoAlunoToolStripMenuItem.Size = new Size(136, 22);
            novoAlunoToolStripMenuItem.Text = "Novo aluno";
            novoAlunoToolStripMenuItem.Click += novoAlunoToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoUsuarioToolStripMenuItem, gestãoDeUsuariosToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // novoUsuarioToolStripMenuItem
            // 
            novoUsuarioToolStripMenuItem.Name = "novoUsuarioToolStripMenuItem";
            novoUsuarioToolStripMenuItem.Size = new Size(173, 22);
            novoUsuarioToolStripMenuItem.Text = "Novo usuario";
            novoUsuarioToolStripMenuItem.Click += novoUsuarioToolStripMenuItem_Click;
            // 
            // gestãoDeUsuariosToolStripMenuItem
            // 
            gestãoDeUsuariosToolStripMenuItem.Name = "gestãoDeUsuariosToolStripMenuItem";
            gestãoDeUsuariosToolStripMenuItem.Size = new Size(173, 22);
            gestãoDeUsuariosToolStripMenuItem.Text = "Gestão de usuarios";
            gestãoDeUsuariosToolStripMenuItem.Click += gestãoDeUsuariosToolStripMenuItem_Click;
            // 
            // manutençãoToolStripMenuItem
            // 
            manutençãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bancoDeDadosToolStripMenuItem, horáriosToolStripMenuItem, professoresToolStripMenuItem, turmasToolStripMenuItem });
            manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            manutençãoToolStripMenuItem.Size = new Size(86, 20);
            manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            bancoDeDadosToolStripMenuItem.Size = new Size(180, 22);
            bancoDeDadosToolStripMenuItem.Text = "Banco de dados";
            bancoDeDadosToolStripMenuItem.Click += bancoDeDadosToolStripMenuItem_Click;
            // 
            // horáriosToolStripMenuItem
            // 
            horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            horáriosToolStripMenuItem.Size = new Size(180, 22);
            horáriosToolStripMenuItem.Text = "Horários";
            horáriosToolStripMenuItem.Click += horáriosToolStripMenuItem_Click;
            // 
            // professoresToolStripMenuItem
            // 
            professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            professoresToolStripMenuItem.Size = new Size(180, 22);
            professoresToolStripMenuItem.Text = "Professores";
            professoresToolStripMenuItem.Click += professoresToolStripMenuItem_Click;
            // 
            // lOGINToolStripMenuItem
            // 
            lOGINToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logonToolStripMenuItem, logoffToolStripMenuItem });
            lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            lOGINToolStripMenuItem.Size = new Size(54, 20);
            lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // logonToolStripMenuItem
            // 
            logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            logonToolStripMenuItem.Size = new Size(109, 22);
            logonToolStripMenuItem.Text = "Logon";
            logonToolStripMenuItem.Click += logonToolStripMenuItem_Click;
            // 
            // logoffToolStripMenuItem
            // 
            logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            logoffToolStripMenuItem.Size = new Size(109, 22);
            logoffToolStripMenuItem.Text = "Logoff";
            logoffToolStripMenuItem.Click += logoffToolStripMenuItem_Click;
            // 
            // turmasToolStripMenuItem
            // 
            turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            turmasToolStripMenuItem.Size = new Size(180, 22);
            turmasToolStripMenuItem.Text = "Turmas";
            turmasToolStripMenuItem.Click += turmasToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Academia - v1.0";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ledLogado).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public PictureBox pb_ledLogado;
        private Label label1;
        private Label label2;
        public Label lb_acesso;
        public Label lb_nomeUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lOGINToolStripMenuItem;
        private ToolStripMenuItem logonToolStripMenuItem;
        private ToolStripMenuItem logoffToolStripMenuItem;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem gestãoDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem novoAlunoToolStripMenuItem;
        private ToolStripMenuItem novoUsuarioToolStripMenuItem;
        private ToolStripMenuItem horáriosToolStripMenuItem;
        private ToolStripMenuItem professoresToolStripMenuItem;
        private ToolStripMenuItem turmasToolStripMenuItem;
    }
}