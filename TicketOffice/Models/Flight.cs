using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TicketOffice.Models
{
    public class Flight
    {
        private string _flightNumber;
        private string _pointOfDeparture;
        private string _pointOfDestination;
        private DateTime _date;
        private DateTime _time;
        private string _classType;

        public Flight(string flightnumber, string pointOfDeparture, string pointOfDestination, DateTime date, DateTime time, string classType)
        {
            FlightNumber = flightnumber;
            PointOfDeparture = pointOfDeparture;
            PointOfDestination = pointOfDestination;
            Date = date;
            Time = time;
            ClassType = classType;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string FlightNumber { get => _flightNumber; set => _flightNumber = value; }
        public string PointOfDeparture { get => _pointOfDeparture; set => _pointOfDeparture = value; }
        public string PointOfDestination { get => _pointOfDestination; set => _pointOfDestination = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public DateTime Time { get => _time; set => _time = value; }
        public string ClassType { get => _classType; set => _classType = value; }
    }
}
