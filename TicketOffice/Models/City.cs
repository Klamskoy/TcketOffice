using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketOffice.Models
{
    public class City
    {
        private string _name;
        private string _description;
        private string _imageInBase64;

        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string ImageInBase64 { get => _imageInBase64; set => _imageInBase64 = value; }

        public City(string name, string description, string imageInBase64)
        {
            Name = name;
            Description = description;
            ImageInBase64 = imageInBase64;
        }
    }
}
