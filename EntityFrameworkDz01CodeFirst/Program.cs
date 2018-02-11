using EntityFrameworkDz01CodeFirst.Model;
using System;

namespace EntityFrameworkDz01CodeFirst
{
    class Program
    {
        static McsDB db = new McsDB();

        static void Main(string[] args)
        {
            foreach (var item in db.TablesModel)
            {
                Console.WriteLine("intModelID: {0}", item.intModelID);
                Console.WriteLine("intManufacturerID: {0}", item.intManufacturerID);
                Console.WriteLine("intSMCSFamily: {0}", item.intSMCSFamilyID);
                Console.WriteLine("strName: {0}", item.strName);
                Console.WriteLine("strImage: {0}", item.strImage);
            }



            //TablesModel tm = new TablesModel();
            //tm.intSMCSFamilyID = 100;
            //tm.strImage = "img.jpeg";
            //tm.strName = "ASDF-16";

            //db.TablesModel.Add(tm);
            //db.SaveChanges();
            //Console.WriteLine("Объекты успешно сохранены");
        }
    }
}
