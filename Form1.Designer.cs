
namespace Kaczuszki_Gra
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtDucks = new System.Windows.Forms.Label();
            this.txtKills = new System.Windows.Forms.Label();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.glownyTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(16, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 346);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(463, 386);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(128, 19);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 100;
            // 
            // txtDucks
            // 
            this.txtDucks.AutoSize = true;
            this.txtDucks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDucks.Location = new System.Drawing.Point(376, 381);
            this.txtDucks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtDucks.Name = "txtDucks";
            this.txtDucks.Size = new System.Drawing.Size(67, 24);
            this.txtDucks.TabIndex = 2;
            this.txtDucks.Text = "Ducks:";
            // 
            // txtKills
            // 
            this.txtKills.AutoSize = true;
            this.txtKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKills.Location = new System.Drawing.Point(253, 381);
            this.txtKills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(58, 24);
            this.txtKills.TabIndex = 1;
            this.txtKills.Text = "Kills 0";
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.Location = new System.Drawing.Point(63, 381);
            this.txtAmmo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(81, 24);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo 0";
            this.txtAmmo.Click += new System.EventHandler(this.txtAmmo_Click);
            // 
            // glownyTimer
            // 
            this.glownyTimer.Interval = 2000;
            this.glownyTimer.Tag = "lotKaczek";
            this.glownyTimer.Tick += new System.EventHandler(this.glownyTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 433);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.txtKills);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDucks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label txtDucks;
        private System.Windows.Forms.Label txtKills;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Timer glownyTimer;
    }
}

