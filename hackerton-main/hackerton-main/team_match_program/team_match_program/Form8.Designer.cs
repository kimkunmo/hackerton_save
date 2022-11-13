namespace team_match_program
{
    partial class frmTeamManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NicknameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefeatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NicknameColumn,
            this.WinColumn,
            this.DefeatColumn});
            this.dataGridView1.Location = new System.Drawing.Point(66, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(290, 340);
            this.dataGridView1.TabIndex = 4;
            // 
            // NicknameColumn
            // 
            this.NicknameColumn.HeaderText = "Nickname";
            this.NicknameColumn.MinimumWidth = 6;
            this.NicknameColumn.Name = "NicknameColumn";
            this.NicknameColumn.ReadOnly = true;
            this.NicknameColumn.Width = 98;
            // 
            // WinColumn
            // 
            this.WinColumn.HeaderText = "Win";
            this.WinColumn.MinimumWidth = 6;
            this.WinColumn.Name = "WinColumn";
            this.WinColumn.ReadOnly = true;
            this.WinColumn.Width = 61;
            // 
            // DefeatColumn
            // 
            this.DefeatColumn.HeaderText = "Defeat";
            this.DefeatColumn.MinimumWidth = 6;
            this.DefeatColumn.Name = "DefeatColumn";
            this.DefeatColumn.ReadOnly = true;
            this.DefeatColumn.Width = 78;
            // 
            // frmTeamManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 369);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTeamManagement";
            this.Text = "팀관리_팀원용";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NicknameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefeatColumn;
    }
}