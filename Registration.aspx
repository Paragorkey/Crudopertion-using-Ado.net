<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="CRUDUSINGBASICASP.Registration" %>

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
                
                <asp:Label ID="lblid" runat="server" Text="Id"></asp:Label>
                <asp:TextBox ID="txtid" runat="server" CssClass="form-control" placeholder="Student Id"></asp:TextBox><br />
                <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="txtname" runat="server" CssClass="form-control" placeholder="Enter Your Name"></asp:TextBox><br />
                <asp:Label ID="lblclass" runat="server" Text="Class"></asp:Label>
                <asp:TextBox ID="txtclass" runat="server" CssClass="form-control" placeholder="Enter Your Class"></asp:TextBox><br />
                <asp:Label ID="lblage" runat="server" Text="Age"></asp:Label>
                <asp:TextBox ID="txtage" runat="server" CssClass="form-control" placeholder="Enter Your age"></asp:TextBox><br />
                <asp:Label ID="lblgender" runat="server" Text="Gender"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataTextField="gender" DataValueField="gender">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList><br />
                <asp:DropDownList ID="ddlCountry" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged" ></asp:DropDownList><br />
                  <asp:DropDownList ID="ddlState" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" ></asp:DropDownList><br />
                  <asp:DropDownList ID="ddlCity" runat="server" CssClass="form-control" AutoPostBack="true" ></asp:DropDownList><br />
                  
               <asp:Label ID="lblusername" runat="server" Text="Username"></asp:Label><br />
                <asp:TextBox ID="txtuser" runat="server" CssClass="form-control" placeholder="Enter  Username"></asp:TextBox><br />
               
                <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label><br />
                <asp:TextBox ID="txtpass" runat="server" CssClass="form-control" placeholder="Enter Your Password" TextMode="Password" ></asp:TextBox><br />

                 <asp:Label ID="lblschool" runat="server" Text="SchoolName"></asp:Label><br />
                <asp:TextBox ID="txtSchool" runat="server" CssClass="form-control" placeholder="Enter Your School Name" TextMode="MultiLine" ></asp:TextBox><br />
                 <asp:Label ID="lbladdress" runat="server" Text="Address"></asp:Label><br />
                <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" placeholder="Enter Your Address" TextMode="MultiLine" ></asp:TextBox><br />
                <center><asp:Button ID="btnSave" runat="server" Text="Register Student" CssClass="btn btn-primary" OnClick="btnSave_Click"  /></center>
            </div>
            <div class="col-md-3"></div>
            </div>
</div>
   
    </form>
         
</body>
</html>
