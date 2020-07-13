using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DL_00_01_Flight
/// </summary>
public class DL_00_01_Flight
{
    


    public bool InsertFlight(BO_Flight BOFlight)
    {

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_InsertFlight", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FlightName", BOFlight.FlightName);
            cmd.Parameters.AddWithValue("@FlightNumber", BOFlight.FlightNumber);
            cmd.Parameters.AddWithValue("@FlightSP", BOFlight.FlightSP);
            DALFlightNames dal = new DALFlightNames();

            dal.insert(BOFlight);

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


    public DataTable GetAllFlight()
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GeytAllFlight", con.Connection);
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
    public bool UpdateFlightDeatils(BO_Flight BOFlight)
    {

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_UpdateFlightDeatils", con.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FlightName", BOFlight.FlightName);
            cmd.Parameters.AddWithValue("@FlightNumber", BOFlight.FlightNumber);
            cmd.Parameters.AddWithValue("@FlightSP", BOFlight.FlightSP);
            cmd.Parameters.AddWithValue("@Id", BOFlight.Id);

            cmd.ExecuteNonQuery();
           

            return true;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public bool DeleteFlight(BO_Flight BOFlight)
    {

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_DeleteFlight", con.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", BOFlight.Id);
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