using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAppTask02.Models;

public class ProductsController : Controller
{
    private static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Corek", Description = "Ev coreyi ", Price = 1, Discount = 1 },
        new Product { Id = 2, Name = "Colpa ", Description = "Kend colpasi ", Price = 15, Discount = 10},
        new Product { Id = 3, Name = "Yumurta ", Description = "20- lik yumurta (toyuq yumurtasi)", Price = 30, Discount = 0},
        new Product { Id = 4, Name = "Et", Description = "Mal eti", Price = 40, Discount = 0},
        new Product { Id = 5, Name = "Sobranie castre", Description ="Siqaret", Price = 5, Discount = 0},
        new Product { Id = 6, Name = " Sobranie blue", Description = "siqaret", Price = 6, Discount = 0},
        new Product { Id = 7, Name = "Sobranie White", Description = "siqaret", Price = 7, Discount = 0},
        new Product { Id = 8, Name = "Marlbro", Description = "Blue", Price = 8, Discount = 0},
        new Product { Id = 9, Name = "Camel", Description = "Yellow", Price = 9, Discount = 0},
        new Product { Id = 10, Name = "Camel", Description = "Blue", Price = 9, Discount = 30}
    };


    public IActionResult Index()
    {
        return View(products);
    }

    public IActionResult Details(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        return View(product);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        product.Id = products.Count > 0 ? products.Max(p => p.Id) + 1 : 1;
        products.Add(product);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        return View(product);
    }

    [HttpPost]
    public IActionResult Edit(int id, Product updatedProduct)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        product.Name = updatedProduct.Name;
        product.Description = updatedProduct.Description;
        product.Price = updatedProduct.Price;
        product.Discount = updatedProduct.Discount;
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        products.Remove(product);
        return Ok();
    }

}
