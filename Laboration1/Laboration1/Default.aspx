<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboration1.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur Många Versaler??</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hur många versaler?</h1>
            <asp:TextBox ID="Textbox" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Button ID="RunButton" runat="server" Text="Kör!" OnClick="RunButton_Click" />
            <asp:Button ID="ResetButton" runat="server" Text="Starta om" Visible="false" />
            <asp:Panel ID="ResultPanel" runat="server" Visible="false">
                Det fanns <asp:Label ID="ResultLabel" runat="server"></asp:Label> versaler.
            </asp:Panel>
        </div>
    </form>
</body>
</html>
