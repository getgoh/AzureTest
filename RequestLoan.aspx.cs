using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RequestLoan : System.Web.UI.Page
{
    User currUser;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["User"] == null)
        {
            Session["RedirectPage"] = "RequestLoan.aspx";
            Response.Redirect("Login.aspx");
        }

        if (!IsPostBack)
        {
            currUser = (User)Session["User"];
            txtInterest.Attributes.Add("readonly", "readonly");
            computeInterest();
            txtEmployeeName.Text = currUser.Firstname + " " + currUser.Lastname;
        }

    }

    protected void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
    {
        computeInterest();
    }

    protected void ddlDuration_SelectedIndexChanged(object sender, EventArgs e)
    {
        computeInterest();
    }

    private void computeInterest()
    {
        double interestPerYear = 0.10;

        int amount = int.Parse(ddlAmount.SelectedValue);
        int years = int.Parse(ddlDuration.SelectedValue);

        double interest = amount * years * interestPerYear;
        //txtInterest.Text = "$" + interest.ToString("#.##");
        //txtInterest.Text = string.Format("{0:#.00}", Convert.ToDecimal(interest) / 100);
        txtInterest.Text = interest.ToString("C", CultureInfo.GetCultureInfo("en-US"));
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // security measure when idle for a long time.. 
        if (Session["User"] == null)
        {
            Session["RedirectPage"] = "RequestLoan.aspx";
            Response.Redirect("Login.aspx");
        }

        currUser = (User)Session["User"];

        double interestPerYear = 0.10;

        int amount = int.Parse(ddlAmount.SelectedValue);
        int years = int.Parse(ddlDuration.SelectedValue);

        Global.databaseManager.insertLoan(currUser.UserId, amount, interestPerYear * years, years,
            () =>
            {
               Response.Write("Loan request successful!");
            },
            (msg) =>
            {
                Response.Write("Error:" + msg);
            });
    }
}