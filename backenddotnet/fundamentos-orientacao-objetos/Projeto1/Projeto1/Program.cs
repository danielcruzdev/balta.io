using Projeto1.ContentContext;
using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            var course = new Course();
            course.Title = "Fundamentos do C#";

            Console.WriteLine(course.Title);
        }
    }
}
