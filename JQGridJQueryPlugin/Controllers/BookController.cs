using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using LibLibrary;

namespace JQGridJQueryPlugin.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/

        public ActionResult Index()
        {
            return View();
        }

        //[System.Web.Services.WebMethod]
        public string getBookList()
        {
            DataTable dt = null;
           
            string procName = "books_select";
            string[] objName = new string[] { "name", "author", "iscontinued", "cateid" };
            object[] objValue = new object[] { "Hello","Holla",1,1 };
            string[] result = null;
            int number = 1;             // 1 output;
            //dt = DBConnect.getTable(procName, objName, objValue, objType, objSize, number, out result);
            //dt = DBConnect.getTable(procName, objName, objValue, number, out result);
            dt = LibLibrary_.getTable(procName, objName, objValue, number, out result);
            if (result != null && result.Length > 0)
            {
                string str = string.Empty;
                for (int i = 0; i < result.Length; i++)
                {
                    str += result[i] + "=>";
                }
                Console.WriteLine("Value: " + str);
            }

            return JsonConvert.SerializeObject(dt);
        }

        [System.Web.Services.WebMethod]
        public string updateBook(string url)
        {
            string[] arr = url.Split('#');

            short bookId = arr[0] == null || "".Equals(arr[0]) ? (short)-1 : Int16.Parse(arr[0]);
            string name = arr[1];
            string summary = arr[2];
            short pageNumber = Int16.Parse(arr[3]);
            string author = arr[4];
            bool isContinued = arr[5].Equals("0") ? false: true;
            byte cateId = Byte.Parse(arr[6]);

            string procName = string.Empty;
            string[] objName = new string[] { "name", "summary", "pagenumber", "author", "iscontinued", "cateid" , "bookid"};
            object[] objValue = new object[] { name, summary, pageNumber, author, isContinued, cateId, bookId};
            string[] result = null;
            int number = 1;             // 1 output;

            if (bookId == -1)
            {
                // che do them moi du lieu;
                procName = "books_insert"; 
            }
            else 
            {
                // che do sua du lieu;
                procName = "books_update"; 
            }
            LibLibrary_.updateData(procName, objName, objValue, number, out result);
            if (result != null && result.Length == 1)
            {
                return result[0];
            }
            return 0 + "";
        }

        [System.Web.Services.WebMethod]
        public string deleteBook(string url)
        {
            string[] arr = url.Split('#');

            short bookId = Int16.Parse(arr[0]);

            string procName = "books_delete";
            string[] objName = new string[] { "bookid" };
            object[] objValue = new object[] {bookId };
            string[] result = null;
            int number = 1;             // 1 output;

            LibLibrary_.updateData(procName, objName, objValue, number, out result);
            if (result != null && result.Length == 1)
            {
                return result[0];
            }
            return 0 + "";
        }

    }
}
