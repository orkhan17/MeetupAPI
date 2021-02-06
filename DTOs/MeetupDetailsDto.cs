using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetupAPI.DTOs
{
    public class MeetupDetailsDto
    {
        public string Name { get; set; }
        public string Organizer { get; set; }
        public DateTime Date { get; set; }
        public bool IsPrivate { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
    }
}
