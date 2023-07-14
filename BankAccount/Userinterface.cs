using ConsoleTables;

namespace BankAccount
{
    public class UserInterface
    {

        List<UIMenu> allMenus = new List<UIMenu>();

        public void AddMenuCategory(int selection, string option)
        {
            var addCategoryOption = new UIMenu(selection, option);
            allMenus.Add(addCategoryOption);
            
        }
        
        public void RemoveMenuCategory(int selection)
        {            
            var itemToRemove = allMenus.Single(item => item.Selection == selection.ToString());
            allMenus.Remove(itemToRemove);
            
            for (int i = 0; i < allMenus.Count; i++)
            {
                int x = int.Parse(allMenus[i].Selection);
                if (x > i + 1)
                {
                    x = i + 1;
                    allMenus[i].Selection = x.ToString();
                }
            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to Your Bank");
            
            var table = new ConsoleTable("Selection", "Option");
            
            foreach (var menu in allMenus)
            {                
                table.AddRow(menu.Selection, menu.Option);                
            }
            table.Write(Format.Alternative);
        }





        

        
    }
}
