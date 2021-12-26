using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TicketOffice.Models
{
    public class Ticket : Flight
    {

        private string _usersName;
        private string _usersSurname;


        public Ticket(string flightnumber, string pointOfDeparture, string pointOfDestination, DateTime date, DateTime time, string classType) : base(flightnumber, pointOfDeparture, pointOfDestination, date, time, classType)
        {

        }

        public string UsersName { get => _usersName; set => _usersName = value; }
        public string UsersSurname { get => _usersSurname; set => _usersSurname = value; }
    }
}
