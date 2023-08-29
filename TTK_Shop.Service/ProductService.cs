using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTK_Shop.Data.Infrastructure;
using TTK_Shop.Data.Repositories;
using TTK_Shop.Model.Models;

namespace TTK_Shop.Service
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int ID);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAll(string Keyword);
        IEnumerable<Product> GetLastest(int top);
        IEnumerable<Product> GetHotProduct(int top);
        IEnumerable<Product> GetAllByCategoryIDPaging(int categoryID, int page, int pageSize, out int totalRow);
        IEnumerable<Product> Search(string keyWord, int page, int pageSize,string sort, out int totalRow);
        IEnumerable<Product> GetReatedProducts(int id, int top);
        Product GetByID(int ID);
        void SaveChange();
        IEnumerable<Product> GetAllByTagPaging(string tagID, int page, int pageSize, out int totalRow);
    }

    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        IUnitOfWork _unitOfWork;
        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Delete(int ID)
        {
            _productRepository.Delete(ID);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll(new string[] { "ProductCategory" });
        }

        public IEnumerable<Product> GetAll(string Keyword)
        {
            return _productRepository.GetAll(Keyword);
        }

        public IEnumerable<Product> GetAllByCategoryIDPaging(int categoryID, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllByTagPaging(string tagID, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public Product GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetHotProduct(int top)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetLastest(int top)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetReatedProducts(int id, int top)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Search(string keyWord, int page, int pageSize, string sort, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
