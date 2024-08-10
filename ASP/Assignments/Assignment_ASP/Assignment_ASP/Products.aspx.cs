using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Assignment_ASP
{
    public partial class Products : System.Web.UI.Page
    {

            
            private readonly Dictionary<string, (string ImageUrl, decimal Price)> products = new Dictionary<string, (string ImageUrl, decimal Price)>
            {
                { "laptop", ("~/Images/laptop.jpg", 35000.08m) },
                 { "Tab", ("~/Images/tab.jpg", 5500.39m) },
                  { "Headphones", ("~/Images/Headphones.jpg", 15000.21m) },
                   { "SmartWatch", ("~/Images/SmartWatch.jpg", 4900.66m) }
            };




        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                ddlProducts.DataSource = products.Keys;
                ddlProducts.DataBind();
                ddlProducts.Items.Insert(0, new ListItem("-- Select a Product from give below --", ""));
            }
        }
            protected void ddlProducts_Selec(object sender, EventArgs e)
            {
                
                string selectedProduct = ddlProducts.SelectedValue;
                if (products.ContainsKey(selectedProduct))
                {
                    imgProduct.ImageUrl = products[selectedProduct].ImageUrl;
                }
                else
                {
                    imgProduct.ImageUrl = "";
                }

                
                lblPrice.Text = "";
            }

            protected void btnGetPrice_Click(object sender, EventArgs e)
            {
                
                string selectedProduct = ddlProducts.SelectedValue;
                if (products.ContainsKey(selectedProduct))
                {
                    lblPrice.Text = "Price: $" + products[selectedProduct].Price.ToString("F2");
                }
                else
                {
                    lblPrice.Text = "Please select a product.";
                }
            }
        
    }
    
}
    
