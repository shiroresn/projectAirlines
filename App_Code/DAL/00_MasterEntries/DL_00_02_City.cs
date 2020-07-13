using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MongoDB.Bson;

/// <summary>
/// Summary description for _00_02_City
/// </summary>
public class DL_00_02_City
{

   



    public bool InsertCity(City City)
    {

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_InsertCity", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CityName", City.CityName);
            cmd.Parameters.AddWithValue("@CityCode", City.CityCode);
            DALCity Dal = new DALCity();
            Dal.insert(City);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            con.CloseConnection();

        }

    }


    public DataTable GetAllCity()
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GetAllCity", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.CloseConnection();
        }
    }

    //UpdateAccountGroup
    public bool UpdateFinancialYear(City city)
    {

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_UpdateCity", con.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CityName", city.CityName);
            cmd.Parameters.AddWithValue("@CityCode", city.CityCode);
            cmd.Parameters.AddWithValue("@Id", city.Id);

            cmd.ExecuteNonQuery();

            return true;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public bool DeleteCity(City City)
    {

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_DeleteCity", con.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", City.Id);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {

        }
        finally
        {
            con.CloseConnection();
        }

        return true;
    }

}


  
