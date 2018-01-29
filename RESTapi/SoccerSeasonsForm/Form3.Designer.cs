namespace SoccerSeasonsForm
{
    partial class FixturesForm
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
            this.dataGridViewFixtures = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matchday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalsHomeTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalsAwayTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixtures)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFixtures
            // 
            this.dataGridViewFixtures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFixtures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFixtures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Matchday,
            this.homeTeamName,
            this.awayTeamName,
            this.goalsHomeTeam,
            this.goalsAwayTeam});
            this.dataGridViewFixtures.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewFixtures.Name = "dataGridViewFixtures";
            this.dataGridViewFixtures.Size = new System.Drawing.Size(918, 480);
            this.dataGridViewFixtures.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "sFixtureDate";
            this.Date.HeaderText = "Datum";
            this.Date.Name = "Date";
            // 
            // Matchday
            // 
            this.Matchday.DataPropertyName = "sFixtureMatchday";
            this.Matchday.HeaderText = "Broj utakmice";
            this.Matchday.Name = "Matchday";
            // 
            // homeTeamName
            // 
            this.homeTeamName.DataPropertyName = "sHomeTeamName";
            this.homeTeamName.HeaderText = "Ime domaćeg tima";
            this.homeTeamName.Name = "homeTeamName";
            // 
            // awayTeamName
            // 
            this.awayTeamName.DataPropertyName = "sAwayTeamName";
            this.awayTeamName.HeaderText = "Ime tima u gostima";
            this.awayTeamName.Name = "awayTeamName";
            // 
            // goalsHomeTeam
            // 
            this.goalsHomeTeam.DataPropertyName = "sGoalsHomeTeam";
            this.goalsHomeTeam.HeaderText = "Domaći";
            this.goalsHomeTeam.Name = "goalsHomeTeam";
            // 
            // goalsAwayTeam
            // 
            this.goalsAwayTeam.DataPropertyName = "sGoalsAwayTeam";
            this.goalsAwayTeam.HeaderText = "Gosti";
            this.goalsAwayTeam.Name = "goalsAwayTeam";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izbornikToolStripMenuItem
            // 
            this.izbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.izbornikToolStripMenuItem.Name = "izbornikToolStripMenuItem";
            this.izbornikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.izbornikToolStripMenuItem.Text = "Izbornik";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // FixturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 519);
            this.Controls.Add(this.dataGridViewFixtures);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FixturesForm";
            this.Text = "Fixtures";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixtures)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFixtures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matchday;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalsHomeTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalsAwayTeam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}