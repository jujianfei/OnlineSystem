<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="牛腩新闻发布系统.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>后台登录-牛腩新闻发布系统</title>
    <link href="../css/login.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript"> //javascript代码
        function changeCode() {
            var imgNode = document.getElementById("vimg");
            imgNode.src = "../handler/WaterMark.ashx?t=" + (new Date()).valueOf();  // 这里加个时间的参数是为了防止浏览器缓存的问题  
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="loginfrm" class="round1">
            <h3>后台登录-牛腩新闻发布系统</h3>
            <div id="login">
                <img src="../image/niunanlogo.jpg" alt="LOGO" class="login_logo" />
                <p>
                    用户名：<asp:TextBox ID="txtUserName" runat="server" CssClass="textbox"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入用户名！" Text="*" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                </p>
                <p>
                    密　码：<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="textbox"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入密码！" Text="*" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </p>
                <p>
                    验证码：<img src="../handler/WaterMark.ashx" id="vimg" alt="" onclick="changeCode()" />
                    <asp:TextBox ID="txtCode" runat="server" CssClass="textcode"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请输入验证码！" Text="*" ControlToValidate="txtCode"></asp:RequiredFieldValidator>
                </p>
                <p>
                    <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
                </p>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="false" />
            </div>
            <div id="footer">版权所有&copy;<a href="http://blog.csdn.net/gnd15732625435?viewmode=contents" target="_blank">琚建飞</a>&amp;<a href="https://www.baidu.com/" target="_blank">百度网</a></div>
        </div>
    </form>
</body>
</html>
