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
    public partial class frmTeamManagement : Form
    {
        public frmTeamManagement(Form1.Team team)
        {
            InitializeComponent();
            for (int i = 0; i < team.nickname.Count; i++)
            {
                dataGridView1.Rows.Add(team.nickname[i], team.Win[i], team.Defeat[i]);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
