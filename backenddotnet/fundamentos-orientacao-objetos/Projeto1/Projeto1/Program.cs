using Projeto1.ContentContext;
using Projeto1.ContentContext.Enums;
using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            var course = new Course();
            course.Title = "Fundamentos do C#";
            course.Level = EcontentLevel.Intermediary;

            Console.WriteLine(course.Id);
            Console.WriteLine(course.Title);
        }
    }
}
