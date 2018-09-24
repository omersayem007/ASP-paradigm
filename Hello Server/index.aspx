<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Hello world</h1>
    <h2><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h2>

    <form id="form1" action="index.aspx" runat="server">

        <input type="text" name="test" value="Hello World From Server!!!" />
        <input type="submit" />
    
    </form>
</body>
</html>
