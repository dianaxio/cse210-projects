using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Address[] _addresses =  new Address[2];
        Customer[] _customers =  new Customer[2];
        List<Product>[] _products_lists = new List<Product>[2];
        Order[] _orders = new Order[2];

        _addresses[0] = new Address("3031 Mulberry Street", "Conroe", "Texas", "United States");
        _customers[0] =  new Customer("John Smith",_addresses[0]);
        _products_lists[0] = new List<Product>();
        _products_lists[0].Add(new Product("Fire TV Stick 4K, brilliant 4K streaming quality, TV and smart home controls, free and live TV","B08XVYZ1Y5",29.99f,3));
        _products_lists[0].Add(new Product("Apple AirPods Pro (2nd Generation) Wireless Earbuds, Up to 2X More Active Noise Cancelling, Adaptive Transparency, Personalized Spatial Audio, MagSafe Charging Case, Bluetooth Headphones for iPhone","B0BDHWDR12",199f,1));
        _orders[0] = new Order(_customers[0],_products_lists[0]);

        _addresses[1] = new Address("Pellegrini avenue, 3rd Street", "Rosario", "Rosario", "Argentina");
        _customers[1] =  new Customer("Enriqueta Mendoza",_addresses[1]);
        _products_lists[1] = new List<Product>();
        _products_lists[1].Add(new Product("Apple EarPods Headphones with Lightning Connector. Microphone with Built-in Remote to Control Music, Phone Calls, and Volume. Wired Earbuds for iPhone","B01M0GB8CC",16.99f,2));
        _products_lists[1].Add(new Product("Basics Lightweight Super Soft Easy Care Microfiber Pillowcase, Standard, Bright White 2 Count","B07B4Z9L7M",9.88f,4));
        _products_lists[1].Add(new Product("Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones","0735211299",14.99f,2));
        _orders[1] = new Order(_customers[1],_products_lists[1]);

        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\nFor Customer Number {i+1} the Order is:");
            Console.WriteLine("\nPacking Label:\n\n{0}",_orders[i].GetPackingLabel()); 
            Console.WriteLine("Shipping Label:\n\n{0}",_orders[i].GetShippingLabel());
            Console.WriteLine("\nTotal Cost: ${0}\n\n",_orders[i].GetTotalCost());
        }
    }
}