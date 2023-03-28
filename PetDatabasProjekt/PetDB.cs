using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PetDatabasProjekt
{
    internal class PetDB
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection("Server = 10.37.129.2 ; Port = 3306; Database = mydb ; Uid = root; Pwd = 1234;");

            
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection!" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
            return conn;
        }
        //här kommer mina metoder för att lägga till updatera och ta bort från appen
        public static void AddPet(Pet pe)
        {
            string connString = "INSERT INTO pet (Type, Size, Color, Breed, Phonenumber) VALUES (@Type, @Size, @Color, @Breed, @Phonenumber)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(connString, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@Type", MySqlDbType.VarChar).Value = pe.Type;
            cmd.Parameters.Add("@Size", MySqlDbType.VarChar).Value = pe.Size;
            cmd.Parameters.Add("@Color", MySqlDbType.VarChar).Value = pe.Color;
            cmd.Parameters.Add("@Breed", MySqlDbType.VarChar).Value = pe.Breed;
            cmd.Parameters.Add("@Phonenumber", MySqlDbType.VarChar).Value = pe.Phonenumber;
            
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully added a pet to our database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pet not inserted" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

            public static void UpdatePet(Pet pe, string id)
        {
            string connString = "UPDATE pet SET Type = @Type, Size = @Size, Color = @Color, Breed = @Breed, Phonenumber = @Phonenumber  WHERE PetID = @PetID";
            MySqlConnection conn = GetConnection(); 
            MySqlCommand cmd = new MySqlCommand(connString, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PetID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@Type", MySqlDbType.VarChar).Value = pe.Type;
            cmd.Parameters.Add("@Size", MySqlDbType.VarChar).Value = pe.Size;
            cmd.Parameters.Add("@Color", MySqlDbType.VarChar).Value = pe.Color;
            cmd.Parameters.Add("@Breed", MySqlDbType.VarChar).Value = pe.Breed;
            cmd.Parameters.Add("@Phonenumber", MySqlDbType.VarChar).Value = pe.Phonenumber;
            
           
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pet not inserted" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }

        public static void DeletePet(string id)
        {
            string connString = " DELETE FROM pet WHERE PetID = @PetID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(connString, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PetID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pet not Deleted" + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }
        //metod för att visa all info i datagrid
        public static void DisplayAndSearch(string query, DataGridView datagrid)
        {
            string connstring = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(connstring, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            datagrid.DataSource = tbl;
            conn.Close();
        }

        


    }


}
