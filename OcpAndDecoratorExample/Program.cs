using OcpAndDecoratorExample.InitialPoint;

namespace OcpAndDecoratorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu(new Robot());
            menu.PrintMenu();
        }
    }
}
