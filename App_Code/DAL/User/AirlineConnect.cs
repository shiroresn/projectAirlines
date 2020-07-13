using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AirlineConnect
/// </summary>
public class AirlineConnect
{
    public AirlineConnect()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public SqlConnection Connection { get; set; }




    public void GetConnection()
    {
        string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog = AsianAirlines; Integrated Security = True";
        this.Connection = new SqlConnection(ConnectionString);
        SqlConnection.ClearPool(this.Connection);
        this.Connection.Open();


    }


    public void CloseConnection(SqlConnection con)
    {
        try
        {
            con.Close();
        }
        catch (Exception ex)
        {
            throw;
        }

    }

    public void CloseConnection()
    {
        try
        {
            this.Connection.Close();
        }
        catch (Exception ex)
        {

            throw;
        }

    }
}