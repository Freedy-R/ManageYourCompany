
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabpMenu = new System.Windows.Forms.TabPage();
            this.tabObiekty = new System.Windows.Forms.TabPage();
            this.tabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabpMenu);
            this.tabMenu.Controls.Add(this.tabObiekty);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.HotTrack = true;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1368, 707);
            this.tabMenu.TabIndex = 0;
            // 
            // tabpMenu
            // 
            this.tabpMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabpMenu.Location = new System.Drawing.Point(4, 22);
            this.tabpMenu.Name = "tabpMenu";
            this.tabpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabpMenu.Size = new System.Drawing.Size(1360, 681);
            this.tabpMenu.TabIndex = 0;
            this.tabpMenu.Text = "Menu";
            // 
            // tabObiekty
            // 
            this.tabObiekty.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabObiekty.Location = new System.Drawing.Point(4, 22);
            this.tabObiekty.Name = "tabObiekty";
            this.tabObiekty.Padding = new System.Windows.Forms.Padding(3);
            this.tabObiekty.Size = new System.Drawing.Size(1360, 681);
            this.tabObiekty.TabIndex = 1;
            this.tabObiekty.Text = "Obiekty";
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1368, 707);
            this.Controls.Add(this.tabMenu);
            this.Name = "fMenu";
            this.Text = "Biznes Menedżer";
            this.tabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabpMenu;
        private System.Windows.Forms.TabPage tabObiekty;
    }
}

