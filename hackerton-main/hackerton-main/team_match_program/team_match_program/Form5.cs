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
    public partial class frmTeamCreate : Form
    {
        public string name;
        public frmTeamCreate()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_teamName.Text == null)
            {
                MessageBox.Show("팀명을 입력해주세요!");
            }
            else
            {
                name = textBox_teamName.Text;
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
