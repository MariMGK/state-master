<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 370px;
            width: 1380px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>RegularexpressionText:</b>
            <br/>
             <asp:TextBox ID="textregularexpression" runat="server"></asp:TextBox>
            <br />
            <br />
            <b>Text:</b>
            <asp:TextBox ID="matchingregularexpression" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <br />

            <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundColumn HeaderText="sucess" DataField="success" />
                    <asp:BoundColumn HeaderText="length" DataField="Length" />
                </Columns>
            </asp:DataGrid>
        
       
            
        
           
        
             </div>
        
           
    </form>
</body>
</html>
