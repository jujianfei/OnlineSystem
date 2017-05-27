<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GD在线.Login" %>

<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="Pragma" content="no-cache">
    <meta http-equiv="Cache-Control" content="no-cache">
    <meta http-equiv="Expires" content="0">
    <title>前台登录</title>
    <%--<script language="javascript">
        function toopen() {
            if (document.getElementById("password").value == "123456") {
                document.forms[0].action = "homePage.aspx";
                return true;
            } else {
                alert("密码不正确！")
                return false;
            }
        }
    </script>--%>
    <script src="js/jquery-1.7.1.min.js"></script>
    <link href="css/login2.css" rel="stylesheet" />
</head>
<body>

    <div class="login">
        <div class="message">GD在线学习平台-管理登录</div>
        <div id="darkbannerwrap"></div>

        <form method="post">
            <input name="action" value="login" type="hidden">
            <input id="userName" name="username" placeholder="用户名" required="" type="text">
            <hr class="hr15">
            <input id="password" name="password" id="password" placeholder="密码" required="" type="password">
            <hr class="hr15">
            <input value="登录" style="width: 100%;" type="button" onclick="test()">
            <hr class="hr20">
            <!-- 帮助 <a onClick="alert('请联系管理员')">忘记密码</a> -->
        </form>
    </div>

    <div class="copyright">© 2017GD在线学习平台 by <a href="http://www.mycodes.net/" target="_blank">琚建飞</a></div>
    <script type="text/javascript">
        function test() {
            var trArr = [];
            var a = document.getElementById("userName").value;
            var b = document.getElementById("password").value;
            $.ajax({
                type: "POST",
                url: "Login.aspx/hite",

                data: "{a:'" + a + "',b:'" + b + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {
                    var c = result.d;
                    if (c == "登录失败！") {
                        alert(result.d);
                    } else {
                        window.location.href = "http://localhost:10698/homePage.aspx";
                    }
                }
            });
        }
    </script>
</body>
</html>
