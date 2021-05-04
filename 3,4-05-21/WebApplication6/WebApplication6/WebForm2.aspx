<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication6.WebForm2" %>

<!DOCTYPE html>
<script language="C#" runat="server">
    Decimal decprice = 9999.99m;
    Decimal decquantity = 9999.99m;
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DataGrid ID="DataGrid1" AutoGenerateColumns="false" runat="server">
            <Columns>
                <asp:BoundColumn HeaderText="EnglishName" DataField="EnglishName" />
                <asp:BoundColumn HeaderText="Name" DataField="Name" />
                <asp:TemplateColumn HeaderText="Currency Format">
                    <ItemTemplate>
                        <%# decprice.ToString("c",(IFormatProvider)Container.DataItem) %>
                    </ItemTemplate>

                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Number Format">
                    <ItemTemplate>
                        <%# decquantity.ToString("n",(IFormatProvider)Container.DataItem) %>
                    </ItemTemplate>

                </asp:TemplateColumn>
                <asp:TemplateColumn HeaderText="Date/Time Format">
                    <ItemTemplate>
                        <%# DateTime.Now.ToString("F",(IFormatProvider)Container.DataItem) %>
                    </ItemTemplate>

                </asp:TemplateColumn>
            </Columns>
        </asp:DataGrid>
    </form>
</body>
</html>
