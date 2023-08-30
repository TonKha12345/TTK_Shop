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
    public interface IProductCategoryService
    {
        void Add(ProductCategory productCategory);
        void Update(ProductCategory productCategory);
        void Delete( int ID );

        IEnumerable<ProductCategory> GetAll();
        IEnumerable<ProductCategory> GetByParentId(int parentID);
        ProductCategory GetByID(int ID);
        void SaveChange();
          
    }
    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._productCategoryRepository = productCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(ProductCategory productCategory)
        {
            _productCategoryRepository.Add(productCategory);
        }

        public void Delete(int ID)
        {
            _productCategoryRepository.Delete(ID);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategoryRepository.GetAll();
        }

        public ProductCategory GetByID(int ID)
        {
            return _productCategoryRepository.GetSingleById(ID);
        }

        public IEnumerable<ProductCategory> GetByParentId(int parentID)
        {
            return _productCategoryRepository.GetByParentId(parentID);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategory productCategory)
        {
            _productCategoryRepository.Update(productCategory);
        }
    }
}
