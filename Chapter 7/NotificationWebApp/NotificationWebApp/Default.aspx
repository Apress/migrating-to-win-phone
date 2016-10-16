<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NotificationWebApp.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<asp:Button ID="ToastButton" runat="server" Text="Toast" OnClick="ToastButton_Click" />
		<asp:Button ID="TileButton" runat="server" Text="Tile" OnClick="TileButton_Click" />
		<asp:Button ID="RawButton" runat="server" Text="Raw" OnClick="RawButton_Click" />
    </div>
    </form>
</body>
</html>
