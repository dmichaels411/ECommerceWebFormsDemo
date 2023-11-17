using ECommerceWebFormsDemo.Logic;
using ECommerceWebFormsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerceWebFormsDemo
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<CartItem> GetCartItems()
        {
            ShoppingCartActions cartActions = new ShoppingCartActions();
            return cartActions.GetCartItems();
        }
    }
}