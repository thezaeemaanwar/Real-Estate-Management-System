﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Real_Estate_Management
{
    static public class Helper
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\projects\Real Estate Management\Database1.mdf;Integrated Security=True");
        public static string userType = "";
        public static string userName = "";
        public static Apartment FindApartment(string appId)
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string query = "SELECT * FROM [dbo].[ApartmentTable] WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", appId);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            con.Close();

            // Store Appartment fields
            string desc = reader[1].ToString();
            float perceivedValue = float.Parse(reader[2].ToString());
            float materialsPrice = float.Parse(reader[3].ToString());
            float workForcePrice = float.Parse(reader[4].ToString());
            float currentExpenditure = float.Parse(reader[5].ToString());
            int squareMeters = Convert.ToInt32(reader[6]);
            int noRooms = Convert.ToInt32(reader[7]);
            int perceivedComfort = Convert.ToInt32(reader[9]);
            bool metroProximity = Convert.ToBoolean(reader[8]);
            string zone = reader[10].ToString();

            // Add apartment in the apartments list
            Apartment apartment = new Apartment(appId, desc, perceivedValue, materialsPrice,
                workForcePrice, currentExpenditure, squareMeters, noRooms, metroProximity,
                perceivedComfort, zone);
            return apartment;
        }
        public static User FindUser(string uname)
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            // Look for the user in DB
            string query = "SELECT * FROM [dbo].[UserTable] WHERE username = @uname";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            string type = "";
            string email = "";
            string password = "";
            if (reader.Read())
            {
                type = reader[1].ToString();
                email = reader[2].ToString();
                password = reader[3].ToString();
            }
            User user = new User(uname, type, email, password);
            con.Close();
            return user;
        }
        public static List<EstateProject> FindProjects(string uname)
        {
            List<EstateProject> projects = new List<EstateProject>();
            con.Open();
            string query = "SELECT * FROM [dbo].[ProjectsTable] WHERE Users LIKE '%,'+@username+',%'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", uname);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader[0].ToString();
                string desc = reader[1].ToString();
                int noWork = Convert.ToInt32(reader[2]);
                string[] apartments = reader[3].ToString().Split(',');
                string[] Users = reader[4].ToString().Split(',');
                List<Apartment> apartments1 = new List<Apartment>();
                List<User> users = new List<User>();
                foreach (string user in Users)
                {
                    users.Add(FindUser(user));
                }
                foreach (string apartment in apartments)
                {
                    apartments1.Add(FindApartment(apartment));
                }
                con.Open();
                EstateProject project = new EstateProject(id, desc, noWork, apartments1, users);
                projects.Add(project);
            }
            con.Close();
            return projects;
        }
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            con.Open();
            // Look for the user in DB
            string query = "SELECT * FROM [dbo].[UserTable] ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string uname = reader[0].ToString();
                string type = reader[1].ToString();
                string email = reader[2].ToString();
                string password = reader[3].ToString();
                User user = new User(uname, type, email, password);
                users.Add(user);
            }
            con.Close();
            return users;
        }
        public static List<Apartment> GetApartments()
        {
            List<Apartment> apartments = new List<Apartment>();
            con.Open();
            string query = "SELECT * FROM [dbo].[ApartmentTable]";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Store Appartment fields
                string appId = reader[0].ToString();
                string desc = reader[1].ToString();
                float perceivedValue = float.Parse(reader[2].ToString());
                float materialsPrice = float.Parse(reader[3].ToString());
                float workForcePrice = float.Parse(reader[4].ToString());
                float currentExpenditure = float.Parse(reader[5].ToString());
                int squareMeters = Convert.ToInt32(reader[6]);
                int noRooms = Convert.ToInt32(reader[7]);
                int perceivedComfort = Convert.ToInt32(reader[9]);
                bool metroProximity = Convert.ToBoolean(reader[8]);
                string zone = reader[10].ToString();

                // Add apartment in the apartments list
                Apartment apartment = new Apartment(appId, desc, perceivedValue, materialsPrice,
                    workForcePrice, currentExpenditure, squareMeters, noRooms, metroProximity,
                    perceivedComfort, zone);
                apartments.Add(apartment);
            }
            con.Close();
            return apartments;
        }
        public static List<EstateProject> GetEstateProjects()
        {
            List<EstateProject> projects = new List<EstateProject>();
            con.Open();
            string query = "SELECT * FROM [dbo].[ProjectsTable]";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> users = new List<string>();
            List<string> apartments = new List<string>();
            while (reader.Read())
            {
                string id = reader[0].ToString();
                string desc = reader[1].ToString();
                int noWork;
                if (reader[2] == DBNull.Value)
                    noWork = 0;
                else
                    noWork = Convert.ToInt32(reader[2]);
                apartments.Add(reader[3].ToString());
                users.Add(reader[4].ToString());
                EstateProject project = new EstateProject(id, desc, noWork);
                projects.Add(project);
            }
            con.Close();
            int count = 0;
            foreach (EstateProject p in projects)
            {
                string [] usersstr = users[count].Split(',');
                foreach(string user in usersstr)
                {
                    if (user != "NULL")
                        p.AssignManager(user);
                }
                string[] appStr = apartments[count].Split(',');
                foreach(string ap in appStr)
                {
                    if (ap != "NULL")
                        p.AssignApartment(ap);
                }
            }
            return projects;
        }
    }
}
