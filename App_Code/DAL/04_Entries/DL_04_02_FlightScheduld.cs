using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DL_04_02_FlightScheduld
/// </summary>
public class DL_04_02_FlightScheduld
{


    public DataTable GetUpdateData(BO_FlightScheduld BALObj)
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GetUpdateDataForFS", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", BALObj.Id);
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
    public DataTable GetAllFlightSchedulds()
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GetAllFlightSchedulds", con.Connection);
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
    public bool InsertFlightScheduld(BO_FlightScheduld BOFlight)
    {

        DL_FlightScheduld dl = new DL_FlightScheduld();

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_InsertFlightScheduld", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FlightId", BOFlight.FlightId);
            cmd.Parameters.AddWithValue("@Date", BOFlight.Date);
            cmd.Parameters.AddWithValue("@Time", BOFlight.Time);
            cmd.Parameters.AddWithValue("@SourceId", BOFlight.Source);
            cmd.Parameters.AddWithValue("@DestinationId", BOFlight.Destination);
         
            cmd.Parameters.AddWithValue("@BFare", BOFlight.BFare);
            cmd.Parameters.AddWithValue("@EFare", BOFlight.EFare);
            cmd.Parameters.AddWithValue("@EXFare", BOFlight.EXFare);


            int result = cmd.ExecuteNonQuery();
            dl.insert(BOFlight);
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

    public DataTable GetCityForDDL()
    {
       
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GetCityForDDL", con.Connection);
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


    public DataTable GetUpdateInfo(BOFlightTarrif BO)
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GetAllFlightScheduldInfoForUpdate", con.Connection);

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
    public bool UpdateFlightScheduld(BO_FlightScheduld BOFlight)
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_UpdateFlightScheduld", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FlightId", BOFlight.FlightId);
            cmd.Parameters.AddWithValue("@Date", BOFlight.Date);
            cmd.Parameters.AddWithValue("@Time", BOFlight.Time);
            cmd.Parameters.AddWithValue("@SourceId", BOFlight.Source);
            cmd.Parameters.AddWithValue("@DestinationId", BOFlight.Destination);

            cmd.Parameters.AddWithValue("@BFare", BOFlight.BFare);
            cmd.Parameters.AddWithValue("@EFare", BOFlight.EFare);
            cmd.Parameters.AddWithValue("@EXFare", BOFlight.EXFare);
            cmd.Parameters.AddWithValue("@Id", BOFlight.Id);

            cmd.ExecuteNonQuery();
            
            return true;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public bool DeleteFlightScheduld(BO_FlightScheduld BOFlight)
    {

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_DeleteFlightScheduld", con.Connection);
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