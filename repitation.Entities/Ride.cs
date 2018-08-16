using System;
using System.Collections.Generic;
using System.Text;

namespace repitation.Entities
{
    public class Ride
    {
        private int id;
        private string name;
        private string category;
        private string status;
        private List<Report> reports;

        public Ride(string status, string category, string name, int iD)
        {
            Status = status;
            Category = category;
            Name = name;
            ID = iD;
        }

        public Ride(string status, string category, string name)
        {
            Status = status;
            Category = category;
            Name = name;
        }

        public List<Report> Reports
        {
            get { return reports; }
            set { reports = value; }
        }



        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        public string Category
        {
            get { return category; }
            set { category = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int NumberOfShutdown()
        {
            throw new NotImplementedException();
        }
        
        public int DaysSinceLastShutdown()
        {
            throw new NotImplementedException();
        }
    }
}
