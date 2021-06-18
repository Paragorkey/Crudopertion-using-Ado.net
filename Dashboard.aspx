<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="CRUDUSINGBASICASP.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
     <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
<
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<div class="container-fluid" style="border:2px black ridge">  
        <!--Creating Jumbotron inside container-->  
        <div class="row">
            <div class="col-md-12">
            <h2 style="text-align:center" class="jumbotron">My Dashboard Page
            </h2>
        </div>
            </div>
    </div><br />
        <div class="row">
            
       <div class="col-md-1"></div>
        <div class="col-md-10" style="text-align:center">
            <table >
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" class="table table-striped" HorizontalAlign="Center">
                    <Columns>
                      <asp:BoundField DataField="id" HeaderText="Customer Id" />
                      <asp:BoundField DataField="Name" HeaderText="Name" />
                      <asp:BoundField DataField="Class" HeaderText="Class" />
                      <asp:BoundField DataField="age" HeaderText="Age" />
                      <asp:BoundField DataField="Gender" HeaderText="Gender" />
                      <asp:BoundField DataField="Country" HeaderText="Country" />
                      <asp:BoundField DataField="State" HeaderText="State" />
                      <asp:BoundField DataField="City" HeaderText="City" />
                      <asp:BoundField DataField="SchoolName" HeaderText="School Name" />
                      <asp:BoundField DataField="Created_date" HeaderText="Date" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                
                                <asp:LinkButton ID="btnEdit" runat="server" CssClass="btn btn-outline-info" OnCommand="btnEdit_Command" CommandArgument='<%# Eval("id") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                          <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="btnDelete" runat="server" CssClass="btn btn-outline-danger" OnCommand="btnDelete_Command" CommandArgument='<%# Eval("id") %>'  OnClientClick="return confirm('Are you sure you want delete');">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    
                </asp:GridView>
                </table>
        </div>

        <div class="col-md-1"></div>
</div>
    </form>
    <script src="JS/bootstrap.min.js"></script>
</body>
</html>
