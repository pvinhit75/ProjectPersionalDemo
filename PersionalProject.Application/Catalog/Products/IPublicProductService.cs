using PersionalProject.Application.Catalog.Products.Dtos;
using PersionalProject.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersionalProject.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PageResult<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pages);

    }
}
