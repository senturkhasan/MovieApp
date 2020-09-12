using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;

namespace MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        //{controller}/{action}/{?id}
        //home/index/2
        //sayfaya gelen route verilerini almak istersek;
        //RouteData.Values["controller"]==>home
        //RouteData.Values["action"]==>index
        //RouteData.Values["id"]==>2
        public IViewComponentResult Invoke(){
            if (RouteData.Values["action"].ToString()=="index")//sadece indexte görüntülensin
                 ViewBag.SelectedCategory=RouteData?.Values["id"];//categori seçilmisse..
            return View(CategoryRepository.Categories);
        }
    }
}