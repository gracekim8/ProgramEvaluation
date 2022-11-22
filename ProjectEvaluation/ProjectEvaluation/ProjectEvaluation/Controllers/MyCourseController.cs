using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using ProjectEvaluation.Models;

namespace ProjectEvaluation.Controllers
{
    public class MyCourseController : Controller
    {
        public IActionResult MyCourses()
        {
            return View();
        }

        public IActionResult setCourses()
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
            query = "select Student_Course.Co_Code, Co_Name, Term, Grade, Credits from Student_Course inner join Course using(Co_Code) where Stu_ID = @Stu_ID";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Stu_ID", UserModel.ID);
            reader = cmd.ExecuteReader();

            List<string> CoCodes = new List<string>();
            List<string> CoNames = new List<string>();
            List<string> CoTerms = new List<string>();
            List<string> CoGrades = new List<string>();
            List<int> CoCredits = new List<int>();
            int CoCount = 0;

            while (reader.Read())
            {
                CoCodes.Add(Convert.ToString(reader[0]));
                CoNames.Add(Convert.ToString(reader[1]));
                CoTerms.Add(Convert.ToString(reader[2]));
                CoGrades.Add(Convert.ToString(reader[3]));
                CoCredits.Add(Convert.ToInt32(reader[4]));
                CoCount++;
            }

            MyCourseModel.CourseCodes = CoCodes;
            MyCourseModel.CourseNames = CoNames;
            MyCourseModel.CourseTerms = CoTerms;
            MyCourseModel.CourseGrades = CoGrades;
            MyCourseModel.CourseCredits = CoCredits;
            MyCourseModel.CourseCount = CoCount;

            conn.Close();


            return RedirectToAction("MyCourses", "MyCourse");
        }
    }
}
