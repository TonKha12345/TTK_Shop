using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TTK_Shop.Model.Models;
using TTK_Shop.Wed.Models;

namespace TTK_Shop.Wed.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateProduct(this Product product, ProductViewModel productViewModel)
        {
            product.ID = productViewModel.ID;
            product.Name = productViewModel.Name;
            product.Alias = productViewModel.Alias;
            product.CategoryID = productViewModel.CategoryID;
            product.Image = productViewModel.Image;
            product.MoreImage = productViewModel.MoreImage;
            product.Description = productViewModel.Description;
            product.Content = productViewModel.Content;
            product.Price = productViewModel.Price;
            product.Promotion = productViewModel.Promotion; 
            product.Warranty = productViewModel.Warranty;
            product.HomeFlag = productViewModel.HomeFlag; 
            product.HotFlag = productViewModel.HotFlag; 
            product.ViewCount = productViewModel.ViewCount; 
            product.CreateDate = productViewModel.CreateDate;
            product.CreateBy = productViewModel.CreateBy;
            product.UpdateDate = productViewModel.UpdateDate;
            product.UpdateBy = productViewModel.UpdateBy;
            product.MetaKeyword = productViewModel.MetaKeyword;
            product.MetaDscription = productViewModel.MetaDscription;
            product.Status = productViewModel.Status;
        }

        public static void UpdateProductCategory(this ProductCategory productCategory, ProductCategoryViewModel productCategoryViewModel)
        {
            productCategory.ID = productCategoryViewModel.ID;
            productCategory.Name = productCategoryViewModel.Name;
            productCategory.Alias = productCategoryViewModel.Alias;
            productCategory.ParentID = productCategoryViewModel.ParentID;
            productCategory.Image = productCategoryViewModel.Image;
            productCategory.Description = productCategoryViewModel.Description;
            productCategory.DisplayOrder = productCategoryViewModel.DisplayOrder;
            productCategory.HomeFlag = productCategoryViewModel.HomeFlag;
            productCategory.CreateDate = productCategoryViewModel.CreateDate;
            productCategory.CreateBy = productCategoryViewModel.CreateBy;
            productCategory.UpdateDate = productCategoryViewModel.UpdateDate;
            productCategory.UpdateBy = productCategoryViewModel.UpdateBy;
            productCategory.MetaKeyword = productCategoryViewModel.MetaKeyword;
            productCategory.MetaDscription = productCategoryViewModel.MetaDscription;
            productCategory.Status = productCategoryViewModel.Status;
        }
    }
}