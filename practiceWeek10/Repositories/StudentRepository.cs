using Microsoft.Data.SqlClient;
using practiceWeek10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWeek10.Repositories
{
    public class StudentRepository
    {
        private readonly string connectionString = "Data Source=LAPTOP-8DI59A6C\\SQLEXPRESS;Initial Catalog=dboExample;Persist Security Info=True;User ID=sa;Password=vinice2004;Encrypt=True;Trust Server Certificate=True";


        public List<Student> ReadStudents()
        {
            var students = new List<Student>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string select = "SELECT * FROM   [dboExample].[dbo].[tableStudent]";
                    using (SqlCommand Select = new SqlCommand(select, connection))
                    {
                        using (SqlDataReader reader = Select.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Student student = new Student();
                                student.Id = reader.GetInt32(0);
                                student.FirstName = reader.GetString(1);
                                student.LastName = reader.GetString(2);
                                student.address = reader.GetString(4);
                                student.Birtthdate = reader.GetDateTime(3);
                                student.number = reader.GetString(5);


                                students.Add(student);
                            }
                        }
                    }

                }
            }
            catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
           
            

            return students;
        }

        public void createStudents(Student student)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [dboExample].[dbo].[tableStudent]"
                        + "(firstName, lastName, birthDate, address, phoneNumber) VALUES"
                        + "(@firstName, @lastName, @birthDate, @address, @phoneNumber)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", student.FirstName);
                        command.Parameters.AddWithValue("@lastName", student.LastName);
                        command.Parameters.AddWithValue("@birthDate", student.Birtthdate);
                        command.Parameters.AddWithValue("@address", student.address);
                        command.Parameters.AddWithValue("@phoneNumber", student.number);

                        command.ExecuteNonQuery();
                    }

                }
            }catch (Exception ex) { Console.WriteLine(ex.Message); }

          
        }

        public void deleteStudents(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"DELETE FROM [dboExample].[dbo].[tableStudent]" +
                        "WHERE student_id = @student_id ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@student_id", Id);

                        int rowsAffected = command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message ); }
        }

        public void updateStudents(int Id, Student student)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE [dboExample].[dbo].[tableStudent] SET firstName = @firstName," +
                        "lastName = @lastname, birthDate = @birthDate, address = @address, phoneNumber = @phoneNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", student.FirstName);
                        command.Parameters.AddWithValue("@lastName", student.LastName);
                        command.Parameters.AddWithValue("@birthDate", student.Birtthdate);
                        command.Parameters.AddWithValue("@address", student.address);
                        command.Parameters.AddWithValue("@phoneNumber", student.number);

                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
