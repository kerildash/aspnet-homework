using OcpAndDecoratorExample.GoodExample;

namespace OcpAndDecoratorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot() ;
            var menu = new AdditionalOptionsMenuDecorator(new Menu(robot), robot);
            var input = menu.PrintMenu(menu.GenerateMenuView());
            menu.HandleInput(input);
        }
    }
}
