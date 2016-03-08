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
            //IPayComputingMachine = IWeapon 
            //useWeapon(), can change at any time, character needs to say different things depending on it's current weapon
            //Employee = character class
            //abstract method declaim()

            

            characterList.Add(new King("Robert", listBox1));
            characterList.Add(new Queen("Cercei", listBox1));
            characterList.Add(new Knight("Jaime", listBox1));
            characterList.Add(new Troll("Tyrion", listBox1));
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
