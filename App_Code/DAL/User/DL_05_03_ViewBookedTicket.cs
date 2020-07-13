using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DL_05_03_ViewBookedTicket
/// </summary>
public class DL_05_03_ViewBookedTicket
{
    public DL_05_03_ViewBookedTicket()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public bool CancelTicket(BO_Booking BoObj)
    {

        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_CancelTicket", con.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TicketNo", BoObj.TicketNo);
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
    public DataTable GetUpdateData(BO_Booking BALObj)
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_GetBookedTickts", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId", BALObj.UserId);
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