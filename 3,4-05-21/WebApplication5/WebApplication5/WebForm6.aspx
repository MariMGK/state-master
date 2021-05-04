<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication5.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:DataGrid ID="DataGrid1" OnItemCommand="DataGrid1_ItemCommand" DataKeyField="positionid" ShowHeader="false" AutoGenerateColumns="false" SelectedItemStyle-BackColor="LightBlue" runat="server">
                <Columns>
                    <asp:BoundColumn
    HeaderText="Employee ID"
    DataField="empid" />

       <asp:BoundColumn
    HeaderText="Name"
    DataField="name" />
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <asp:LinkButton Text='<%#DataBinder.Eval(Container.DataItem,"positionid")  %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>


            <asp:DataGrid ID="DataGrid2" runat="server">
            </asp:DataGrid>


        </div>
    </form>
</body>
</html>
