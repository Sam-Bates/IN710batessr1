using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay: IDisplay
    {
        List<PictureBox> pictureBoxList;
        public PictureDisplay(List<PictureBox> pictureBoxList)
        {
            this.pictureBoxList = pictureBoxList;
        }
        public void displayCritterList(List<Critter> critterList)
        {
            //loop through and add image to the list
            for (int i = 0; i < critterList.Count; i++)
            {
                pictureBoxList[i].Image = Image.FromFile(critterList[i].ImageFileName);
            }
        }

        public void clearDisplay()
        {
            //loop through and delete images from the list
            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                pictureBoxList[i].Image = null;
            }
        }
    }
}
