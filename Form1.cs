using System.Drawing.Text;
using System.IO;


namespace EditorTexto

{
    public partial class EditorText : Form
    {
        StreamReader leitura = null;
        public EditorText()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Fun��es para os bot�es

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
                     * FileMode = Verificar se existe ou n�o o arquivo
                     * FilAccess = Acesso para salvar o conte�do escrito
                    */

                    StreamWriter escrever_stream = new StreamWriter(arquivo);
                    escrever_stream.Flush(); //Faz os dados em buffers serem armazenados
                    escrever_stream.BaseStream.Seek(0, SeekOrigin.Begin); // Linha inicial e posi��o inicial
                    escrever_stream.Write(this.richTextBox1.Text);
                    escrever_stream.Flush(); //Atualizar buffer
                    escrever_stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na cria��o do arquivo: " + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                
                ler_stream.Close() ;    
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de leitura no arquivo: " + e.Message, "Erro ao abrir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //M�todos dos bot�es

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
    }
}
