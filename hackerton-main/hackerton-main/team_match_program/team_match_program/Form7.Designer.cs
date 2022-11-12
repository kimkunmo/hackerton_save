namespace team_match_program
{
    partial class frmTeamManagement_admin
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NicknameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefeatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "팀원 방출.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(290, 340);
            this.dataGridView1.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 25);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neo둥근모 Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "팀명 : ";
            // 
            // frmTeamManagement_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "frmTeamManagement_admin";
            this.Text = "팀관리_어드민용";
            this.Load += new System.EventHandler(this.frmTeamManagement_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NicknameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefeatColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}