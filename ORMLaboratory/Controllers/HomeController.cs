using DapperExtensions;
using Massive;
using MicroDal;
using ORMLaboratory.Models;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORMLaboratory.Controllers
{
    public class HomeController : Controller
    {

        string searchTerm = "nike";

        public ActionResult Index()
        {
            Response.Write("<h1>ORM Laboratory</h1>");

            Response.Write("<h2>Dapper</h2>");
            ExecuteDapper();
            Response.Write("<hr>");

            Response.Write("<h2>PetaPoco</h2>");
            ExecutePetaPoco();
            Response.Write("<hr>");

            Response.Write("<h2>Massive</h2>");
            ExecuteMassive();
            Response.Write("<hr>");

            Response.Write("<h2>ORM Lite (ServiceStack)</h2>");
            ExecuteORMLite();
            Response.Write("<hr>");

            Response.Write("<h2>Simple.Data</h2>");
            ExecuteSimpleData();
            Response.Write("<hr>");

            Response.Write("<h2>MicroDAL</h2>");
            ExecuteMicroDAL();
            Response.Write("<hr>");

            Response.Write("<h2>Entity Framework</h2>");
            ExecuteEntityFramework();
            Response.Write("<hr>");

            return View();
        }

        protected void ExecuteDapper()
        {
            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();

            // Do something
            using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["LabConnectionString"].ConnectionString))
            {
                cn.Open();
                var predicate = Predicates.Field<Product>(f => f.Brand, Operator.Eq, searchTerm);
                IEnumerable<Product> list = cn.GetList<Product>(predicate);
                cn.Close();

                int i = 0;
                string title = String.Empty;
                foreach (var p in list)
                {
                    title += p.Title + " | ";
                    i++;
                }
                //Response.Write("Data: " + title + "<br>");
                Response.Write("Rows: " + i.ToString() + "<br>");
            }

            // Stop timing
            stopwatch.Stop();

            // Write result
            Response.Write(String.Format("Time elapsed: {0}",
                stopwatch.Elapsed));
        }

        protected void ExecutePetaPoco()
        {
            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();

            // Do something
            // Create a PetaPoco database object
            var db = new PetaPoco.Database("LabConnectionString");

            // Show all products    
            IEnumerable<Product> list = db.Query<Product>("SELECT * FROM Product WHERE Brand = '" + searchTerm + "'");

            int i = 0;
            string title = String.Empty;
            foreach (var p in list)
            {
                title += p.Title + " | ";
                i++;
            }
            //Response.Write("Data: " + title + "<br>");
            Response.Write("Rows: " + i.ToString() + "<br>");

            // Stop timing
            stopwatch.Stop();

            // Write result
            Response.Write(String.Format("Time elapsed: {0}",
                stopwatch.Elapsed));
        }

        protected void ExecuteMassive()
        {

            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();

            // Do something

            //important - must be dynamic
            //var tbl = new DynamicModel("BUYOO", tableName: "Product", primaryKeyField: "ProductID");
            dynamic table = new Products();
            var list = table.Find(Brand: searchTerm);

            int i = 0;
            string title = String.Empty;
            foreach (var p in list)
            {
                title += p.Title + " | ";
                i++;
            }
            //Response.Write("Data: " + title + "<br>");
            Response.Write("Rows: " + i.ToString() + "<br>");



            // Stop timing
            stopwatch.Stop();

            // Write result
            Response.Write(String.Format("Time elapsed: {0}",
                stopwatch.Elapsed));


        }

        protected void ExecuteORMLite()
        {
            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();

            // Do something
            var dbFactory = new OrmLiteConnectionFactory(System.Configuration.ConfigurationManager.ConnectionStrings["LabConnectionString"].ConnectionString, SqlServerOrmLiteDialectProvider.Instance);

            // Wrap all code in using statement to not forget about using db.Close()
            using (var db = dbFactory.Open())
            {
                var list = db.Where<Product>(new { Brand = searchTerm });

                int i = 0;
                string title = String.Empty;
                foreach (var p in list)
                {
                    title += p.Title + " | ";
                    i++;
                }
                //Response.Write("Data: " + title + "<br>");
                Response.Write("Rows: " + i.ToString() + "<br>");
            }

            


            // Stop timing
            stopwatch.Stop();

            // Write result
            Response.Write(String.Format("Time elapsed: {0}",
                stopwatch.Elapsed));
        }

        protected void ExecuteSimpleData()
        {

            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();

            // Do something
            var namedDb = Simple.Data.Database.OpenNamedConnection("LabConnectionString");
            var list = namedDb.Product.FindAllByBrand(searchTerm);

            int i = 0;
            string title = String.Empty;
            foreach (var p in list)
            {
                title += p.Title + " | ";
                i++;
            }
            //Response.Write("Data: " + title + "<br>");
            Response.Write("Rows: " + i.ToString() + "<br>");

            // Stop timing
            stopwatch.Stop();

            // Write result
            Response.Write(String.Format("Time elapsed: {0}",
                stopwatch.Elapsed));


        }

        protected void ExecuteMicroDAL()
        {

            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();

            // Do something
            using (var ses = new DataSession("LabConnectionString"))
            {
                var list = ses.Fetch<Product>("SELECT * FROM Product WHERE brand LIKE @brand", searchTerm);

                int i = 0;
                string title = String.Empty;
                foreach (var p in list)
                {
                    title += p.Title + " | ";
                    i++;
                }
                //Response.Write("Data: " + title + "<br>");
                Response.Write("Rows: " + i.ToString() + "<br>");
            }


            // Stop timing
            stopwatch.Stop();

            // Write result
            Response.Write(String.Format("Time elapsed: {0}",
                stopwatch.Elapsed));


        }

        protected void ExecuteEntityFramework()
        {
            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing
            stopwatch.Start();

            // Do something
            var context = new LabEntities();
            IEnumerable<Product> list = context.Product.Where(x => x.Brand == searchTerm);

            int i = 0;
            string title = String.Empty;
            foreach (var p in list)
            {
                title += p.Title + " | ";
                i++;
            }
            //Response.Write("Data: " + title + "<br>");
            Response.Write("Rows: " + i.ToString() + "<br>");


            // Stop timing
            stopwatch.Stop();

            // Write result
            Response.Write(String.Format("Time elapsed: {0}",
                stopwatch.Elapsed));
        }



    }

    public class Products : DynamicModel
    {
        //you don't have to specify the connection - Massive will use the first one it finds in your config
        public Products() : base("LabConnectionString", "Product", "ProductId") { }
    }
}
