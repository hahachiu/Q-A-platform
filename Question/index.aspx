<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Question.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
    
        <div class="auto-style1">
            <div class="auto-style2">
                欢迎来到在线答疑系统<br />
            </div>
        <asp:Login ID="Login1" runat="server" DisplayRememberMe="False" OnLoggingIn="Login1_LoggingIn" UserNameLabelText="用户账号:" Width="268px">
        </asp:Login>
    
            <br />
        </div>
    
    </div>
    </form>
</body>
</html>
