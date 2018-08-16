using System;
using System.Collections.Generic;
using System.Text;

namespace repitation.Entities
{
    public class Report
    {
        private int id;
        private Ride ride;
        private string status;
        private DateTime reporttime;
        private string notes;

        public Report(string notes, DateTime reporttime, string status, Ride ride)
        {
            Notes = notes;
            Reporttime = reporttime;
            Status = status;
            Ride = ride;
        }

        public Report(string notes, DateTime reporttime, string status, Ride ride, int iD)
        {
            Notes = notes;
            Reporttime = reporttime;
            Status = status;
            Ride = ride;
            ID = iD;
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }


        public DateTime Reporttime
        {
            get { return reporttime; }
            set { reporttime = value; }
        }


        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        public Ride Ride
        {
            get { return ride; }
            set { ride = value; }
        }


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
