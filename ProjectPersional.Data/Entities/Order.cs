﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPersional.Data.Entities
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime OrderDate { get; set; } 
        public Guid UserId { get; set; }    
        public string ShipName { get; set; }    
        public string ShipAddress { get; set; } 
        public string  ShipEmail { get; set; }  
        public string ShipPhoneNumber { get; set; } 
        public OrderStatus Status { get; set; } 

    }
}
