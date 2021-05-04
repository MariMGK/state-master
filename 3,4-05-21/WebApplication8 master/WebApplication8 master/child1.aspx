<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/child.Master" CodeBehind="child1.aspx.cs" Inherits="WebApplication8_master.child1" %>

<asp:Content id="Content1" ContentPlaceholderID="ChildContent1" runat="server">
   <asp:Label runat="server" id="Label1" 
        text="Child File1" font-bold="true" />
   <br />
</asp:Content>
<asp:Content id="Content2" ContentPlaceholderID="ChildContent2" runat="server">
   <asp:Label runat="server" id="Label2" 
        text="Child File2" font-bold="true"/>
</asp:Content>