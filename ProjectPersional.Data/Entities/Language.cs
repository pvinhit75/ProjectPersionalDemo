﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPersional.Data.Entities
{
    public class Language
    {
        public string Id { get; set; }
        public string name { get; set; }
        public bool IsDefault { get; set; } 
        public List<ProductTranslation> ProductTranslations { get; set; }  
        public List<CategoryTranslation> CategoryTranslations { get; set }   
    }
}