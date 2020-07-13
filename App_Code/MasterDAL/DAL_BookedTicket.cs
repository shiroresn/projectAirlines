using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAL_BookedTicket
/// </summary>
public class DAL_BookedTicket
{
    string con = "";
    MongoServer server;
    MongoDatabase emptbl;
    public void DAL()
    {
        con = ConfigurationManager.ConnectionStrings["MongoConString"].ConnectionString;
        server = MongoServer.Create(con);
        emptbl = server.GetDatabase("AsianAirlines");

    }
    public List<Flight> getCityList()
    {
        DAL();
        List<Flight> list = new List<Flight>();
        var collection = emptbl.GetCollection<Flight>("BookedTicket");
        foreach (Flight Flight in collection.FindAll())
        {
            list.Add(Flight);
        }
        return list;

    }
    public void insert(BO_Booking Flig)
    {
        DAL();
        try
        {
            MongoCollection<BO_FlightScheduld> collection = emptbl.GetCollection<BO_FlightScheduld>("BookedTicket");
            BsonDocument citycol = new BsonDocument{
                    {"FlightName",Flig.FlightName},
                    {"FlightNumber",Flig.FlightNumber},
                {"Date",Flig.DepartureDate},
                {"Time",Flig.Departuretime.ToString()},
                    {"Source",Flig.Source},
                {"Destination",Flig.Destination.ToString()},
                {"Passangers",Flig.NoOfPassangers.ToString()},
                 {"Class",Flig.Class.ToString()},
                 {"Amount",Flig.AmountPayable.ToString()},
                   {"TicketNo",Flig.TicketNo.ToString()}


                };
            collection.Insert(citycol);
        }
        catch { };
    }

}