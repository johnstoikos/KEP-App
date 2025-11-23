using System;

namespace KEP.Models
{
    public class CitizenRequest
    {
        public int Id { get; set; }               
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }    
        public string RequestType { get; set; }    
        public string Address { get; set; }        
        public DateTime RequestDate { get; set; } 

        public string BirthDateIso => BirthDate.ToString("yyyy-MM-dd");
        public string RequestDateIso => RequestDate.ToString("yyyy-MM-dd HH:mm");

    }
}
