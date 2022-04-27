using System;
using System.Windows.Forms;
using System.Configuration;
using ImageMagick;
using System.IO;
using PdfConverter.Properties;

namespace PdfConverter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            int lastID = Database.LastID() + 1;
            Settings.Default.NumLote = lastID;
            Settings.Default.Save();

            ChangeIdValue(lastID);
        }

        public void CriarPasta(string outdir)
        {
            if (!Directory.Exists(outdir))
            {
                Directory.CreateDirectory(outdir);
            }
        }

        public void ChangeIdValue(int id)
        {
            Txt_Counter.Text = $"E{id.ToString().PadLeft(7, '0')}";
            Txt_Counter.Update();
            Application.DoEvents();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                lstArquivos.Items.Clear();
                openFileDialog.InitialDirectory = ConfigurationManager.AppSettings["DiretorioInicial"];
                openFileDialog.Filter = ConfigurationManager.AppSettings["formatoImagem"];
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;
                var intCount = 0;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item in openFileDialog.FileNames)
                    {
                        lstArquivos.Items.Add(item, CheckState.Checked);
                        intCount += 1;
                    }
                }
                Lbl_Openned.Text = lstArquivos.Items.Count.ToString();
                Lbl_Openned.Update();
                Application.DoEvents();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= (lstArquivos.Items.Count - 1); i++)
                {
                    string infile = lstArquivos.Items[i].ToString();
                    FileInfo fileInfo = new FileInfo(infile);

                    string outdir = Path.Combine(fileInfo.DirectoryName, "output");
                    string batchtrack = "E" + Settings.Default.NumLote.ToString().PadLeft(7, '0');
                    string structured_outdir = Path.Combine(outdir, batchtrack);
                    string structured_outfile = Path.Combine(structured_outdir, "00000001.tif");

                    CriarPasta(outdir);
                    CriarPasta(structured_outdir);

                    MagickReadSettings settings = new MagickReadSettings();
                    settings.Density = new Density(300, 300);
                    settings.ColorType = ColorType.Bilevel;
                    settings.Compression = CompressionMethod.Group4;
                    settings.ColorSpace = ColorSpace.Gray;

                    using (MagickImage magickimage = new MagickImage(infile, settings))
                    {
                        magickimage.Format = MagickFormat.Tif;
                        magickimage.Write(structured_outfile);
                    }

                    Lbl_Processed.Text = Convert.ToString(i + 1);

                    ChangeIdValue(Settings.Default.NumLote);

                    Database.CreateFlowItem(DateTime.Now, fileInfo.Name, batchtrack);

                    Settings.Default.NumLote += 1;
                    Application.DoEvents();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Erro: {0}", er.Message.ToString()));
            }
            finally
            {
                Settings.Default.Save();
                MessageBox.Show("Fim");
            }
        }

    }
}
