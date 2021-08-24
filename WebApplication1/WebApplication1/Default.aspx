<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <html>
        <title></title>
    </head>
    <body>
        <div style=""font-family":Arial>
            <tr>
                <td>
                    Country Code:
                </td>
                <td>
                    <asp:TextBox ID="txtCountryCode" runat="server" AutoPostBack="True" OnTextChanged="txtCountryCode_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Name:
                </td>
                <td>
                    <asp:TextBox ID="txtNames" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Capital:
                </td>
                <td>
                    <asp:TextBox ID="txtCapital" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>

        </div>
    


    </body>
    </html>


</asp:Content>
