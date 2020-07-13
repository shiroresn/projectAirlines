using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DL_04_01_FlightTarrif
/// </summary>
public class DL_04_01_FlightTarrif
{

    public DataTable GetFlightsForDDL()
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GetFlightsForDDL", con.Connection);
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
    public bool InsertFlightTarrif(BOFlightTarrif BOFlight)
    {
        DALFlightTarrif dal = new DALFlightTarrif();

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_InsertFlightTarrif", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flight", BOFlight.Flight);
            cmd.Parameters.AddWithValue("@Class", BOFlight.Class);
            cmd.Parameters.AddWithValue("@Seats", BOFlight.Seats);
            cmd.Parameters.AddWithValue("@Fare", BOFlight.Fare);

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


    public DataTable GetAllFlightTarrifInfo()
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GetAllFlightTarrifInfo", con.Connection);
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


    public DataTable GetUpdateInfo(BOFlightTarrif BO)
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GetAllFlightTarrifInfoForUpdate", con.Connection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", BO.Id);
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
    public bool UpdateFlightTarrif(BOFlightTarrif BOFlight)
    {

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_UpdateFlightTarrif", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FlightName", BOFlight.Flight);
            cmd.Parameters.AddWithValue("@Class", BOFlight.Class);
            cmd.Parameters.AddWithValue("@Seats", BOFlight.Seats);
            cmd.Parameters.AddWithValue("@Fare", BOFlight.Fare);
            cmd.Parameters.AddWithValue("@Id", BOFlight.Id);

            cmd.ExecuteNonQuery();

            return true;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public bool DeleteFlightTarrif(BOFlightTarrif BOFlight)
    {

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_DeleteFlightTarrif", con.Connection);
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