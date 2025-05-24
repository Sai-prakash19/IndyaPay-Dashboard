<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FinServices_Dashboard.Pages.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="dashboard-container">
        <h2>Welcome to IndyaPay</h2>
        <p>Your one-stop dashboard for managing mobile recharge operations efficiently.</p>

        <div class="card-deck">
            <div class="dashboard-card">
                <h3>Recharge</h3>
                <p>Simulate a mobile recharge and log request/response details.</p>
                <a href="RechargeAPI.aspx" class="btn btn-primary">Go to Recharge</a>
            </div>

            <div class="dashboard-card">
                <h3>History</h3>
                <p>View and filter past recharge transactions with powerful search tools.</p>
                <a href="RechargeHistory.aspx" class="btn btn-outline-success">View History</a>
            </div>
        </div>
    </div>
</asp:Content>

