using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace WcfService_Test
{
    public class Service1:IService1
    {


        public static List<Students> Students = new List<Students>();
        static Dictionary<string, string> logged = new Dictionary<string, string>();
        public string user = null;
        public string AddGrade(int id, string codemasar, string first_name, string last_name, string major, int grade)
        {
            if (!logged.ContainsKey(codemasar))
            {
                return "Log in";
            }
            else
            {
                lock (Students)
                {
                    int i = 0;
                    for (i = 0; i < Students.Count && Students[i].Id != id; i++) ;
                    if (i < Students.Count)
                    {
                        return "Exists";
                    }
                    else
                    {
                        Students temp = new Students(id, codemasar, first_name, last_name, major, grade);
                        Students.Add(temp);
                        return "OK";
                    }
                }
            }
        }

        public List<Students> List()
        {
            lock (Students)
            {
                return Students;

            }
        }

        public string login(string name, string codemasar, string password)
        {
            this.user = name;
            string id = Guid.NewGuid().ToString();
            lock (logged)
            {
                logged.Add(id, name);
            }
            return id;
        }

        List<Students> IService1.List()
        {
            throw new System.NotImplementedException();
        }
        //TO GET STUDENT INFORMITION FROM DATABASE.

        public Students GetStudent(int id)
        {
           Students student = new Students();
           string cs = @"server=localhost;userid=roort;Password=Rachid20;database=db_wcf";
            using ( SqlConnection con = new SqlConnection(cs))
           {
                SqlCommand cmd = new SqlCommand("GetStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "p_id";
                parameterId.Value = id;
                cmd.Parameters.Add(parameterId);
                con.Open();
               SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    student.Id =Convert.ToInt32(reader["p_Id"]);
                    student.First_name = reader["p_firstname"].ToString();
                    student.Last_name = reader["p_lastname"].ToString();
                    student.Codemasar = reader["codemasar"].ToString();
                    student.Major = reader["p_studentmajor"].ToString();
                    student.Grade = Convert.ToInt32(reader["p_grade"]);
                }
            }
            return student;
        }

        public void Addrade(Students student)
        {
            string cs = @"server=localhost;userid=roort;Password=Rachid20;database=db_wcf";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("SaveStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter
                {
                    ParameterName = "p_id",
                    Value = student.Id
                };
                cmd.Parameters.Add(parameterId);


                SqlParameter parameterFirstname = new SqlParameter
                {
                    ParameterName = "p_firstname",
                    Value = student.First_name
                };
                cmd.Parameters.Add(parameterFirstname);


                SqlParameter parameterLastname = new SqlParameter
                {
                    ParameterName = "p_lastname",
                    Value = student.Last_name
                };
                cmd.Parameters.Add(parameterLastname);


                SqlParameter parameterCodemasar = new SqlParameter
                {
                    ParameterName = "codemasar",
                    Value = student.Codemasar
                };
                cmd.Parameters.Add(parameterCodemasar);


                SqlParameter parameterMajor = new SqlParameter
                {
                    ParameterName = "p_studentmajor",
                    Value = student.Major
                };
                cmd.Parameters.Add(parameterMajor);


                SqlParameter parameterGrade = new SqlParameter
                {
                    ParameterName = "p_grade",
                    Value = student.Grade
                };
                cmd.Parameters.Add(parameterGrade);

                con.Open();
                cmd.ExecuteNonQuery();

            }
        }
    }
}
