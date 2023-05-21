using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPersional.Data.Entities
{
    internal class Language
    {
        public string Id { get; set; }
        public string name { get; set; }
        public bool IsDefault { get; set; } 
    }
}
