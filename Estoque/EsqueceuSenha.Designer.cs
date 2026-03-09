namespace Estoque
{
    partial class EsqueceuSenha
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
            checkBoxLembrarLogin = new CheckBox();
            btnEntrar = new Button();
            txtCadastrar = new LinkLabel();
            boxUsuario = new TextBox();
            boxSenha = new TextBox();
            txtNovaSenha = new Label();
            txtUsuario = new Label();
            txtEsqueciSenha = new LinkLabel();
            imagemConfiguracoes = new PictureBox();
            imagemRelatorio = new PictureBox();
            imagemReabastecimento = new PictureBox();
            imagemInventario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagemConfiguracoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagemRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagemReabastecimento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagemInventario).BeginInit();
            SuspendLayout();
            // 
            // checkBoxLembrarLogin
            // 
            checkBoxLembrarLogin.AutoSize = true;
            checkBoxLembrarLogin.BackColor = Color.Transparent;
            checkBoxLembrarLogin.ForeColor = SystemColors.Control;
            checkBoxLembrarLogin.Location = new Point(87, 319);
            checkBoxLembrarLogin.Name = "checkBoxLembrarLogin";
            checkBoxLembrarLogin.Size = new Size(141, 19);
            checkBoxLembrarLogin.TabIndex = 104;
            checkBoxLembrarLogin.Text = "Lembrar minha senha";
            checkBoxLembrarLogin.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEntrar.AutoSize = true;
            btnEntrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEntrar.BackColor = Color.Blue;
            btnEntrar.ForeColor = SystemColors.Control;
            btnEntrar.Location = new Point(231, 319);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(48, 25);
            btnEntrar.TabIndex = 105;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtCadastrar
            // 
            txtCadastrar.AutoSize = true;
            txtCadastrar.BackColor = Color.Transparent;
            txtCadastrar.Location = new Point(222, 290);
            txtCadastrar.Name = "txtCadastrar";
            txtCadastrar.Size = new Size(57, 15);
            txtCadastrar.TabIndex = 103;
            txtCadastrar.TabStop = true;
            txtCadastrar.Text = "Cadastrar";
            txtCadastrar.LinkClicked += txtCadastrar_LinkClicked;
            // 
            // boxUsuario
            // 
            boxUsuario.Location = new Point(87, 210);
            boxUsuario.Name = "boxUsuario";
            boxUsuario.Size = new Size(192, 23);
            boxUsuario.TabIndex = 100;
            // 
            // boxSenha
            // 
            boxSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxSenha.Location = new Point(87, 254);
            boxSenha.Name = "boxSenha";
            boxSenha.PasswordChar = '*';
            boxSenha.Size = new Size(192, 23);
            boxSenha.TabIndex = 101;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.AutoSize = true;
            txtNovaSenha.BackColor = Color.Transparent;
            txtNovaSenha.ForeColor = SystemColors.Control;
            txtNovaSenha.Location = new Point(87, 236);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(69, 15);
            txtNovaSenha.TabIndex = 106;
            txtNovaSenha.Text = "Nova senha";
            // 
            // txtUsuario
            // 
            txtUsuario.AutoSize = true;
            txtUsuario.BackColor = Color.Transparent;
            txtUsuario.ForeColor = SystemColors.Control;
            txtUsuario.Location = new Point(87, 192);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(47, 15);
            txtUsuario.TabIndex = 107;
            txtUsuario.Text = "Usuário";
            // 
            // txtEsqueciSenha
            // 
            txtEsqueciSenha.AutoSize = true;
            txtEsqueciSenha.BackColor = Color.Transparent;
            txtEsqueciSenha.Location = new Point(87, 290);
            txtEsqueciSenha.Name = "txtEsqueciSenha";
            txtEsqueciSenha.Size = new Size(100, 15);
            txtEsqueciSenha.TabIndex = 102;
            txtEsqueciSenha.TabStop = true;
            txtEsqueciSenha.Text = "Tenho uma conta";
            txtEsqueciSenha.LinkClicked += txtEsqueciSenha_LinkClicked;
            // 
            // imagemConfiguracoes
            // 
            imagemConfiguracoes.BackColor = Color.Transparent;
            imagemConfiguracoes.Image = Properties.Resources.imagemConfiguracoes;
            imagemConfiguracoes.Location = new Point(633, 361);
            imagemConfiguracoes.Name = "imagemConfiguracoes";
            imagemConfiguracoes.Size = new Size(100, 50);
            imagemConfiguracoes.SizeMode = PictureBoxSizeMode.Zoom;
            imagemConfiguracoes.TabIndex = 111;
            imagemConfiguracoes.TabStop = false;
            // 
            // imagemRelatorio
            // 
            imagemRelatorio.BackColor = Color.Transparent;
            imagemRelatorio.Image = Properties.Resources.imagemGraficoRelatorio;
            imagemRelatorio.Location = new Point(461, 361);
            imagemRelatorio.Name = "imagemRelatorio";
            imagemRelatorio.Size = new Size(100, 50);
            imagemRelatorio.SizeMode = PictureBoxSizeMode.Zoom;
            imagemRelatorio.TabIndex = 110;
            imagemRelatorio.TabStop = false;
            // 
            // imagemReabastecimento
            // 
            imagemReabastecimento.BackColor = Color.Transparent;
            imagemReabastecimento.Image = Properties.Resources.imagemReabastecimento;
            imagemReabastecimento.Location = new Point(270, 361);
            imagemReabastecimento.Name = "imagemReabastecimento";
            imagemReabastecimento.Size = new Size(100, 50);
            imagemReabastecimento.SizeMode = PictureBoxSizeMode.Zoom;
            imagemReabastecimento.TabIndex = 109;
            imagemReabastecimento.TabStop = false;
            // 
            // imagemInventario
            // 
            imagemInventario.BackColor = Color.Transparent;
            imagemInventario.Image = Properties.Resources.imagemControleInventario;
            imagemInventario.Location = new Point(87, 361);
            imagemInventario.Name = "imagemInventario";
            imagemInventario.Size = new Size(100, 50);
            imagemInventario.SizeMode = PictureBoxSizeMode.Zoom;
            imagemInventario.TabIndex = 108;
            imagemInventario.TabStop = false;
            // 
            // EsqueceuSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.fundo_desktop_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(imagemConfiguracoes);
            Controls.Add(imagemRelatorio);
            Controls.Add(imagemReabastecimento);
            Controls.Add(imagemInventario);
            Controls.Add(checkBoxLembrarLogin);
            Controls.Add(btnEntrar);
            Controls.Add(txtCadastrar);
            Controls.Add(boxUsuario);
            Controls.Add(txtEsqueciSenha);
            Controls.Add(boxSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtUsuario);
            Name = "EsqueceuSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Redefinir senha";
            FormClosed += EsqueceuSenha_FormClosed;
            Load += EsqueceuSenha_Load;
            ((System.ComponentModel.ISupportInitialize)imagemConfiguracoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagemRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagemReabastecimento).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagemInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxLembrarLogin;
        private Button btnEntrar;
        private LinkLabel txtCadastrar;
        private TextBox boxUsuario;
        private TextBox boxSenha;
        private Label txtNovaSenha;
        private Label txtUsuario;
        private LinkLabel txtEsqueciSenha;
        private PictureBox imagemConfiguracoes;
        private PictureBox imagemRelatorio;
        private PictureBox imagemReabastecimento;
        private PictureBox imagemInventario;
    }
}