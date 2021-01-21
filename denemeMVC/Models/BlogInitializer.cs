using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace denemeMVC.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {

            List<Category> categories = new List<Category>()
            {
               new Category(){KategoriAdi="C#"},
               new Category(){KategoriAdi="Asp.net MVC"},
               new Category(){KategoriAdi="Asp.net WebForm"},
               new Category(){KategoriAdi="Windows Form"}

            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);

            }
            context.SaveChanges();

            List<Blog> blogs = new List<Blog>()
            {
                new Blog(){Baslik="C# Delegates Hakkında", Aciklama="Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true, Onay=true,Icerik="Delegates HakkındaDelegates Hakkında",Resim="1.jpg",CategoryId=1 },
                new Blog(){Baslik="C# Delegates Hakkında", Aciklama="Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-7),Anasayfa=false, Onay=true,Icerik="Delegates HakkındaDelegates Hakkında",Resim="2.jpg",CategoryId=2 },
                new Blog(){Baslik="C# List Hakkında", Aciklama="List Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-2),Anasayfa=true, Onay=false,Icerik="List HakkındaList Hakkında",Resim="3.jpg",CategoryId=3 },
                new Blog(){Baslik="C# Delegates Hakkında", Aciklama="Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-3),Anasayfa=false, Onay=true,Icerik="Delegates HakkındaDelegates Hakkında",Resim="4.jpg",CategoryId=4 },
                new Blog(){Baslik="C# Interface Hakkında", Aciklama="Interface Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-5),Anasayfa=true, Onay=true,Icerik="Interface HakkındaInterface Hakkında",Resim="5.jpg",CategoryId=4 }
            };

            foreach (var items in blogs)
            {
                context.Blogs.Add(items);

            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}