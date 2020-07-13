using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALFlightTarrif
/// </summary>
public class DALFlightTarrif
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
        var collection = emptbl.GetCollection<Flight>("ManageFlight");
        foreach (Flight Flight in collection.FindAll())
        {
            list.Add(Flight);
        }
        return list;

    }
    public void insert(BOFlightTarrif Flig)
    {
        DAL();
        try
        {
            MongoCollection<City> collection = emptbl.GetCollection<City>("ManageFlight");
            BsonDocument citycol = new BsonDocument{
                    {"FlightName",Flig.Flight},
                    {"Class",Flig.Class},
                {"Seats",Flig.Seats},
                {"Fare",Flig.Fare.ToString()}


                };
            collection.Insert(citycol);
        }
        catch { };
    }

    public void updateCity(BO_Flight emp)
    {
        DAL();
        MongoCollection<Flight> collection = emptbl.GetCollection<Flight>("ManageFlight");
        IMongoQuery query = Query.EQ("_id", emp._id);
        IMongoUpdate update = MongoDB.Driver.Builders.Update.Set("FlightName", emp.FlightName)
                                                             .Set("FlightNumber", emp.FlightNumber)
         .Set("FlightSp", emp.FlightSP);

        collection.Update(query, update);


    }

    public void DeleteCity(BO_Flight id)
    {
        DAL();
        MongoCollection<City> collection = emptbl.GetCollection<City>("ManageFlight");
        IMongoQuery query = Query.EQ("_id", id._id);
        collection.Remove(query);

    }
}