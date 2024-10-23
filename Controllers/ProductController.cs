using Microsoft.AspNetCore.Mvc;
using Lab8.Models;
using System;
using System.Collections.Generic;

namespace Lab8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Створюємо колекцію продуктів
            List<Product> products = new List<Product>
            {
                new Product { ID = 1, Name = "Laptop", Price = 1200.99m, CreatedDate = DateTime.Now.AddDays(-10) },
                new Product { ID = 2, Name = "Phone", Price = 799.50m, CreatedDate = DateTime.Now.AddDays(-30) },
                new Product { ID = 3, Name = "Tablet", Price = 450.75m, CreatedDate = DateTime.Now.AddDays(-20) }
            };

            // Передаємо колекцію продуктів у представлення
            return View(products);
        }
    }
}
