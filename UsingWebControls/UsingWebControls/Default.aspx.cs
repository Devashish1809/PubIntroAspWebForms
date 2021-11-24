using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingWebControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            var fname = FirstNameTextBox.Text;
            var lname = LastNameTextBox.Text;
            var state = StatesDropDown.SelectedValue;
            OutputLabel.Text = fname + " " + " " + lname + " " + state;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}