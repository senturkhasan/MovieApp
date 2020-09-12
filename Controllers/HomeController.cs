using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using MovieApp.Data;
using System.Linq;

namespace MovieApp.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public IActionResult Index(int ?id)
        {
            //ProductRepository.Movies
            //CategoryRepository.Catogory 2 datayı da göndermek gerekirse ..


            //MovieCategoryModel model=new MovieCategoryModel();
            //model.Categories=CategoryRepository.Categories;
            //model.Movies=MovieRepository.Movies;

            var movies=MovieRepository.Movies;
            if (id!=null){
                 movies=movies.Where(i=>i.CategoryId==id).ToList();   
            }
            return View(movies);
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        
        public IActionResult Details(int id){
          //  MovieCategoryModel  model=new MovieCategoryModel();
           // model.Categories=CategoryRepository.Categories;
            //model.Movie=MovieRepository.GetById(id);
            return View(MovieRepository.GetById(id));
        }
    }
}