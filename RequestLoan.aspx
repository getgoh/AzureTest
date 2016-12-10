<%@ Page Title="" Language="C#" MasterPageFile="~/Dorknozzle.master" AutoEventWireup="true" CodeFile="RequestLoan.aspx.cs" Inherits="RequestLoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1>Request A Loan</h1>

    <h3>Employee Information</h3>
    <span class="widelabel2">Employee: </span>
    <asp:Label id="txtEmployeeName" runat="server" />
    <br /><br />
    <h3>Loan Information</h3>

    <span class="widelabel2">Amount:</span>
    <asp:DropDownList ID="ddlAmount" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlAmount_SelectedIndexChanged">
        <asp:ListItem Selected="True" Value="1000" Text="$1,000" />
        <asp:ListItem Value="5000" Text="$5,000" />
        <asp:ListItem Value="10000" Text="$10,000" />
        <asp:ListItem Value="20000" Text="$20,000" />
        <asp:ListItem Value="50000" Text="$50,000" />
        <asp:ListItem Value="100000" Text="$100,000" />
    </asp:DropDownList>

    
    <br />
    <span class="widelabel2">Duration (years):</span>
    <asp:DropDownList ID="ddlDuration" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDuration_SelectedIndexChanged">
        <asp:ListItem Selected="True" Value="1" Text="1" />
        <asp:ListItem Value="2" Text="2" />
        <asp:ListItem Value="3" Text="3" />
        <asp:ListItem Value="4" Text="4" />
        <asp:ListItem Value="5" Text="5" />
        <asp:ListItem Value="6" Text="6" />
        <asp:ListItem Value="7" Text="7" />
        <asp:ListItem Value="8" Text="8" />
        <asp:ListItem Value="9" Text="9" />
        <asp:ListItem Value="10" Text="10" />
    </asp:DropDownList>
    <br />
    <span class="widelabel2">Total Interest:</span>
    <asp:TextBox ID="txtInterest" runat="server" />  
    <br />
    <br />
    <asp:Button Text="Submit" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" />

</asp:Content>

