using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DL_05_01_ViewFlightScheduld
/// </summary>
public class DL_05_01_ViewFlightScheduld
{
    public DL_05_01_ViewFlightScheduld()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataTable GetDataByDates(BO_FlightScheduld BALObj)
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GetFSbyDates", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FromDate", BALObj.FromDate);
            cmd.Parameters.AddWithValue("@ToDate", BALObj.ToDate);
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
    public DataTable GetDataBySD(BO_FlightScheduld BALObj)
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GetDataBySD", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SourceId", BALObj.Source);
            cmd.Parameters.AddWithValue("@DestinationId", BALObj.Destination);
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


}