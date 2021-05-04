<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" Height="243px" Width="521px">
        </asp:GridView>
         <asp:DataGrid ID="DataGrid1" AllowPaging="true" OnPageIndexChanged="DataGrid1_PageIndexChanged" AllowCustomPaging="true" PageSize="3" PagerStyle-Mode="NumericPages" runat="server" AutoGenerateColumns="false" OnItemCommand="DataGrid1_ItemCommand" Width="365px">
        <Columns>
            <asp:BoundColumn HeaderText="mobile" DataField="Mobileno"></asp:BoundColumn>
                <asp:BoundColumn HeaderText="name" DataField="UserName"></asp:BoundColumn>
        </Columns>
            
         
         </asp:DataGrid>
    </form>
</body>
</html>
