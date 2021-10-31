using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Plagecon.Models.Interfaces;
using Plagecon.Models;

namespace Plagecon.Controllers
{

    /*
     * basicamente este é um exemplo em que construímos um controller e a partir desse
     * controller criamos um model e view
     * O view usa o model criado pelo controller para renderizar o HTML e nos dar
     * 
     * 
     */ 
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;

        public BlogController( IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        //esse action é responsável pela criação do nosso model e view
        public IActionResult Index()
        {
            //criação do model
            BlogPosts blog = _blogRepository.GetPostByID(2);

            ViewData["Title"] = "Title of my blog";
            ViewData["BlogData"] = blog;
            return View();

        }
    }
}
