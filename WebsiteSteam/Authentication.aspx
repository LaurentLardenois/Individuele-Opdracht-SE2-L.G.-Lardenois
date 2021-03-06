﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Authentication.aspx.cs" Inherits="Authentication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login to your account, Steam</title>
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
        <div class="col-md-12" style="padding-left:35%; margin-top:7%">
            <asp:Label ID="lbLogin" runat="server" Text="Login:" ForeColor="White" Font-Size="Large"></asp:Label>
            <asp:Label ID="lbFailed" runat="server" Text="Invalid username and/or password." ForeColor="White" Font-Size="Large" Visible="false"></asp:Label>
        </div>
        <div class="col-md-12" style="padding-left:35%; margin-top:1%">
            <asp:Label ID="lbUserName" runat="server" Text="Username:" ForeColor="White"></asp:Label>
            <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-12" style="padding-left:35%; margin-top:1%">
            <asp:Label ID="lbPassword" runat="server" Text="Password:" ForeColor="White"></asp:Label>
            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div class="col-md-12" style="padding-left:35%; margin-top:1%">
            <asp:Button ID="btSignUp" runat="server" Text="Sign up" CssClass="btn btn-default" BorderColor="White" BackColor="Black" ForeColor="White" Width="15%"/>
            <asp:Button ID="btLogin" runat="server" Text="Login" CssClass="btn btn-default" BorderColor="White" BackColor="Black" ForeColor="White" Width="15%" OnClick="btLogin_Click"/>
        </div>
    </div>
    </div>
    </form>
</body>
</html>

