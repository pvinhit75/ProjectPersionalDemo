using PersionalProject.Application.Catalog.Products.Dtos;
using PersionalProject.Application.Dtos;
using ProjectPersional.Data.EF;
using ProjectPersional.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersionalProject.Application.Catalog.Products
{
    public class ManageProductService : IManagerProductService
    {
        private readonly EShopDbContext _context;
        public ManageProductService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var Product = new Product()
            {
                Price = request.Price,

            };
            _context.Products.Add(Product);
            return await _context.SaveChangesAsync();  
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        Task<int> IManagerProductService.Edit(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        Task<List<ProductViewModel>> IManagerProductService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<PageResult<ProductViewModel>> IManagerProductService.GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
