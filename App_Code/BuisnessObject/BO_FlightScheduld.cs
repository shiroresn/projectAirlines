using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BO_FlightScheduld
/// </summary>
public class BO_FlightScheduld
{
    public int Id { get; set; }

    public DateTime Date { get; set; }
    public string Time  { get; set; }
    public string FlightId { get; set; }
    public string Source { get; set; }
    public string Destination { get; set; }
   
    public decimal BFare { get; set; }
    public decimal EFare { get; set; }
    public decimal EXFare { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
}