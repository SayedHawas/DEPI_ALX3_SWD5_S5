using Day18LabQuery.Models;
using Microsoft.EntityFrameworkCore;

namespace Day18LabQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using (ADOTestContext db = new ADOTestContext())
            {
                var students = db.Students.AsNoTracking().ToList();
                foreach (var item in students)
                {
                    Console.WriteLine($"Id {item.ID} Name {item.Name}");
                }

                var s = db.Students.Find(5);
                Console.WriteLine($"Status {db.Entry(s).State}");
                s.Name = "Koko";
                Console.WriteLine($"Status {db.Entry(s).State}");


                var m = db.Students.Find(3);
                Console.WriteLine($"Status {db.Entry(m).State}");
                db.Students.Remove(m);
                Console.WriteLine($"Status {db.Entry(m).State}");

                Student NewStudent = new Student() { Name = "Lolo", Class = "123", IsDelete = false, Mark = 90, Subject = "Arabic" };
                Console.WriteLine($"Status {db.Entry(NewStudent).State}");
                db.Students.Add(NewStudent);
                Console.WriteLine($"Status {db.Entry(NewStudent).State}");



                Console.WriteLine(db.ChangeTracker.ToDebugString());

                //db.SaveChanges();


            }
            Console.ReadLine();
        }
    }
}
