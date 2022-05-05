
namespace Biznes_Menedżer
{
    partial class fMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenu));
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabpMenu = new System.Windows.Forms.TabPage();
            this.tabObiekty = new System.Windows.Forms.TabPage();
            this.menuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.menuCategory = new System.Windows.Forms.TableLayoutPanel();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnMagazine = new System.Windows.Forms.Button();
            this.showWindows = new System.Windows.Forms.Panel();
            this.ObjectLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oddzialyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaOddzialuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodPocztwoyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczbaPracownikowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessDataDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.businessDataDataSet = new Biznes_Menedżer.BusinessDataDataSet();
            this.businessDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oddzialyTableAdapter = new Biznes_Menedżer.BusinessDataDataSetTableAdapters.OddzialyTableAdapter();
            this.tabMenu.SuspendLayout();
            this.tabpMenu.SuspendLayout();
            this.tabObiekty.SuspendLayout();
            this.menuLayout.SuspendLayout();
            this.menuCategory.SuspendLayout();
            this.ObjectLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddzialyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabpMenu);
            this.tabMenu.Controls.Add(this.tabObiekty);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.HotTrack = true;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1580, 802);
            this.tabMenu.TabIndex = 0;
            // 
            // tabpMenu
            // 
            this.tabpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.tabpMenu.Controls.Add(this.menuLayout);
            this.tabpMenu.Location = new System.Drawing.Point(4, 22);
            this.tabpMenu.Name = "tabpMenu";
            this.tabpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabpMenu.Size = new System.Drawing.Size(1572, 776);
            this.tabpMenu.TabIndex = 0;
            this.tabpMenu.Text = "Menu";
            // 
            // tabObiekty
            // 
            this.tabObiekty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.tabObiekty.Controls.Add(this.ObjectLayout);
            this.tabObiekty.Location = new System.Drawing.Point(4, 22);
            this.tabObiekty.Name = "tabObiekty";
            this.tabObiekty.Padding = new System.Windows.Forms.Padding(3);
            this.tabObiekty.Size = new System.Drawing.Size(1572, 776);
            this.tabObiekty.TabIndex = 1;
            this.tabObiekty.Text = "Obiekty";
            // 
            // menuLayout
            // 
            this.menuLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.menuLayout.ColumnCount = 2;
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.menuLayout.Controls.Add(this.menuCategory, 0, 0);
            this.menuLayout.Controls.Add(this.showWindows, 1, 0);
            this.menuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.menuLayout.Location = new System.Drawing.Point(3, 3);
            this.menuLayout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.RowCount = 1;
            this.menuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuLayout.Size = new System.Drawing.Size(1566, 770);
            this.menuLayout.TabIndex = 0;
            // 
            // menuCategory
            // 
            this.menuCategory.ColumnCount = 1;
            this.menuCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuCategory.Controls.Add(this.btnWorkers, 0, 0);
            this.menuCategory.Controls.Add(this.btnMagazine, 0, 1);
            this.menuCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuCategory.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.menuCategory.Location = new System.Drawing.Point(0, 0);
            this.menuCategory.Margin = new System.Windows.Forms.Padding(0);
            this.menuCategory.Name = "menuCategory";
            this.menuCategory.RowCount = 2;
            this.menuCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuCategory.Size = new System.Drawing.Size(313, 770);
            this.menuCategory.TabIndex = 0;
            // 
            // btnWorkers
            // 
            this.btnWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(190)))));
            this.btnWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkers.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkers.Image")));
            this.btnWorkers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkers.Location = new System.Drawing.Point(3, 3);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(307, 379);
            this.btnWorkers.TabIndex = 0;
            this.btnWorkers.Text = "Pracownicy";
            this.btnWorkers.UseVisualStyleBackColor = false;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnMagazine
            // 
            this.btnMagazine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(190)))));
            this.btnMagazine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMagazine.Image = ((System.Drawing.Image)(resources.GetObject("btnMagazine.Image")));
            this.btnMagazine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMagazine.Location = new System.Drawing.Point(3, 388);
            this.btnMagazine.Name = "btnMagazine";
            this.btnMagazine.Size = new System.Drawing.Size(307, 379);
            this.btnMagazine.TabIndex = 1;
            this.btnMagazine.Text = "Towar";
            this.btnMagazine.UseVisualStyleBackColor = false;
            this.btnMagazine.Click += new System.EventHandler(this.btnMagazine_Click);
            // 
            // showWindows
            // 
            this.showWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showWindows.Location = new System.Drawing.Point(316, 3);
            this.showWindows.Name = "showWindows";
            this.showWindows.Size = new System.Drawing.Size(1247, 764);
            this.showWindows.TabIndex = 1;
            // 
            // ObjectLayout
            // 
            this.ObjectLayout.ColumnCount = 1;
            this.ObjectLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ObjectLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.ObjectLayout.Controls.Add(this.dataGridView1, 0, 0);
            this.ObjectLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ObjectLayout.Location = new System.Drawing.Point(3, 3);
            this.ObjectLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ObjectLayout.Name = "ObjectLayout";
            this.ObjectLayout.RowCount = 2;
            this.ObjectLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.ObjectLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ObjectLayout.Size = new System.Drawing.Size(1566, 770);
            this.ObjectLayout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnADD, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnModify, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 693);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1566, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(391, 77);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Wybrałeś Obiekt z ID:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(190)))));
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.Location = new System.Drawing.Point(391, 0);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(391, 77);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(190)))));
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Location = new System.Drawing.Point(782, 0);
            this.btnModify.Margin = new System.Windows.Forms.Padding(0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(391, 77);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Zmodyfikuj";
            this.btnModify.UseVisualStyleBackColor = false;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(190)))));
            this.btnADD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnADD.Location = new System.Drawing.Point(1173, 0);
            this.btnADD.Margin = new System.Windows.Forms.Padding(0);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(393, 77);
            this.btnADD.TabIndex = 3;
            this.btnADD.Text = "Dodaj";
            this.btnADD.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwaOddzialuDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.kodPocztwoyDataGridViewTextBoxColumn,
            this.miejscowoscDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.liczbaPracownikowDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oddzialyBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1566, 693);
            this.dataGridView1.TabIndex = 1;
            // 
            // oddzialyBindingSource
            // 
            this.oddzialyBindingSource.DataMember = "Oddzialy";
            this.oddzialyBindingSource.DataSource = this.businessDataDataSetBindingSource1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nazwaOddzialuDataGridViewTextBoxColumn
            // 
            this.nazwaOddzialuDataGridViewTextBoxColumn.DataPropertyName = "Nazwa_Oddzialu";
            this.nazwaOddzialuDataGridViewTextBoxColumn.HeaderText = "Nazwa_Oddzialu";
            this.nazwaOddzialuDataGridViewTextBoxColumn.Name = "nazwaOddzialuDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // kodPocztwoyDataGridViewTextBoxColumn
            // 
            this.kodPocztwoyDataGridViewTextBoxColumn.DataPropertyName = "Kod_Pocztwoy";
            this.kodPocztwoyDataGridViewTextBoxColumn.HeaderText = "Kod_Pocztwoy";
            this.kodPocztwoyDataGridViewTextBoxColumn.Name = "kodPocztwoyDataGridViewTextBoxColumn";
            // 
            // miejscowoscDataGridViewTextBoxColumn
            // 
            this.miejscowoscDataGridViewTextBoxColumn.DataPropertyName = "Miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.HeaderText = "Miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.Name = "miejscowoscDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // liczbaPracownikowDataGridViewTextBoxColumn
            // 
            this.liczbaPracownikowDataGridViewTextBoxColumn.DataPropertyName = "Liczba_Pracownikow";
            this.liczbaPracownikowDataGridViewTextBoxColumn.HeaderText = "Liczba_Pracownikow";
            this.liczbaPracownikowDataGridViewTextBoxColumn.Name = "liczbaPracownikowDataGridViewTextBoxColumn";
            // 
            // businessDataDataSetBindingSource1
            // 
            this.businessDataDataSetBindingSource1.DataSource = this.businessDataDataSet;
            this.businessDataDataSetBindingSource1.Position = 0;
            // 
            // businessDataDataSet
            // 
            this.businessDataDataSet.DataSetName = "BusinessDataDataSet";
            this.businessDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessDataDataSetBindingSource
            // 
            this.businessDataDataSetBindingSource.DataSource = this.businessDataDataSet;
            this.businessDataDataSetBindingSource.Position = 0;
            // 
            // oddzialyTableAdapter
            // 
            this.oddzialyTableAdapter.ClearBeforeFill = true;
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(1580, 802);
            this.Controls.Add(this.tabMenu);
            this.Name = "fMenu";
            this.Text = "Biznes Menedżer";
            this.Load += new System.EventHandler(this.fMenu_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabpMenu.ResumeLayout(false);
            this.tabObiekty.ResumeLayout(false);
            this.menuLayout.ResumeLayout(false);
            this.menuCategory.ResumeLayout(false);
            this.ObjectLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oddzialyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabpMenu;
        private System.Windows.Forms.TabPage tabObiekty;
        private System.Windows.Forms.TableLayoutPanel menuLayout;
        private System.Windows.Forms.TableLayoutPanel menuCategory;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnMagazine;
        private System.Windows.Forms.Panel showWindows;
        private System.Windows.Forms.TableLayoutPanel ObjectLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource businessDataDataSetBindingSource1;
        private BusinessDataDataSet businessDataDataSet;
        private System.Windows.Forms.BindingSource businessDataDataSetBindingSource;
        private System.Windows.Forms.BindingSource oddzialyBindingSource;
        private BusinessDataDataSetTableAdapters.OddzialyTableAdapter oddzialyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaOddzialuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPocztwoyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczbaPracownikowDataGridViewTextBoxColumn;
    }
}

