<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication5.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataGrid ID="DataGrid1" AllowSorting="true" AutoGenerateColumns="false" runat="server" OnSortCommand="DataGrid1_SortCommand">
                 <Columns>
                    <asp:BoundColumn HeaderText="positionid" DataField="positionid" SortExpression="positionid" />
                    <asp:BoundColumn HeaderText="positionname" DataField="positionname" SortExpression="positionname" />
                     </Columns>
            </asp:DataGrid>
        </div>
    </form>
</body>
</html>
