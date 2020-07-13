using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Flight
/// </summary>
public class Flight
{
    public ObjectId _id { get; set; }
    public string FlightName { get; set; }
    public string FlightCode { get; set; }
}