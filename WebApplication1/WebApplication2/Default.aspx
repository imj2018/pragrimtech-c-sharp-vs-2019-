<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <html>
        <title></title>
    </head>
        <div style="font-family:Arial; border:1px solid black; text-align:center; height: 250px;">
            <br />
            <tr>
                <td>
                   <b>Counter 1</b>
                </td>
                <td>
                </td>
                <td>
                   <b>Counter 2</b>
                </td> 
                <td>
                </td>
                <td>
                   <b>Counter 3</b>
                </td>
            </tr>
              <br />
            <tr>
                <td>
                     <asp:TextBox ID="txtCounter1" runat="server"></asp:TextBox>
                </td>
                <td>
                </td>
                <td>
                    <asp:TextBox ID="txtCounter2" runat="server"></asp:TextBox>
                </td>
                <td>
                </td>
                <td>
                     <asp:TextBox ID="txtCounter3" runat="server"></asp:TextBox>
                </td>
                <td>              
            </tr>
            <br />
            <br />
            <tr>
                <td>
                   <asp:Button ID="btnCounter1" runat="server" Text="Next" />
                </td>
                <td>
                    
                </td>
                <td> 
                    
                    <asp:Button ID="btnCounter2" runat="server" Text="Next" />
                </td>
                <td>
                </td>
                <td>
                    <asp:Button ID="btnCounter3" runat="server" Text="Next" />
                </td>        
                <td>              
            </tr>
            <br />
                    <asp:TextBox ID="txtDisplay" runat="server"></asp:TextBox>
            <br />
            <tr>
                <td>
                </td>
            </tr>
                    <asp:ListBox ID="listTokens" runat="server"></asp:ListBox>
            <br />
                    <asp:Button ID="btnPrintToken" runat="server" Text="Print Token" />
            <br />
            <asp:Label ID="lblStatus" runat="server"></asp:Label>
            <br />

                   

        </div>
    


    <body>
    


    </body>
    </html>


</asp:Content>
