
namespace PdfConverter
{
    partial class Form1
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
            this.BtnConvert = new System.Windows.Forms.Button();
            this.lstArquivos = new System.Windows.Forms.CheckedListBox();
            this.BtnOpenDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblQuantidadeArquivo = new System.Windows.Forms.Label();
            this.LblQtProc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblLastP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnConvert
            // 
            this.BtnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConvert.Location = new System.Drawing.Point(13, 56);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(277, 38);
            this.BtnConvert.TabIndex = 0;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // lstArquivos
            // 
            this.lstArquivos.FormattingEnabled = true;
            this.lstArquivos.Location = new System.Drawing.Point(12, 200);
            this.lstArquivos.Name = "lstArquivos";
            this.lstArquivos.Size = new System.Drawing.Size(277, 349);
            this.lstArquivos.TabIndex = 1;
            // 
            // BtnOpenDir
            // 
            this.BtnOpenDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenDir.Location = new System.Drawing.Point(13, 12);
            this.BtnOpenDir.Name = "BtnOpenDir";
            this.BtnOpenDir.Size = new System.Drawing.Size(277, 38);
            this.BtnOpenDir.TabIndex = 2;
            this.BtnOpenDir.Text = "Open Directory";
            this.BtnOpenDir.UseVisualStyleBackColor = true;
            this.BtnOpenDir.Click += new System.EventHandler(this.BtnOpenDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Openned Qantity";
            // 
            // LblQuantidadeArquivo
            // 
            this.LblQuantidadeArquivo.AutoSize = true;
            this.LblQuantidadeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantidadeArquivo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblQuantidadeArquivo.Location = new System.Drawing.Point(264, 102);
            this.LblQuantidadeArquivo.Name = "LblQuantidadeArquivo";
            this.LblQuantidadeArquivo.Size = new System.Drawing.Size(24, 25);
            this.LblQuantidadeArquivo.TabIndex = 4;
            this.LblQuantidadeArquivo.Text = "0";
            // 
            // LblQtProc
            // 
            this.LblQtProc.AutoSize = true;
            this.LblQtProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtProc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LblQtProc.Location = new System.Drawing.Point(264, 131);
            this.LblQtProc.Name = "LblQtProc";
            this.LblQtProc.Size = new System.Drawing.Size(24, 25);
            this.LblQtProc.TabIndex = 6;
            this.LblQtProc.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Processed Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Processed";
            // 
            // LblLastP
            // 
            this.LblLastP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastP.Location = new System.Drawing.Point(210, 161);
            this.LblLastP.Name = "LblLastP";
            this.LblLastP.Size = new System.Drawing.Size(70, 26);
            this.LblLastP.TabIndex = 9;
            this.LblLastP.TextChanged += new System.EventHandler(this.LblLastP_TextChanged);
            this.LblLastP.Enter += new System.EventHandler(this.LblLastP_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(300, 565);
            this.Controls.Add(this.LblLastP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblQtProc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblQuantidadeArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOpenDir);
            this.Controls.Add(this.lstArquivos);
            this.Controls.Add(this.BtnConvert);
            this.Name = "Form1";
            this.Text = "PDF to TIFF Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.CheckedListBox lstArquivos;
        private System.Windows.Forms.Button BtnOpenDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblQuantidadeArquivo;
        private System.Windows.Forms.Label LblQtProc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LblLastP;
    }
}

