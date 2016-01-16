using System;
using System.Web;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Data.OracleClient;

/// <summary>
/// Databaseclass with 
/// </summary>
public class Database
{
	#region Fields
    string connString = "User Id=SE2DB;Password=SE2DB;Data Source= //localhost:1521/xe;";
    //string connString = "User Id=dbi311092;Password=DAhEQlt6nE;Data Source= //192.168.15.50:1521/fhictora;"; 
    OracleConnection conn;
    OracleCommand cmd;
    #endregion

    #region Constructor
    public Database()
    {
        conn = new OracleConnection();
        conn.ConnectionString = connString;
        cmd = conn.CreateCommand();
    }
    #endregion

    #region Methodes
    public Account LogIn(string username, string password)
    {
        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT \"ID\", \"Username\", \"Email\", \"Password\" FROM \"ACCOUNT\" WHERE \"Username\" = :username AND \"Password\" = :password";
            cmd.Parameters.Add(new OracleParameter("username", username));
            cmd.Parameters.Add(new OracleParameter("password", password));
            OracleDataReader reader = cmd.ExecuteReader();
            int id;
            string userName;
            string email;

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["ID"]);
                userName = Convert.ToString(reader["Username"]);
                email = Convert.ToString(reader["Email"]);
                return new Account(id, userName, email);   
            }
            return null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
        finally
        {
            conn.Close();
        }
    }
    public List<ProductItem> GetProducts(int type)
    {
        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT \"ID\", \"Name\", \"Description\", \"About\", \"Price\", \"ReleaseDate\" FROM \"Product\" WHERE \" TYPE_ID\" = '" + type + "';";
            OracleDataReader reader = cmd.ExecuteReader();
            int id;
            string name;
            string description;
            string about;
            decimal price;
            DateTime releaseDate;
            List<ProductItem> Products = new List<ProductItem>();

            while (reader.Read())
            {
                id = (int)reader["ID"];
                name = (string)reader["Name"];
                description = (string)reader["Description"];
                about = (string)reader["About"];
                price = (decimal)reader["Price"];
                releaseDate = (DateTime)reader["ReleaseDate"];
                Products.Add(new ProductItem(id, name, description, about, price, releaseDate));
            }
            return Products;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
        finally
        {
            conn.Close();
        }
    }
    #endregion
}