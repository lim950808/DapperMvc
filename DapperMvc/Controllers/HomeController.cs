using DapperMvc.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DapperMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Friend  
        public ActionResult Index()
        {
            List<Friend> FriendList = new List<Friend>();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["friendConnection"].ConnectionString))
            {

                FriendList = db.Query<Friend>("Select * From tblFriends").ToList();
            }
            return View(FriendList);
        }
    }
}