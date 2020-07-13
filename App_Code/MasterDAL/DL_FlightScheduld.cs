using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DL_FlightScheduld
/// </summary>
public class DL_FlightScheduld
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
        var collection = emptbl.GetCollection<Flight>("FlightScheduld");
        foreach (Flight Flight in collection.FindAll())
        {
            list.Add(Flight);
        }
        return list;

    }
    public void insert(BO_FlightScheduld Flig)
    {
        DAL();
        try
        {
            MongoCollection<BO_FlightScheduld> collection = emptbl.GetCollection<BO_FlightScheduld>("FlightScheduld");
            BsonDocument citycol = new BsonDocument{
                    {"Flight",Flig.FlightId},
                    {"Date",Flig.Date},
                {"Time",Flig.Time},
                {"Source",Flig.Source.ToString()},
                    {"Destination",Flig.Destination},
                {"BFare",Flig.BFare.ToString()},
                {"ExFare",Flig.EXFare.ToString()},
                 {"EcFare",Flig.EFare.ToString()}


                };
            collection.Insert(citycol);
        }
        catch { };
    }

   
}