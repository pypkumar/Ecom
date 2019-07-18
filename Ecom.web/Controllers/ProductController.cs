﻿using Ecom.Entities;
using Ecom.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecom.web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductTable(string Search)
        {
            var products = productsService.GetProducts();
            if(string.IsNullOrEmpty(Search)==false)
            {
                products = products.Where(p =>p.Name !=null && p.Name.ToLower().Contains(Search.ToLower())).ToList();
            }
           
            return PartialView(products);
        }
        [HttpGet]
        public ActionResult Create()

        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            productsService.SaveProduct(product);


            return RedirectToAction("ProductTable");
        }
    }
}