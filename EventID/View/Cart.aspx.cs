using EventID.Model;
using EventID.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventID.View
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                List<Model.Cart> cart = CartRepo.getListCart();
                int CountCart = cart.Count;

                if (CountCart == 0)
                {
                    TitleKosong.Visible = true;
                    BelanjaBtn.Visible = true;
                }
                else
                {
                    Load_Cart();
                    ListCartTable.Visible = true;
                    ListCart.Visible = true;
                    CheckOutBtn.Visible = true;
                    TitleKosong.Visible = false;
                    BelanjaBtn.Visible = false;
                }
            }
            
        }

        protected void Load_Cart()
        {
            List<Product> product = ProductRepo.getProduct();
            List<Model.Cart> cart = CartRepo.getListCart();

            for (int i = 0; i < cart.Count; i++)
            {
                TableRow newRow = new TableRow();
                ListCart.Controls.Add(newRow);

                TableCell productNumberCell = new TableCell();
                productNumberCell.Controls.Add(new Label()
                {
                    Text = (i + 1) + "."
                });
                newRow.Cells.Add(productNumberCell);

                TableCell idCartCell = new TableCell();
                idCartCell.Visible = false;
                idCartCell.Controls.Add(new Label()
                {
                    Text = cart.ElementAt(i).CartID.ToString()
                });
                newRow.Cells.Add(idCartCell);


                TableCell productCartCell = new TableCell();
                productCartCell.Controls.Add(new Label()
                {
                    Text = product.ElementAt(i).ProductName
                });
                newRow.Cells.Add(productCartCell);
                productCartCell.DataBind();

                TableCell productPriceCell = new TableCell();
                productPriceCell.Controls.Add(new Label()
                {
                    Text = product.ElementAt(i).Price.ToString()
                });
                newRow.Cells.Add(productPriceCell);

                TableCell productQuantityCell = new TableCell();
                productQuantityCell.Controls.Add(new Label()
                {
                    Text = cart.ElementAt(i).Quantity.ToString()
                });
                newRow.Cells.Add(productQuantityCell);

                TableCell productTotalCell = new TableCell();
                productTotalCell.Controls.Add(new Label()
                {
                    Text = (product.ElementAt(i).Price * cart.ElementAt(i).Quantity).ToString()
                });
                newRow.Cells.Add(productTotalCell);

                TableCell deleteButtonCell = new TableCell();
                Button deleteButton = new Button()
                {
                    ID = (i + 1) + "_D",
                    Text = "Delete",
                    CssClass = "btn btn-danger"
                };
                deleteButton.Click += deleteButton_Click;
                deleteButtonCell.Controls.Add(deleteButton);
                newRow.Cells.Add(deleteButtonCell);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            int selectedRowIndex = 0;
            if (int.TryParse(currButton.ID.Substring(0, currButton.ID.Length - 2), out selectedRowIndex))
            {
                int CartId = int.Parse(((Label)ListCart.Rows[selectedRowIndex].Cells[1].Controls[0]).Text);

                CartRepo.Delete(CartId);

                Response.Redirect("./Cart.aspx");
            }
        }

        protected void btnShop_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllProduct.aspx");
        }
    }
}