using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using ProjectEvaluation.Models;

namespace ProjectEvaluation.Controllers
{
    public class PlanController : Controller
    {
        public IActionResult CoursePlan()
        {
            return View();
        }

        public IActionResult setPlan()
        {
            setSem1();
            setSem2();
            setSem3();
            setSem4();
            setSem5();
            setSem6();
            setSem7();
            setSem8();
            return RedirectToAction("CoursePlan", "Plan");

        }

        public ActionResult setSem1()
        {
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
            query = "select Co_code, Co_Name, Co_Credits from Plan where Term like '%(1)%'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            List<string> Codes = new List<string>();
            List<string> Names = new List<string>();
            List<int> Credits = new List<int>();
            int Count = 0;

            while (reader.Read())
            {
                Codes.Add(Convert.ToString(reader[0]));
                Names.Add(Convert.ToString(reader[1]));
                Credits.Add(Convert.ToInt32(reader[2]));
                Count++;
            }

            PlanModel.Sem1Codes = Codes;
            PlanModel.Sem1Names = Names;
            PlanModel.Sem1Credits = Credits;
            PlanModel.Sem1Count = Count;


            conn.Close();


            return RedirectToAction("CoursePlan", "Plan");
        }

        public ActionResult setSem2()
        {
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
            query = "select Co_code, Co_Name, Co_Credits from Plan where Term like '%(2)%'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            List<string> Codes = new List<string>();
            List<string> Names = new List<string>();
            List<int> Credits = new List<int>();
            int Count = 0;

            while (reader.Read())
            {
                Codes.Add(Convert.ToString(reader[0]));
                Names.Add(Convert.ToString(reader[1]));
                Credits.Add(Convert.ToInt32(reader[2]));
                Count++;
            }

            PlanModel.Sem2Codes = Codes;
            PlanModel.Sem2Names = Names;
            PlanModel.Sem2Credits = Credits;
            PlanModel.Sem2Count = Count;


            conn.Close();


            return RedirectToAction("CoursePlan", "Plan");
        }

        public ActionResult setSem3()
        {
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
            query = "select Co_code, Co_Name, Co_Credits from Plan where Term like '%(3)%'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            List<string> Codes = new List<string>();
            List<string> Names = new List<string>();
            List<int> Credits = new List<int>();
            int Count = 0;

            while (reader.Read())
            {
                Codes.Add(Convert.ToString(reader[0]));
                Names.Add(Convert.ToString(reader[1]));
                Credits.Add(Convert.ToInt32(reader[2]));
                Count++;
            }

            PlanModel.Sem3Codes = Codes;
            PlanModel.Sem3Names = Names;
            PlanModel.Sem3Credits = Credits;
            PlanModel.Sem3Count = Count;


            conn.Close();


            return RedirectToAction("CoursePlan", "Plan");
        }

        public ActionResult setSem4()
        {
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
            query = "select Co_code, Co_Name, Co_Credits from Plan where Term like '%(4)%'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            List<string> Codes = new List<string>();
            List<string> Names = new List<string>();
            List<int> Credits = new List<int>();
            int Count = 0;

            while (reader.Read())
            {
                Codes.Add(Convert.ToString(reader[0]));
                Names.Add(Convert.ToString(reader[1]));
                Credits.Add(Convert.ToInt32(reader[2]));
                Count++;
            }

            PlanModel.Sem4Codes = Codes;
            PlanModel.Sem4Names = Names;
            PlanModel.Sem4Credits = Credits;
            PlanModel.Sem4Count = Count;


            conn.Close();


            return RedirectToAction("CoursePlan", "Plan");
        }

        public ActionResult setSem5()
        {
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
            query = "select Co_code, Co_Name, Co_Credits from Plan where Term like '%(5)%'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            List<string> Codes = new List<string>();
            List<string> Names = new List<string>();
            List<int> Credits = new List<int>();
            int Count = 0;

            while (reader.Read())
            {
                Codes.Add(Convert.ToString(reader[0]));
                Names.Add(Convert.ToString(reader[1]));
                Credits.Add(Convert.ToInt32(reader[2]));
                Count++;
            }

            PlanModel.Sem5Codes = Codes;
            PlanModel.Sem5Names = Names;
            PlanModel.Sem5Credits = Credits;
            PlanModel.Sem5Count = Count;


            conn.Close();


            return RedirectToAction("CoursePlan", "Plan");
        }

        public ActionResult setSem6()
        {
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
            query = "select Co_code, Co_Name, Co_Credits from Plan where Term like '%(6)%'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            List<string> Codes = new List<string>();
            List<string> Names = new List<string>();
            List<int> Credits = new List<int>();
            int Count = 0;

            while (reader.Read())
            {
                Codes.Add(Convert.ToString(reader[0]));
                Names.Add(Convert.ToString(reader[1]));
                Credits.Add(Convert.ToInt32(reader[2]));
                Count++;
            }

            PlanModel.Sem6Codes = Codes;
            PlanModel.Sem6Names = Names;
            PlanModel.Sem6Credits = Credits;
            PlanModel.Sem6Count = Count;


            conn.Close();


            return RedirectToAction("CoursePlan", "Plan");
        }

        public ActionResult setSem7()
        {
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
            query = "select Co_code, Co_Name, Co_Credits from Plan where Term like '%(7)%'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            List<string> Codes = new List<string>();
            List<string> Names = new List<string>();
            List<int> Credits = new List<int>();
            int Count = 0;

            while (reader.Read())
            {
                Codes.Add(Convert.ToString(reader[0]));
                Names.Add(Convert.ToString(reader[1]));
                Credits.Add(Convert.ToInt32(reader[2]));
                Count++;
            }

            PlanModel.Sem7Codes = Codes;
            PlanModel.Sem7Names = Names;
            PlanModel.Sem7Credits = Credits;
            PlanModel.Sem7Count = Count;


            conn.Close();


            return RedirectToAction("CoursePlan", "Plan");
        }

        public ActionResult setSem8()
        {
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
            query = "select Co_code, Co_Name, Co_Credits from Plan where Term like '%(8)%'";
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();

            List<string> Codes = new List<string>();
            List<string> Names = new List<string>();
            List<int> Credits = new List<int>();
            int Count = 0;

            while (reader.Read())
            {
                Codes.Add(Convert.ToString(reader[0]));
                Names.Add(Convert.ToString(reader[1]));
                Credits.Add(Convert.ToInt32(reader[2]));
                Count++;
            }

            PlanModel.Sem8Codes = Codes;
            PlanModel.Sem8Names = Names;
            PlanModel.Sem8Credits = Credits;
            PlanModel.Sem8Count = Count;


            conn.Close();


            return RedirectToAction("CoursePlan", "Plan");
        }
    }
}
