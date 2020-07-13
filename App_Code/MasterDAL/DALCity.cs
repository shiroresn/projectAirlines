using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALCity
/// </summary>
public class DALCity
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
        public List<City> getCityList()
        {
            DAL();
            List<City> list = new List<City>();
            var collection = emptbl.GetCollection<City>("City");
            foreach (City city in collection.FindAll())
            {
                list.Add(city);
            }
            return list;

        }
        public void insert(City city)
        {
            DAL();
            try
            {
                MongoCollection<City> collection = emptbl.GetCollection<City>("City");
                BsonDocument citycol = new BsonDocument{
                    {"CityName",city.CityName},
                    {"CityCode",city.CityCode}
                
                };
                collection.Insert(citycol);
            }
            catch { };
        }

        public void updateCity(City emp)
        {
            DAL();
            MongoCollection<City> collection = emptbl.GetCollection<City>("City");
            IMongoQuery query = Query.EQ("_id", emp._id);
            IMongoUpdate update = MongoDB.Driver.Builders.Update.Set("CityName", emp.CityName)
                                                                 .Set("CityCode", emp.CityCode);

            collection.Update(query, update);


        }

        public void DeleteCity(ObjectId id)
        {
            DAL();
            MongoCollection<City> collection = emptbl.GetCollection<City>("City");
            IMongoQuery query = Query.EQ("_id", id);
            collection.Remove(query);
        }
    }
