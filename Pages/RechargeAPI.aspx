<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RechargeAPI.aspx.cs" Inherits="FinServices_Dashboard.Pages.RechargeAPI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Recharge Simulator</h2>

    <div class="form-container">
        <asp:Label Text="Mobile Number:" AssociatedControlID="txtMobile" runat="server" />
        <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control" />
        <br />

        <asp:Label Text="Operator:" AssociatedControlID="txtOperator" runat="server" />
        <asp:TextBox ID="txtOperator" runat="server" CssClass="form-control" />
        <br />

        <asp:Label Text="Amount:" AssociatedControlID="txtAmount" runat="server" />
        <asp:TextBox ID="txtAmount" runat="server" CssClass="form-control" />
        <br />

        <asp:Button ID="btnRecharge" runat="server" Text="Submit Recharge" CssClass="btn btn-primary" OnClick="btnRecharge_Click" />
        <br /><br />

        <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />
    </div>
</asp:Content>

