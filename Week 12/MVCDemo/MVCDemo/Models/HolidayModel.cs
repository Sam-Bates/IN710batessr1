using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class HolidayModel
    {
        public String Name { get; set; }
        public int DaysUntil { get; set; }
        public String Url { get; set; }
        public DateTime Date { get; set; }
        public HolidayModel(String name, DateTime date, String url)
        {
            Name = name;
            Date = date;
            Url = url;
        }
        public HolidayModel() { }
    }
}