﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Canteen_Management_System_Asp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
    </title>
</head>
<body>
    <form id="form1" runat="server">
        
                 
                <tr>
                    <td rowspan ="1">
                        <asp:Button ID="btnSubmit" runat="server" Text="Click Here for details" ForeColor="#006600" OnClick="btnSubmit_Click" />
                    </td>
                     <td rowspan ="1">
                        <asp:Button ID="Button1" runat="server" Text="Back" ForeColor="#006600" OnClick="btnSubmit_Click2" />
                    </td>
   
                </tr>
              <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" >
                  <AlternatingRowStyle BackColor="White" />
                  <EditRowStyle BackColor="#2461BF" />
                  <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                  <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                  <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                  <RowStyle BackColor="#EFF3FB" />
                  <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                  <SortedAscendingCellStyle BackColor="#F5F7FB" />
                  <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                  <SortedDescendingCellStyle BackColor="#E9EBEF" />
                  <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </form>
</body>
</html>