using System;

namespace Mocks
{
    public delegate void ProductRemoveEventHandler(string productName, int quantity);

    public interface Iwarehouse
    {
        event ProductRemoveEventHandler ProductRemoved;

        string Manager { get; set; }

        bool HasInventory(string productName, int quantity);
        void Remove(string productName, int quantity);
    }

    public class Order
    {
        public Order(string productName, int quantity)
        {
            this.ProductName = productName;
            this.Quantity = quantity;
        }

        public string ProductName { get; private set; }
        public int Quantity { get; private set; }
        public bool IsFilled { get; private set; }

        public void Fill(Iwarehouse warehouse)
        {
            if (warehouse.HasInventory(this.ProductName, this.Quantity))
            {
                warehouse.Remove(this.ProductName, this.Quantity);
            }
        }

        public virtual string Receipt(DateTime orderDate)
        {
            return string.Format("Ordered {0} {1} on {2}", this.Quantity, this.ProductName, orderDate.ToString("d"));
        }
    }
}