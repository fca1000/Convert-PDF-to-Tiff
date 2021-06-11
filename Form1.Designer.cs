
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
            this.lstArquivos.Location = new System.Drawing.Point(12, 185);
            this.lstArquivos.Name = "lstArquivos";
            this.lstArquivos.Size = new System.Drawing.Size(277, 364);
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
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Openned Qantity";
            // 
            // LblQuantidadeArquivo
            // 
            this.LblQuantidadeArquivo.AutoSize = true;
            this.LblQuantidadeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantidadeArquivo.Location = new System.Drawing.Point(264, 109);
            this.LblQuantidadeArquivo.Name = "LblQuantidadeArquivo";
            this.LblQuantidadeArquivo.Size = new System.Drawing.Size(24, 25);
            this.LblQuantidadeArquivo.TabIndex = 4;
            this.LblQuantidadeArquivo.Text = "0";
            // 
            // LblQtProc
            // 
            this.LblQtProc.AutoSize = true;
            this.LblQtProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtProc.Location = new System.Drawing.Point(264, 134);
            this.LblQtProc.Name = "LblQtProc";
            this.LblQtProc.Size = new System.Drawing.Size(24, 25);
            this.LblQtProc.TabIndex = 6;
            this.LblQtProc.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Processed Quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(300, 565);
            this.Controls.Add(this.LblQtProc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblQuantidadeArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOpenDir);
            this.Controls.Add(this.lstArquivos);
            this.Controls.Add(this.BtnConvert);
            this.Name = "Form1";
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
    }
}

