using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TicketOffice.Models
{
    public class User
    {
        private string _login;
        private string _password;
        private string _name;
        private string _surname;
        private string _patronymic;
        private DateTime _dayOfBirth;
        private string _imageInBase64;
        private string _role;

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Patronymic { get => _patronymic; set => _patronymic = value; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime DayOfBirth { get => _dayOfBirth; set => _dayOfBirth = value; }
        public string ImageInBase64 { get => _imageInBase64; set => _imageInBase64 = value; }
        public string Role { get => _role; set => _role = value; }

        public User(string login, string password, string name, string surname, string patronymic, DateTime dayOfBirth)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            DayOfBirth = dayOfBirth;
            Role = "user";
        }
    }
}
