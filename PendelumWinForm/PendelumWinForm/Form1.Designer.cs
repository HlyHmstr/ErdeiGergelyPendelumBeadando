namespace PendelumWinForm
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
            this.lbl_artist = new System.Windows.Forms.Label();
            this.lbl_album = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.lbl_textUrl = new System.Windows.Forms.Label();
            this.lbl_url = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btn_addDisc = new System.Windows.Forms.Button();
            this.btn_addUrl = new System.Windows.Forms.Button();
            this.btn_editsel = new System.Windows.Forms.Button();
            this.cb_album = new System.Windows.Forms.ComboBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_artist = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_artist
            // 
            this.lbl_artist.AutoSize = true;
            this.lbl_artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_artist.Location = new System.Drawing.Point(12, 27);
            this.lbl_artist.Name = "lbl_artist";
            this.lbl_artist.Size = new System.Drawing.Size(41, 18);
            this.lbl_artist.TabIndex = 0;
            this.lbl_artist.Text = "Artist";
            // 
            // lbl_album
            // 
            this.lbl_album.AutoSize = true;
            this.lbl_album.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_album.Location = new System.Drawing.Point(186, 27);
            this.lbl_album.Name = "lbl_album";
            this.lbl_album.Size = new System.Drawing.Size(49, 18);
            this.lbl_album.TabIndex = 1;
            this.lbl_album.Text = "Album";
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_search.Location = new System.Drawing.Point(12, 84);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(140, 18);
            this.lbl_search.TabIndex = 2;
            this.lbl_search.Text = "Search in track\'s file";
            // 
            // lbl_textUrl
            // 
            this.lbl_textUrl.AutoSize = true;
            this.lbl_textUrl.Location = new System.Drawing.Point(410, 322);
            this.lbl_textUrl.Name = "lbl_textUrl";
            this.lbl_textUrl.Size = new System.Drawing.Size(63, 13);
            this.lbl_textUrl.TabIndex = 3;
            this.lbl_textUrl.Text = "URL(if any):";
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(476, 322);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(75, 13);
            this.lbl_url.TabIndex = 4;
            this.lbl_url.Text = "dasdasdasdas";
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(395, 166);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(100, 102);
            this.pb.TabIndex = 5;
            this.pb.TabStop = false;
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(514, 166);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(274, 102);
            this.rtb.TabIndex = 6;
            this.rtb.Text = "";
            // 
            // btn_addDisc
            // 
            this.btn_addDisc.Location = new System.Drawing.Point(395, 379);
            this.btn_addDisc.Name = "btn_addDisc";
            this.btn_addDisc.Size = new System.Drawing.Size(127, 59);
            this.btn_addDisc.TabIndex = 7;
            this.btn_addDisc.Text = "Add Discography";
            this.btn_addDisc.UseVisualStyleBackColor = true;
            // 
            // btn_addUrl
            // 
            this.btn_addUrl.Location = new System.Drawing.Point(528, 379);
            this.btn_addUrl.Name = "btn_addUrl";
            this.btn_addUrl.Size = new System.Drawing.Size(127, 59);
            this.btn_addUrl.TabIndex = 8;
            this.btn_addUrl.Text = "Add URL";
            this.btn_addUrl.UseVisualStyleBackColor = true;
            // 
            // btn_editsel
            // 
            this.btn_editsel.Location = new System.Drawing.Point(661, 379);
            this.btn_editsel.Name = "btn_editsel";
            this.btn_editsel.Size = new System.Drawing.Size(127, 59);
            this.btn_editsel.TabIndex = 9;
            this.btn_editsel.Text = "Edit Selected";
            this.btn_editsel.UseVisualStyleBackColor = true;
            // 
            // cb_album
            // 
            this.cb_album.FormattingEnabled = true;
            this.cb_album.Location = new System.Drawing.Point(186, 48);
            this.cb_album.Name = "cb_album";
            this.cb_album.Size = new System.Drawing.Size(168, 21);
            this.cb_album.TabIndex = 11;
            this.cb_album.SelectedIndexChanged += new System.EventHandler(this.cb_album_SelectedIndexChanged);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(12, 116);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(344, 20);
            this.tb_search.TabIndex = 12;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.length});
            this.dgv.Location = new System.Drawing.Point(13, 166);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(344, 272);
            this.dgv.TabIndex = 13;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.FillWeight = 70F;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            // 
            // length
            // 
            this.length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.length.FillWeight = 30F;
            this.length.HeaderText = "Length";
            this.length.Name = "length";
            // 
            // cb_artist
            // 
            this.cb_artist.FormattingEnabled = true;
            this.cb_artist.Location = new System.Drawing.Point(12, 48);
            this.cb_artist.Name = "cb_artist";
            this.cb_artist.Size = new System.Drawing.Size(168, 21);
            this.cb_artist.TabIndex = 14;
            this.cb_artist.SelectedIndexChanged += new System.EventHandler(this.cb_artist_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_artist);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.cb_album);
            this.Controls.Add(this.btn_editsel);
            this.Controls.Add(this.btn_addUrl);
            this.Controls.Add(this.btn_addDisc);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.lbl_textUrl);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.lbl_album);
            this.Controls.Add(this.lbl_artist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_artist;
        private System.Windows.Forms.Label lbl_album;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Label lbl_textUrl;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btn_addDisc;
        private System.Windows.Forms.Button btn_addUrl;
        private System.Windows.Forms.Button btn_editsel;
        private System.Windows.Forms.ComboBox cb_album;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cb_artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
    }
}

