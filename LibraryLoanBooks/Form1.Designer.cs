namespace LibraryLoanBooks
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.tabPageAuthor = new System.Windows.Forms.TabPage();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.groupBoxSearchAuthor = new System.Windows.Forms.GroupBox();
            this.cmbAuthorNationalitySearch = new System.Windows.Forms.ComboBox();
            this.txtAuthorNameSearch = new System.Windows.Forms.TextBox();
            this.lblAuthorNationalitySearch = new System.Windows.Forms.Label();
            this.lblAuthorNameSearch = new System.Windows.Forms.Label();
            this.tabPagePublishingCompany = new System.Windows.Forms.TabPage();
            this.tabPageTheme = new System.Windows.Forms.TabPage();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.tagPagePublishingCompany = new System.Windows.Forms.GroupBox();
            this.lblPublishingCompany = new System.Windows.Forms.Label();
            this.txtPublishingNameSearch = new System.Windows.Forms.TextBox();
            this.pnlPublishingCompany = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPrincipal.SuspendLayout();
            this.tabPageAuthor.SuspendLayout();
            this.pnlAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            this.groupBoxSearchAuthor.SuspendLayout();
            this.tabPagePublishingCompany.SuspendLayout();
            this.tagPagePublishingCompany.SuspendLayout();
            this.pnlPublishingCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPagePrincipal);
            this.tabPrincipal.Controls.Add(this.tabPageAuthor);
            this.tabPrincipal.Controls.Add(this.tabPagePublishingCompany);
            this.tabPrincipal.Controls.Add(this.tabPageTheme);
            this.tabPrincipal.Controls.Add(this.tabPageBooks);
            this.tabPrincipal.Controls.Add(this.tabPageClient);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1214, 711);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 24);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "Principal";
            this.tabPagePrincipal.UseVisualStyleBackColor = true;
            // 
            // tabPageAuthor
            // 
            this.tabPageAuthor.Controls.Add(this.pnlAuthor);
            this.tabPageAuthor.Controls.Add(this.groupBoxSearchAuthor);
            this.tabPageAuthor.Location = new System.Drawing.Point(4, 24);
            this.tabPageAuthor.Name = "tabPageAuthor";
            this.tabPageAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthor.Size = new System.Drawing.Size(1206, 683);
            this.tabPageAuthor.TabIndex = 1;
            this.tabPageAuthor.Text = "Autores";
            this.tabPageAuthor.UseVisualStyleBackColor = true;
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuthor.BackColor = System.Drawing.Color.LightCyan;
            this.pnlAuthor.Controls.Add(this.btnDeleteAuthor);
            this.pnlAuthor.Controls.Add(this.btnEditAuthor);
            this.pnlAuthor.Controls.Add(this.btnNewAuthor);
            this.pnlAuthor.Controls.Add(this.dataGridViewAuthor);
            this.pnlAuthor.Location = new System.Drawing.Point(6, 145);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(1190, 504);
            this.pnlAuthor.TabIndex = 6;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Delete;
            this.btnDeleteAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(118, 13);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteAuthor.TabIndex = 12;
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Edit;
            this.btnEditAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditAuthor.Location = new System.Drawing.Point(62, 13);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnEditAuthor.TabIndex = 11;
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Add;
            this.btnNewAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewAuthor.Location = new System.Drawing.Point(6, 13);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnNewAuthor.TabIndex = 10;
            this.btnNewAuthor.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(0, 73);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.RowTemplate.Height = 25;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(1187, 236);
            this.dataGridViewAuthor.TabIndex = 0;
            // 
            // groupBoxSearchAuthor
            // 
            this.groupBoxSearchAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchAuthor.Controls.Add(this.btnSearchAuthor);
            this.groupBoxSearchAuthor.Controls.Add(this.cmbAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.txtAuthorNameSearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNameSearch);
            this.groupBoxSearchAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchAuthor.Location = new System.Drawing.Point(6, 6);
            this.groupBoxSearchAuthor.Name = "groupBoxSearchAuthor";
            this.groupBoxSearchAuthor.Size = new System.Drawing.Size(1190, 133);
            this.groupBoxSearchAuthor.TabIndex = 5;
            this.groupBoxSearchAuthor.TabStop = false;
            this.groupBoxSearchAuthor.Text = "Consulta";
            // 
            // cmbAuthorNationalitySearch
            // 
            this.cmbAuthorNationalitySearch.FormattingEnabled = true;
            this.cmbAuthorNationalitySearch.Location = new System.Drawing.Point(205, 59);
            this.cmbAuthorNationalitySearch.Name = "cmbAuthorNationalitySearch";
            this.cmbAuthorNationalitySearch.Size = new System.Drawing.Size(175, 29);
            this.cmbAuthorNationalitySearch.TabIndex = 8;
            // 
            // txtAuthorNameSearch
            // 
            this.txtAuthorNameSearch.Location = new System.Drawing.Point(6, 59);
            this.txtAuthorNameSearch.Name = "txtAuthorNameSearch";
            this.txtAuthorNameSearch.Size = new System.Drawing.Size(175, 29);
            this.txtAuthorNameSearch.TabIndex = 7;
            // 
            // lblAuthorNationalitySearch
            // 
            this.lblAuthorNationalitySearch.AutoSize = true;
            this.lblAuthorNationalitySearch.Location = new System.Drawing.Point(204, 35);
            this.lblAuthorNationalitySearch.Name = "lblAuthorNationalitySearch";
            this.lblAuthorNationalitySearch.Size = new System.Drawing.Size(122, 21);
            this.lblAuthorNationalitySearch.TabIndex = 6;
            this.lblAuthorNationalitySearch.Text = "Nacionalidade";
            // 
            // lblAuthorNameSearch
            // 
            this.lblAuthorNameSearch.AutoSize = true;
            this.lblAuthorNameSearch.Location = new System.Drawing.Point(6, 35);
            this.lblAuthorNameSearch.Name = "lblAuthorNameSearch";
            this.lblAuthorNameSearch.Size = new System.Drawing.Size(128, 21);
            this.lblAuthorNameSearch.TabIndex = 5;
            this.lblAuthorNameSearch.Text = "Nome do Autor";
            // 
            // tabPagePublishingCompany
            // 
            this.tabPagePublishingCompany.Controls.Add(this.pnlPublishingCompany);
            this.tabPagePublishingCompany.Controls.Add(this.tagPagePublishingCompany);
            this.tabPagePublishingCompany.Location = new System.Drawing.Point(4, 24);
            this.tabPagePublishingCompany.Name = "tabPagePublishingCompany";
            this.tabPagePublishingCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePublishingCompany.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePublishingCompany.TabIndex = 2;
            this.tabPagePublishingCompany.Text = "Editoras";
            this.tabPagePublishingCompany.UseVisualStyleBackColor = true;
            // 
            // tabPageTheme
            // 
            this.tabPageTheme.Location = new System.Drawing.Point(4, 24);
            this.tabPageTheme.Name = "tabPageTheme";
            this.tabPageTheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTheme.Size = new System.Drawing.Size(1206, 683);
            this.tabPageTheme.TabIndex = 3;
            this.tabPageTheme.Text = "Temas";
            this.tabPageTheme.UseVisualStyleBackColor = true;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Location = new System.Drawing.Point(4, 24);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(1206, 683);
            this.tabPageBooks.TabIndex = 4;
            this.tabPageBooks.Text = "Livros";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Location = new System.Drawing.Point(4, 24);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(1206, 683);
            this.tabPageClient.TabIndex = 5;
            this.tabPageClient.Text = "Clientes";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Search;
            this.btnSearchAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchAuthor.Location = new System.Drawing.Point(404, 38);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnSearchAuthor.TabIndex = 9;
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // tagPagePublishingCompany
            // 
            this.tagPagePublishingCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagPagePublishingCompany.Controls.Add(this.txtPublishingNameSearch);
            this.tagPagePublishingCompany.Controls.Add(this.lblPublishingCompany);
            this.tagPagePublishingCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tagPagePublishingCompany.Location = new System.Drawing.Point(3, 6);
            this.tagPagePublishingCompany.Name = "tagPagePublishingCompany";
            this.tagPagePublishingCompany.Size = new System.Drawing.Size(1190, 133);
            this.tagPagePublishingCompany.TabIndex = 0;
            this.tagPagePublishingCompany.TabStop = false;
            this.tagPagePublishingCompany.Text = "Consulta";
            // 
            // lblPublishingCompany
            // 
            this.lblPublishingCompany.AutoSize = true;
            this.lblPublishingCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPublishingCompany.Location = new System.Drawing.Point(6, 36);
            this.lblPublishingCompany.Name = "lblPublishingCompany";
            this.lblPublishingCompany.Size = new System.Drawing.Size(65, 21);
            this.lblPublishingCompany.TabIndex = 0;
            this.lblPublishingCompany.Text = "Editora";
            // 
            // txtPublishingNameSearch
            // 
            this.txtPublishingNameSearch.Location = new System.Drawing.Point(6, 60);
            this.txtPublishingNameSearch.Name = "txtPublishingNameSearch";
            this.txtPublishingNameSearch.Size = new System.Drawing.Size(175, 29);
            this.txtPublishingNameSearch.TabIndex = 1;
            // 
            // pnlPublishingCompany
            // 
            this.pnlPublishingCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPublishingCompany.BackColor = System.Drawing.Color.LightCyan;
            this.pnlPublishingCompany.Controls.Add(this.button1);
            this.pnlPublishingCompany.Controls.Add(this.dataGridView1);
            this.pnlPublishingCompany.Location = new System.Drawing.Point(3, 145);
            this.pnlPublishingCompany.Name = "pnlPublishingCompany";
            this.pnlPublishingCompany.Size = new System.Drawing.Size(1190, 504);
            this.pnlPublishingCompany.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(15, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 711);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageAuthor.ResumeLayout(false);
            this.pnlAuthor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            this.groupBoxSearchAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.PerformLayout();
            this.tabPagePublishingCompany.ResumeLayout(false);
            this.tagPagePublishingCompany.ResumeLayout(false);
            this.tagPagePublishingCompany.PerformLayout();
            this.pnlPublishingCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabPagePrincipal;
        private TabPage tabPageAuthor;
        private Panel pnlAuthor;
        private Button btnDeleteAuthor;
        private Button btnEditAuthor;
        private Button btnNewAuthor;
        private DataGridView dataGridViewAuthor;
        private GroupBox groupBoxSearchAuthor;
        private ComboBox cmbAuthorNationalitySearch;
        private TextBox txtAuthorNameSearch;
        private Label lblAuthorNationalitySearch;
        private Label lblAuthorNameSearch;
        private TabPage tabPagePublishingCompany;
        private TabPage tabPageTheme;
        private TabPage tabPageBooks;
        private TabPage tabPageClient;
        private StatusStrip statusStrip1;
        private Button btnSearchAuthor;
        private Panel pnlPublishingCompany;
        private Button button1;
        private DataGridView dataGridView1;
        private GroupBox tagPagePublishingCompany;
        private TextBox txtPublishingNameSearch;
        private Label lblPublishingCompany;
    }
}