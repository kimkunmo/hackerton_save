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
    public partial class frmSignUp : Form
    {
        public string NewID = "";
        public string NewPass = "";
        public string NickName = "";
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null)
            {
                NickName = textBox1.Text;
                NewID = textBox2.Text;
                NewPass = textBox3.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("아이디 비밀번호 및 닉네임을 입력해주세요.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
