<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Canteen_Management_System_Asp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <tr>
                    <td rowspan ="1">
                        <asp:Button ID="btnSubmit" runat="server" Text="MENU LIST" ForeColor="#006600" OnClick="Button1_Click" />
                    </td>
                    <td rowspan ="2">
                        <asp:Button ID="btnSubmit2" runat="server" Text="PLACE ORDER" ForeColor="#006600" OnClick="Button2_Click" />
                    </td>
                <td rowspan ="2">
                        <asp:Button ID="Button1" runat="server" Text="VENDOR" ForeColor="#006600" OnClick="Button3_Click" />
                    </td>
                </tr>
        </div>
    </form>
</body>
</html>
