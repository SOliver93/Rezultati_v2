namespace SoccerSeasonsForm
{
    partial class FormLeague
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
            this.dataGridViewLeague = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPretraga2 = new System.Windows.Forms.TextBox();
            this.pretraga2 = new System.Windows.Forms.Button();
            this.comboBoxSortiranje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDesc = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamesPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalsScored = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.draws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeague)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLeague
            // 
            this.dataGridViewLeague.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLeague.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeague.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.teamName,
            this.gamesPlayed,
            this.points,
            this.goals,
            this.goalsScored,
            this.goalDifference,
            this.wins,
            this.draws,
            this.loses});
            this.dataGridViewLeague.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewLeague.Name = "dataGridViewLeague";
            this.dataGridViewLeague.Size = new System.Drawing.Size(1342, 565);
            this.dataGridViewLeague.TabIndex = 0;
            this.dataGridViewLeague.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeague_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
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
            // textBoxPretraga2
            // 
            this.textBoxPretraga2.Location = new System.Drawing.Point(12, 27);
            this.textBoxPretraga2.Name = "textBoxPretraga2";
            this.textBoxPretraga2.Size = new System.Drawing.Size(152, 20);
            this.textBoxPretraga2.TabIndex = 2;
            // 
            // pretraga2
            // 
            this.pretraga2.Location = new System.Drawing.Point(170, 25);
            this.pretraga2.Name = "pretraga2";
            this.pretraga2.Size = new System.Drawing.Size(75, 23);
            this.pretraga2.TabIndex = 3;
            this.pretraga2.Text = "Pretraži";
            this.pretraga2.UseVisualStyleBackColor = true;
            this.pretraga2.Click += new System.EventHandler(this.pretraga2_Click);
            // 
            // comboBoxSortiranje
            // 
            this.comboBoxSortiranje.FormattingEnabled = true;
            this.comboBoxSortiranje.Location = new System.Drawing.Point(451, 29);
            this.comboBoxSortiranje.Name = "comboBoxSortiranje";
            this.comboBoxSortiranje.Size = new System.Drawing.Size(131, 21);
            this.comboBoxSortiranje.TabIndex = 4;
            this.comboBoxSortiranje.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortiranje_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sortiranje";
            // 
            // checkBoxDesc
            // 
            this.checkBoxDesc.AutoSize = true;
            this.checkBoxDesc.Location = new System.Drawing.Point(588, 33);
            this.checkBoxDesc.Name = "checkBoxDesc";
            this.checkBoxDesc.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDesc.TabIndex = 6;
            this.checkBoxDesc.UseVisualStyleBackColor = true;
            this.checkBoxDesc.CheckedChanged += new System.EventHandler(this.checkBoxDesc_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descending order";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "sPosition";
            this.Position.HeaderText = "Pozicija";
            this.Position.Name = "Position";
            // 
            // teamName
            // 
            this.teamName.DataPropertyName = "sTeamName";
            this.teamName.HeaderText = "Naziv tima";
            this.teamName.Name = "teamName";
            // 
            // gamesPlayed
            // 
            this.gamesPlayed.DataPropertyName = "sGamesPlayed";
            this.gamesPlayed.HeaderText = "Odigrane utakmice";
            this.gamesPlayed.Name = "gamesPlayed";
            // 
            // points
            // 
            this.points.DataPropertyName = "sPoints";
            this.points.HeaderText = "Broj bodova";
            this.points.Name = "points";
            // 
            // goals
            // 
            this.goals.DataPropertyName = "sGoals";
            this.goals.HeaderText = "Zabijeni golovi";
            this.goals.Name = "goals";
            // 
            // goalsScored
            // 
            this.goalsScored.DataPropertyName = "sGoalsAgainst";
            this.goalsScored.HeaderText = "Primljeni golovi";
            this.goalsScored.Name = "goalsScored";
            // 
            // goalDifference
            // 
            this.goalDifference.DataPropertyName = "sGoalDifference";
            this.goalDifference.HeaderText = "Gol razlika";
            this.goalDifference.Name = "goalDifference";
            // 
            // wins
            // 
            this.wins.DataPropertyName = "sWins";
            this.wins.HeaderText = "Pobjede";
            this.wins.Name = "wins";
            // 
            // draws
            // 
            this.draws.DataPropertyName = "sDraws";
            this.draws.HeaderText = "Izjednačene utakmice";
            this.draws.Name = "draws";
            // 
            // loses
            // 
            this.loses.DataPropertyName = "sLosses";
            this.loses.HeaderText = "Porazi";
            this.loses.Name = "loses";
            // 
            // FormLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSortiranje);
            this.Controls.Add(this.pretraga2);
            this.Controls.Add(this.textBoxPretraga2);
            this.Controls.Add(this.dataGridViewLeague);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLeague";
            this.Text = "League Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeague)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLeague;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPretraga2;
        private System.Windows.Forms.Button pretraga2;
        private System.Windows.Forms.ComboBox comboBoxSortiranje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamesPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn points;
        private System.Windows.Forms.DataGridViewTextBoxColumn goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalsScored;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalDifference;
        private System.Windows.Forms.DataGridViewTextBoxColumn wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn draws;
        private System.Windows.Forms.DataGridViewTextBoxColumn loses;
    }
}