using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TTK_Shop.Data.Repositories;
using TTK_Shop.Model.Models;
using TTK_Shop.Service;
using TTK_Shop.Wed.Infrastructure.Core;
using TTK_Shop.Wed.Models;

namespace TTK_Shop.Wed.API
{
    [RoutePrefix("api/productcategory")]
    public class ProductCategoryController : ApiControllerBase
    {
        private IProductCategoryService _productCategoryService;
        public ProductCategoryController(IErrorService errorService, IProductCategoryService productCategoryService) : base(errorService)
        {
            this._productCategoryService = productCategoryService;
        }

        [Route("GetAll")]
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var model = _productCategoryService.GetAll();
                var responseData = Mapper.Map<List<ProductCategoryViewModel>>(model);
                var response = request.CreateResponse(HttpStatusCode.OK, responseData);
                return response;

            });
        }

        //public HttpResponseMessage Put(HttpRequestMessage request)
        //{
        //    return CreateHttpResponse(request, () =>
        //    {
        //        var listCategory = _productCategoryService.GetAll();
        //        HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listCategory);
        //        return response;
        //    });
        //}
    }
}