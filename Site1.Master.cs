using myProject.WebPage.WebFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myProject.WebPage
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null || Session["role"].ToString() == "")
            {
                Logout.Visible = false;
                HelloUser.Visible = false;
                AuthorManagement.Visible = false;
                PublisherManagement.Visible = false;
                BookInventory.Visible = false;
                BookIssuing.Visible = false;
                MemberManagement.Visible = false;
                ViewBook.Visible = false;
                AdminLogin.Visible = true;
                UserLogin.Visible = true;
                SignUp.Visible = true; 
            }else if (Session["role"].ToString() == "user")
            {
                UserLogin.Visible = false;
               
                MemberManagement.Visible = false;
                AdminCom.Visible = false;
                SignUp.Visible = false;
                Logout.Visible = true;
                HelloUser.Visible=true;
                ViewBook.Visible=true;
               HelloUser.Text="Hello " + Session["fullName"].ToString();
            }else if (Session["role"].ToString() == "Admin")
            {
                AdminLogin.Visible = false;
                UserLogin.Visible = false;
                SignUp.Visible = false;

                Logout.Visible = true;
                HelloUser.Text = "Hello " + Session["AdminName"];
                AuthorManagement.Visible = true;
                PublisherManagement.Visible = true;
                BookInventory.Visible = true;
                BookIssuing.Visible = true;
                ViewBook.Visible = true;
                MemberManagement.Visible = true;
            }
        }

        protected void UserLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            try
            {
                Session["role"] = "";
                Session["fullName"] = "";
                Logout.Visible = false;
                HelloUser.Visible=false;
                Response.Redirect("Home.aspx");
            }catch (Exception ex)
            {
                Response.Write(ex.Message); 
            }
        }

        protected void AdminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuthorLogin.aspx");
        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void MemberManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMembermanagment.aspx");
        }

        
        protected void BookIssuing_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookIssue.aspx");
        }

        protected void ViewBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBook.aspx");
        }

        protected void HelloUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserData.aspx");
        }

        protected void BookInventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminBookInventory.aspx");
        }

        protected void PublisherManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("Publisher.aspx");
        }

        protected void AuthorManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuthorList.aspx");
        }
    }
}