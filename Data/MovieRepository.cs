using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;
namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie>_movies=null;
        static MovieRepository()
            {
              _movies=new List<Movie>(){
                    new Movie(){ Id=1,
                                Name="Dark",
                                ShortDecription="Dark",
                                Description="<p>Lenovo V15 Intel Core i7 8565U 12GB 512GB SSD MX110 Freedos 15.6 FHD Taşınabilir Bilgisayar 81YE0090TX tesi hd izle, Çizgi Ötesi 1990 izle, Film, beş tıp öğrencisi, geçmiş trajedilerin karanlık sonuçları hayatlarını tehlikeye atana kadar deneyimlerle deneyler yapmasını konu ediniyor. hdfilmcehennemi2.pw iyi seyirler diler</p>",
                                ImageUrl="dark_crimes.jfif",
                                CategoryId=1 },
                    new Movie(){ Id=2,
                                 Name="Sky",
                                 ShortDecription="Sky",
                                 Description="<p>Lenovo V15 Intel Core i7 8565U 12GB 512GB SSD MX110 Freedos 15.6 FHD Taşınabilir Bilgisayar 81YE0090TX tesi hd izle, Çizgi Ötesi 1990 izle, Film, beş tıp öğrencisi, geçmiş trajedilerin karanlık sonuçları hayatlarını tehlikeye atana kadar deneyimlerle deneyler yapmasını konu ediniyor. hdfilmcehennemi2.pw iyi seyirler diler 2</p>",
                                 ImageUrl="2.jpg",
                                 CategoryId=2 },
                    new Movie(){ Id=3,
                                 Name="A.I",
                                 ShortDecription="A.I",
                                 Description="<p>p etiketiyle yazıldı</p>",
                                 ImageUrl="3.jpg",
                                 CategoryId=1 },
                    new Movie(){ Id=4,
                                 Name="Konak",
                                 ShortDecription="Konak",
                                 Description="<span>span etiketiyle yazıldı</span>",
                                 ImageUrl="4.jfif" ,
                                 CategoryId=3}
                    };  
            }  
        public static List<Movie>Movies{
            get{
                return _movies;
            }
        }   
        public static void AddMovie(Movie entity){
            _movies.Add(entity);
        } 
        public static Movie GetById(int id){
            return _movies.FirstOrDefault(i=>i.Id==id);
        }
    }
}