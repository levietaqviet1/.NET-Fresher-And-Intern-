using buoi2;

internal class Program
{
    private static void Main(string[] args)
    {
        IManager manager = new Manager();
        int choose;
        do
        {
            choose = Menu();
            switch (choose)
            {
                case 0:
                    return;
                case 1:
                    manager.Create();
                    break;
                case 2:
                    manager.ShowList();
                    break;
                case 3:
                    manager.Update();
                    break;
                case 4:
                    manager.Delete();
                    break;
                case 5:
                    manager.SaveFile("..\\..\\..\\data.txt");
                    break;
                case 6:
                    manager.LoadFile("..\\..\\..\\data.txt");
                    break;
            }
        } while (choose != 0);
    } 

    public static int Menu()
    {
        int choose = 0;
        do
        {
        Console.WriteLine("Menu:");
        
        Console.WriteLine("1. Input to list Employee");
        Console.WriteLine("2. Show list Employee");
        Console.WriteLine("3. Update information of Employee");
        Console.WriteLine("4. Remove Employee by code");
        Console.WriteLine("5. Save to file");
        Console.WriteLine("6. Load from file");
        Console.WriteLine("0. Exit");
        choose = int.Parse(Console.ReadLine());
        } while (choose < 0 || choose > 6);

        return choose;
    }
}