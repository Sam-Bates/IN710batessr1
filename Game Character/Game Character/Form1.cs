using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        public List<Character> characterList = new List<Character>();
        public Form1()
        {
            InitializeComponent();
            characterList.Add(new King("Robert"));
            characterList.Add(new Queen("Cercei"));
            characterList.Add(new Knight("Jaime"));
            characterList.Add(new Troll("Tyrion"));
            for (int i = 0; i < characterList.Count; i++)
            {
                checkedListBox1.Items.Add(characterList[i].Name);
                checkedListBox2.Items.Add(characterList[i].Name);
            }

        }
        public void updateScreen()
        {
            //resets and re-populates all of the list boxes
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();

            foreach (Character character in characterList)
            {
                checkedListBox1.Items.Add(character.Name);
                checkedListBox2.Items.Add(character.Name);
            }
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            Character newCharacter;
            if (rdKing.Checked)
            {
                newCharacter = new King(txtName.Text);
                characterList.Add(newCharacter);
            }
            else if (rdQueen.Checked)
            {
                newCharacter = new Queen(txtName.Text);
                characterList.Add(newCharacter);
            }
            else if (rdKnight.Checked)
            {
                newCharacter = new Knight(txtName.Text);
                characterList.Add(newCharacter);
            }
            else if (rdTroll.Checked)
            {
                newCharacter = new Troll(txtName.Text);
                characterList.Add(newCharacter);
            }
            else
            {
                MessageBox.Show("Please select a character class.");
            }
            updateScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> changers = new List<int>();
            foreach (int checkedIndex in checkedListBox2.CheckedIndices)
            {
                if (rdSword.Checked)
                {
                    characterList[checkedIndex].weapon = new Sword();
                }
                if (rdMace.Checked)
                {
                    characterList[checkedIndex].weapon = new Mace();
                }
                if (rdBow.Checked)
                {
                    characterList[checkedIndex].weapon = new Bow();
                }
                if (rdClub.Checked)
                {
                    characterList[checkedIndex].weapon = new Club();
                }
            }

        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<int> players = new List<int>();
            //loop over the checkedlistBox and add each selected player to the list
            foreach (int checkedIndex in checkedListBox1.CheckedIndices)
            {
                players.Add(checkedIndex);
            }
            //loop over the selected players 
            for (int j = 0; j < players.Count(); j++)
            {
                //call the toString method and split it into a string array
                String[] substrings = characterList[players[j]].ToString().Split(',');
                for (int l = 0; l < substrings.Length; l++)
                {
                    //add each item from the string array into it's own line on the list box
                    listBox1.Items.Add(substrings[l]);
                }
                listBox1.Items.Add(" ");
            }
        }
    }
}
