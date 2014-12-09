namespace SubAlign
{
    partial class frmSubAlign
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
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.txtMovieFiles = new System.Windows.Forms.TextBox();
            this.txtSubsFile = new System.Windows.Forms.TextBox();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.dgvSubs = new System.Windows.Forms.DataGridView();
            this.btnProcessSub = new System.Windows.Forms.Button();
            this.fldDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.clmMovies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFiles.Location = new System.Drawing.Point(932, 12);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(176, 38);
            this.btnLoadFiles.TabIndex = 0;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // txtMovieFiles
            // 
            this.txtMovieFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMovieFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieFiles.Location = new System.Drawing.Point(12, 12);
            this.txtMovieFiles.Name = "txtMovieFiles";
            this.txtMovieFiles.Size = new System.Drawing.Size(537, 38);
            this.txtMovieFiles.TabIndex = 1;
            this.txtMovieFiles.Text = "mkv";
            // 
            // txtSubsFile
            // 
            this.txtSubsFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubsFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubsFile.Location = new System.Drawing.Point(555, 12);
            this.txtSubsFile.Name = "txtSubsFile";
            this.txtSubsFile.Size = new System.Drawing.Size(371, 38);
            this.txtSubsFile.TabIndex = 2;
            this.txtSubsFile.Text = "srt";
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowDrop = true;
            this.dgvMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMovies});
            this.dgvMovies.Location = new System.Drawing.Point(12, 68);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.Size = new System.Drawing.Size(537, 581);
            this.dgvMovies.TabIndex = 3;
            this.dgvMovies.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvMovies_MouseDown);
            this.dgvMovies.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvMovies_MouseMove);
            this.dgvMovies.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvMovies_DragOver);
            this.dgvMovies.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvMovies_DragDrop);
            // 
            // dgvSubs
            // 
            this.dgvSubs.AllowDrop = true;
            this.dgvSubs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSub});
            this.dgvSubs.Location = new System.Drawing.Point(555, 68);
            this.dgvSubs.Name = "dgvSubs";
            this.dgvSubs.Size = new System.Drawing.Size(553, 581);
            this.dgvSubs.TabIndex = 4;
            this.dgvSubs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvSubs_MouseDown);
            this.dgvSubs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvSubs_MouseMove);
            this.dgvSubs.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvSubs_DragOver);
            this.dgvSubs.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvSubs_DragDrop);
            // 
            // btnProcessSub
            // 
            this.btnProcessSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessSub.Location = new System.Drawing.Point(881, 665);
            this.btnProcessSub.Name = "btnProcessSub";
            this.btnProcessSub.Size = new System.Drawing.Size(227, 63);
            this.btnProcessSub.TabIndex = 5;
            this.btnProcessSub.Text = "Process Subs";
            this.btnProcessSub.UseVisualStyleBackColor = true;
            this.btnProcessSub.Click += new System.EventHandler(this.btnProcessSub_Click);
            // 
            // clmMovies
            // 
            this.clmMovies.HeaderText = "Movie Files";
            this.clmMovies.Name = "clmMovies";
            this.clmMovies.ReadOnly = true;
            // 
            // clmSub
            // 
            this.clmSub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSub.HeaderText = "Subtitle Files";
            this.clmSub.Name = "clmSub";
            this.clmSub.ReadOnly = true;
            // 
            // frmSubAlign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 740);
            this.Controls.Add(this.btnProcessSub);
            this.Controls.Add(this.dgvSubs);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.txtSubsFile);
            this.Controls.Add(this.txtMovieFiles);
            this.Controls.Add(this.btnLoadFiles);
            this.MaximumSize = new System.Drawing.Size(1136, 1000);
            this.MinimumSize = new System.Drawing.Size(1136, 778);
            this.Name = "frmSubAlign";
            this.Text = "Sync Sub";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.TextBox txtMovieFiles;
        private System.Windows.Forms.TextBox txtSubsFile;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.DataGridView dgvSubs;
        private System.Windows.Forms.Button btnProcessSub;
        private System.Windows.Forms.FolderBrowserDialog fldDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSub;
    }
}

