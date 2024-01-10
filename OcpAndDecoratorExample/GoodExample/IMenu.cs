using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpAndDecoratorExample.GoodExample;

public interface IMenu
{
    public string PrintMenu(List<string> view);
    public List<string> GenerateMenuView();
    public void HandleInput(string menuItem);
}
