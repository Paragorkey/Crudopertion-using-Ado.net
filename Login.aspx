<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CRUDUSINGBASICASP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <marquee style="position:relative"><h1>Login Form</h1></marquee>
        <div class="container-fluid">
              <div class="row">
            <div class="col-md-4"></div><br />
            <div class="col-md-4" style="border:2px solid black;margin-top:100px" >
              
                 <asp:Label ID="lblusername" runat="server" Text="Username"></asp:Label><br />
                <asp:TextBox ID="txtuser" runat="server" CssClass="form-control" placeholder="Enter  Username"></asp:TextBox><br />
               
                <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label><br />
                <asp:TextBox ID="txtpass" runat="server" CssClass="form-control" placeholder="Enter Your Password" TextMode="Password" ></asp:TextBox><br />
            <center><asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-success" OnClick="btnLogin_Click"  /></center><br /> 
            </div>
            </div>
            <div class="col-md-4"></div>

        </div>
    </form>
</body>
</html>
