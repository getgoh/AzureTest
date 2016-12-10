using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tax : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User currUser;
        if (Session["User"] == null)
        {
            Session["RedirectPage"] = "Tax.aspx";
            Response.Redirect("Login.aspx");
        }

        if (!IsPostBack)
        {
            currUser = (User)Session["User"];
            //computeInterest();
            txtEmployeeName.Text = currUser.Firstname + " " + currUser.Lastname;
            txtEmployeeSalary.Text = currUser.TotalIncome.ToString("C", CultureInfo.GetCultureInfo("en-US"));

            txtTaxesPaid.Text = currUser.TotalTaxesPaid.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            txtContribution.Text = currUser.Contributions.ToString("C", CultureInfo.GetCultureInfo("en-US"));
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // security measure when idle for a long time.. 
        if (Session["User"] == null)
        {
            Session["RedirectPage"] = "RequestLoan.aspx";
            Response.Redirect("Login.aspx");
        }
    }

    }