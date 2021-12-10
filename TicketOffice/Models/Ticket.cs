using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketOffice.Models
{
    public class Ticket
    {
        private string _pointOfDeparture;
        private string _pointOfDestination;
        private DateTime _date;
        private string _classType;

        public Ticket(string pointOfDeparture, string pointOfDestination, DateTime date, string classType)
        {
            PointOfDeparture = pointOfDeparture;
            PointOfDestination = pointOfDestination;
            Date = date;
            ClassType = classType;
        }

        public string PointOfDeparture { get => _pointOfDeparture; set => _pointOfDeparture = value; }
        public string PointOfDestination { get => _pointOfDestination; set => _pointOfDestination = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string ClassType { get => _classType; set => _classType = value; }
    }
}
