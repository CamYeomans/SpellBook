using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Spellbook
{
    public partial class spellbookMenu : Form
    {
        string gamestate;

        public spellbookMenu()
        {
            gamestate = "startmenu";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leftpageCharacterCreate.Left = panel2.Width/3; 
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newChar_Click(object sender, EventArgs e)
        {
            this.gamestate = "newChar";
            panel2.Visible = false;
            backBtn.Visible = true;
            this.BackgroundImage = Properties.Resources.OpenBook;
            leftpageCharacterCreate.Visible = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (gamestate.Equals("newChar"))
            {
                this.BackgroundImage = Properties.Resources.BookClosed;
                backBtn.Visible = false;
                gamestate = "startmenu";
                panel2.Visible = true;
                leftpageCharacterCreate.Visible = false;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
