using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for City
/// </summary>
public class City
{
    public int Id { get; set; }

    public string CityName { get; set; }

    public String CityCode { get; set; }

    public ObjectId _id { get; set; }
}