using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plagecon.Models;
using Plagecon.Models.Interfaces;
using Plagecon.Models.Repo;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Plagecon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;
        private readonly IBlogRepository _blogRepo;
        

        public HomeController(ILogger<HomeController> logger, IConfiguration config, IBlogRepository blogRepository )
        {
            _logger = logger;
            _config = config;
            _blogRepo = blogRepository;   
        }

        public IActionResult Index()
        {
            return View();
            //return  _blogRepo.GetPostByID(2).Title;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

/*namespace Plagecon.NtierApp
{
    ////Decoupling Layer
    //public interface IBlogDataAccess
    //{
    //    string GetBlogTitleById(int id);
    //}

    //public class BlogBusinessLogic
    //{
    //    IBlogDataAccess _blogDataAccess;


    //    //business layer code snippet
    //    public BlogBusinessLogic(IBlogDataAccess blogBusinessLogic)
    //    {
    //        _blogDataAccess = blogBusinessLogic;
    //    }

    //    public string GetBlogTitleById(int id)
    //    {
    //        return _blogDataAccess.GetBlogTitleById(id);
    //    }
    //}




    ////data acess layer code snippet
    //public class BlogDataAccess : IBlogDataAccess
    //{
    //    public string GetBlogTitleById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}*/
   