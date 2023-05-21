using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPersional.Data.Entities
{
    public class ProductTranslation
    {
        public int Id { get; set; } 
        public int ProductId { set; get; }   
        public string Name { get; set; }    
        public string Description { get; set; } 
        public string Details { get; set; } 
        public string SeoDescription { set; get; }  
        public string SeoTitle { set; get; }    
        public string SeoAlias { set; get; }    
        public string LanguageId { set; get; }  
        public Product Product { set; get; } 
        public Language Language { set; get; }
        
    }
}
