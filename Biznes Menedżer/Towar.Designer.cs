
namespace Biznes_Menedżer
{
    partial class fTowar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtProducent = new System.Windows.Forms.TextBox();
            this.txtNrFaktury = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.txtSzukam = new System.Windows.Forms.TextBox();
            this.dgvPrzegladaj = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblWartoscBrutto = new System.Windows.Forms.Label();
            this.lblWartoscNetto = new System.Windows.Forms.Label();
            this.lblKpodatkow = new System.Windows.Forms.Label();
            this.cbStan = new System.Windows.Forms.ComboBox();
            this.numIlosc = new System.Windows.Forms.NumericUpDown();
            this.numPodatek = new System.Windows.Forms.NumericUpDown();
            this.numCenaNetto = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzegladaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPodatek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenaNetto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1940, 900);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1932, 874);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dodaj";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1926, 868);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.cbStan, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.numCenaNetto, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.numPodatek, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.txtNrFaktury, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtProducent, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.numIlosc, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(963, 868);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(0, 192);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(963, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Nazwa";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProducent
            // 
            this.txtProducent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProducent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProducent.Location = new System.Drawing.Point(0, 384);
            this.txtProducent.Margin = new System.Windows.Forms.Padding(0);
            this.txtProducent.Name = "txtProducent";
            this.txtProducent.Size = new System.Drawing.Size(963, 38);
            this.txtProducent.TabIndex = 2;
            this.txtProducent.Text = "Producent";
            this.txtProducent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNrFaktury
            // 
            this.txtNrFaktury.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNrFaktury.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNrFaktury.Location = new System.Drawing.Point(0, 480);
            this.txtNrFaktury.Margin = new System.Windows.Forms.Padding(0);
            this.txtNrFaktury.Name = "txtNrFaktury";
            this.txtNrFaktury.Size = new System.Drawing.Size(963, 38);
            this.txtNrFaktury.TabIndex = 3;
            this.txtNrFaktury.Text = "Numer faktury";
            this.txtNrFaktury.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnWyczysc, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.btnDodaj, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblWartoscBrutto, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblWartoscNetto, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblKpodatkow, 0, 5);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(963, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(963, 868);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wartość Brutto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wartość Netto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kwota Podatków";
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWyczysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyczysc.Location = new System.Drawing.Point(0, 738);
            this.btnWyczysc.Margin = new System.Windows.Forms.Padding(0);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(481, 130);
            this.btnWyczysc.TabIndex = 3;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(481, 738);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(482, 130);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1932, 874);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Przeglądaj";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvPrzegladaj, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1926, 868);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnSzukaj, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSzukam, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1926, 86);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(190)))));
            this.btnSzukaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSzukaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.Location = new System.Drawing.Point(1540, 0);
            this.btnSzukaj.Margin = new System.Windows.Forms.Padding(0);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(386, 86);
            this.btnSzukaj.TabIndex = 2;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // txtSzukam
            // 
            this.txtSzukam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSzukam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSzukam.Location = new System.Drawing.Point(0, 0);
            this.txtSzukam.Margin = new System.Windows.Forms.Padding(0);
            this.txtSzukam.Multiline = true;
            this.txtSzukam.Name = "txtSzukam";
            this.txtSzukam.Size = new System.Drawing.Size(1540, 86);
            this.txtSzukam.TabIndex = 1;
            // 
            // dgvPrzegladaj
            // 
            this.dgvPrzegladaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrzegladaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrzegladaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrzegladaj.Location = new System.Drawing.Point(3, 89);
            this.dgvPrzegladaj.Name = "dgvPrzegladaj";
            this.dgvPrzegladaj.Size = new System.Drawing.Size(1920, 776);
            this.dgvPrzegladaj.TabIndex = 1;
            this.dgvPrzegladaj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrzegladaj_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1932, 874);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modyfikuj";
            // 
            // lblWartoscBrutto
            // 
            this.lblWartoscBrutto.AutoSize = true;
            this.lblWartoscBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWartoscBrutto.Location = new System.Drawing.Point(3, 123);
            this.lblWartoscBrutto.Name = "lblWartoscBrutto";
            this.lblWartoscBrutto.Size = new System.Drawing.Size(0, 39);
            this.lblWartoscBrutto.TabIndex = 5;
            // 
            // lblWartoscNetto
            // 
            this.lblWartoscNetto.AutoSize = true;
            this.lblWartoscNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWartoscNetto.Location = new System.Drawing.Point(3, 369);
            this.lblWartoscNetto.Name = "lblWartoscNetto";
            this.lblWartoscNetto.Size = new System.Drawing.Size(0, 39);
            this.lblWartoscNetto.TabIndex = 6;
            // 
            // lblKpodatkow
            // 
            this.lblKpodatkow.AutoSize = true;
            this.lblKpodatkow.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKpodatkow.Location = new System.Drawing.Point(3, 615);
            this.lblKpodatkow.Name = "lblKpodatkow";
            this.lblKpodatkow.Size = new System.Drawing.Size(0, 39);
            this.lblKpodatkow.TabIndex = 7;
            // 
            // cbStan
            // 
            this.cbStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbStan.FormattingEnabled = true;
            this.cbStan.Items.AddRange(new object[] {
            "W magazynie",
            "Na półkach",
            "W drodze"});
            this.cbStan.Location = new System.Drawing.Point(3, 771);
            this.cbStan.Name = "cbStan";
            this.cbStan.Size = new System.Drawing.Size(957, 39);
            this.cbStan.TabIndex = 6;
            // 
            // numIlosc
            // 
            this.numIlosc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numIlosc.Location = new System.Drawing.Point(3, 291);
            this.numIlosc.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numIlosc.Name = "numIlosc";
            this.numIlosc.Size = new System.Drawing.Size(957, 38);
            this.numIlosc.TabIndex = 7;
            this.numIlosc.ValueChanged += new System.EventHandler(this.numCena_ValueChanged);
            // 
            // numPodatek
            // 
            this.numPodatek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPodatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numPodatek.Location = new System.Drawing.Point(3, 579);
            this.numPodatek.Name = "numPodatek";
            this.numPodatek.Size = new System.Drawing.Size(957, 38);
            this.numPodatek.TabIndex = 9;
            this.numPodatek.ValueChanged += new System.EventHandler(this.numPodatek_ValueChanged);
            // 
            // numCenaNetto
            // 
            this.numCenaNetto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numCenaNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numCenaNetto.Location = new System.Drawing.Point(3, 675);
            this.numCenaNetto.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numCenaNetto.Name = "numCenaNetto";
            this.numCenaNetto.Size = new System.Drawing.Size(957, 38);
            this.numCenaNetto.TabIndex = 10;
            this.numCenaNetto.ValueChanged += new System.EventHandler(this.numCenaNetto_ValueChanged);
            // 
            // fTowar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(148)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(1940, 900);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fTowar";
            this.Text = "Biznes Menedżer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzegladaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPodatek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenaNetto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtSzukam;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.DataGridView dgvPrzegladaj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtProducent;
        private System.Windows.Forms.TextBox txtNrFaktury;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblWartoscBrutto;
        private System.Windows.Forms.Label lblWartoscNetto;
        private System.Windows.Forms.Label lblKpodatkow;
        private System.Windows.Forms.ComboBox cbStan;
        private System.Windows.Forms.NumericUpDown numIlosc;
        private System.Windows.Forms.NumericUpDown numPodatek;
        private System.Windows.Forms.NumericUpDown numCenaNetto;
    }
}