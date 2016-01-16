<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Steam!</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body style="background-color:black">
    <form id="form1" runat="server">
    <div>
    <div class="container">
        <div class="jumbotron" style="background-color:black; border:1px solid white; margin-bottom:3px">
            <h1 style="color:white">Welcome to Steam!</h1>
        </div>
        <div class="col-md-12" style="padding:0px">
            <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btn btn-default" BorderColor="White" BackColor="Black" ForeColor="White" Width="11%" OnClick="btHome_Click"/>
            <asp:Button ID="btnGames" runat="server" Text="Games" CssClass="btn btn-default" BorderColor="White" BackColor="Black" ForeColor="White" Width="11%" OnClick="btGames_Click"/>
            <asp:Button ID="btnSoft" runat="server" Text="Software" CssClass="btn btn-default" BorderColor="White" BackColor="Black" ForeColor="White" Width="11%" OnClick="btSoft_Click"/>
            <asp:Button ID="btnHard" runat="server" Text="Hardware" CssClass="btn btn-default" BorderColor="White" BackColor="Black" ForeColor="White" Width="11%" OnClick="btHard_Click"/>
            <asp:Button ID="btnCart" runat="server" Text="My cart" CssClass="btn btn-default" BorderColor="White" BackColor="Black" ForeColor="White" Width="10%" OnClick="btCart_Click"/>
            <asp:Button ID="btnStuff" runat="server" Text="My stuff" CssClass="btn btn-default" BorderColor="White" BackColor="Black" ForeColor="White" Width="10%" OnClick="btStuff_Click"/>
            <asp:Button ID="btnAuth" runat="server" Text="Login" CssClass="btn btn-default" BorderColor="White" BackColor="Black" ForeColor="White" Width="10%" OnClick="btAuth_Click"/>
            <asp:TextBox ID="tbSearch" runat="server" Width="16%"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-default" BorderColor="White" BackColor="Black" ForeColor="White" Width="7%" OnClick="btSearch_Click"/>
        </div>
    </div>
    </div>
    </form>
</body>
</html>
