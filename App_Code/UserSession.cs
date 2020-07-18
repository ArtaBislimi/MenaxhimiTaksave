using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiTaksit.BO;

namespace MenaxhimiTaksit.App_Code
{
    public class UserSession
    {
        public static User LoggedUser = null;
        
        //Metoda per Manual
        public static void ShowHelpManual(System.Windows.Forms.Form parent ,string htmlpage)
        {                                              //linku i manualit
            System.Windows.Forms.Help.ShowHelp(parent, @" C:\Users\Arta\Dropbox\My PC (DESKTOP-496EP8N)\Desktop\MenaxhimiTaksitManual.chm", System.Windows.Forms.HelpNavigator.TableOfContents,htmlpage);// helpNavigation.Topic //forma:overview
        }
    }
}
