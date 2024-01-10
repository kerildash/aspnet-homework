
// The code at the moment before making changes in it
namespace OcpAndDecoratorExample.InitialPoint;


//Menu class to provide a cli for program user
internal class Menu
{
    Robot Robot;
    internal Menu(Robot robot)
    {
        Robot = new Robot();
    }
    
    internal virtual void PrintMenu()
    {
        var view = GenerateMenuView();
        foreach (var item in view)
        {
            Console.WriteLine(item);
        }
    }
    private protected List<string> GenerateMenuView()
    {
        List<string> optionLIst =
        [
            "\n   MENU",
            "1. Do first job.",
            "2. Do second job.",
            "",
            "0. Exit.",
            "",
            "Choose what to do: ",
        ];
        return optionLIst;
    }

    internal void HandleInput()
    {
        try
        {
            string menuItem = Console.ReadLine().Trim();
            Console.WriteLine("");

            switch (menuItem)
            {
                case "1":
                    Robot.DoWork1();
                    break;
                case "2":
                    Robot.DoWork2();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
