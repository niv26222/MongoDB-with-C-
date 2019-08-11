using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MongoCRUD db = new MongoCRUD("AddressBook");

            //PersonModel person = new PersonModel()
            //{
            //    FirstName = "Joe",
            //    LastName = "smith",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "101 Oak Street",
            //        city = "Scranton",
            //        state = "PA",
            //        ZipCode = "18512"
            //    }

            //};

            //db.InsertRecord("Users", person);


            var recs = db.LoadRecords<NameModel>("Users");


            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.FirstName } {rec.LastName}");

                Console.WriteLine();
            }


            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{rec.Id}: {rec.FirstName } {rec.LastName}");

            //    if (rec.PrimaryAddress != null)
            //    {
            //        Console.WriteLine(rec.PrimaryAddress.city);
            //    }
            //    Console.WriteLine();
            //}


            //var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("db57d0b5-6740-487b-9d37-33057d4ee2d3"));

            //oneRec.DateOfBirth = new DateTime(1982, 10, 31, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord("Users", oneRec.Id, oneRec);

            //db.DeleteRecord<PersonModel>("Users", oneRec.Id);

            Console.ReadLine();
        }
    }

}
