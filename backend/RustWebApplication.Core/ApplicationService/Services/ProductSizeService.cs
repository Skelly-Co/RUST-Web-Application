﻿using System;
using System.Collections.Generic;
using RustWebApplication.Core.DomainService;
using RustWebApplication.Core.Entity;

namespace RustWebApplication.Core.ApplicationService.Services
{
    public class ProductSizeService : IProductSizeService
    {
        private readonly IProductSizeRepository _productSizeRepository;

        public ProductSizeService(IProductSizeRepository productSizeRepository)
        {
            _productSizeRepository = productSizeRepository;
        }

        public ProductSize Create(ProductSize newProductSize)
        {
            throw new NotImplementedException();
        }

        public ProductSize Delete(int productSizeId)
        {
            throw new NotImplementedException();
        }

        public ProductSize Read(int productSizeId)
        {
            throw new NotImplementedException();
        }

        public List<ProductSize> ReadAll()
        {
            throw new NotImplementedException();
        }

        public ProductSize Update(ProductSize updatedProductSize)
        {
            throw new NotImplementedException();
        }
    }
}
