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
            panel2.Width = this.Width / 2;
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
            classList.Visible = true;
            leftpageCharacterCreate.Left = 250;
            leftpageCharacterCreate.Top = 60;
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (gamestate.Equals("newChar"))
            {
                selectedClass.Visible = false;
                flavortxt.Visible = false;
                backBtn.Visible = false;
                gamestate = "startmenu";
                panel2.Visible = true;
                leftpageCharacterCreate.Width = this.Width;
                leftpageCharacterCreate.Visible = false;
                classList.Visible = false;
                this.BackgroundImage = Properties.Resources.BookClosed;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void leftpageCharacterCreate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void classList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Bard";
            selectedClass.Visible = true;
            flavortxt.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Sorcerer";
            selectedClass.Visible = true;
            flavortxt.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Wizard";
            selectedClass.Visible = true;
            flavortxt.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Ranger";
            selectedClass.Visible = true;
            flavortxt.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Monk";
            selectedClass.Visible = true;
            flavortxt.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Fighter";
            selectedClass.Visible = true;
            flavortxt.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Druid";
            selectedClass.Visible = true;
            flavortxt.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Rogue";
            selectedClass.Visible = true;
            flavortxt.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Barbarian";
            selectedClass.Visible = true;
            flavortxt.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Cleric";
            selectedClass.Visible = true;
            flavortxt.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Paladin";
            selectedClass.Visible = true;
            flavortxt.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Warlock";
            selectedClass.Visible = true;

        }
    }
}
