using PersionalProject.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersionalProject.Application.Catalog.Products.Dtos
{
    public class GetProductPagingRequest : PagingRequestPage
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
