using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EF_Example
{
    class Program
    {
        public IServiceProvider containter { get; private set; }

        static void Main(string[] args)
        {
            var p = new Program();
            p.InitializeServices();

            var services = p.containter.GetService<StudentService>();
            services.WriteStudents();
            services.ReadStudents();

        }

        private void InitializeServices()
        {
            const string _ConnectionString = "Host=localhost;Username=user;Password=password123;Database=user;Pooling=true;";

            var services = new ServiceCollection();
            services.AddTransient<StudentService>();
            services.AddEntityFrameworkNpgsql().AddDbContext<StudentContext>(options => options.UseNpgsql(_ConnectionString));

            containter = services.BuildServiceProvider();


        }


    }
}


