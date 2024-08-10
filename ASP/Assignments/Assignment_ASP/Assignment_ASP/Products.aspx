<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Assignment_ASP.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <h2>Select a Product</h2>
 
            <asp:Label ID="lblProduct" runat="server" Text="Choose a product: " />
            <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProducts_Selec">
            </asp:DropDownList>
            <br /><br />
 
            <asp:Image ID="imgProduct" runat="server" Width="200px" Height="200px" />
            <br /><br />
 
            <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" />
            <br /><br />
 
            <asp:Label ID="lblPrice" runat="server" Text="" Font-Bold="True" />
        
        </div>
    </form>
</body>
</html>
