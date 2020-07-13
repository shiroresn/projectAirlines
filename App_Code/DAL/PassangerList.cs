using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PassangerList
/// </summary>
public class PassangerList
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
    public List<Register> getPassangerList()
    {
        DAL();
        List<Register> list = new List<Register>();
        var collection = emptbl.GetCollection<Register>("AsianAirlines");
        foreach (Register reg in collection.FindAll())
        {
            list.Add(reg);
        }
        return list;

    }
}