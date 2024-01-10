
namespace OcpAndDecoratorExample.BadExample;
// the code before changes made in a bad way
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

    //Let's add new options to a menu!
    private protected List<string> GenerateMenuView()
    {
        List<string> optionLIst =
        [
            "\n   MENU",
            "1. Do first job.",
            "2. Do second job.",
            "3. Do 3rd job",    //changes directly in the method => possible new bugs in tested code
            "4. Do 4th job",    //changes directly in the method 
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
                case "3":                 //changes directly in the method 
                    Robot.DoWork3();      //
                    break;                //
                case "4":                 //
                    Robot.DoWork4();      //
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
