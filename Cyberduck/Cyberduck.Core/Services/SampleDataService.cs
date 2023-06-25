using Cyberduck.Core.Services;
using TestApp.Core.Models;

namespace TestApp.Core.Services;

// This class holds sample data used by some generated pages to show how they can be used.
// TODO: The following classes have been created to display sample data. Delete these files once your app is using real data.
// 1. Contracts/Services/ISampleDataService.cs
// 2. Services/SampleDataService.cs
// 3. Models/SampleCompany.cs
// 4. Models/SampleOrder.cs
// 5. Models/SampleOrderDetail.cs
public class SampleDataService : ISampleDataService
{
    private List<SampleOrder> _allOrders;

    public SampleDataService()
    {
    }

    private static IEnumerable<SampleOrder> AllSampleOrders()
    {
        return new List<SampleOrder>()
        {
          new SampleOrder()
                    {
                        OrderID = 10642, // Symbol Globe
                        OrderDate = new DateTime(1997, 8, 25),
                        RequiredDate = new DateTime(1997, 9, 22),
                        ShippedDate = new DateTime(1997, 9, 22),
                        ShipperName = "Speedy Express",
                        ShipperPhone = "(503) 555-9831",
                        Freight = 29.46,
                        Company = "Company A",
                        ShipTo = "Company A, Obere Str. 57, Berlin, 12209, Germany",
                        OrderTotal = 814.50,
                        Status = "Shipped",
                        SymbolCode = 57643,
                        SymbolName = "Globe",
                 },
                    new SampleOrder()
                    {
                        OrderID = 10643, // Symbol Globe
                        OrderDate = new DateTime(1997, 8, 25),
                        RequiredDate = new DateTime(1997, 9, 22),
                        ShippedDate = new DateTime(1997, 9, 22),
                        ShipperName = "Speedy Express",
                        ShipperPhone = "(503) 555-9831",
                        Freight = 29.46,
                        Company = "Company A",
                        ShipTo = "Company A, Obere Str. 57, Berlin, 12209, Germany",
                        OrderTotal = 814.50,
                        Status = "Shipped",
                        SymbolCode = 57643,
                        SymbolName = "Globe",
                 },
        };
    }
}

