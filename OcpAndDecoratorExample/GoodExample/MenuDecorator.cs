
namespace OcpAndDecoratorExample.GoodExample;


public abstract class MenuDecorator : IMenu
{
    public IMenu Menu;
    public Robot Robot;
    

    internal MenuDecorator(IMenu menu, Robot robot) 
    {
        Menu = menu;
        Robot = robot;
    }
    public virtual void HandleInput(string menuItem)
    {
        Menu.HandleInput(menuItem);
    }
    public virtual List<string> GenerateMenuView()
    {
        return Menu.GenerateMenuView();
    }
    public virtual string PrintMenu(List<string> view)
    {
        return Menu.PrintMenu(view);
    }
}
