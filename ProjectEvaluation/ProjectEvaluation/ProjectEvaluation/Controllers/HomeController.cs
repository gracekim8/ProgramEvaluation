using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using ProjectEvaluation.Models;
using System.Diagnostics;
using System;
using System.Security.Cryptography;

namespace ProjectEvaluation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CoursePlan()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginSubmit(LoginModel loginUser)
        {

            string un = loginUser.Username;
            string pw = loginUser.Password;
            bool hasAccess = false;

            string server = "localhost"; 
            string database = "ProgramEval"; 
            string username = "root"; 
            string password = "GracePW"; 

            string connstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            string query;

            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd;
            MySqlDataReader reader;

            conn.Open();
            query = "select Stu_Password from student where Stu_Password = @Stu_Password and Stu_Username = @Stu_Username";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Stu_Username", loginUser.Username);
            cmd.Parameters.AddWithValue("@Stu_Password", loginUser.Password);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (pw == reader.GetString(0))
                {
                    loginUser.Username = un;
                    loginUser.Password = pw;
                    setName(loginUser);
                    setProgram(loginUser);
                    setMajor(loginUser);
                    setID(loginUser);
                    hasAccess = true;
                }
            }

            conn.Close();

            if (hasAccess == true)
            {
                
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult setName(LoginModel loginUser)
        {
            string un = loginUser.Username;
            
            string server = "localhost"; 
            string database = "ProgramEval"; 
            string username = "root";
            string password = "GracePW";

            string connstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            string query;

            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd;
            MySqlDataReader reader;

            conn.Open();
            query = "select Stu_Name from student where Stu_Username = @Stu_Username";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Stu_Username", un);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               UserModel.Name = reader.GetString(0);
            }

            return View("Index");
        }

        public ActionResult setProgram(LoginModel loginUser)
        {
            string un = loginUser.Username;

            string server = "localhost"; 
            string database = "ProgramEval"; 
            string username = "root"; 
            string password = "GracePW"; 

            string connstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            string query;

            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd;
            MySqlDataReader reader;

            conn.Open();
            query = "select Stu_Degree from student where Stu_Username = @Stu_Username";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Stu_Username", un);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UserModel.Program = reader.GetString(0);
            }

            return View("Index");
        }

        public ActionResult setMajor(LoginModel loginUser)
        {
            string un = loginUser.Username;

            string server = "localhost"; 
            string database = "ProgramEval"; 
            string username = "root"; 
            string password = "GracePW"; 

            string connstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            string query;

            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd;
            MySqlDataReader reader;

            conn.Open();
            query = "select Stu_Major from student where Stu_Username = @Stu_Username";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Stu_Username", un);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UserModel.Major = reader.GetString(0);
            }

            return View("Index");
        }

        public ActionResult setID(LoginModel loginUser)
        {
            string un = loginUser.Username;

            string server = "localhost";
            string database = "ProgramEval";
            string username = "root";
            string password = "GracePW";

            string connstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            string query;

            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand cmd;
            MySqlDataReader reader;

            conn.Open();
            query = "select Stu_ID from student where Stu_Username = @Stu_Username";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Stu_Username", un);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UserModel.ID = reader.GetString(0);
            }

            return View("Index");
        }


        public IActionResult ForgotPW()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}