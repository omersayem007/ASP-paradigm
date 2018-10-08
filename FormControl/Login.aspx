<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <fieldset>
            <legend>Login</legend>
            Name : <input type="text" name="name" value=""/><br /><br />
            Password :<input type="password" name="password" value=""/><br /><br />
            Remember me ? <input type="checkbox" name="rem" /><br />
            <button type="submit">Login</button>
            <button><a href="Registration.php">Register ?</a></button>
            <a href="forget.aspx">Forget password ?</a>
    </fieldset>
    </form>
</body>
</html>
