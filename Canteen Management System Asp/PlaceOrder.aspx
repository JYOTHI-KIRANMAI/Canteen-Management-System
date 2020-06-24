<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="Canteen_Management_System_Asp.PlaceOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                    ItemId
                    </td>
                    <td>
                        <asp:TextBox ID = "TxtId"
                            runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                       <td>
                   Quatity
                    </td>
                    <td>
                        <asp:TextBox ID = "TxtQuantity"
                            runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td rowspan ="1">
                        <asp:Button ID="btnSubmit" runat="server" Text="Place Order" ForeColor="#006600" OnClick="btnSubmit_Click" />
    <input id="Text1" type="Your order is placed" />
                    </td>
                    <td rowspan ="2">
                        <asp:Button ID="btnSubmit2" runat="server" Text="Back" ForeColor="#006600" OnClick="btnSubmit2_Click" />
                    </td>
                </tr>

            </table>
        </div>
    </form
>
</body>
</html>