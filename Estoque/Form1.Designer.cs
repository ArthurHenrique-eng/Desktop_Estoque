namespace Estoque
{
    partial class Login
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
            imagemInventario = new PictureBox();
            imagemReabastecimento = new PictureBox();
            imagemRelatorio = new PictureBox();
            imagemConfiguracoes = new PictureBox();
            txtSenha = new Label();
            txtUsuario = new Label();
            boxSenha = new TextBox();
            txtEsqueciSenha = new LinkLabel();
            txtCadastrar = new LinkLabel();
            boxUsuario = new TextBox();
            checkBoxLembrarLogin = new CheckBox();
            btnEntrar = new Button();
            sairLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)imagemInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagemReabastecimento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagemRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagemConfiguracoes).BeginInit();
            SuspendLayout();
            // 
            // imagemInventario
            // 
            imagemInventario.BackColor = Color.Transparent;
            imagemInventario.Image = Properties.Resources.imagemControleInventario;
            imagemInventario.Location = new Point(87, 368);
            imagemInventario.Name = "imagemInventario";
            imagemInventario.Size = new Size(100, 50);
            imagemInventario.SizeMode = PictureBoxSizeMode.Zoom;
            imagemInventario.TabIndex = 7;
            imagemInventario.TabStop = false;
            // 
            // imagemReabastecimento
            // 
            imagemReabastecimento.BackColor = Color.Transparent;
            imagemReabastecimento.Image = Properties.Resources.imagemReabastecimento;
            imagemReabastecimento.Location = new Point(275, 368);
            imagemReabastecimento.Name = "imagemReabastecimento";
            imagemReabastecimento.Size = new Size(100, 50);
            imagemReabastecimento.SizeMode = PictureBoxSizeMode.Zoom;
            imagemReabastecimento.TabIndex = 8;
            imagemReabastecimento.TabStop = false;
            // 
            // imagemRelatorio
            // 
            imagemRelatorio.BackColor = Color.Transparent;
            imagemRelatorio.Image = Properties.Resources.imagemGraficoRelatorio;
            imagemRelatorio.Location = new Point(464, 368);
            imagemRelatorio.Name = "imagemRelatorio";
            imagemRelatorio.Size = new Size(100, 50);
            imagemRelatorio.SizeMode = PictureBoxSizeMode.Zoom;
            imagemRelatorio.TabIndex = 9;
            imagemRelatorio.TabStop = false;
            // 
            // imagemConfiguracoes
            // 
            imagemConfiguracoes.BackColor = Color.Transparent;
            imagemConfiguracoes.Image = Properties.Resources.imagemConfiguracoes;
            imagemConfiguracoes.Location = new Point(645, 368);
            imagemConfiguracoes.Name = "imagemConfiguracoes";
            imagemConfiguracoes.Size = new Size(100, 50);
            imagemConfiguracoes.SizeMode = PictureBoxSizeMode.Zoom;
            imagemConfiguracoes.TabIndex = 10;
            imagemConfiguracoes.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.BackColor = Color.Transparent;
            txtSenha.ForeColor = SystemColors.Control;
            txtSenha.Location = new Point(87, 237);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(39, 15);
            txtSenha.TabIndex = 98;
            txtSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.AutoSize = true;
            txtUsuario.BackColor = Color.Transparent;
            txtUsuario.ForeColor = SystemColors.Control;
            txtUsuario.Location = new Point(87, 193);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(47, 15);
            txtUsuario.TabIndex = 99;
            txtUsuario.Text = "Usuário";
            // 
            // boxSenha
            // 
            boxSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxSenha.Location = new Point(87, 255);
            boxSenha.Name = "boxSenha";
            boxSenha.PasswordChar = '*';
            boxSenha.Size = new Size(192, 23);
            boxSenha.TabIndex = 1;
            // 
            // txtEsqueciSenha
            // 
            txtEsqueciSenha.AutoSize = true;
            txtEsqueciSenha.BackColor = Color.Transparent;
            txtEsqueciSenha.Location = new Point(87, 291);
            txtEsqueciSenha.Name = "txtEsqueciSenha";
            txtEsqueciSenha.Size = new Size(118, 15);
            txtEsqueciSenha.TabIndex = 2;
            txtEsqueciSenha.TabStop = true;
            txtEsqueciSenha.Text = "Esqueci minha senha";
            txtEsqueciSenha.LinkClicked += txtEsqueciSenha_LinkClicked;
            // 
            // txtCadastrar
            // 
            txtCadastrar.AutoSize = true;
            txtCadastrar.BackColor = Color.Transparent;
            txtCadastrar.Location = new Point(222, 291);
            txtCadastrar.Name = "txtCadastrar";
            txtCadastrar.Size = new Size(57, 15);
            txtCadastrar.TabIndex = 3;
            txtCadastrar.TabStop = true;
            txtCadastrar.Text = "Cadastrar";
            txtCadastrar.LinkClicked += txtCadastrar_LinkClicked;
            // 
            // boxUsuario
            // 
            boxUsuario.Location = new Point(87, 211);
            boxUsuario.Name = "boxUsuario";
            boxUsuario.Size = new Size(192, 23);
            boxUsuario.TabIndex = 0;
            // 
            // checkBoxLembrarLogin
            // 
            checkBoxLembrarLogin.AutoSize = true;
            checkBoxLembrarLogin.BackColor = Color.Transparent;
            checkBoxLembrarLogin.ForeColor = SystemColors.Control;
            checkBoxLembrarLogin.Location = new Point(87, 320);
            checkBoxLembrarLogin.Name = "checkBoxLembrarLogin";
            checkBoxLembrarLogin.Size = new Size(127, 19);
            checkBoxLembrarLogin.TabIndex = 4;
            checkBoxLembrarLogin.Text = "Lembrar meu login";
            checkBoxLembrarLogin.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEntrar.AutoSize = true;
            btnEntrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEntrar.BackColor = Color.Blue;
            btnEntrar.ForeColor = SystemColors.Control;
            btnEntrar.Location = new Point(231, 320);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(48, 25);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // sairLogin
            // 
            sairLogin.BackColor = Color.Red;
            sairLogin.ForeColor = Color.White;
            sairLogin.Location = new Point(656, 433);
            sairLogin.Name = "sairLogin";
            sairLogin.Size = new Size(75, 23);
            sairLogin.TabIndex = 100;
            sairLogin.Text = "Sair";
            sairLogin.UseVisualStyleBackColor = false;
            sairLogin.Click += sairLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.fundo_desktop_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 459);
            Controls.Add(sairLogin);
            Controls.Add(checkBoxLembrarLogin);
            Controls.Add(btnEntrar);
            Controls.Add(txtCadastrar);
            Controls.Add(boxUsuario);
            Controls.Add(txtEsqueciSenha);
            Controls.Add(boxSenha);
            Controls.Add(imagemConfiguracoes);
            Controls.Add(txtSenha);
            Controls.Add(imagemRelatorio);
            Controls.Add(imagemReabastecimento);
            Controls.Add(txtUsuario);
            Controls.Add(imagemInventario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)imagemInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagemReabastecimento).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagemRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagemConfiguracoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox imagemInventario;
        private PictureBox imagemReabastecimento;
        private PictureBox imagemRelatorio;
        private PictureBox imagemConfiguracoes;
        private Label txtSenha;
        private Label txtUsuario;
        private TextBox boxSenha;
        private LinkLabel txtEsqueciSenha;
        private LinkLabel txtCadastrar;
        private TextBox boxUsuario;
        private CheckBox checkBoxLembrarLogin;
        private Button btnEntrar;
        private Button sairLogin;
    }
}
