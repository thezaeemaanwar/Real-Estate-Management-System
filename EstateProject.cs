using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using 

namespace Real_Estate_Management
{
    public class EstateProject
    {
        public string ID { get; }
        public string description { get; set; }
        public int noWorkers { get; set; }
        public List<Apartment> apartments { get; }
        public List<User> users { get; }
        
        public EstateProject()
        {
            Guid guid = Guid.NewGuid();
            this.ID = guid.ToString();
            Helper.con.Open();
            string query = "INSERT INTO [dbo].[ProjectsTable] (id) VALUES (@id)";
            SqlCommand cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@id", this.ID);
            cmd.ExecuteNonQuery();
            Helper.con.Close();
        }
        public EstateProject(string desc, int nW, List<Apartment> apartments, List<User> users)
        {
            Guid guid = Guid.NewGuid();
            this.ID = guid.ToString();
            this.description = desc;
            this.noWorkers = nW;
            this.apartments = apartments;
            this.users = users;
        }
        public EstateProject(string id, string desc, int nW, List<Apartment> apartments, List<User>users)
        {
            this.ID = id;
            this.description = desc;
            this.noWorkers = nW;
            this.apartments = apartments;
            this.users = users;
        }
        public void AssignApartment (string appId)
        {
            Helper.con.Open();

            // Look in the DB for apartment with appId
            string query = "SELECT * FROM [dbo].[ApartmentTable] WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@id", appId);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            // Store Appartment fields
            string desc = reader[1].ToString();
            float perceivedValue = float.Parse( reader[2].ToString());
            float materialsPrice = float.Parse(reader[3].ToString());
            float workForcePrice = float.Parse(reader[4].ToString());
            float currentExpenditure = float.Parse(reader[5].ToString());
            int squareMeters = Convert.ToInt32(reader[6]) ;
            int noRooms = Convert.ToInt32(reader[7]);
            int perceivedComfort = Convert.ToInt32(reader[9]);
            bool metroProximity = Convert.ToBoolean(reader[8]);
            string zone = reader[10].ToString();

            // Add apartment in the apartments list
            Apartment apartment = new Apartment(appId, desc, perceivedValue, materialsPrice,
                workForcePrice, currentExpenditure, squareMeters, noRooms, metroProximity, 
                perceivedComfort, zone);
            this.apartments.Add(apartment);
            string apIDs = "";

            // Look for the alredy existing apartments in DB
            query = "SELECT apartments FROM [dbo].[ProjectsTable] WHERE id = @id";
            cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@id", this.ID);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                apIDs = reader[0].ToString();

            // concatenate the already existing Apartment IDs
            apIDs += ","+appId;

            // Update APartment IDs in the DB
            query = "UPDATE [dbo].[ProjectsTable] SET apartments = @apartments WHERE id = @id";
            cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@apartments", apIDs);
            cmd.Parameters.AddWithValue("@id", appId);
            cmd.ExecuteNonQuery();

            // close the Helper.connection
            Helper.con.Close();
        }
        public void AssignManager (string uname)
        {
            this.users.Add(Helper.FindUser(uname));

            string usernames = "";

            // Look for the alredy existing users in DB
            string query = "SELECT Users FROM [dbo].[ProjectsTable] WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@id", this.ID);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                usernames = reader[0].ToString();

            // Concatenate the already existing Usernames
            usernames += ","+uname;

            // Update Users IDs in the DB
            query = "UPDATE [dbo].[ProjectsTable] SET Users = @users WHERE id = @id";
            cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@users", usernames);
            cmd.Parameters.AddWithValue("@id", this.ID);
            cmd.ExecuteNonQuery();

            Helper.con.Close();
        }
        public void UnassignApartment(Apartment apartment)
        {
            Helper.con.Open();
            // Retrieving the apartments from DataBase
            string query = "SELECT apartments FROM [dbo].[ProjectsTable] WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@id", this.ID);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Helper.con.Close();

            // Replacing the apartment with empty string
            string apartmentIDs = reader.ToString();
            apartmentIDs.Replace(apartment.ID+",", "");

            // Storing in database again
            query = "UPDATE [dbo].[ProjectsTable] SET apartments = @apartments WHERE id = @id";
            cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@apartments", apartmentIDs);
            cmd.Parameters.AddWithValue("@id", this.ID);
            Helper.con.Open();
            cmd.ExecuteNonQuery();
            Helper.con.Close();
        }
        public void UnassignUser(User user)
        {

            Helper.con.Open();
            // Retrieving the users from DataBase
            string query = "SELECT Users FROM [dbo].[ProjectsTable] WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@id", this.ID);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Helper.con.Close();

            // Replacing the user with empty string
            string usernames = reader.ToString();
            usernames.Replace(user.username + ",", "");

            // Storing in database again
            query = "UPDATE [dbo].[ProjectsTable] SET Users = @usernames WHERE id = @id";
            cmd = new SqlCommand(query, Helper.con);
            cmd.Parameters.AddWithValue("@usernames", usernames);
            cmd.Parameters.AddWithValue("@id", this.ID);
            Helper.con.Open();
            cmd.ExecuteNonQuery();
        }
        public DataTable GetPercievedValues()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Percieved Values", typeof(float));
            table.Columns.Add("Apartment IDs", typeof(string));

            foreach (Apartment apartment in apartments) {
                table.Rows.Add(apartment.perceivedValue, apartment.ID);
            }

            return table;
        }
        public DataTable GetWorkforcePrice()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Work Force Price", typeof(float));
            table.Columns.Add("Apartment IDs", typeof(string));

            foreach (Apartment apartment in apartments)
            {
                table.Rows.Add(apartment.workForcePrice, apartment.ID);
            }

            return table;
        }
        public void UpdateDB()
        {

        }
    }
}
