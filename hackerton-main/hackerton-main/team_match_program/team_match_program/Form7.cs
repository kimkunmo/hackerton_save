using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_match_program
{
    public partial class frmTeamManagement_admin : Form
    {
        Form1.Myinfo _myinfo;
        Form1.Team _team;
        public frmTeamManagement_admin(Form1.Myinfo myinfo, Form1.Team team)
        {
            _myinfo = myinfo;
            _team = team;
            InitializeComponent();
            textBox1.Text = team.TeamName;
            for (int i = 0; i < team.nickname.Count; i++)
            {
                dataGridView1.Rows.Add(team.nickname[i], team.Win[i], team.Defeat[i]);
            }
        }

        private void frmTeamManagement_admin_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string data = row.Cells[0].Value.ToString();
            if (data == _team.adminNickname)
            {
                MessageBox.Show("방장은 방출할 수 없습니다.");
            }
            else
            {
                for (int i = 0; i < _team.nickname.Count; i++)
                {
                    if (data == _team.nickname[i])
                    {
                        _team.nickname.RemoveAt(i);
                        _team.Win.RemoveAt(i);
                        _team.Defeat.RemoveAt(i);
                    }
                }
            }
            dataGridView1.Rows.Clear();
            textBox1.Text = _team.TeamName;
            for (int i = 0; i < _team.nickname.Count; i++)
            {
                dataGridView1.Rows.Add(_team.nickname[i], _team.Win[i], _team.Defeat[i]);
            }
        }
    }
}
