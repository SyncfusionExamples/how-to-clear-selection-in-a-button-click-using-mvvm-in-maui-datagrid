using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample
{
    public class OrderInfoRepository
    {
        ObservableCollection<OrderInfo> orderDetails;
        public OrderInfoRepository()
        {
            orderDetails = new ObservableCollection<OrderInfo>();
        }


        private Random random = new Random();

        public ObservableCollection<OrderInfo> GetOrderDetails(int count)
        {
            for (int i = 10001; i <= count + 10000; i++)
            {

                var ord = new OrderInfo()
                {
                    OrderID = random.Next(10001, 10010),
                    CustomerID = CustomerID[random.Next(15)],
                    Freight = (Math.Round(random.Next(1000) + random.NextDouble(), 2)).ToString(),
                    Country = country[random.Next(20)],
                };
                orderDetails.Add(ord);
            }
            return orderDetails;
        }

        string[] CustomerID = new string[] {
            "Alfki",
            "Frans",
            "Merep",
            "Folko",
            "Simob",
            "Warta",
            "Vaffe",
            "Furib",
            "Seves",
            "Linod",
            "Riscu",
            "Picco",
            "Blonp",
            "Welli",
            "Folig"
        };

        string[] country = new string[]
        {
            "US",
            "Australia",
            "Canada",
            "UK",
            "India",
            "Italy",
            "China",
            "Japan",
            "Belgium",
            "Mexico",
            "Brazil",
            "Singapore",
            "NorthKorea",
            "Greece",
            "Norway",
            "Netherland",
            "Austria",
            "Sweden",
            "Poland",
            "Hungary",
            "Russia"
        };
    }
}

