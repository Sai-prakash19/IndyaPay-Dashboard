<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RechargeHistory.aspx.cs" Inherits="FinServices_Dashboard.Pages.RechargeHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Recharge History</h2>

    <div class="filter-container">
        Operator:
        <asp:DropDownList ID="ddlOperator" runat="server">
            <asp:ListItem Text="All" Value="" />
            <asp:ListItem Text="Airtel" Value="Airtel" />
            <asp:ListItem Text="Jio" Value="Jio" />
            <asp:ListItem Text="Vi" Value="Vi" />
        </asp:DropDownList>

        From:
        <asp:TextBox ID="txtFromDate" runat="server" TextMode="Date" />

        To:
        <asp:TextBox ID="txtToDate" runat="server" TextMode="Date" />

        <asp:Button ID="btnFilter" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnFilter_Click" />
    </div>

    <br />

    <asp:GridView ID="gvHistory" runat="server" AutoGenerateColumns="False"
        CssClass="table table-bordered table-hover" GridLines="None">
        <Columns>
            <asp:BoundField DataField="MobileNumber" HeaderText="Mobile Number" />
            <asp:BoundField DataField="Operator" HeaderText="Operator" />
            <asp:BoundField DataField="Amount" HeaderText="Amount" DataFormatString="{0:C}" />
            <asp:BoundField DataField="RechargedAt" HeaderText="Recharged At" DataFormatString="{0:dd-MM-yyyy HH:mm}" />
        </Columns>
    </asp:GridView>
</asp:Content>

