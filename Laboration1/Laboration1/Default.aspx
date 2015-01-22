<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboration1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur Många Versaler??</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 152px">
    <h1>Hur många versaler?</h1>
        <asp:TextBox ID="Textbox" runat="server" Height="48px" Width="394px"></asp:TextBox>
        <asp:Button ID="Button" runat="server" Text="Kör!" Width="106px" OnClick="Button_Click" />
        <div>
        <asp:Label ID="Result" runat="server"></asp:Label>    
        </div>
        </div>
    </form>
</body>
</html>
