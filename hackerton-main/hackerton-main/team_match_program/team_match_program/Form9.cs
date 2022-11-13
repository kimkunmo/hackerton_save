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
    public partial class frmmatching : Form
    {
        List<Form1.Team> _teamlist;
        Form1.Myinfo _myinfo;
        string enemy;
        public frmmatching(List<Form1.Team> teamlist, Form1.Myinfo myinfo)
        {
            _teamlist = teamlist;
            _myinfo = myinfo;
            
            InitializeComponent();
            for(int i = 0; i < teamlist.Count; i++)
            {
                if (teamlist[i].TeamNum == myinfo.teamnum)
                {
                    continue;
                }
                dataGridView1.Rows.Add(teamlist[i].TeamName, teamlist[i].adminNickname);
            }
        }

        private void frmmatching_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string data = row.Cells[0].Value.ToString();
            for (int i = 0; i < _teamlist.Count; i++)
            {
                if (data == _teamlist[i].TeamName)
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Add("Nickname", "Nickname");
                    dataGridView1.Columns.Add("Win", "Win");
                    dataGridView1.Columns.Add("Defeat", "Defeat");
                    dataGridView1.Columns[2].Name = "Defeat";
                    for (int j= 0; j < _teamlist[i].nickname.Count; j++)
                    {
                        dataGridView1.Rows.Add(_teamlist[i].nickname[j], _teamlist[i].Win[j], _teamlist[i].Defeat[j]);
                    }
                    enemy = _teamlist[i].TeamName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmdisplay display = new frmdisplay(_teamlist, _myinfo, enemy);
            DialogResult diResult = display.ShowDialog();
            if (diResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
