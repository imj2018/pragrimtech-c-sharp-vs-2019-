<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;<html><title></title></head><body><div style="font-family:Arial; border:1px solid black; text-align:center; height: 250px;">

                <br />
                <br />
                <tr>
                    <td>
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </td>
                <tr>
                        <td style="width:100px">
                                <tr>
                                    <td>
                                        <b> Links</b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <a href="http://localhost/WebApplication1/WebForm1.aspx">Webform1</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <a href="http://localhost/WebApplication1/WebForm2.aspx">Webform2</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <a href="http://localhost/WebApplication1/WebForm3.aspx">Webform3</a>
                                    </td>
                                </tr>  
                                <tr>
                                    <td>
                                        <a href="http://localhost/WebApplication1/WebForm4.aspx">Webform4</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
                                         <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                                    </td>
                                </tr>                                 
        </div>
    </body>
    </html>


</asp:Content>
