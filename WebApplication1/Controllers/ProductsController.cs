using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext context= new ApplicationDbContext();
        public ViewResult Index()
        {
            var products= context.Products.ToList();
            return View(products);
        }
        public ViewResult Create()
        {
            return View();
        }

        public RedirectToActionResult Add(Product requst)
        {
            context.Products.Add(requst);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        public ViewResult Details(int id)
        {
            var products= context.Products.Find(id);
            return View(products);
        }
    }
}
