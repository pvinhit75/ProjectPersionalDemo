using ProjectPersional.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPersional.Data.Entities
{
    public class Contact
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Email { get; set; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; } 
        public Status Status { get; set; }  
    }
}
