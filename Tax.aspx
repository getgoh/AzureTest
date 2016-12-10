<%@ Page Title="" Language="C#" MasterPageFile="~/Dorknozzle.master" AutoEventWireup="true" CodeFile="Tax.aspx.cs" Inherits="Tax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1>Generate Tax</h1>

    <h3>Employee Information</h3>
    <span class="widelabel2">Employee: </span>
    <asp:Label id="txtEmployeeName" runat="server" />
    <br />
    <span class="widelabel2">Total Income: </span>
    <asp:Label id="txtEmployeeSalary" runat="server" />
    <br />
    <span class="widelabel2">Taxes Paid: </span>
    <asp:Label id="txtTaxesPaid" runat="server" />
    <br />
    <span class="widelabel2">Contribution: </span>
    <asp:Label id="txtContribution" runat="server" />
    <br /><br />
    <asp:Button Text="Submit" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" />

</asp:Content>

