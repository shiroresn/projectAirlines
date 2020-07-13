using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DL_05_07_Booking
/// </summary>
public class DL_05_07_Booking
{
    public DL_05_07_Booking()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataSet GetFlightInfo(BO_Booking BalObj)
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataSet ds = new DataSet();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_FlightInfoForBook", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FlightId", BalObj.FlightId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
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


    public bool BookTickets(BO_Booking BalObj)
    {

        DAL_BookedTicket DalObj = new DAL_BookedTicket();
        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_BookTicket", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FlightId", BalObj.FlightId);
            cmd.Parameters.AddWithValue("@FlightName", BalObj.FlightName);
            cmd.Parameters.AddWithValue("@FlightNumber", BalObj.FlightNumber);
            cmd.Parameters.AddWithValue("@Date", BalObj.DepartureDate);
            cmd.Parameters.AddWithValue("@Time", BalObj.Departuretime);

            cmd.Parameters.AddWithValue("@SourceId", BalObj.Source);
            cmd.Parameters.AddWithValue("@DestinationId", BalObj.Destination);
            cmd.Parameters.AddWithValue("@Class", BalObj.Class);
            cmd.Parameters.AddWithValue("@Passangers", BalObj.NoOfPassangers);
            cmd.Parameters.AddWithValue("@Amount", BalObj.AmountPayable);
            cmd.Parameters.AddWithValue("@TicketNo", BalObj.TicketNo);
            cmd.Parameters.AddWithValue("@UserId", BalObj.UserId);

            DalObj.insert(BalObj);
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

}