<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="CRUDUSINGBASICASP.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
                
              <h1 style="text-align:center">Update Form</h1>
                <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="txtname" runat="server" CssClass="form-control" placeholder="Enter Your Name"></asp:TextBox><br />
                <asp:Label ID="lblclass" runat="server" Text="Class"></asp:Label>
                <asp:TextBox ID="txtclass" runat="server" CssClass="form-control" placeholder="Enter Your Class"></asp:TextBox><br />
                <asp:Label ID="lblage" runat="server" Text="Age"></asp:Label>
                <asp:TextBox ID="txtage" runat="server" CssClass="form-control" placeholder="Enter Your age"></asp:TextBox><br />
               <center><asp:Button ID="btnupdate" runat="server" Text="Update Student" CssClass="btn btn-info" OnClick="btnupdate_Click"  /></center>
            </div>
            <div class="col-md-3"></div>
            </div>
</div>
   
    </form>
</body>
</html>
