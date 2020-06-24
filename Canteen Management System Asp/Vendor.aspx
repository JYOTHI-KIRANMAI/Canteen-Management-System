<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vendor.aspx.cs" Inherits="Canteen_Management_System_Asp.Vendor" %>

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
                        <asp:Button ID="btnSubmit" runat="server" Text="View Pending List " ForeColor="#006600" OnClick="btnSubmit_Click" />
                    </td>
                     <td rowspan ="1">
                         <asp:Button ID="Button1" runat="server" Text="Back" ForeColor="#006600" OnClick="btnSubmit_Click2" />
                    </td>
   
                </tr>
              <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
                  <Columns>
                      <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Accept" />
                      <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Reject"  />
                  </Columns>
        </asp:GridView>
    </form>
</body>
</html>