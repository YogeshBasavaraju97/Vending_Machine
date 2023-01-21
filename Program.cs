namespace VendingMachine;
class Program
{
    static void initialise(VendingMachine[] vms)
    {
        Random r = new Random();
        vms[0].addCans(r.Next(1, 11));
        vms[0].setName("Machine 1");
        vms[0].setLocation("Hallway");
        vms[1].addCans(r.Next(1, 11));
        vms[1].setName("Machine 2");
        vms[1].setLocation("First Floor");
        vms[2].addCans(r.Next(1, 11));
        vms[2].setName("Machine 3");
        vms[2].setLocation("Lower Ground Floor");
        vms[3].setName("Machine 4");
        vms[3].setLocation("Lower Ground Floor");
        vms[4].setName("Machine 5");
        vms[4].setLocation("Lower Ground Floor");
    }

    static void print(VendingMachine[] vms)
    {
        foreach (VendingMachine vm in vms)
        {
            Console.WriteLine(vm.ToString());
        }
    }

    static void buyCans(VendingMachine[] vms)
    {
        // randomly buying cans from the machines
        Random r = new Random();
        foreach (VendingMachine vm in vms)
        {
            // random number of cans to purchase
            int cansToBuy = r.Next(1, 11);
            // we need to insert 1 token for each can to be purchesed
            if (vm.insertToken(cansToBuy))
            {
                Console.WriteLine("Successfully bought " + cansToBuy + " cans");
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        VendingMachine[] vendingMachines = { new VendingMachine(),
 new VendingMachine(),
 new VendingMachine(),
 new VendingMachine(10),
 new VendingMachine(10)
 };
        initialise(vendingMachines);
        print(vendingMachines);
        buyCans(vendingMachines);
        // try inserting one more coin to machine[0]
        if (vendingMachines[0].insertToken())
        {
            Console.WriteLine("Successfully bought one more can");
        }
        Console.WriteLine("Machines that need refilling:");
        for (int i = 0; i < vendingMachines.Length; i++)
        {
            if (vendingMachines[i].getCans() <= 3)
            {
                Console.WriteLine($"Vending machine {vendingMachines[i].getName()} in " +
                vendingMachines[i].getLocation() + " needs refilling: " +
                vendingMachines[i].getCans() + " cans left");
            }
        }
    }
}

