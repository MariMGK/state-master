<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication5.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:DataGrid ID="DataGrid1" AutoGenerateColumns="false" EnableViewState="false" runat="server">
            <Columns>
                 <asp:BoundColumn HeaderText="positionname" DataField="positionname" />
                <asp:HyperLinkColumn HeaderText="Details" DataNavigateUrlField="positionid" DataNavigateUrlFormatString="WebForm3.aspx?id={0}" Text="view details" />
            </Columns>
            </asp:DataGrid>


            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />


        </div>
    </form>
</body>
</html>
