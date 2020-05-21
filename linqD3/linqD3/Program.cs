using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqD3
{
    class Program
    {
        static void Main(string[] args)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();

            //MarketDataConText db = new MarketDataConText();
            //var query = from c in db.Categories
            //            select c;
            //foreach (var category in query)
            //    Console.WriteLine(category.ID + " " +category.Name);
            //Console.ReadLine();
            ////--------------------------------------------------------------
            //3
            //Category C1 = new Category()
            //{
            //    Name = "New Category_Milk",
            //    ID=8,
            //};
            //db.Categories.InsertOnSubmit(C1);
            ////db.SubmitChanges();



            //Category C2 = new Category()
            //{
            //    Name = "New Category_Water",
            //    ID =12
            //};
            //db.Categories.InsertOnSubmit(C2);


            ////--------------------------------------------------------------
            //4
            //Product P1 = new Product
            //{
            //    Name = "B5iro",
            //    Price=30,
            //    ID=18,
            //    Category = C1,


            //};
            //db.Products.InsertOnSubmit(P1);
            //Product P2 = new Product
            //{
            //    Name = "ELMara3y",
            //    Price = 50,
            //    ID=20,
            //    Category = C2
            //};
            //db.Products.InsertOnSubmit(P2);
            //db.SubmitChanges();
            //--------------------------------------------------------------------------
            //7
            var SelectedCategory = db.Categories.OrderByDescending(i => i.ID).FirstOrDefault();
            if (SelectedCategory != null)

            {
                SelectedCategory.Name = "New Name";
                db.SubmitChanges();

            }
            //----------------------------------------------------------------------------

            // 5 ,6
            //order O1 = new order()
            //{
            //    ID =11,
            //    Customer_Name = "Ahmed",
            //    Date = DateTime.Now
            //};
            //db.orders.InsertOnSubmit(O1);
            //db.SubmitChanges();

            //var query = from c in db.Products
            //            select c;
            //foreach (var product in query)
            //    Console.WriteLine(product.Name );
            //var X = Console.ReadLine();

           

            //var p = db.Products.FirstOrDefault(i => i.Name == X);


            //OrderDetial O2 = new OrderDetial
            //{
            //    ID = 30,
            //    Product=p,
            //    order=O1,
            //    Quantity = 15,
            //    Discount = 5

            //};




            //    db.OrderDetials.InsertOnSubmit(O2);
            //    db.SubmitChanges();


            //var total = O2.Product.Price * O2.Quantity;
            //Console.WriteLine("order Created Successfuly"+total);


            //--------------------------------------------------------------------------
            //8
        

            var toDeletedList =
                db.OrderDetials
                .Where(i => i.ID ==11);

            db.OrderDetials.DeleteAllOnSubmit(toDeletedList);
            db.SubmitChanges();



            var toDeletedList2 =
               db.orders
               .Where(i => i.ID == 11);
            db.orders.DeleteAllOnSubmit(toDeletedList2);
            db.SubmitChanges();







            Console.ReadLine();
        }
    }
}


