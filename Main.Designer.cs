
namespace PdfConverter
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lstArquivos = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Openned = new System.Windows.Forms.Label();
            this.Lbl_Processed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Menu_Bar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Txt_Counter = new System.Windows.Forms.TextBox();
            this.Line_Password = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Btn_Close = new FontAwesome.Sharp.IconButton();
            this.Menu_Bar.SuspendLayout();
            this.Line_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lstArquivos
            // 
            this.lstArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.lstArquivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstArquivos.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lstArquivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.lstArquivos.FormattingEnabled = true;
            this.lstArquivos.Location = new System.Drawing.Point(10, 114);
            this.lstArquivos.Name = "lstArquivos";
            this.lstArquivos.Size = new System.Drawing.Size(282, 478);
            this.lstArquivos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Files";
            // 
            // Lbl_Openned
            // 
            this.Lbl_Openned.AutoSize = true;
            this.Lbl_Openned.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Openned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.Lbl_Openned.Location = new System.Drawing.Point(268, 28);
            this.Lbl_Openned.Name = "Lbl_Openned";
            this.Lbl_Openned.Size = new System.Drawing.Size(24, 25);
            this.Lbl_Openned.TabIndex = 4;
            this.Lbl_Openned.Text = "0";
            this.Lbl_Openned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Processed
            // 
            this.Lbl_Processed.AutoSize = true;
            this.Lbl_Processed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Processed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.Lbl_Processed.Location = new System.Drawing.Point(267, 57);
            this.Lbl_Processed.Name = "Lbl_Processed";
            this.Lbl_Processed.Size = new System.Drawing.Size(24, 25);
            this.Lbl_Processed.TabIndex = 6;
            this.Lbl_Processed.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Processed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Batchtrack";
            // 
            // Menu_Bar
            // 
            this.Menu_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Menu_Bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.Menu_Bar.Location = new System.Drawing.Point(0, 0);
            this.Menu_Bar.Name = "Menu_Bar";
            this.Menu_Bar.Size = new System.Drawing.Size(300, 24);
            this.Menu_Bar.TabIndex = 10;
            this.Menu_Bar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.newToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.openToolStripMenuItem.Text = "&Open Folder";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.newToolStripMenuItem.Text = "Convert &All";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Txt_Counter
            // 
            this.Txt_Counter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.Txt_Counter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Counter.Enabled = false;
            this.Txt_Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Counter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.Txt_Counter.Location = new System.Drawing.Point(219, 92);
            this.Txt_Counter.MaxLength = 8;
            this.Txt_Counter.Multiline = true;
            this.Txt_Counter.Name = "Txt_Counter";
            this.Txt_Counter.Size = new System.Drawing.Size(72, 18);
            this.Txt_Counter.TabIndex = 22;
            this.Txt_Counter.Text = "00000000";
            this.Txt_Counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Line_Password
            // 
            this.Line_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.Line_Password.Controls.Add(this.flowLayoutPanel6);
            this.Line_Password.Controls.Add(this.pictureBox4);
            this.Line_Password.Controls.Add(this.flowLayoutPanel7);
            this.Line_Password.Controls.Add(this.pictureBox6);
            this.Line_Password.Location = new System.Drawing.Point(228, 109);
            this.Line_Password.Name = "Line_Password";
            this.Line_Password.Size = new System.Drawing.Size(64, 1);
            this.Line_Password.TabIndex = 21;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(230, 1);
            this.flowLayoutPanel6.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(3, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel7.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 41);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(230, 1);
            this.flowLayoutPanel7.TabIndex = 6;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(230, 1);
            this.flowLayoutPanel8.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(3, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(3, 48);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Menu_Bar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(31)))));
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.Btn_Close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.Btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Close.IconSize = 15;
            this.Btn_Close.Location = new System.Drawing.Point(260, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(40, 24);
            this.Btn_Close.TabIndex = 23;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(300, 600);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Line_Password);
            this.Controls.Add(this.Txt_Counter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Processed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_Openned);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstArquivos);
            this.Controls.Add(this.Menu_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.Menu_Bar;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Converter";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Menu_Bar.ResumeLayout(false);
            this.Menu_Bar.PerformLayout();
            this.Line_Password.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox lstArquivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Openned;
        private System.Windows.Forms.Label Lbl_Processed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip Menu_Bar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox Txt_Counter;
        private System.Windows.Forms.FlowLayoutPanel Line_Password;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private FontAwesome.Sharp.IconButton Btn_Close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

