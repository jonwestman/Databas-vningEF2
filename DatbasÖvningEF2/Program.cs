using DatbasÖvningEF2.Data;
using DatbasÖvningEF2.Model;

namespace DatbasÖvningEF2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using LedighetDbContext ledighetDbContext= new LedighetDbContext();

            VacayTable vacayTable = new VacayTable();
            //{
            //    Personel = "Anton Antonsson",
            //    Date = DateTime.Now,
            //    TypeOfVacay = "Semester"
            //};
            //VacayTable vacayTable2 = new VacayTable()
            //{
            //    Personel =  "Sven Svensson",
            //    Date= DateTime.Now,
            //    TypeOfVacay = "Höstlov"
            //};
            //VacayTable vacayTable3 = new VacayTable()
            //{
            //    Personel = "Paul Paulsson",
            //    Date = DateTime.Now,
            //    TypeOfVacay = "Jullov"
            //};


            //ledighetDbContext.Add(vacayTable);
            //ledighetDbContext.Add(vacayTable2);
            //ledighetDbContext.Add(vacayTable3);
            //ledighetDbContext.SaveChanges();

            //leta efter specifik ledighetstyp
            //var myVacation = from Vacay in ledighetDbContext.VacayTables
            //                 where Vacay.TypeOfVacay == "Höstlov"
            //                 select Vacay;

            //foreach (var item in myVacation)
            //{
            //    Console.WriteLine($"{item.Personel}\n{item.TypeOfVacay}\n{item.Date}");
            //    Console.WriteLine(new string('-', (30)));
            //}

            //Hämta ut alla ledighetstyper
            var myVacation2 = from Vacay in ledighetDbContext.VacayTables
                             select Vacay.TypeOfVacay;

            foreach (var item in myVacation2)
            {
                Console.WriteLine($"{item}");
                Console.WriteLine(new string('-', (30)));
            }
        }
    }
}