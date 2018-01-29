namespace SoccerSeasonsForm
{
    partial class FormPlayers
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
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sJersey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPlayers = new System.Windows.Forms.TextBox();
            this.buttonPlayers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sName,
            this.sPosition,
            this.sJersey,
            this.sDate,
            this.sNationality,
            this.sContract});
            this.dataGridViewPlayers.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.Size = new System.Drawing.Size(1427, 553);
            this.dataGridViewPlayers.TabIndex = 0;
            // 
            // sName
            // 
            this.sName.DataPropertyName = "sPName";
            this.sName.HeaderText = "Ime";
            this.sName.Name = "sName";
            // 
            // sPosition
            // 
            this.sPosition.DataPropertyName = "sPosition";
            this.sPosition.HeaderText = "Pozicija";
            this.sPosition.Name = "sPosition";
            // 
            // sJersey
            // 
            this.sJersey.DataPropertyName = "sjerseyNumber";
            this.sJersey.HeaderText = "Broj dresa";
            this.sJersey.Name = "sJersey";
            // 
            // sDate
            // 
            this.sDate.DataPropertyName = "sdateOfBirth";
            this.sDate.HeaderText = "Datum rođenja";
            this.sDate.Name = "sDate";
            // 
            // sNationality
            // 
            this.sNationality.DataPropertyName = "snationality";
            this.sNationality.HeaderText = "Nacionalnost";
            this.sNationality.Name = "sNationality";
            // 
            // sContract
            // 
            this.sContract.DataPropertyName = "scontractUntil";
            this.sContract.HeaderText = "Istek ugovora";
            this.sContract.Name = "sContract";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1451, 24);
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
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // textBoxPlayers
            // 
            this.textBoxPlayers.Location = new System.Drawing.Point(12, 31);
            this.textBoxPlayers.Name = "textBoxPlayers";
            this.textBoxPlayers.Size = new System.Drawing.Size(143, 20);
            this.textBoxPlayers.TabIndex = 2;
            // 
            // buttonPlayers
            // 
            this.buttonPlayers.Location = new System.Drawing.Point(161, 29);
            this.buttonPlayers.Name = "buttonPlayers";
            this.buttonPlayers.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayers.TabIndex = 3;
            this.buttonPlayers.Text = "Pretraži";
            this.buttonPlayers.UseVisualStyleBackColor = true;
            this.buttonPlayers.Click += new System.EventHandler(this.buttonPlayers_Click);
            // 
            // FormPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 622);
            this.Controls.Add(this.buttonPlayers);
            this.Controls.Add(this.textBoxPlayers);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPlayers";
            this.Text = "Players";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn sJersey;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn sContract;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPlayers;
        private System.Windows.Forms.Button buttonPlayers;
    }
}