using Projeto1.ContentContext;
using Projeto1.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
                Console.WriteLine("------------------------");
            }

            var courses = new List<Course>();

            courses.Add(new Course("Fundamentos OOP", "fundamentos-oop"));
            courses.Add(new Course("Fundamentos C#", "fundamentos-csharp"));
            courses.Add(new Course("Fundamentos ASP.NET", "fundamentos-dotnet"));

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");

            var carrerItem2 = new CareerItem(2, "Aprenda OOP", "", courses[0]);
            var carrerItem = new CareerItem(1, "Comece por aqui", "", courses[1]);
            var carrerItem3 = new CareerItem(3, "Aprenda .NET", "", courses[2]);

            careerDotNet.Items.Add(carrerItem2);
            careerDotNet.Items.Add(carrerItem);
            careerDotNet.Items.Add(carrerItem3);

            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);
                }
            }
        }
    }
}
