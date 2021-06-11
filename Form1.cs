using System;
using System.Windows.Forms;
using System.Configuration;
using ImageMagick;
using System.IO;
using PdfConverter.Properties;

namespace PdfConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CriarPasta(string outdir)
        {
            if (!Directory.Exists(outdir))
            {
                Directory.CreateDirectory(outdir);
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= (lstArquivos.Items.Count - 1); i++)
                {
                    string infile = lstArquivos.Items[i].ToString();
                    FileInfo fileInfo = new FileInfo(infile);

                    string outdir = fileInfo.DirectoryName + @"\output";
                    string structured_outdir = outdir + @"\" + "A_" + Settings.Default.NumLote.ToString().PadLeft(8, '0');
                    string structured_outfile = structured_outdir + @"\" + fileInfo.Name.ToString().Replace(".pdf", ".tif").Replace(".jpg",".tif").Replace(".png", ".tif");

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

                    LblQtProc.Text = Convert.ToString(i + 1);
                    LblQtProc.Update();
                    Application.DoEvents();
                    Settings.Default.NumLote += 1;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Deu ruim: {0}", er.Message.ToString());
            }
            finally
            {
                Settings.Default.Save();
                MessageBox.Show("Fim");
            }
        }

        private void BtnOpenDir_Click(object sender, EventArgs e)
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
                LblQuantidadeArquivo.Text = lstArquivos.Items.Count.ToString();
                LblQuantidadeArquivo.Update();
                Application.DoEvents();
            }
        }
    }
}
