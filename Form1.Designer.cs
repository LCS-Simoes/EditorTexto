namespace EditorTexto
{
    partial class EditorText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorText));
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            desfazerToolStripMenuItem = new ToolStripMenuItem();
            refazerToolStripMenuItem = new ToolStripMenuItem();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            negritoToolStripMenuItem = new ToolStripMenuItem();
            italicoToolStripMenuItem = new ToolStripMenuItem();
            sublinhadoToolStripMenuItem = new ToolStripMenuItem();
            alinhamentoToolStripMenuItem = new ToolStripMenuItem();
            centralizarToolStripMenuItem = new ToolStripMenuItem();
            esquerdaToolStripMenuItem = new ToolStripMenuItem();
            alinharADireitaToolStripMenuItem = new ToolStripMenuItem();
            justificarToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btn_novo = new ToolStripButton();
            btn_abrir = new ToolStripButton();
            btn_salvar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_copiar = new ToolStripButton();
            btn_colar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_negrito = new ToolStripButton();
            btn_italico = new ToolStripButton();
            btn_sublinhado = new ToolStripButton();
            btn_fonte = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_esquerda = new ToolStripButton();
            btn_direita = new ToolStripButton();
            btn_centro = new ToolStripButton();
            btn_justificado = new ToolStripButton();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(654, 476);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, formatarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(654, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, imprimirToolStripMenuItem, salvarToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(180, 22);
            imprimirToolStripMenuItem.Text = "Imprimir";
            imprimirToolStripMenuItem.Click += imprimirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(180, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem, desfazerToolStripMenuItem, refazerToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(118, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.Size = new Size(118, 22);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += colarToolStripMenuItem_Click;
            // 
            // desfazerToolStripMenuItem
            // 
            desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            desfazerToolStripMenuItem.Size = new Size(118, 22);
            desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            refazerToolStripMenuItem.Size = new Size(118, 22);
            refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { negritoToolStripMenuItem, italicoToolStripMenuItem, sublinhadoToolStripMenuItem, alinhamentoToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(67, 20);
            formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            negritoToolStripMenuItem.Size = new Size(143, 22);
            negritoToolStripMenuItem.Text = "Negrito";
            negritoToolStripMenuItem.Click += negritoToolStripMenuItem_Click;
            // 
            // italicoToolStripMenuItem
            // 
            italicoToolStripMenuItem.Name = "italicoToolStripMenuItem";
            italicoToolStripMenuItem.Size = new Size(143, 22);
            italicoToolStripMenuItem.Text = "Italico";
            italicoToolStripMenuItem.Click += italicoToolStripMenuItem_Click;
            // 
            // sublinhadoToolStripMenuItem
            // 
            sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            sublinhadoToolStripMenuItem.Size = new Size(143, 22);
            sublinhadoToolStripMenuItem.Text = "Sublinhado";
            sublinhadoToolStripMenuItem.Click += sublinhadoToolStripMenuItem_Click;
            // 
            // alinhamentoToolStripMenuItem
            // 
            alinhamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { centralizarToolStripMenuItem, esquerdaToolStripMenuItem, alinharADireitaToolStripMenuItem, justificarToolStripMenuItem });
            alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            alinhamentoToolStripMenuItem.Size = new Size(143, 22);
            alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            centralizarToolStripMenuItem.Size = new Size(172, 22);
            centralizarToolStripMenuItem.Text = "Alinhar ao Centro";
            centralizarToolStripMenuItem.Click += centralizarToolStripMenuItem_Click;
            // 
            // esquerdaToolStripMenuItem
            // 
            esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            esquerdaToolStripMenuItem.Size = new Size(172, 22);
            esquerdaToolStripMenuItem.Text = "Alinhar a Esquerda";
            esquerdaToolStripMenuItem.Click += esquerdaToolStripMenuItem_Click;
            // 
            // alinharADireitaToolStripMenuItem
            // 
            alinharADireitaToolStripMenuItem.Name = "alinharADireitaToolStripMenuItem";
            alinharADireitaToolStripMenuItem.Size = new Size(172, 22);
            alinharADireitaToolStripMenuItem.Text = "Alinhar a Direita";
            alinharADireitaToolStripMenuItem.Click += alinharADireitaToolStripMenuItem_Click;
            // 
            // justificarToolStripMenuItem
            // 
            justificarToolStripMenuItem.Name = "justificarToolStripMenuItem";
            justificarToolStripMenuItem.Size = new Size(172, 22);
            justificarToolStripMenuItem.Text = "Justificar";
            justificarToolStripMenuItem.Click += justificarToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_novo, btn_abrir, btn_salvar, toolStripSeparator1, btn_copiar, btn_colar, toolStripSeparator2, btn_negrito, btn_italico, btn_sublinhado, btn_fonte, toolStripSeparator3, btn_esquerda, btn_direita, btn_centro, btn_justificado });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(654, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_novo
            // 
            btn_novo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_novo.Image = Properties.Resources.novo_arquivo;
            btn_novo.ImageTransparentColor = Color.Magenta;
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(23, 22);
            btn_novo.Text = "Novo";
            btn_novo.ToolTipText = "btn_novo";
            btn_novo.Click += btn_novo_Click;
            // 
            // btn_abrir
            // 
            btn_abrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_abrir.Image = Properties.Resources.aberto;
            btn_abrir.ImageTransparentColor = Color.Magenta;
            btn_abrir.Name = "btn_abrir";
            btn_abrir.Size = new Size(23, 22);
            btn_abrir.Text = "Abrir";
            btn_abrir.Click += btn_abrir_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_salvar.Image = Properties.Resources.marca;
            btn_salvar.ImageTransparentColor = Color.Magenta;
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(23, 22);
            btn_salvar.Text = "Salvar";
            btn_salvar.Click += btn_salvar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btn_copiar
            // 
            btn_copiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_copiar.Image = Properties.Resources.cola;
            btn_copiar.ImageTransparentColor = Color.Magenta;
            btn_copiar.Name = "btn_copiar";
            btn_copiar.Size = new Size(23, 22);
            btn_copiar.Text = "Copiar";
            btn_copiar.Click += btn_copiar_Click;
            // 
            // btn_colar
            // 
            btn_colar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_colar.Image = Properties.Resources.copia_de;
            btn_colar.ImageTransparentColor = Color.Magenta;
            btn_colar.Name = "btn_colar";
            btn_colar.Size = new Size(23, 22);
            btn_colar.Text = "Colar";
            btn_colar.Click += btn_colar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btn_negrito
            // 
            btn_negrito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_negrito.Image = Properties.Resources.negrito;
            btn_negrito.ImageTransparentColor = Color.Magenta;
            btn_negrito.Name = "btn_negrito";
            btn_negrito.Size = new Size(23, 22);
            btn_negrito.Text = "Negrito";
            btn_negrito.Click += btn_negrito_Click;
            // 
            // btn_italico
            // 
            btn_italico.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_italico.Image = Properties.Resources.italico;
            btn_italico.ImageTransparentColor = Color.Magenta;
            btn_italico.Name = "btn_italico";
            btn_italico.Size = new Size(23, 22);
            btn_italico.Text = "Italico";
            btn_italico.Click += btn_italico_Click;
            // 
            // btn_sublinhado
            // 
            btn_sublinhado.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_sublinhado.Image = Properties.Resources.sublinhado;
            btn_sublinhado.ImageTransparentColor = Color.Magenta;
            btn_sublinhado.Name = "btn_sublinhado";
            btn_sublinhado.Size = new Size(23, 22);
            btn_sublinhado.Text = "Sublinhar";
            btn_sublinhado.Click += btn_sublinhado_Click;
            // 
            // btn_fonte
            // 
            btn_fonte.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_fonte.Image = Properties.Resources.fonte;
            btn_fonte.ImageTransparentColor = Color.Magenta;
            btn_fonte.Name = "btn_fonte";
            btn_fonte.Size = new Size(23, 22);
            btn_fonte.Text = "Fonte";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btn_esquerda
            // 
            btn_esquerda.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_esquerda.Image = Properties.Resources.alinhar_a_esquerda;
            btn_esquerda.ImageTransparentColor = Color.Magenta;
            btn_esquerda.Name = "btn_esquerda";
            btn_esquerda.Size = new Size(23, 22);
            btn_esquerda.Text = "Alinhar a Esquerda";
            btn_esquerda.Click += btn_esquerda_Click;
            // 
            // btn_direita
            // 
            btn_direita.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_direita.Image = Properties.Resources.alinhar_a_direita;
            btn_direita.ImageTransparentColor = Color.Magenta;
            btn_direita.Name = "btn_direita";
            btn_direita.Size = new Size(23, 22);
            btn_direita.Text = "Alinhar a Direita";
            btn_direita.Click += btn_direita_Click;
            // 
            // btn_centro
            // 
            btn_centro.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_centro.Image = Properties.Resources.texto;
            btn_centro.ImageTransparentColor = Color.Magenta;
            btn_centro.Name = "btn_centro";
            btn_centro.Size = new Size(23, 22);
            btn_centro.Text = "Alinhar ao Centro";
            btn_centro.Click += btn_centro_Click;
            // 
            // btn_justificado
            // 
            btn_justificado.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_justificado.Image = Properties.Resources.alinhamento_de_texto;
            btn_justificado.ImageTransparentColor = Color.Magenta;
            btn_justificado.Name = "btn_justificado";
            btn_justificado.Size = new Size(23, 22);
            btn_justificado.Text = "Justificado";
            btn_justificado.Click += btn_justificado_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "(*.txt)| *.TXT";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // EditorText
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 528);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "EditorText";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor de Texto ";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem italicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem centralizarToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem alinharADireitaToolStripMenuItem;
        private ToolStripMenuItem justificarToolStripMenuItem;
        private ToolStripButton btn_novo;
        private ToolStripButton btn_abrir;
        private ToolStripButton btn_salvar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_copiar;
        private ToolStripButton btn_colar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_negrito;
        private ToolStripButton btn_italico;
        private ToolStripButton btn_sublinhado;
        private ToolStripButton btn_fonte;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btn_esquerda;
        private ToolStripButton btn_direita;
        private ToolStripButton btn_centro;
        private ToolStripButton btn_justificado;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
