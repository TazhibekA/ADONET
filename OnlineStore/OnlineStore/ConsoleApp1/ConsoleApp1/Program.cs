using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static DataSet dataSet;

        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>() {
                new Category(0, "nan"),
                new Category(1, "kan"),
                new Category(2, "tan"),
                new Category(3, "han"),
                new Category(4, "can"),
                new Category(5, "lan"),
                new Category(6, "pan"),
                new Category(7, "xan"),
                new Category(8, "ean"),
                new Category(9, "kan"),
                new Category(10, "wan"),

            };

            List<Manufacture> manufactures = new List<Manufacture>() {
                new Manufacture(0, "nun"),
                new Manufacture(1, "tun"),
                new Manufacture(2, "bun"),
                new Manufacture(3, "run"),
                new Manufacture(4, "wun"),
                new Manufacture(5, "pun"),
                new Manufacture(6, "dun"),
                new Manufacture(7, "qun"),
                new Manufacture(8, "lun"),
                new Manufacture(9, "sun"),
                new Manufacture(10, "xun")

            };

            List<Good> goods = new List<Good>() {
                new Good(0,"ten",2,3,"qwertyuiop",200),
                new Good(1,"ben",1,9,"qwertyuiop",200),
                new Good(2,"len",3,5,"qwertyuiop",200),
                new Good(3,"ben",2,6,"qwertyuiop",200),
                new Good(4,"ken",6,3,"qwertyuiop",200),
                new Good(5,"nen",9,4,"qwertyuiop",200),
                new Good(6,"uen",8,2,"qwertyuiop",200),
                new Good(7,"men",0,1,"qwertyuiop",200),
                new Good(8,"gen",4,0,"qwertyuiop",200),
                new Good(9,"jen",5,8,"qwertyuiop",200),
                new Good(10,"ren",2,3,"qwertyuiop",200)
            };

            List<Customer> customers = new List<Customer>() {
                new Customer(000,"Kara",21,"dfgdfg","87754472102"),
                new Customer(111,"Lara",22,"dfgdfg","87754472103"),
                new Customer(222,"Mara",23,"dfgdfg","87754472104"),
                new Customer(333,"Tara",24,"dfgdfg","87754472105"),
                new Customer(444,"Nara",25,"dfgdfg","87754472106"),
                new Customer(555,"Yara",26,"dfgdfg","87754472107"),
                new Customer(666,"Bara",27,"dfgdfg","87754472108"),
                new Customer(777,"Rara",28,"dfgdfg","87754472109"),
                new Customer(888,"Para",29,"dfgdfg","87754472100"),
                new Customer(999,"Cara",20,"dfgdfg","87754472101")
            };


            List<Employee> employees = new List<Employee>() {
                new Employee(0,"Kere",21,"dfgdfg","87754472102"),
                new Employee(1,"Lere",22,"dfgdfg","87754472103"),
                new Employee(2,"Mere",23,"dfgdfg","87754472104"),
                new Employee(3,"Tere",24,"dfgdfg","87754472105"),
                new Employee(4,"Nere",25,"dfgdfg","87754472106"),
                new Employee(5,"Yere",26,"dfgdfg","87754472107"),
                new Employee(6,"Bere",27,"dfgdfg","87754472108"),
                new Employee(7,"Rere",28,"dfgdfg","87754472109"),
                new Employee(9,"Pere",29,"dfgdfg","87754472100"),
                new Employee(10,"Cere",20,"dfgdfg","87754472101")
            };

            List<OrderGood> orderGoods = new List<OrderGood>();
            List<OrderStatus> orderStatuses = new List<OrderStatus>()
            {
                  new OrderStatus(0, "On process"),
                  new OrderStatus(1, "Accepted"),
                  new OrderStatus(2, "Canceled"),
            };
            List<CartGood> cartGoods = new List<CartGood>();



            List<Transaction> transactions = new List<Transaction>();

            List<Delivery> deliveries = new List<Delivery>();



            List<Order> orders = new List<Order>();

            List<Cart> carts = new List<Cart>();

            DataSet dataSet = new DataSet("OnlineStore");
            #region Customer
            DataTable customer = new DataTable("Customer");
            DataColumn customerId = new DataColumn("Id");
            customerId.DataType = typeof(int);
            customerId.AllowDBNull = false;
            customerId.AutoIncrement = true;
            customerId.AutoIncrementSeed = 1;
            customerId.AutoIncrementStep = 1;

            DataColumn customerFullName = new DataColumn("FullName");
            customerFullName.DataType = typeof(string);

            DataColumn customerAge = new DataColumn("Age");
            customerAge.DataType = typeof(int);

            DataColumn customerAddress = new DataColumn("Address");
            customerAddress.DataType = typeof(string);

            DataColumn customerPhone = new DataColumn("Phone");
            customerPhone.DataType = typeof(string);

            customer.Columns.Add(customerId);
            customer.Columns.Add(customerFullName);
            customer.Columns.Add(customerAge);
            customer.Columns.Add(customerAddress);
            customer.Columns.Add(customerPhone);

            // customer.PrimaryKey = customerId;

            dataSet.Tables.Add(customer);
            #endregion

            #region Employee
            DataTable employee = new DataTable("Employee");
            DataColumn employeeId = new DataColumn("Id");
            employeeId.DataType = typeof(int);
            employeeId.AllowDBNull = false;
            employeeId.AutoIncrement = true;
            employeeId.AutoIncrementSeed = 1;
            employeeId.AutoIncrementStep = 1;

            DataColumn employeeFullName = new DataColumn("FullName");
            employeeFullName.DataType = typeof(string);

            DataColumn employeeAge = new DataColumn("Age");
            employeeAge.DataType = typeof(int);

            DataColumn employeeAddress = new DataColumn("Address");
            employeeAddress.DataType = typeof(string);

            DataColumn employeePhone = new DataColumn("Phone");
            employeePhone.DataType = typeof(string);

            employee.Columns.Add(employeeId);
            employee.Columns.Add(employeeFullName);
            employee.Columns.Add(employeeAge);
            employee.Columns.Add(employeeAddress);
            employee.Columns.Add(employeePhone);

            //            employee.PrimaryKey = employeeId.;

            dataSet.Tables.Add(employee);
            #endregion

            #region Cart
            DataTable cart = new DataTable("Cart");
            DataColumn cartId = new DataColumn("Id");
            cartId.DataType = typeof(int);
            cartId.AllowDBNull = false;
            cartId.AutoIncrement = true;
            cartId.AutoIncrementSeed = 1;
            cartId.AutoIncrementStep = 1;

            DataColumn cartCustomerId = new DataColumn("CustomerId");
            cartCustomerId.DataType = typeof(int);

            DataColumn cartTotalSum = new DataColumn("TotalSum");
            cartTotalSum.DataType = typeof(int);

            cart.Columns.Add(cartId);
            cart.Columns.Add(cartCustomerId);
            cart.Columns.Add(cartTotalSum);

            dataSet.Tables.Add(cart);

            // cart.PrimaryKey = cartId;
            DataRelation cartCustomerIdRelation = new DataRelation("FK_cart_CustomerId", customerId, cartCustomerId);
            #endregion

            #region OrderStatus
            DataTable orderStatus = new DataTable("OrderStatus");
            DataColumn orderStatusId = new DataColumn("Id");
            orderStatusId.DataType = typeof(int);
            orderStatusId.AllowDBNull = false;
            orderStatusId.AutoIncrement = true;
            orderStatusId.AutoIncrementSeed = 1;
            orderStatusId.AutoIncrementStep = 1;

            DataColumn orderStatusName = new DataColumn("OrderStatusName");
            orderStatusName.DataType = typeof(string);

            orderStatus.Columns.Add(orderStatusId);
            orderStatus.Columns.Add(orderStatusName);
            dataSet.Tables.Add(orderStatus);
            #endregion

            #region Order
            DataTable order = new DataTable("Order");
            DataColumn orderId = new DataColumn("Id");
            orderId.DataType = typeof(int);
            orderId.AllowDBNull = false;
            orderId.AutoIncrement = true;
            orderId.AutoIncrementSeed = 1;
            orderId.AutoIncrementStep = 1;

            DataColumn orderCustomerId = new DataColumn("CustomerId");
            orderCustomerId.DataType = typeof(int);

            DataColumn orderEmployeeId = new DataColumn("EmployeeId");
            orderEmployeeId.DataType = typeof(int);

            DataColumn orderTotalSum = new DataColumn("TotalSum");
            orderTotalSum.DataType = typeof(int);

            DataColumn orderDate = new DataColumn("OrderDate");
            orderDate.DataType = typeof(DateTime);

            DataColumn orderOrderStatusId = new DataColumn("OrderStatusId");
            orderOrderStatusId.DataType = typeof(int);

            order.Columns.Add(orderId);
            order.Columns.Add(orderCustomerId);
            order.Columns.Add(orderEmployeeId);
            order.Columns.Add(orderTotalSum);
            order.Columns.Add(orderDate);
            order.Columns.Add(orderOrderStatusId);

            dataSet.Tables.Add(order);

            DataRelation orderCustomerIdRelation = new DataRelation("FK_order_CustomerId", customerId, orderCustomerId);
            DataRelation orderEmployeeIdRelation = new DataRelation("FK_order_EmployeeId", employeeId, orderEmployeeId);
            DataRelation orderOrderStatusIdRelation = new DataRelation("FK_order_orderStatusId", orderStatusId, orderOrderStatusId);
            #endregion

            #region DeliveryStatus
            DataTable deliveryStatus = new DataTable("DeliveryStatus");
            DataColumn deliveryStatusId = new DataColumn("Id");
            deliveryStatusId.DataType = typeof(int);
            deliveryStatusId.AllowDBNull = false;
            deliveryStatusId.AutoIncrement = true;
            deliveryStatusId.AutoIncrementSeed = 1;
            deliveryStatusId.AutoIncrementStep = 1;

            DataColumn deliveryStatusName = new DataColumn("deliveryStatusName");
            deliveryStatusName.DataType = typeof(string);

            deliveryStatus.Columns.Add(deliveryStatusId);
            deliveryStatus.Columns.Add(deliveryStatusName);
            dataSet.Tables.Add(deliveryStatus);
            #endregion

            #region Delivery
            DataTable delivery = new DataTable("Delivery");
            DataColumn deliveryId = new DataColumn("Id");
            deliveryId.DataType = typeof(int);
            deliveryId.AllowDBNull = false;
            deliveryId.AutoIncrement = true;
            deliveryId.AutoIncrementSeed = 1;
            deliveryId.AutoIncrementStep = 1;

            DataColumn deliveryOrderId = new DataColumn("OrderId");
            deliveryOrderId.DataType = typeof(int);

            DataColumn deliveryDeliveryStatusId = new DataColumn("DeliveryStatusId");
            deliveryDeliveryStatusId.DataType = typeof(int);

            delivery.Columns.Add(deliveryId);
            delivery.Columns.Add(deliveryOrderId);
            delivery.Columns.Add(deliveryDeliveryStatusId);

            dataSet.Tables.Add(delivery);

            DataRelation deliveryCustomerIdRelation = new DataRelation("FK_delivery_OrderId", orderId, deliveryOrderId);
            DataRelation deliveryDeliveryStatusIdRelation = new DataRelation("FK_delivery_StatusId", deliveryStatusId, deliveryDeliveryStatusId);
            #endregion

            #region Manufacturer
            DataTable manufacturer = new DataTable("Manufacturer");
            DataColumn manufacturerId = new DataColumn("Id");
            manufacturerId.DataType = typeof(int);
            manufacturerId.AllowDBNull = false;
            manufacturerId.AutoIncrement = true;
            manufacturerId.AutoIncrementSeed = 1;
            manufacturerId.AutoIncrementStep = 1;

            DataColumn manufacturerName = new DataColumn("Name");
            manufacturerName.DataType = typeof(string);

            manufacturer.Columns.Add(manufacturerId);
            manufacturer.Columns.Add(manufacturerName);
            dataSet.Tables.Add(manufacturer);
            #endregion

            #region Category
            DataTable category = new DataTable("Category");
            DataColumn categoryId = new DataColumn("Id");
            categoryId.DataType = typeof(int);
            categoryId.AllowDBNull = false;
            categoryId.AutoIncrement = true;
            categoryId.AutoIncrementSeed = 1;
            categoryId.AutoIncrementStep = 1;

            DataColumn categoryName = new DataColumn("Name");
            categoryName.DataType = typeof(string);

            category.Columns.Add(categoryId);
            category.Columns.Add(categoryName);
            dataSet.Tables.Add(category);
            #endregion

            #region Good
            DataTable good = new DataTable("Good");
            DataColumn goodId = new DataColumn("Id");
            goodId.DataType = typeof(int);
            goodId.AllowDBNull = false;
            goodId.AutoIncrement = true;
            goodId.AutoIncrementSeed = 1;
            goodId.AutoIncrementStep = 1;

            DataColumn goodName = new DataColumn("Name");
            goodName.DataType = typeof(string);

            DataColumn goodManufacturerId = new DataColumn("ManufacturerId");
            goodManufacturerId.DataType = typeof(int);

            DataColumn goodCategoryId = new DataColumn("CategoryId");
            goodCategoryId.DataType = typeof(int);

            DataColumn goodDescription = new DataColumn("Description");
            goodDescription.DataType = typeof(string);

            DataColumn goodPrice = new DataColumn("Price");
            goodPrice.DataType = typeof(int);

            good.Columns.Add(goodId);
            good.Columns.Add(goodName);
            good.Columns.Add(goodManufacturerId);
            good.Columns.Add(goodCategoryId);
            good.Columns.Add(goodDescription);
            good.Columns.Add(goodPrice);

            dataSet.Tables.Add(good);

            DataRelation goodManufacturerIdRelation = new DataRelation("FK_good_ManufacturerId", manufacturerId, goodManufacturerId);
            DataRelation goodCategoryIdRelation = new DataRelation("FK_good_CategoryId", categoryId, goodCategoryId);
            #endregion

            #region CartGood
            DataTable cartGood = new DataTable("CartGood");
            DataColumn cartGoodId = new DataColumn("Id");
            cartGoodId.DataType = typeof(int);
            cartGoodId.AllowDBNull = false;
            cartGoodId.AutoIncrement = true;
            cartGoodId.AutoIncrementSeed = 1;
            cartGoodId.AutoIncrementStep = 1;

            DataColumn cartGoodCartId = new DataColumn("CartId");
            cartGoodCartId.DataType = typeof(int);

            DataColumn cartGoodGoodId = new DataColumn("GoodId");
            cartGoodGoodId.DataType = typeof(int);

            DataColumn cartGoodGoodCount = new DataColumn("GoodCount");
            cartGoodGoodCount.DataType = typeof(int);

            cartGood.Columns.Add(cartGoodId);
            cartGood.Columns.Add(cartGoodCartId);
            cartGood.Columns.Add(cartGoodGoodId);
            cartGood.Columns.Add(cartGoodGoodCount);

            dataSet.Tables.Add(cartGood);

            DataRelation cartGoodCartIdRelation = new DataRelation("FK_cartGood_CartId", cartId, cartGoodCartId);
            DataRelation cartGoodGoodIdRelation = new DataRelation("FK_cartGood_GoodId", goodId, cartGoodGoodId);
            #endregion

            #region OrderGood
            DataTable orderGood = new DataTable("OrderGood");
            DataColumn orderGoodId = new DataColumn("Id");
            orderGoodId.DataType = typeof(int);
            orderGoodId.AllowDBNull = false;
            orderGoodId.AutoIncrement = true;
            orderGoodId.AutoIncrementSeed = 1;
            orderGoodId.AutoIncrementStep = 1;

            DataColumn orderGoodOrderId = new DataColumn("OrderId");
            orderGoodOrderId.DataType = typeof(int);

            DataColumn orderGoodGoodId = new DataColumn("GoodId");
            orderGoodGoodId.DataType = typeof(int);

            DataColumn orderGoodGoodCount = new DataColumn("GoodCount");
            orderGoodGoodCount.DataType = typeof(int);

            orderGood.Columns.Add(orderGoodId);
            orderGood.Columns.Add(orderGoodOrderId);
            orderGood.Columns.Add(orderGoodGoodId);
            orderGood.Columns.Add(orderGoodGoodCount);

            dataSet.Tables.Add(orderGood);

            DataRelation orderGoodCartIdRelation = new DataRelation("FK_orderGood_CartId", orderId, orderGoodOrderId);
            DataRelation orderGoodGoodIdRelation = new DataRelation("FK_orderGood_CartId", goodId, orderGoodGoodId);
            #endregion

            #region TransactionStatus
            DataTable transactionStatus = new DataTable("TransactionStatus");
            DataColumn transactionStatusId = new DataColumn("Id");
            transactionStatusId.DataType = typeof(int);
            transactionStatusId.AllowDBNull = false;
            transactionStatusId.AutoIncrement = true;
            transactionStatusId.AutoIncrementSeed = 1;
            transactionStatusId.AutoIncrementStep = 1;

            DataColumn transactionStatusName = new DataColumn("transactionStatusName");
            transactionStatusName.DataType = typeof(string);

            transactionStatus.Columns.Add(transactionStatusId);
            transactionStatus.Columns.Add(transactionStatusName);
            dataSet.Tables.Add(transactionStatus);
            #endregion

            #region Transaction
            DataTable transaction = new DataTable("Transaction");
            DataColumn transactionId = new DataColumn("Id");
            transactionId.DataType = typeof(int);
            transactionId.AllowDBNull = false;
            transactionId.AutoIncrement = true;
            transactionId.AutoIncrementSeed = 1;
            transactionId.AutoIncrementStep = 1;

            DataColumn transactionOrderId = new DataColumn("OrderId");
            transactionOrderId.DataType = typeof(int);

            DataColumn transactionTransactionStatusId = new DataColumn("TransactionStatusId");
            transactionTransactionStatusId.DataType = typeof(int);

            transaction.Columns.Add(transactionId);
            transaction.Columns.Add(transactionOrderId);
            transaction.Columns.Add(transactionTransactionStatusId);

            dataSet.Tables.Add(transaction);

            DataRelation transactionCustomerIdRelation = new DataRelation("FK_transaction_OrderId", orderId, transactionOrderId);
            DataRelation transactionTransactionStatusIdRelation = new DataRelation("FK_transaction_StatusId", transactionStatusId, transactionTransactionStatusId);
            #endregion 

            AddRowsTables(dataSet, category, manufacturer, good, customer, employee, cart, categories, employees, customers, goods, manufactures, carts);


            while (true)
            {
                Console.Clear();



                Console.WriteLine("------------------------");
                Console.WriteLine("     1 - Log in");
                Console.WriteLine("     2 - Exit");
                Console.WriteLine("------------------------");
                Console.Write("Choose: ");
                string ch = Console.ReadLine();
                int intch;



                bool success = Int32.TryParse(ch, out intch);
                if (success)
                {
                    switch (intch)
                    {

                        case 1:
                            Console.WriteLine("------------------------");
                            Console.Write("Enter the FullName: ");

                            string nameCustomer = Console.ReadLine();
                            if (CheckCustomer(customers, nameCustomer))
                            {
                                int customerIdd = IdCustomer(customers, nameCustomer);
                                bool correctName = true;
                                while (correctName)
                                {
                                    Console.Clear();
                                    Console.WriteLine("--------------------------");
                                    Console.WriteLine("  1 - Add goods to cart");
                                    Console.WriteLine("  2 - Check the cart");
                                    Console.WriteLine("  3 - Clear the cart");
                                    Console.WriteLine("  4 - Delete goods in cart");
                                    Console.WriteLine("  5 - Make order");
                                    Console.WriteLine("  6 - Check my orders");
                                    Console.WriteLine("  7 - Exit account");
                                    Console.WriteLine("--------------------------");
                                    Console.Write("Choose: ");
                                    string choose = Console.ReadLine();
                                    int intChoose;
                                    bool successs = Int32.TryParse(choose, out intChoose);
                                    if (successs)
                                    {
                                        switch (intChoose)
                                        {
                                            case 1:
                                                GoodChoose(goods, customerIdd, carts, cartGoods, cartGood, cart);
                                                break;
                                            case 2:
                                                CheckCart(cartGoods, carts, customerIdd, goods);
                                                break;
                                            case 3:
                                                CleanCart(cartGoods, carts, customerIdd, goods);
                                                break;
                                            case 4:
                                                DeleteGoodsInCart(goods, customerIdd, carts, cartGoods, cartGood, cart);
                                                break;
                                            case 5:
                                                MakeOrder(cartGoods, carts, orders, orderGoods, customerIdd, goods, employees, orderStatuses, deliveries, transactions);
                                                break;
                                            case 6:
                                                CheckOrder(orders, customerIdd, employees, orderGoods, goods, orderStatuses);
                                                break;
                                            case 7: correctName = false; break;
                                            default:
                                                Console.WriteLine("Please, enter 1 to 4");

                                                break;
                                        }
                                    }
                                    else {
                                        Console.WriteLine("Please, enter number");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorrect name!");
                                Console.Read();

                            }
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please enter 1 or 2");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Enter numbers!");
                    Console.Read();
                }


            }

        }


        public static void AddRowsTables(DataSet dataSet, DataTable category, DataTable manufacture, DataTable good, DataTable customer, DataTable employee, DataTable cart, List<Category> categories, List<Employee> employees, List<Customer> customers, List<Good> goods, List<Manufacture> manufactures, List<Cart> carts) {


            foreach (var item in customers) {
                customer.Rows.Add(new object[] { item.Id, item.FullName, item.Age, item.Address, item.Phone });
            }
            foreach (var item in employees)
            {
                employee.Rows.Add(new object[] { item.Id, item.FullName, item.Age, item.Address, item.Phone });
            }
            foreach (var item in goods)
            {
                good.Rows.Add(new object[] { item.Id, item.Name, item.ManufacturerId, item.CategoryId, item.Description, item.Price });
            }
            foreach (var item in categories)
            {
                category.Rows.Add(new object[] { item.Id, item.Name });
            }
            foreach (var item in manufactures)
            {
                manufacture.Rows.Add(new object[] { item.Id, item.Name });
            }

            for (int i = 0; i < customers.Count; i++) {
                carts.Add(new Cart(i, customers[i].Id, 0));
            }

            foreach (var item in carts)
            {
                cart.Rows.Add(new object[] { item.Id, item.CustomerId, item.TotalSum });
            }
        }

        public static bool CheckCustomer(List<Customer> customers, string nameCustomer) {
            foreach (var item in customers)
            {
                if (item.FullName == nameCustomer)
                {
                    return true;
                }
            }
            return false;

        }

        public static int IdCustomer(List<Customer> customers, string nameCustomer)
        {
            foreach (var item in customers)
            {
                if (item.FullName == nameCustomer)
                {
                    return item.Id;
                }
            }
            return 0;

        }

        public static bool CheckChooseMainMenu(string choose) {
            if (int.Parse(choose) > 4 && int.Parse(choose) < 1) {
                return false;
            }
            return true;

        }

        public static void GoodChoose(List<Good> goods, int customerId, List<Cart> carts, List<CartGood> cartGoods, DataTable cartGood, DataTable cart)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            foreach (var item in goods)
            {
                Console.WriteLine($"  {item.Id}\t{item.Name}\t{item.Description}\t{item.Price}");
            }
            Console.WriteLine("----------------------------------------");
            int id = 0;
            bool firstCheck = true;
            while (firstCheck)
            {
                Console.Write("Choose id of good: ");
                string choose = Console.ReadLine();

                int intch;
                bool success = Int32.TryParse(choose, out intch);
                if (!success || intch >= goods.Count || intch < 0)
                {
                    Console.WriteLine("Enter numbers 0-10! ");
                }
                else
                {
                    firstCheck = false;
                    id = intch;
                }
            }
            int count = 0;
            bool secondCheck = true;
            while (secondCheck)
            {
                Console.Write("Choose count of good: ");
                string choose = Console.ReadLine();

                int intch;
                bool success = Int32.TryParse(choose, out intch);
                if (!success || intch == 0 || intch < 0)
                {
                    Console.WriteLine("Enter numbers more than 0! ");
                }
                else
                {
                    secondCheck = false;
                    count = intch;
                }
            }
            int cartId = 0;
            foreach (var item in carts) {
                if (item.CustomerId == customerId) {
                    cartId = item.Id;
                }
            }

            cartGoods.Add(new CartGood(cartGoods.Count, cartId, id, count));

            foreach (var item in carts)
            {
                if (item.CustomerId == customerId)
                {
                    item.TotalSum = SumCostGoodsInCart(customerId, goods, cartGoods, carts);
                }
            }




            Console.WriteLine("Good added to cart!");
            //foreach (var item in cartGoods) {
            //    Console.WriteLine($"{item.Id}\t{item.CartId}\t{item.GoodId}\t{item.GoodCount}");
            //}

            //foreach (var item in carts)
            //{
            //    Console.WriteLine($"{item.Id}\t{item.CustomerId}\t{item.TotalSum}");
            //}
            Console.Read();
        }

        public static int SumCostGoodsInCart(int customerId, List<Good> goods, List<CartGood> cartGoods, List<Cart> carts) {
            int sum = 0;
            for (int i = 0; i < carts.Count; i++)
            { for (int j = 0; j < cartGoods.Count; j++)
                {
                    if (carts[i].CustomerId == customerId)
                    {
                        if (carts[i].Id == cartGoods[j].CartId)
                        {
                            sum = sum + (goods[cartGoods[j].GoodId].Price * cartGoods[j].GoodCount);

                        }
                    }
                }
            }

            return sum;

        }

        public static void CheckCart(List<CartGood> cartGoods, List<Cart> carts, int customerId, List<Good> goods) {
            if (IsFullCart(cartGoods, carts, customerId))
            {
                int cartId = 0;
                foreach (var item in carts)
                {
                    if (item.CustomerId == customerId)
                    {
                        cartId = item.Id;
                    }
                }
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Id\tName\tCount\tPrice");
                foreach (var item in cartGoods)
                {
                    if (item.CartId == cartId)
                    {
                        foreach (var secItem in goods)
                        {
                            if (secItem.Id == item.GoodId)
                            {
                                Console.WriteLine($"{secItem.Id}\t{secItem.Name}\t{item.GoodCount}\t{secItem.Price}");
                            }
                        }
                    }

                }
                Console.WriteLine("----------------------------------------");
                foreach (var item in carts)
                {
                    if (item.CustomerId == customerId)
                    {
                        Console.WriteLine("Total sum: " + item.TotalSum);
                    }
                }
                Console.Read();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Cart is empty!");
                Console.Read();
            }
            }

        public static void CleanCart(List<CartGood> cartGoods, List<Cart> carts, int customerId, List<Good> goods)
        {
            if (IsFullCart(cartGoods, carts, customerId))
            {
                int cartId = 0;
                foreach (var item in carts)
                {
                    if (item.CustomerId == customerId)
                    {
                        cartId = item.Id;
                    }
                }


                cartGoods.RemoveAll(item => item.CartId == cartId);

                foreach (var item in carts)
                {
                    if (item.CustomerId == customerId)
                    {
                        item.TotalSum = SumCostGoodsInCart(customerId, goods, cartGoods, carts);
                    }
                }
                Console.Clear();
                Console.WriteLine("Cart was cleared!");
                Console.Read();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Cart is empty!");
                Console.Read();
            }
        }

        public static void CleanCartAfterOrder(List<CartGood> cartGoods, List<Cart> carts, int customerId, List<Good> goods)
        {
            int cartId = 0;
            foreach (var item in carts)
            {
                if (item.CustomerId == customerId)
                {
                    cartId = item.Id;
                }
            }


            cartGoods.RemoveAll(item => item.CartId == cartId);

            foreach (var item in carts)
            {
                if (item.CustomerId == customerId)
                {
                    item.TotalSum = SumCostGoodsInCart(customerId, goods, cartGoods, carts);
                }
            }

            Console.WriteLine("Cart was cleared because of ordering!");

        }

        public static void DeleteGoodsInCart(List<Good> goods, int customerId, List<Cart> carts, List<CartGood> cartGoods, DataTable cartGood, DataTable cart)
        {
            if (IsFullCart(cartGoods, carts, customerId))
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                foreach (var item in goods)
                {
                    Console.WriteLine($"  {item.Id}\t{item.Name}\t{item.Description}\t{item.Price}");
                }
                Console.WriteLine("----------------------------------------");
                int id = 0;
                bool firstCheck = true;
                while (firstCheck)
                {
                    Console.Write("Choose id of good: ");
                    string choose = Console.ReadLine();

                    int intch;
                    bool success = Int32.TryParse(choose, out intch);
                    if (!success || intch >= goods.Count)
                    {
                        Console.WriteLine("Enter numbers 0-10! ");
                    }
                    else
                    {
                        firstCheck = false;
                        id = intch;
                    }
                }
                int count = 0;
                bool secondCheck = true;
                while (secondCheck)
                {
                    Console.Write("Choose count of good: ");
                    string choose = Console.ReadLine();

                    int intch;
                    bool success = Int32.TryParse(choose, out intch);
                    if (!success || intch == 0 || intch < 0)
                    {
                        Console.WriteLine("Enter numbers! ");
                    }
                    else
                    {
                        secondCheck = false;
                        count = intch;
                    }
                }
                int cartId = 0;
                foreach (var item in carts)
                {
                    if (item.CustomerId == customerId)
                    {
                        cartId = item.Id;
                    }
                }

                bool check = false;
                for (int i = 0; i < cartGoods.Count; i++)
                {
                    if (cartGoods[i].CartId == cartId)
                    {
                        if (cartGoods[i].GoodId == id)
                        {
                            if (cartGoods[i].GoodCount > count)
                                cartGoods[i].GoodCount -= count;
                            else if (cartGoods[i].GoodCount == count)
                                cartGoods.Remove(cartGoods[i]);
                            else
                                Console.WriteLine("Quantity of good exceeds current quantity!");
                            check = true;
                        }
                    }

                }
                foreach (var item in carts)
                {
                    if (item.CustomerId == customerId)
                    {
                        item.TotalSum = SumCostGoodsInCart(customerId, goods, cartGoods, carts);
                    }
                }


                if (check == false)
                {
                    Console.WriteLine("There is no such good in cart!");
                }
                else
                    Console.WriteLine("Good was deleted!");
                Console.Read();
            }
            else {
                Console.Clear();
                Console.WriteLine("Cart is empty!");
                Console.Read();
            }
        }

        public static bool IsFullCart(List<CartGood> cartGoods, List<Cart> carts, int customerId) {
            int cartId = 0;
            foreach (var item in carts)
            {
                if (item.CustomerId == customerId)
                {
                    cartId = item.Id;
                }
            }

            foreach (var item in cartGoods) {
                if (item.CartId == cartId) {
                    return true;
                }

            }
            return false;
        }

        public static void MakeOrder(List<CartGood> cartGoods, List<Cart> carts, List<Order> orders, List<OrderGood> orderGoods, int customerId, List<Good> goods, List<Employee> employees, List<OrderStatus> orderStatuses, List<Delivery> deliveries, List<Transaction> transactions) {
            if (IsFullCart(cartGoods, carts, customerId))
            {
                int cartId = 0;
                foreach (var item in carts)
                {
                    if (item.CustomerId == customerId)
                    {
                        cartId = item.Id;
                    }
                }
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Id\tName\tCount\tPrice");
                foreach (var item in cartGoods)
                {
                    if (item.CartId == cartId)
                    {
                        foreach (var secItem in goods)
                        {
                            if (secItem.Id == item.GoodId)
                            {
                                Console.WriteLine($"{secItem.Id}\t{secItem.Name}\t{item.GoodCount}\t{secItem.Price}");
                            }
                        }
                    }

                }
                Console.WriteLine("----------------------------------------");
                int totalSum = 0;
                foreach (var item in carts)
                {
                    if (item.CustomerId == customerId)
                    {
                        Console.WriteLine("Total sum: " + item.TotalSum);
                        totalSum = item.TotalSum;
                    }
                }

                Console.WriteLine("------------------------");
                Console.WriteLine("   1 - Make order");
                Console.WriteLine("   2 - Cancel");
                Console.WriteLine("------------------------");

                int ch = 0;
                bool check = true;
                while (check)
                {
                    Console.Write("Choose : ");
                    string choose = Console.ReadLine();

                    int intch;
                    bool success = Int32.TryParse(choose, out intch);
                    if (!success || intch > 2 || intch < 1)
                    {
                        Console.WriteLine("Enter numbers 1 or 2! ");
                    }
                    else
                    {
                        check = false;
                        ch = intch;
                    }
                }


                Random rand = new Random();

                int temp;

                temp = rand.Next(employees.Count);

                int orderCount = orders.Count;
                if (ch == 1)
                {
                    orders.Add(new Order(orders.Count, customerId, temp, totalSum, DateTime.Now, orderStatuses[0].Id));

                    foreach (var item in cartGoods)
                    {
                        if (item.CartId == cartId)
                        {
                            foreach (var secItem in goods)
                            {
                                if (secItem.Id == item.GoodId)
                                {
                                    orderGoods.Add(new OrderGood((orderGoods.Count), orderCount, item.GoodId, item.GoodCount));
                                }
                            }
                        }

                    }

                    //foreach (var item in orders)
                    //{
                    //    Console.WriteLine($"{item.Id}\t{item.CustomerId}\t{item.EmployeeId}\t{item.TotalSum}\t{item.Date}");
                    //}

                    //foreach (var item in orderGoods)
                    //{
                    //    Console.WriteLine($"{item.Id}\t{item.OrderId}\t{item.GoodId}\t{item.GoodCount}");
                    //}

                    CleanCartAfterOrder(cartGoods, carts, customerId, goods);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("                          Delivery!");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("                  ------------------------");
                    Console.WriteLine("                         1 - Pay " + totalSum + " tg");
                    Console.WriteLine("                         2 - Refuse");
                    Console.WriteLine("                  ------------------------");

                    int secondCh = 0;
                    bool secondCheck = true;
                    while (secondCheck)
                    {
                        Console.Write("Choose : ");
                        string choose = Console.ReadLine();

                        int intch;
                        bool success = Int32.TryParse(choose, out intch);
                        if (!success || intch > 2 || intch < 1)
                        {
                            Console.WriteLine("Enter numbers 1 or 2! ");
                        }
                        else
                        {
                            secondCheck = false;
                            secondCh = intch;
                        }
                    }

                    if (secondCh == 1) {
                        orders[orderCount].StatusId = orderStatuses[1].Id;
                        deliveries.Add(new Delivery(deliveries.Count, orderCount));
                        transactions.Add(new Transaction(transactions.Count, orderCount));

                    }
                    else if (secondCh == 2) {
                        orders[orderCount].StatusId = orderStatuses[2].Id;
                    }


                }
            }
            else {
                Console.Clear();
                Console.WriteLine("Cart is empty!");
                Console.Read();
            }


        }

        public static bool IsFullOrders(int customerId, List<Order> orders) {
            foreach (var item in orders) {
                if (item.CustomerId == customerId) {
                    return true;
                }
            }
            return false;

        }
        public static void CheckOrder(List<Order> orders, int customerId, List<Employee> employees, List<OrderGood> orderGoods, List<Good> goods, List<OrderStatus> orderStatuses)
        {
            if (IsFullOrders(customerId, orders))
            {
                Console.Clear();
                Console.WriteLine("Date of order\t\tEmployee's fullname\t\tTotal Sum\t\tStatus");
                foreach (var item in orders)
                {
                    foreach (var secItem in employees)
                    {
                        foreach (var thirdItem in orderStatuses)
                            if (item.CustomerId == customerId)
                            {
                                if (secItem.Id == item.EmployeeId)
                                {
                                    if (thirdItem.Id == item.StatusId)
                                        Console.WriteLine($"{item.Date}\t\t{secItem.FullName}\t\t\t{item.TotalSum}\t\t\t{thirdItem.Name}");

                                }
                            }
                    }
                }
                Console.Read();
            }
            else
                Console.Clear();
                Console.WriteLine("There is no order!");
            Console.Read();
        }
        
    
      
    }
}
