using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ghost_T.Data;
using Ghost_T.Models;
using Ghost_T.DTO;
using Microsoft.AspNetCore.Hosting;
using System.Data.Entity;
using Ghost_T.Services;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MyEcommerceAdmin.Controllers;
using MyEcommerceAdmin.Models;

namespace Ghost_T.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly host host;

        public ProductsController(IWebHostEnvironment _webHostEnvironment, ApplicationDbContext applicationDbContext)
        {
            this.hostEnvironment = _webHostEnvironment;
            host = new host(hostEnvironment);
            db = applicationDbContext;
        }

        public ActionResult Create()
        {
          //  ViewBag.supplierList = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            ViewBag.categoryList = new SelectList(db.Categories, "CategoryID", "Name");
            ViewBag.SubCategoryList = new SelectList(db.SubCategories, "SubCategoryID", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product_dto pvm)
        {

            if (ModelState.IsValid)
            {
                //if (pvm.Picture != null)
                //{
                    //string filePath = Path.Combine("~/Images", Guid.NewGuid().ToString() + Path.GetExtension(pvm.PicturePath));
              //    pvm.Picture.SaveAs(Server.MapPath(filePath));

                    Product p = new Product
                    {
                        ID = pvm.ProductID,
                        Name = pvm.Name,
                        SupplierID = pvm.SupplierID,
                        CategoryID = pvm.CategoryID,
                        SubCategoryID = pvm.SubCategoryID,
                        UnitPrice = pvm.UnitPrice,
                        OldPrice = pvm.OldPrice,
                        Discount = pvm.Discount,
                        UnitInStock = pvm.UnitInStock,
                        ProductAvailable = pvm.ProductAvailable,
                        ShortDescription = pvm.ShortDescription,
                        Note = pvm.Note,
                        PicturePath = host.UploadFile(pvm.PicturePath, "images")
                    };
                    db.Products.Add(p);
                    db.SaveChanges();
                return RedirectToAction(nameof(Index));
                //}
            }
            //ViewBag.supplierList = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            //ViewBag.categoryList = new SelectList(db.Suppliers, "CategoryID", "Name");
            //ViewBag.SubCategoryList = new SelectList(db.Suppliers, "SubCategoryID", "Name");
            return RedirectToAction(nameof(Error));
        }




        // EDIT: Product


        public ActionResult Edit(int id)
        {
            Product p = db.Products.Find(id);

            var pvm = new Product
            {
                ID = p.ID,
                Name = p.Name,
                SupplierID = p.SupplierID,
                CategoryID = p.CategoryID,
                SubCategoryID = p.SubCategoryID,
                UnitPrice = p.UnitPrice,
                OldPrice = p.OldPrice,
                Discount = p.Discount,
                UnitInStock = p.UnitInStock,
                ProductAvailable = p.ProductAvailable,
                ShortDescription = p.ShortDescription,
                Note = p.Note,
                PicturePath = p.PicturePath

            };
          //  ViewBag.supplierList = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            ViewBag.categoryList = new SelectList(db.Categories, "CategoryID", "Name");
            ViewBag.SubCategoryList = new SelectList(db.SubCategories, "SubCategoryID", "Name");
            return View(pvm);
        }

        [HttpPost]

        public ActionResult Edit(Product_dto pvm)
        {

            if (ModelState.IsValid)
            {
                if (pvm.PicturePath != null)
                {

                    Product p = new Product
                    {
                        ID = pvm.ProductID,
                        Name = pvm.Name,
                        SupplierID = pvm.SupplierID,
                        CategoryID = pvm.CategoryID,
                        SubCategoryID = pvm.SubCategoryID,
                        UnitPrice = pvm.UnitPrice,
                        OldPrice = pvm.OldPrice,
                        Discount = pvm.Discount,
                        UnitInStock = pvm.UnitInStock,
                        ProductAvailable = pvm.ProductAvailable,
                        ShortDescription = pvm.ShortDescription,
                        Note = pvm.Note,
                        PicturePath = host.UploadFile(pvm.PicturePath, "images")
                    };
                    db.Entry(p).State = (EntityState)System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    Product p = new Product
                    {
                        ID = pvm.ProductID,
                        Name = pvm.Name,
                        SupplierID = pvm.SupplierID,
                        CategoryID = pvm.CategoryID,
                        SubCategoryID = pvm.SubCategoryID,
                        UnitPrice = pvm.UnitPrice,
                        OldPrice = pvm.OldPrice,
                        Discount = pvm.Discount,
                        UnitInStock = pvm.UnitInStock,
                        ProductAvailable = pvm.ProductAvailable,
                        ShortDescription = pvm.ShortDescription,
                        Note = pvm.Note,
                        PicturePath = host.UploadFile(pvm.PicturePath, "images")
                    };
                    db.Entry(p).State = (EntityState)System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            //ViewBag.supplierList = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            ViewBag.categoryList = new SelectList(db.Categories, "CategoryID", "Name");
            ViewBag.SubCategoryList = new SelectList(db.SubCategories, "SubCategoryID", "Name");
            return PartialView(pvm);
        }


        // DETAILS: Product
        public ActionResult Details(int id)
        {
            Product p = db.Products.Find(id);

            var pvm = new Product
            {
                ID = p.ID,
                Name = p.Name,
                SupplierID = p.SupplierID,
                CategoryID = p.CategoryID,
                SubCategoryID = p.SubCategoryID,
                UnitPrice = p.UnitPrice,
                OldPrice = p.OldPrice,
                Discount = p.Discount,
                UnitInStock = p.UnitInStock,
                ProductAvailable = p.ProductAvailable,
                ShortDescription = p.ShortDescription,
                Note = p.Note,
              //  PicturePath = host.UploadFile(p.PicturePath, "images")

            };
           // ViewBag.supplierList = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            ViewBag.categoryList = new SelectList(db.Categories, "CategoryID", "Name");
            ViewBag.SubCategoryList = new SelectList(db.SubCategories, "SubCategoryID", "Name");
            return View(pvm);
        }

        [HttpPost]

        public ActionResult Details(Product_dto pvm)
        {

            if (ModelState.IsValid)
            {
              //  string filePath = pvm.PicturePath;
                if (pvm.PicturePath != null)
                {
                //    filePath = Path.Combine("~/Images", Guid.NewGuid().ToString() + Path.GetExtension(pvm.Picture.FileName));
                  //  pvm.PicturePath.SaveAs(Server.MapPath(filePath));

                    Product p = new Product
                    {
                        ID = pvm.ProductID,
                        Name = pvm.Name,
                        SupplierID = pvm.SupplierID,
                        CategoryID = pvm.CategoryID,
                        SubCategoryID = pvm.SubCategoryID,
                        UnitPrice = pvm.UnitPrice,
                        OldPrice = pvm.OldPrice,
                        Discount = pvm.Discount,
                        UnitInStock = pvm.UnitInStock,
                        ProductAvailable = pvm.ProductAvailable,
                        ShortDescription = pvm.ShortDescription,
                        Note = pvm.Note,
                        PicturePath = host.UploadFile(pvm.PicturePath, "images")
                    };
                    db.Entry(p).State = (EntityState)System.Data.Entity.EntityState.Unchanged;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    Product p = new Product
                    {
                        ID = pvm.ProductID,
                        Name = pvm.Name,
                        SupplierID = pvm.SupplierID,
                        CategoryID = pvm.CategoryID,
                        SubCategoryID = pvm.SubCategoryID,
                        UnitPrice = pvm.UnitPrice,
                        OldPrice = pvm.OldPrice,
                        Discount = pvm.Discount,
                        UnitInStock = pvm.UnitInStock,
                        ProductAvailable = pvm.ProductAvailable,
                        ShortDescription = pvm.ShortDescription,
                        Note = pvm.Note,
                        PicturePath = host.UploadFile(pvm.PicturePath, "images")
                    };
                    db.Entry(p).State = (EntityState)System.Data.Entity.EntityState.Unchanged;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
           // ViewBag.supplierList = new SelectList(db.Suppliers, "SupplierID", "CompanyName");
            ViewBag.categoryList = new SelectList(db.Categories, "CategoryID", "Name");
            ViewBag.SubCategoryList = new SelectList(db.SubCategories, "SubCategoryID", "Name");
            return PartialView(pvm);
        }


        // DELETE: Product

        public ActionResult Delete(int? id)
        {
           
            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            //Product product = db.Products.Find(id);
            //string file_name = product.PicturePath;
            //string path = Server.MapPath(file_name);
            //FileInfo file = new FileInfo(path);
            //if (file.Exists)
            //{
            //    file.Delete();
            //}
            //db.Products.Remove(product);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}