<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="registration.aspx">
     <fieldset>
            <legend>Regitration</legend>
            Name : <input type="text" name="name" value=""/><br /><br />
            Password :<input type="password" name="password" value=""/><br /><br />
            
            <button type="submit" >Register</button>
            <button> <a href="Login.aspx">Login</a></button>
    </fieldset>

    </form>
</body>
</html>
