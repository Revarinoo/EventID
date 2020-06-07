using EventID.Controller;
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
            if (Session["user"] == null)
            {
                HttpCookie cookies = Request.Cookies.Get("user");
                if (cookies != null)
                {
                    int cookie_id = int.Parse(cookies.Value);

                    User users = UserRepo.GetUserByID(cookie_id);

                    Session["user"] = users;
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                List<Model.Cart> cartList = CartRepo.getListCart();
                int countCart = cartList.Count;

                if (countCart == 0)
                {
                    TitleKosong.Visible = true;
                    BelanjaBtn.Visible = true;
                    LblGrandTotal.Visible = false;
                }
                else
                {
                    Load_Cart();
                    TitleKosong.Visible = false;
                    BelanjaBtn.Visible = false;
                    ListCartTable.Visible = true;
                    LblGrandTotal.Visible = true;
                    ListCart.Visible = true;
                    CheckOutBtn.Visible = true;
                }
            }
        }

        protected int getUserID()
        {
            int userID = Convert.ToInt32(((User)Session["user"]).UserID);
            return userID;
        }

        protected void Load_Cart()
        {
            int userID = getUserID();
            List<Model.Cart> cartList = CartController.getCartbyUserId(userID);

            int totalPrice = 0;
            int grandTotal = 0;

                for (int i = 0; i < cartList.Count; i++)
                {
                    TableRow newRow = new TableRow();
                    ListCart.Controls.Add(newRow);

                    TableCell numberCell = new TableCell();
                    numberCell.Controls.Add(new Label()
                    {
                        Text = (i + 1) + "."
                    });
                    newRow.Cells.Add(numberCell);

                    int productId = cartList.ElementAt(i).ProductID;
                    Product products = ProductController.getProductById(productId);

                    TableCell productIDCell = new TableCell();
                    productIDCell.Visible = false;
                    productIDCell.Controls.Add(new Label()
                    {
                        Text = productId.ToString()
                    });
                    newRow.Cells.Add(productIDCell);

                    TableCell productNameCell = new TableCell();
                    productNameCell.Controls.Add(new Label()
                    {
                        Text = products.ProductName
                    });
                    newRow.Cells.Add(productNameCell);

                    TableCell productPriceCell = new TableCell();
                    productPriceCell.Controls.Add(new Label()
                    {
                        Text = "Rp. " + products.Price.ToString()
                    });
                    newRow.Cells.Add(productPriceCell);

                    TableCell qtyCell = new TableCell();
                    qtyCell.Controls.Add(new Label()
                    {
                        Text = cartList.ElementAt(i).Quantity.ToString()
                    });
                    newRow.Cells.Add(qtyCell);

                    totalPrice = (products.Price * cartList.ElementAt(i).Quantity);

                    TableCell totalPriceCell = new TableCell();
                    totalPriceCell.Controls.Add(new Label()
                    {
                        Text = "Rp. " + totalPrice.ToString()
                    });
                    newRow.Cells.Add(totalPriceCell);

                    grandTotal = grandTotal + totalPrice;

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
                LblGrandTotal.Text = "GRAND TOTAL : Rp. " + grandTotal.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Button currButton = (Button)sender;
            int selectedRowIndex = 0;
            int userId = getUserID();

            if (int.TryParse(currButton.ID.Substring(0, currButton.ID.Length - 2), out selectedRowIndex))
            {
                int productId = int.Parse(((Label)ListCart.Rows[selectedRowIndex].Cells[1].Controls[0]).Text);
                CartController.deleteCartUser(productId, userId);

                Response.Redirect("./Cart.aspx");
            }
        }
    }
}