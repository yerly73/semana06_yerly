using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBusiness
    {
        public List<Product> getProducts() { 
            DProduct product = new DProduct();
            var dataProduct = product.getProducts();
            return dataProduct;
        }

        public List<Product> getProductsByName(string name)
        {
            DProduct dataProduct = new DProduct();
            var product = dataProduct.getProducts();
            var result = product.Where(x => x.name == name).ToList();
            return result;
        }
    }
}
