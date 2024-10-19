namespace PetProject.Order
{
    enum StatusOrder
    {
        completed,
        in_progress,
        cancelled
    }
    public class Order
    {
        public int id;
        public User user { get; set; }
        public Products products { get; set; }
        public StatusOrder statusOrder { get; set; } = StatusOrder.in_progress;

        public Order(User user, Product product, int id)
        {
            this.user = user;
            this.product = product;
            this.id = id;
        }
    }
    public class Orders
    {
        public List<Order> orders { get; set; } = new List<Order>();

        public void AddOrder(User user, Product product, int id)
        {
            Order order = new Order(user, product, id);
            orders.Add(order);
        }
        public void DeleteOrder(int id)
        {
            orders.RemoveAll(item => item.id == id);
        }
        public void ShowOrders()
        {
            foreach (var order in orders)
            {
                Console.WriteLine($"Id заказа -{order.id}");
            }
        }
    }
}
