using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay: IDisplay
    {
        ListBox listbox;
        public TextDisplay(ListBox listBox1)
        {
            this.listbox = listBox1;
        }
        public void displayCritterList(List<Critter> critterList)
        {
            //loop through and add items to the litsbox
            for (int i = 0; i < critterList.Count; i++)
            {
                listbox.Items.Add(critterList[i].Name + " , " + critterList[i].Species);
            }
        }

        public void clearDisplay()
        {
            listbox.Items.Clear();
        }
    }
}
