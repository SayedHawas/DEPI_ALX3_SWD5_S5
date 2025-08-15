//using System.Data.SqlClient; POCO
using Microsoft.Data.SqlClient;
namespace Day9LabADOConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -------------- Day 9 ADO.Net Connection ------------");
            #region Session Part 1
            //"Data Source=SAYEDHAWAS\\DEPI2025R3G2;Initial Catalog=ADOTest;Integrated Security=True;Trust Server Certificate=True";
            //Server=myServerName,myPortNumber;Database=myDataBase;User Id=myUsername;Password=myPassword;
            //SOLID
            //I Interface 
            // Generic Interface   Done 
            // ADO.Net Data Provider 
            //Console.WriteLine(" ---------------------- SQl Server ADO.Net ------------------");
            //const string connectionString = "Data Source=SAYEDHAWAS\\DEPI2025R3G2;Initial Catalog=ADOTest;Integrated Security=True;";
            ////1) Create Object From SQL Connection To Open Connection with Database 
            //SqlConnection con = new SqlConnection();
            ////2) Connection string (Server ; Database ; Security)
            //con.ConnectionString = connectionString;
            ////3) Open Connection
            //con.Open();


            ////4) Create Command 
            //SqlCommand cmd = new SqlCommand();
            ////5) Command Type 
            //cmd.CommandType = System.Data.CommandType.Text;
            ////6) Command Statment
            //cmd.CommandText = "Select * from Students";
            ////7) Link Connection With Command 
            //cmd.Connection = con;
            ////8)Execute Command With return Sql Data Reader  
            //SqlDataReader dr = cmd.ExecuteReader();
            ////9)Loop to read Result 
            //if (dr.HasRows)
            //{
            //    while (dr.Read())
            //    {
            //        Console.WriteLine($"ID {dr[0]} , Name {dr[1]} , Mark {dr[2]}");
            //    }
            //}
            ////10)Close Connection 
            //con.Close();
            const string connectionString = "Data Source=SAYEDHAWAS\\DEPI2025R3G2;Initial Catalog=ADOTest;Integrated Security=True;Trust Server Certificate=True";

            Console.WriteLine(" ---------------------- SQl Server ADO.Net With CRUD ------------------");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Scalar Counter
                SqlCommand cmdCounter = new SqlCommand("Select count(*) from Students", con);
                int RowCounter = (int)cmdCounter.ExecuteScalar();
                Console.WriteLine($"Row Numbers in Student Table is {RowCounter}");
                Console.WriteLine("------------------------------------------------------------");
                //DataReader
                SqlCommand cmd = new SqlCommand("Select * from Students", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"ID {dr[0]} , Name {dr[1]} , Mark {dr[2]}");
                    }
                }
            }
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine(" ---------------------- C -> Create ------------------");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("----------- Insert Data ------------");
                Console.Write("Enter Your Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter Your Mark : ");
                int mark;
                int.TryParse(Console.ReadLine(), out mark);

                string strInsert = $"Insert into Students values ('{name}', {mark})";

                SqlCommand cmdInsert = new SqlCommand(strInsert, con);

                int RowInsert = cmdInsert.ExecuteNonQuery();

                Console.WriteLine($"Row Numbers is Insert {RowInsert}");
                Console.WriteLine("------------------------------------------------------------");
                //Reload Data 
                SqlCommand cmd = new SqlCommand("Select * from Students", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"ID {dr[0]} , Name {dr[1]} , Mark {dr[2]}");
                    }
                }
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(" ---------------------- U -> Update  ------------------");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("----------- Update Data ------------");
                Console.Write("Enter Your Id : ");
                int idUpdate;
                int.TryParse(Console.ReadLine(), out idUpdate);

                Console.Write("Enter Your Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter Your Mark : ");
                int mark;
                int.TryParse(Console.ReadLine(), out mark);

                string strUpdate = $"Update Students set Name ='{name}', Mark = {mark}  Where ID = {idUpdate}";

                SqlCommand cmdUpdate = new SqlCommand(strUpdate, con);

                int RowUpdate = cmdUpdate.ExecuteNonQuery();

                Console.WriteLine($"Row Numbers is Update {RowUpdate}");
                Console.WriteLine("------------------------------------------------------------");
                //Reload Data 
                SqlCommand cmd = new SqlCommand("Select * from Students", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"ID {dr[0]} , Name {dr[1]} , Mark {dr[2]}");
                    }
                }
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(" ---------------------- D -> Delete  ------------------");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("----------- Delete Data ------------");
                Console.Write("Enter Your Id : ");
                int idDelete;
                int.TryParse(Console.ReadLine(), out idDelete);

                string strDelete = $"Delete Students Where ID = {idDelete}";

                SqlCommand cmdDelete = new SqlCommand(strDelete, con);

                int RowDelete = cmdDelete.ExecuteNonQuery();

                Console.WriteLine($"Row Numbers is Delete {RowDelete}");
                Console.WriteLine("------------------------------------------------------------");
                //Reload Data 
                SqlCommand cmd = new SqlCommand("Select * from Students", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"ID {dr[0]} , Name {dr[1]} , Mark {dr[2]}");
                    }
                }
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.ReadLine();
            #endregion 
        }
    }
}
