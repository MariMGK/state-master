<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication5.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:DataGrid DataKeyField="positionid" ID="DataGrid1"  OnEditCommand="DataGrid1_EditCommand"  runat="server" AutoGenerateColumns="false" OnUpdateCommand="DataGrid1_UpdateCommand" OnCancelCommand="DataGrid1_CancelCommand">
                <Columns>
                    <asp:BoundColumn HeaderText="positionid" DataField="positionid" ReadOnly="true" />
                    <asp:BoundColumn HeaderText="positionname" DataField="positionname" />
                    <asp:EditCommandColumn EditText="edit!" UpdateText="update" CancelText="cancel" />
                </Columns>
            </asp:DataGrid>


        </div>
    </form>
</body>
</html>
