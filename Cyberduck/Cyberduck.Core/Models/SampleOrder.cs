using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Core.Models;

// Model for the SampleDataService. Replace with your own model.
public class SampleOrder
{
    public long OrderID
    {
        get; set;
    }

    public DateTime OrderDate
    {
        get; set;
    }

    public DateTime RequiredDate
    {
        get; set;
    }

    public DateTime ShippedDate
    {
        get; set;
    }

    public string ShipperName
    {
        get; set;
    }

    public string ShipperPhone
    {
        get; set;
    }

    public double Freight
    {
        get; set;
    }

    public string Company
    {
        get; set;
    }

    public string ShipTo
    {
        get; set;
    }

    public double OrderTotal
    {
        get; set;
    }

    public string Status
    {
        get; set;
    }

    public int SymbolCode
    {
        get; set;
    }

    public string SymbolName
    {
        get; set;
    }

    public char Symbol => (char)SymbolCode;

    public string ShortDescription => $"Order ID: {OrderID}";

    public override string ToString() => $"{Company} {Status}";
}

