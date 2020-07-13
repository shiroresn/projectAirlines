using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

/// <summary>
/// Summary description for BOFlightTarrif
/// </summary>
public class BOFlightTarrif
{

    public ObjectId _id { get; set; }
    public int Id { get; set; }

    public string Flight { get; set; }

    public string Class { get; set; }

    public int Seats { get; set; }
    public decimal Fare { get; set; }
}