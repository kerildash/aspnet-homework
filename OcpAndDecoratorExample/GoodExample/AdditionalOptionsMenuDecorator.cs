using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpAndDecoratorExample.GoodExample
{
    internal class AdditionalOptionsMenuDecorator : MenuDecorator
    {
        public AdditionalOptionsMenuDecorator(IMenu menu, Robot robot) : base(menu, robot) { }
        public override void HandleInput(string menuItem)
        {
            switch (menuItem)
            {
                case "3":
                    Robot.DoWork3();
                    break;
                case "4":
                    Robot.DoWork4();
                    break;
                default:
                    Menu.HandleInput(menuItem);
                    break;
            }
        }

        public override List<string> GenerateMenuView()
        {
            List<string> newItems = [
                "3. Do 3rd work",
                "4. Do 4th work"
            ];
            var view = Menu.GenerateMenuView();
            int insertPlase = view.IndexOf("");
            foreach ( var item in newItems )
            {
                view.Insert(insertPlase, item);
                insertPlase++;
            }
            return view;
        }

        public override string PrintMenu(List<string> view)
        {
            return Menu.PrintMenu(view);
        }

    }

}
