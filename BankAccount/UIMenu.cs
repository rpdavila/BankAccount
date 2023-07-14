using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class UIMenu
    {
        public string Selection { get; set; }

        public string Option { get; set; }

        public UIMenu(int selection, string option)
        {
            this.Selection = selection.ToString();
            this.Option = option;   
        }

        public int SelectionToInt()
        {
            int selection = int.Parse(Selection);
            return selection;
        }  
    }

    
}
