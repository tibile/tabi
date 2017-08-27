namespace SelectFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_filter = new System.Windows.Forms.Button();
            this.txt_jpeg = new System.Windows.Forms.TextBox();
            this.txt_raw = new System.Windows.Forms.TextBox();
            this.txt_saveto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_folderPathJpeg = new System.Windows.Forms.Button();
            this.btn_folderPathRaw = new System.Windows.Forms.Button();
            this.btn_folderPathSaveTo = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(102, 173);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(60, 31);
            this.btn_filter.TabIndex = 0;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // txt_jpeg
            // 
            this.txt_jpeg.Location = new System.Drawing.Point(102, 44);
            this.txt_jpeg.Name = "txt_jpeg";
            this.txt_jpeg.Size = new System.Drawing.Size(252, 20);
            this.txt_jpeg.TabIndex = 1;
            // 
            // txt_raw
            // 
            this.txt_raw.Location = new System.Drawing.Point(102, 83);
            this.txt_raw.Name = "txt_raw";
            this.txt_raw.Size = new System.Drawing.Size(252, 20);
            this.txt_raw.TabIndex = 2;
            // 
            // txt_saveto
            // 
            this.txt_saveto.Location = new System.Drawing.Point(102, 134);
            this.txt_saveto.Name = "txt_saveto";
            this.txt_saveto.Size = new System.Drawing.Size(252, 20);
            this.txt_saveto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jpeg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "RAW:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Save to:";
            // 
            // btn_folderPathJpeg
            // 
            this.btn_folderPathJpeg.Location = new System.Drawing.Point(358, 44);
            this.btn_folderPathJpeg.Name = "btn_folderPathJpeg";
            this.btn_folderPathJpeg.Size = new System.Drawing.Size(25, 19);
            this.btn_folderPathJpeg.TabIndex = 7;
            this.btn_folderPathJpeg.Text = "...";
            this.btn_folderPathJpeg.UseVisualStyleBackColor = true;
            this.btn_folderPathJpeg.Click += new System.EventHandler(this.btn_folderPathJpeg_Click);
            // 
            // btn_folderPathRaw
            // 
            this.btn_folderPathRaw.Location = new System.Drawing.Point(358, 83);
            this.btn_folderPathRaw.Name = "btn_folderPathRaw";
            this.btn_folderPathRaw.Size = new System.Drawing.Size(25, 19);
            this.btn_folderPathRaw.TabIndex = 8;
            this.btn_folderPathRaw.Text = "...";
            this.btn_folderPathRaw.UseVisualStyleBackColor = true;
            this.btn_folderPathRaw.Click += new System.EventHandler(this.btn_folderPathRaw_Click);
            // 
            // btn_folderPathSaveTo
            // 
            this.btn_folderPathSaveTo.Location = new System.Drawing.Point(358, 134);
            this.btn_folderPathSaveTo.Name = "btn_folderPathSaveTo";
            this.btn_folderPathSaveTo.Size = new System.Drawing.Size(25, 19);
            this.btn_folderPathSaveTo.TabIndex = 9;
            this.btn_folderPathSaveTo.Text = "...";
            this.btn_folderPathSaveTo.UseVisualStyleBackColor = true;
            this.btn_folderPathSaveTo.Click += new System.EventHandler(this.btn_folderPathSaveTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 265);
            this.Controls.Add(this.btn_folderPathSaveTo);
            this.Controls.Add(this.btn_folderPathRaw);
            this.Controls.Add(this.btn_folderPathJpeg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_saveto);
            this.Controls.Add(this.txt_raw);
            this.Controls.Add(this.txt_jpeg);
            this.Controls.Add(this.btn_filter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.TextBox txt_jpeg;
        private System.Windows.Forms.TextBox txt_raw;
        private System.Windows.Forms.TextBox txt_saveto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_folderPathJpeg;
        private System.Windows.Forms.Button btn_folderPathRaw;
        private System.Windows.Forms.Button btn_folderPathSaveTo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
    }
}

