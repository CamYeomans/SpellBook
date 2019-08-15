﻿using System;
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
using System.Text.RegularExpressions;

namespace Spellbook
{
    public partial class spellbookMenu : Form
    {
        string gamestate;
        Character playerCharacter = new Character();

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
            leftpageCharacterCreate.Left = this.Width / 8;
            leftpageCharacterCreate.Top = 100;
            classList.Left = 25;
            classList.Top = 75;
            rightpagepanel.Width = this.Width / 2;
            selectedClass.Text = "";
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
                rightpagepanel.Visible = false;
                this.BackgroundImage = Properties.Resources.book;
                charnameInput.Text = "";
                levelInput.Text = "";
                selectedClass.Text = "";
                playerCharacter = new Character();
                statsPanel.Visible = false;
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
            flavortxt.Text = "An inspiring magician whose power echoes the music of creation";
            flavortxt.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Sorcerer";
            selectedClass.Visible = true;
            flavortxt.Text = "A spellcaster who draws on inherent magic from a gift or bloodline";
            flavortxt.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Wizard";
            selectedClass.Visible = true;
            flavortxt.Text = "A scholarly magic-user capable of manipulating the structure of reality";
            flavortxt.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Ranger";
            selectedClass.Visible = true;
            flavortxt.Text = "A warrior who combats theats on the edges of civilization";
            flavortxt.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Monk";
            selectedClass.Visible = true;
            flavortxt.Text = "A master of martial arts, harnessing the power of the body in pursuit of physical and spiritual elightenment";
            flavortxt.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Fighter";
            selectedClass.Visible = true;
            flavortxt.Text = "A master of martial combat, skilled with a variety of weapons and armor";
            flavortxt.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Druid";
            selectedClass.Visible = true;
            flavortxt.Text = "A priest of the old faith, wielding the powers of nature and adopting animal forms";
            flavortxt.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Rogue";
            selectedClass.Visible = true;
            flavortxt.Text = "A scoundrel who uses stealth and trickery to overcome obstacles and enemies";
            flavortxt.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Barbarian";
            selectedClass.Visible = true;
            flavortxt.Text = "A fierce warrior of primative background who can enter a battle rage";
            flavortxt.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Cleric";
            selectedClass.Visible = true;
            flavortxt.Text = "A priestly champion who wields divine magic in service of higher power";
            flavortxt.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Paladin";
            selectedClass.Visible = true;
            flavortxt.Text = "A holy warrior bound to a sacred oath";
            flavortxt.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "The Warlock";
            flavortxt.Text = "A wielder of magic that is derived from a bargain with an extraplanar entity";
            selectedClass.Visible = true;

        }

        private void createCharacter_Click(object sender, EventArgs e)
        {
            int inputvalue;
            if (!Int32.TryParse(levelInput.Text,out inputvalue))
            {
                System.Windows.Forms.MessageBox.Show("Please enter a number between 1 and 20 in the character level box to choose your character's level");
            }
            else
            {
                if(inputvalue > 20 || inputvalue < 1)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a number between 1 and 20 in the character level box to choose your character's level");
                }else if(charnameInput.Text.Equals(""))
                {
                    System.Windows.Forms.MessageBox.Show("Your name cannot be blank");
                }else if(selectedClass.Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("You must select a class");
                }
                else {
                    playerCharacter.setClass(selectedClass.Text);
                    playerCharacter.setLevel(inputvalue);
                    playerCharacter.setName(charnameInput.Text);
                    createdCharName.Text = playerCharacter.getName() + " the level " + playerCharacter.getLevel().ToString() + " " + playerCharacter.getClass().ToString();
                    modifierLabel.Text = "Please enter your character's " + playerCharacter.getClass().getSpellcastingAbility() + " modifier";
                    createdCharName.Visible = true;
                    rightpagepanel.Visible = true;
                }
            }
        }

        private void modClick(object sender, EventArgs e)
        {
            var regex = @"^(\+|-)?\d?\d$";
            Match match = Regex.Match(modBox.Text, regex, RegexOptions.IgnoreCase);

            if (modBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please enter your character's spellcasting modifier\nexamples:\n+5\n-3\n0");
            }else if (!match.Success)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid spellcasting modifier\nexamples:\n+5\n-3\n0");
            }
            else
            {
                int charvalue;
                if (modBox.Text[0] == '+')
                {
                    Int32.TryParse(modBox.Text.Substring(1),out charvalue);
                    playerCharacter.GetCharClass().setSpellAbilityValue(charvalue);
                }
                else
                {
                    Int32.TryParse(modBox.Text.Substring(1), out charvalue);
                    playerCharacter.GetCharClass().setSpellAbilityValue(charvalue);
                }
                spellSaveDC.Text = "Spell save DC:\n" + (playerCharacter.GetCharClass().getSpellcastingAbilityValue() + 8 + playerCharacter.GetCharClass().getProfBonus(playerCharacter.getLevel())).ToString();
                spellattackmodlabel.Text = "Spell attack modifier:\n" + (playerCharacter.GetCharClass().getSpellcastingAbilityValue() + playerCharacter.GetCharClass().getProfBonus(playerCharacter.getLevel())).ToString();
                spellsKnowLabel.Text = "Spells Known:\n" + playerCharacter.GetCharClass().getTotalSpellsKnown(playerCharacter.getLevel()).ToString();
                cantripsKnownLabel.Text = "Cantrips Known:\n" + playerCharacter.GetCharClass().getspellslots(playerCharacter.getLevel(), 0);
                statsPanel.Visible = true;
                tableLayoutPanel1.Visible = true;
                availableSpells.Visible = true;
            }
        }
    }
}
