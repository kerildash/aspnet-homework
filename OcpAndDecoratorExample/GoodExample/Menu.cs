

namespace OcpAndDecoratorExample.GoodExample;

public class Menu : IMenu
{
    public Robot Robot;
    public Menu(Robot robot)
    {
        Robot = new Robot();
    }

    public virtual string PrintMenu(List<string> view)
    {
        //var view = GenerateMenuView();
        foreach (var item in view)
        {
            Console.WriteLine(item);
        }
        return Console.ReadLine().Trim();
    }
    public List<string> GenerateMenuView()
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

    public void HandleInput(string menuItem)
    {
        try
        {           

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
