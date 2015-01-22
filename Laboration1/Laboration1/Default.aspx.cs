using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboration1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button_Click(object sender, EventArgs e)
        {
            if(Button.Text !="Starta om")
            {
                int Versaler = 0;
                string Information = Textbox.Text;
                for (int i = 0; i < Information.Length; i++)
                {
                    if (char.IsUpper(Information[i])) Versaler++;
                }
                
                Result.Text = string.Format("Det fanns {0} Versaler", Versaler);
                Button.Text = "Starta om";
                Textbox.Enabled = false;
            }
            else
            {
                Button.Text = "Kör!";
                Result.Text = "";
                Textbox.Text = "";
                Textbox.Enabled = true;
            }
        }
    }
}