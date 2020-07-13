using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DL_FeedBack
/// </summary>
public class DL_FeedBack
{
    public DL_FeedBack()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string  Name { get; set; }
    public string MobileNo{ get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }

    public bool SubmitFeedBack()
    {


        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_SubmitFeedBack", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@MobileNo", this.MobileNo);
            cmd.Parameters.AddWithValue("@Subject", this.Subject);
            cmd.Parameters.AddWithValue("@Message", this.Message);


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
    public DataTable GetAllFeedBack()
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_ViewFeedBack", con.Connection);
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

    public DataTable GetUserId(Register Reg)
    {
        AirlineConnect con = new AirlineConnect();
        try
        {
            DataTable dt = new DataTable();
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_getUserId", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email",Reg.Email);
            cmd.Parameters.AddWithValue("@Password",Reg.Password);
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

    public bool userinsert(Register reg)
    {


        AirlineConnect con = new AirlineConnect();
        try
        {
            con.GetConnection();
            SqlCommand cmd = new SqlCommand("usp_userinsert", con.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", reg.FirstName);
            cmd.Parameters.AddWithValue("@LastName", reg.LastName);
            cmd.Parameters.AddWithValue("@MobileNo", reg.Mobile);
            cmd.Parameters.AddWithValue("@Email", reg.Email);
            cmd.Parameters.AddWithValue("@Address", reg.City);
            cmd.Parameters.AddWithValue("@Gender", reg.Gender);
            cmd.Parameters.AddWithValue("@Password", reg.Password);



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