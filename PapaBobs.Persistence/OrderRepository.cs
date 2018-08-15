using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobs.Persistence
{
    public class OrderRepository
    {

        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            var db = new PapaBobsDbEntities();
            var order = convertToEntity(orderDTO);

            db.Orders.Add(order);
            db.SaveChanges();
        }

        private static Orders convertToEntity(DTO.OrderDTO orderDTO)
        {
            var order = new Orders();

            order.OrderId = Guid.NewGuid();
            order.Size = orderDTO.Size;
            order.Crust = orderDTO.Crust;
            order.Sausage = orderDTO.Sausage;
            order.Pepperoni = orderDTO.Pepperoni;
            order.Onions = orderDTO.Onions;
            order.GreenPeppers = orderDTO.GreenPeppers;
            order.Name = orderDTO.Name;
            order.Address = orderDTO.Address;
            order.ZipCode = orderDTO.ZipCode;
            order.Phone = orderDTO.Phone;
            order.TotalCost = orderDTO.TotalCost;
            order.PaymentType = orderDTO.PaymentType;

            //throw new NotImplementedException();

            return order;
        }

    }
}
