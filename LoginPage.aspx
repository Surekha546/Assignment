<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginForm.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Name</td>
                    <td><asp:TextBox ID="Name" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>Movie</td>
                    <td>
                        <asp:TextBox ID="Movie" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Review</td>
                    <td><asp:TextBox ID="Review" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>Comment</td>
                    <td><asp:TextBox ID="Comment" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                   <td colspan="2" align="center">
                       <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click"></asp:Button>
                       <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click"></asp:Button>
                       
                      

                <asp:GridView ID="GridView" runat ="server" CssClass="auto-style1"></asp:GridView>
                       
                      

                   </td>
                        
                </tr>

            </table>

            <tr>
            </tr>
        </div>
    </form>
</body>
</html>
