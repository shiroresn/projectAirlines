using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BO_Booking
/// </summary>
public class BO_Booking
{
    public BO_Booking()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string FlightId { get; set; }
    public string FlightName { get; set; }
    public string FlightNumber { get; set; }
    public DateTime DepartureDate { get; set; }
    public string Departuretime { get; set; }
    public string Source { get; set; }
    public string Destination { get; set; }
    public Guid UserId { get; set; }
    public int NoOfPassangers { get; set; }
    public string Class { get; set; }
    public string TicketNo { get; set; }
    public decimal AmountPayable { get; set; }


}