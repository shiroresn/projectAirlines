using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALFlightNames
/// </summary>
public class DALFlightNames
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
        var collection = emptbl.GetCollection<Flight>("Flight");
        foreach (Flight Flight in collection.FindAll())
        {
            list.Add(Flight);
        }
        return list;

    }
    public void insert(BO_Flight flg)
    {
        DAL();
        try
        {
            MongoCollection<City> collection = emptbl.GetCollection<City>("Flight");
            BsonDocument citycol = new BsonDocument{
                    {"FlightName",flg.FlightName},
                    {"FlightNumber",flg.FlightNumber},
                {"FlightSp",flg.FlightSP}


                };
            collection.Insert(citycol);
        }
        catch { };
    }

    public void updateCity(BO_Flight emp)
    {
        DAL();
        MongoCollection<Flight> collection = emptbl.GetCollection<Flight>("Flight");
        IMongoQuery query = Query.EQ("_id", emp._id);
        IMongoUpdate update = MongoDB.Driver.Builders.Update.Set("FlightName", emp.FlightName)
                                                             .Set("FlightNumber", emp.FlightNumber)
         .Set("FlightSp", emp.FlightSP);

        collection.Update(query, update);


    }

    public void DeleteCity(BO_Flight id)
    {
        DAL();
        MongoCollection<City> collection = emptbl.GetCollection<City>("Flight");
        IMongoQuery query = Query.EQ("_id", id._id);
        collection.Remove(query);
    }
 
}