using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ghost_T.Data;
using Ghost_T.Models;

namespace Ghost_T.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categorie ctg)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(ctg);
                _context.SaveChanges();
                return PartialView("_Success");
            }
            return PartialView("_Error");
        }


    }
}