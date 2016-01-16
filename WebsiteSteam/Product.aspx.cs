using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Handler.Instance.GetProducts();
        if (Handler.Instance.User != null)
        {
            btnAuth.Text = "Logout";
        }
        else
        {
            btnAuth.Text = "Login";
            btnCart.Enabled = false;
            btnStuff.Enabled = false;
        }
    }
    protected void btHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void btGames_Click(object sender, EventArgs e)
    {
        Response.Redirect("Product.aspx");
        Handler.Instance.Type = 1;
    }
    protected void btSoft_Click(object sender, EventArgs e)
    {
        Response.Redirect("Product.aspx");
        Handler.Instance.Type = 2;
    }
    protected void btHard_Click(object sender, EventArgs e)
    {
        Response.Redirect("Product.aspx");
        Handler.Instance.Type = 3;
    }
    protected void btCart_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cart.aspx");
    }
    protected void btStuff_Click(object sender, EventArgs e)
    {
        Response.Redirect("Library.aspx");
    }
    protected void btAuth_Click(object sender, EventArgs e)
    {
        if (Handler.Instance.User != null)
        {
            Handler.Instance.User = null;
            Response.Redirect("Home.aspx");
        }
        else
        {
            Response.Redirect("Authentication.aspx");
        }
    }
    protected void btSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect("Product.aspx");
    }
}