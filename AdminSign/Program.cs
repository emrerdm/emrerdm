using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

 
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdminSign
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
                var host = BuildWebHost(args);

                host.Run();
            }

            // Tools will use this to get application services
            public static IWebHost BuildWebHost(string[] args) =>
                new WebHostBuilder()
                    .UseKestrel()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();

            //using (var ctx = new Context())
            //{
            //    var stud = new Category() { CategoryName = "Bill" };

            //    ctx.Category.Add(stud);
            //    ctx.SaveChanges();
            //}
            //CreateWebHostBuilder(args).Build().Run();
            //Context Data = new Context();
            // Data.Category.Add(new Category
            // {
            //     CategoryName = "Test1",
            //     Description = "Test2",
            //     Picture="Test3"
            // });
            //Data.SaveChanges();
            //Context Veri = new Context();
            //Category ornek = Veri.Category.FirstOrDefault(o => o.CategoryID == 7);
            //ornek.CategoryName = "Test1";
            //ornek.Description = "Test2";
            //ornek.Picture = "Test3";
            //Veri.SaveChanges();
        }

        
    }

