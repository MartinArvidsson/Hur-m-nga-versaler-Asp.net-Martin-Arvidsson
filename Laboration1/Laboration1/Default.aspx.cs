using Laboration1.Model;
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

        protected void RunButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = TextAnalyzer.NumberOfCapitals(Textbox.Text).ToString();
            Textbox.Enabled = false;
            ResultPanel.Visible = true;
            RunButton.Visible = false;
            ResetButton.Visible = true;
        }
    }
}