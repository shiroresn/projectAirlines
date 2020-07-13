using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Register
/// </summary>
public class Register
{

    public ObjectId _id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string City { get; set; }
    public string Location { get; set; }
    public string Gender { get; set; }
    public string Password { get; set; }



}