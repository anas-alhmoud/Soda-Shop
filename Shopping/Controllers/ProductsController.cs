using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Shopping.Models;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        List<ProductModel> productList = new List<ProductModel>() 
        { 
            new ProductModel(1, "Pepsi", 20.3, "https://images-na.ssl-images-amazon.com/images/I/515Lwr5CyxL.jpg"), 
            new ProductModel(2, "Seven Up", 25.3, "http://cdn.shopify.com/s/files/1/0257/2645/1765/products/seven-up-diet_1200x1200.jpg?v=1601016365"), 
            new ProductModel(3, "Cola", 40.6, "https://germanfoods.eu/media/image/product/2025/lg/coca-cola-can-034.jpg") 
        };
        public IActionResult Index(string color)
        {
            ViewData["color"] = color;
            ViewData["Products"] = productList;
            return View();
        }

        public IActionResult Details(int? id)
        {
            ProductModel p = productList.Find(el => el.Id == id);

            ViewData["Product"] = p;
            return View();
        }

        public IActionResult Random()
        {
            Random r = new Random();

            int id = r.Next(productList[0].Id, productList[productList.Count() - 1].Id + 1);

            ProductModel p = productList.Find(el => el.Id == id);

            ViewData["Product"] = p;
            return View();
        }
    }
}
