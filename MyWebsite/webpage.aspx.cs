using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MyWebsite
{
    public partial class webpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        class clsStudent
        {

            
            public int ID;
            public string FirstName;
            public string LastName;
            public string UserName;
            public string Email;
            public string Password;
            public int Age;

            public clsStudent(int iD, string firstName, string lastName, string userName, string email, string password, int age)
            {
                ID = iD;
                FirstName = firstName;
                LastName = lastName;
                UserName = userName;
                Email = email;
                Password = password;
                Age = age;
            }

            public clsStudent() { }
        }

        string connectionString = "Data Source=SQL5107.site4now.net;Initial Catalog=db_a9eb75_algods;User Id=db_a9eb75_algods_admin;Password=dbAlgoDSpassword1234567890";

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email    = tb_UserName.Text.Trim();
            string password = tb_Password.Text.Trim();

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Students WHERE Email = @Email AND Password = @Password";

            SqlCommand command= new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);

            clsStudent student = null;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    student = new clsStudent();
                    student.ID = (int)reader["ID"];
                    student.FirstName = (string)reader["FirstName"];
                    student.LastName = (string)reader["LastName"];
                    student.UserName = (string)reader["UserName"];
                    student.Email = (string)reader["Email"];
                    student.Password = (string)reader["Password"];
                    student.Age = (int)reader["Age"];
                }

                connection.Close();
            }
            catch (Exception ex)
            {

            }

            if(student == null) 
            {
                tb_UserName.Text = "Not Found";
                tb_Password.Text = "";
                tb_UserName.Focus();
            }
            else
            {
                tb_UserName.Text = "Welcome " + student.FirstName + student.LastName;
                tb_Password.Text = "";
                tb_UserName.Focus();
            }

        }

    }
} 