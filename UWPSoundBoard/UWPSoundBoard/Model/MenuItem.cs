using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    //In splitview pane there will be MenuItems, The item has IconFile and Category as properties.
    public class MenuItem
    {
        //To display the menu item we need the icon and category name
        //That is the reason we have created separate MEnuItem class.
        public string IconFile { get; set; }
        public SoundCategory Category { get; set; }
    }
}
