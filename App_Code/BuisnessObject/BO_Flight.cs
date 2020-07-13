using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

/// <summary>
/// Summary description for BO_Flight
/// </summary>
public class BO_Flight
{

    public int Id { get; set; }

    public ObjectId _id { get; set; }
    public string FlightName { get; set; }

    public string FlightNumber { get; set; }
    public string FlightSP { get; set; }

}