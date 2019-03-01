namespace ExercicioEvenJunior
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto1 = new System.Windows.Forms.Label();
            this.btn_imagem_fundo = new System.Windows.Forms.Button();
            this.link_dica_template = new System.Windows.Forms.LinkLabel();
            this.ofd_busca_cracha = new System.Windows.Forms.OpenFileDialog();
            this.texto2 = new System.Windows.Forms.Label();
            this.texto3_explicando_colagem = new System.Windows.Forms.Label();
            this.area_tabela = new System.Windows.Forms.TextBox();
            this.texto3 = new System.Windows.Forms.Label();
            this.btn_baixar_crachas = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pic_imagem_cracha = new System.Windows.Forms.PictureBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btn_edita_texto = new System.Windows.Forms.Button();
            this.area_tags = new System.Windows.Forms.RichTextBox();
            this.pic_preview = new System.Windows.Forms.PictureBox();
            this.btn_preview = new System.Windows.Forms.Button();
            this.txt_preview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagem_cracha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto1.Location = new System.Drawing.Point(13, 13);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(161, 26);
            this.texto1.TabIndex = 0;
            this.texto1.Text = "1- Criar Modelo";
            this.texto1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_imagem_fundo
            // 
            this.btn_imagem_fundo.Location = new System.Drawing.Point(18, 57);
            this.btn_imagem_fundo.Name = "btn_imagem_fundo";
            this.btn_imagem_fundo.Size = new System.Drawing.Size(156, 23);
            this.btn_imagem_fundo.TabIndex = 1;
            this.btn_imagem_fundo.Text = "Anexar  Imagem de Fundo";
            this.btn_imagem_fundo.UseVisualStyleBackColor = true;
            this.btn_imagem_fundo.Click += new System.EventHandler(this.btn_imagem_fundo_Click);
            // 
            // link_dica_template
            // 
            this.link_dica_template.AutoSize = true;
            this.link_dica_template.Location = new System.Drawing.Point(180, 62);
            this.link_dica_template.Name = "link_dica_template";
            this.link_dica_template.Size = new System.Drawing.Size(93, 13);
            this.link_dica_template.TabIndex = 3;
            this.link_dica_template.TabStop = true;
            this.link_dica_template.Text = "Dica: Templates...";
            this.link_dica_template.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ofd_busca_cracha
            // 
            this.ofd_busca_cracha.FileName = "ofd";
            this.ofd_busca_cracha.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_busca_cracha_FileOk);
            // 
            // texto2
            // 
            this.texto2.AutoSize = true;
            this.texto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto2.Location = new System.Drawing.Point(13, 502);
            this.texto2.Name = "texto2";
            this.texto2.Size = new System.Drawing.Size(250, 26);
            this.texto2.TabIndex = 4;
            this.texto2.Text = "2- Importar Participantes";
            this.texto2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // texto3_explicando_colagem
            // 
            this.texto3_explicando_colagem.AutoSize = true;
            this.texto3_explicando_colagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto3_explicando_colagem.Location = new System.Drawing.Point(15, 542);
            this.texto3_explicando_colagem.Name = "texto3_explicando_colagem";
            this.texto3_explicando_colagem.Size = new System.Drawing.Size(460, 17);
            this.texto3_explicando_colagem.TabIndex = 6;
            this.texto3_explicando_colagem.Text = "Copie o conteúdo da planilha excel, incluindo os cabeçalhos e cole aqui";
            // 
            // area_tabela
            // 
            this.area_tabela.Location = new System.Drawing.Point(18, 573);
            this.area_tabela.Multiline = true;
            this.area_tabela.Name = "area_tabela";
            this.area_tabela.Size = new System.Drawing.Size(743, 119);
            this.area_tabela.TabIndex = 7;
            // 
            // texto3
            // 
            this.texto3.AutoSize = true;
            this.texto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto3.Location = new System.Drawing.Point(14, 708);
            this.texto3.Name = "texto3";
            this.texto3.Size = new System.Drawing.Size(99, 26);
            this.texto3.TabIndex = 8;
            this.texto3.Text = "3- Baixar";
            this.texto3.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_baixar_crachas
            // 
            this.btn_baixar_crachas.Location = new System.Drawing.Point(19, 751);
            this.btn_baixar_crachas.Name = "btn_baixar_crachas";
            this.btn_baixar_crachas.Size = new System.Drawing.Size(110, 23);
            this.btn_baixar_crachas.TabIndex = 9;
            this.btn_baixar_crachas.Text = "Baixar Crachás";
            this.btn_baixar_crachas.UseVisualStyleBackColor = true;
            this.btn_baixar_crachas.Click += new System.EventHandler(this.btn_baixar_crachas_Click);
            // 
            // pic_imagem_cracha
            // 
            this.pic_imagem_cracha.Location = new System.Drawing.Point(18, 97);
            this.pic_imagem_cracha.Name = "pic_imagem_cracha";
            this.pic_imagem_cracha.Size = new System.Drawing.Size(290, 386);
            this.pic_imagem_cracha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_imagem_cracha.TabIndex = 2;
            this.pic_imagem_cracha.TabStop = false;
            this.pic_imagem_cracha.Click += new System.EventHandler(this.pic_imagem_cracha_Click);
            // 
            // btn_edita_texto
            // 
            this.btn_edita_texto.Location = new System.Drawing.Point(325, 333);
            this.btn_edita_texto.Name = "btn_edita_texto";
            this.btn_edita_texto.Size = new System.Drawing.Size(117, 23);
            this.btn_edita_texto.TabIndex = 17;
            this.btn_edita_texto.Text = "Fonte e Estilos";
            this.btn_edita_texto.UseVisualStyleBackColor = true;
            this.btn_edita_texto.Click += new System.EventHandler(this.button1_Click);
            // 
            // area_tags
            // 
            this.area_tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area_tags.Location = new System.Drawing.Point(33, 304);
            this.area_tags.Name = "area_tags";
            this.area_tags.Size = new System.Drawing.Size(240, 96);
            this.area_tags.TabIndex = 18;
            this.area_tags.Text = "";
            this.area_tags.TextChanged += new System.EventHandler(this.area_tags_TextChanged_2);
            // 
            // pic_preview
            // 
            this.pic_preview.Location = new System.Drawing.Point(459, 97);
            this.pic_preview.Name = "pic_preview";
            this.pic_preview.Size = new System.Drawing.Size(290, 386);
            this.pic_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_preview.TabIndex = 19;
            this.pic_preview.TabStop = false;
            this.pic_preview.Click += new System.EventHandler(this.pic_preview_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(325, 377);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(117, 23);
            this.btn_preview.TabIndex = 20;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // txt_preview
            // 
            this.txt_preview.AutoSize = true;
            this.txt_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preview.Location = new System.Drawing.Point(516, 57);
            this.txt_preview.Name = "txt_preview";
            this.txt_preview.Size = new System.Drawing.Size(196, 26);
            this.txt_preview.TabIndex = 21;
            this.txt_preview.Text = "Preview do Crachá";
            this.txt_preview.Visible = false;
            this.txt_preview.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 882);
            this.Controls.Add(this.txt_preview);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.pic_preview);
            this.Controls.Add(this.area_tags);
            this.Controls.Add(this.btn_edita_texto);
            this.Controls.Add(this.btn_baixar_crachas);
            this.Controls.Add(this.texto3);
            this.Controls.Add(this.area_tabela);
            this.Controls.Add(this.texto3_explicando_colagem);
            this.Controls.Add(this.texto2);
            this.Controls.Add(this.link_dica_template);
            this.Controls.Add(this.pic_imagem_cracha);
            this.Controls.Add(this.btn_imagem_fundo);
            this.Controls.Add(this.texto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagem_cracha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.Button btn_imagem_fundo;
        private System.Windows.Forms.PictureBox pic_imagem_cracha;
        private System.Windows.Forms.LinkLabel link_dica_template;
        private System.Windows.Forms.OpenFileDialog ofd_busca_cracha;
        private System.Windows.Forms.Label texto2;
        private System.Windows.Forms.Label texto3_explicando_colagem;
        private System.Windows.Forms.TextBox area_tabela;
        private System.Windows.Forms.Label texto3;
        private System.Windows.Forms.Button btn_baixar_crachas;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btn_edita_texto;
        private System.Windows.Forms.RichTextBox area_tags;
        private System.Windows.Forms.PictureBox pic_preview;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Label txt_preview;
    }
}

