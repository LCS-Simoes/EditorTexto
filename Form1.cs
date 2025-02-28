using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Text;
using System.IO;


namespace EditorTexto

{
    public partial class EditorText : Form
    {
        StringReader leitura = null;
        public EditorText()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Métodos para os botões

        private void NewArquivo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void Save()
        {
            try
            {
                //Se o retorno da janela de salver for verdadeiro = quero salvar arquivo
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Criando um arquivo
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    /*
                     * SaveDialog = Tela de save pra passar o nome
                     * FileMode = Verificar se existe ou não o arquivo
                     * FilAccess = Acesso para salvar o conteúdo escrito
                    */

                    StreamWriter escrever_stream = new StreamWriter(arquivo);
                    escrever_stream.Flush(); //Faz os dados em buffers serem armazenados
                    escrever_stream.BaseStream.Seek(0, SeekOrigin.Begin); // Linha inicial e posição inicial
                    escrever_stream.Write(this.richTextBox1.Text);
                    escrever_stream.Flush(); //Atualizar buffer
                    escrever_stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na criação do arquivo: " + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Open()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "(*.txt)| *.TXT";

            DialogResult result = openFileDialog1.ShowDialog();
            try
            {
                FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader ler_stream = new StreamReader(arquivo);
                ler_stream.BaseStream.Seek(0, SeekOrigin.Begin);
                this.richTextBox1.Text = "";
                string line = ler_stream.ReadLine();

                while (line != null)
                {
                    this.richTextBox1.Text += line + "\n";
                    line = ler_stream.ReadLine();
                }

                ler_stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de leitura no arquivo: " + e.Message, "Erro ao abrir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Copy()
        {
            //Se no richtextbox tiver +1 caracter, copiar.
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void Paste()
        {
            richTextBox1.Paste();
        }

        private void unificacaoFontes(FontStyle style)
        {
            if (richTextBox1.SelectionFont == null) return;

            string fontName = richTextBox1.SelectionFont.Name;
            float fontSize = richTextBox1.SelectionFont.Size;
            FontStyle newStyle = richTextBox1.SelectionFont.Style;

            // Alterna o estilo específico
            newStyle ^= style;

            richTextBox1.SelectionFont = new Font(fontName, fontSize, newStyle);
        }

        private void AlinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void AlinharCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string text = this.richTextBox1.Text;
            leitura = new StringReader(text);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }


        /*
        private void Justificar()
        {
            richTextBox1.SelectionAlignment = 
        }

        */




        //Funções dos botões

        private void btn_novo_Click(object sender, EventArgs e)
        {
            NewArquivo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewArquivo();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unificacaoFontes(FontStyle.Bold);
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            unificacaoFontes(FontStyle.Bold);
        }

        private void italicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unificacaoFontes(FontStyle.Italic);
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            unificacaoFontes(FontStyle.Italic);
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unificacaoFontes(FontStyle.Underline);
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            unificacaoFontes(FontStyle.Underline);
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void btn_centro_Click(object sender, EventArgs e)
        {
            AlinharCentro();
        }

        private void btn_justificado_Click(object sender, EventArgs e)
        {
            //Preencher em breve
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharCentro();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void alinharADireitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void justificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Preencher em breve
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linesPage = 0;
            float PosY = 0;
            int count = 0;
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;

            if(margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }

            if(margemSuperior < 5)
            {
                margemSuperior = 20;
            }

            string line = null;
            Font font = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linesPage = e.MarginBounds.Height / font.GetHeight(e.Graphics); //Calcular o número de linhas por paginas
            line = leitura.ReadLine();

            while (count < linesPage)
            {
                if(line == null)
                {
                    MessageBox.Show("Não há nada a ser imprimido");
                    break;
                }else
                {
                    PosY = (margemSuperior + (count * font.GetHeight(e.Graphics)));
                    e.Graphics.DrawString(line, font, pincel, margemEsquerda, PosY, new StringFormat());
                    count++;
                    line = leitura.ReadLine();
                }

                if(line != null)
                {
                    e.HasMorePages = true;
                }else
                {
                    e.HasMorePages = false;
                }
                pincel.Dispose();
            }
        }
    }
}
