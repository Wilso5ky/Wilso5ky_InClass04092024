using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wilso5ky_InClass04092024
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            //This should only run once when the page is initally loaded in the browser
            lbFruits.Items.Add("Strawberry");
        }

        protected void lbFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This code wtuns when the user selects a new item from the lbFruits List Box
            //Copy the currently selected item fromthe List box into our label
            lblChosenFruit.Text = lbFruits.SelectedValue;
        }
        //I need an event that will run when the user, 
        //in their browswer, selects a fruit from the list box
        //"event-driven" programming.
        //Our event is The user selected an item from the list box
    }
}