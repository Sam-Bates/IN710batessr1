using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public class GardenManager
    {
        List<Garden> gardens;
        public GardenManager()
        {
            gardens = new List<Garden>();
        }
        public void AddGarden(Garden garden)
        {
            gardens.Add(garden);
        }
        public string GetGardenAreas()
        {
            string reportString = "";
            for (int i = 0; i < gardens.Count; i++)
            {
                reportString += String.Format("{0,-14}:{1,8:f2}", gardens[i].OwnerName, gardens[i].GetArea() + ",");
            }
            return reportString;
        }
        public string GetOwnerBalances()
        {
            string reportString = "";
            for (int i = 0; i < gardens.Count; i++)
            {
                reportString += String.Format("{0,-14}:{1,8:C2}", gardens[i].OwnerName, gardens[i].GetAccountBalance() + ",");
            }
            return reportString;
        }
    }
}
