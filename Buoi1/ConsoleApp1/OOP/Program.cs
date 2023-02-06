using OOP;

internal class Program
{
    private static void Main(string[] args)
    {
        //Students students = new Students();
        //students.Id = 1;
        //students.Name = "Viet";
        //Console.WriteLine(students.ToString());

        //Students students2 = new Students(2, "Nguyet");
        //Console.WriteLine(students2.ToString());
        //Console.WriteLine("viet\nlong");
        // le viet\t

        IAction action = new NguoiA();
        action.Chan();
        


    }
}