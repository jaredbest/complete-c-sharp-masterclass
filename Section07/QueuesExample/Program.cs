using System;
using System.Collections.Generic;

namespace QueuesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a queue of integers
            Queue<int> queue = new Queue<int>();

            // Add object to end of queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            // Print object at the front of the queue
            Console.WriteLine("The value at the front of the queue: {0}", queue.Peek());

            // Removes and returns the object at the beginning of the queue
            int queueItem = queue.Dequeue();

            Console.WriteLine("The value at the front of the queue: {0}", queue.Peek());

            while(queue.Count > 0)
            {
                Console.Write("The front value {0} was removed from the queue", queue.Dequeue());

                // Print the queue count
                Console.Write("The current count in the queue: {0}", queue.Count);
            }

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in ReceiveOrdersFromBranch1())
            {
                // Add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                // Add each order to the queue
                ordersQueue.Enqueue(o);
            }

            while(ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }
        }

        // This method will create an array of orders and return it
        static Order[] ReceiveOrdersFromBranch1()
        {
            // Create new orders array
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }

        static Order[] ReceiveOrdersFromBranch2()
        {
            // Create new orders array
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }
    }

    class Order
    {
        // Order ID
        public int OrderId { get; set; }
        // Quantity of order
        public int OrderQuantity { get; set; }

        // Simple constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        // Print message on screen that order was processed
        public void ProcessOrder()
        {
            // Print the message
            Console.WriteLine($"Order {OrderId} processed!");
        }
    }
}
