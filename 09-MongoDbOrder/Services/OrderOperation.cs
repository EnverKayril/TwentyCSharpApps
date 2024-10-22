using _09_MongoDbOrder.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace _09_MongoDbOrder.Services
{
    public class OrderOperation
    {
        public void AddOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrderCollection();

            var document = new BsonDocument
            {
                {"CustomerName", order.CustomerName },
                {"District", order.District },
                {"City", order.City },
                {"TotalPrice", order.TotalPrice }
            };

            orderCollection.InsertOne(document);
        }

        public List<Order> GetOrders()
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrderCollection();

            var orders = orderCollection.Find(new BsonDocument()).ToList();
            List<Order> orderList = new List<Order>();

            foreach (var order in orders)
            {
                orderList.Add(new Order
                {
                    City = order["City"].ToString(),
                    CustomerName = order["CustomerName"].ToString(),
                    District = order["District"].ToString(),
                    TotalPrice = Decimal.Parse(order["TotalPrice"].ToString()),
                    OrderId = order["_id"].ToString()
                });
            }
            return orderList;
        }

        public void DeleteOrder(string orderId)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrderCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            orderCollection.DeleteOne(filter);
        }

        public void UpdateOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrderCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(order.OrderId));
            var update = Builders<BsonDocument>.Update
                .Set("CustomerName", order.CustomerName)
                .Set("District", order.District)
                .Set("City", order.City)
                .Set("TotalPrice", order.TotalPrice);
            orderCollection.UpdateOne(filter, update);
        }

        public Order GetOrderById(string orderId)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrderCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            var order = orderCollection.Find(filter).FirstOrDefault();
            if (order != null)
            {
                return new Order
                {
                    City = order["City"].ToString(),
                    CustomerName = order["CustomerName"].ToString(),
                    District = order["District"].ToString(),
                    TotalPrice = Decimal.Parse(order["TotalPrice"].ToString()),
                    OrderId = order["_id"].ToString()
                };
            }
            else
            {
                return null;
            }
        }
    }
}
