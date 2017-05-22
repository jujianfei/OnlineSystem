<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="备份WebForm1.aspx.cs" Inherits="牛腩新闻发布系统.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>首页—牛腩新闻发布系统</title>
    <link href="css/commen.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="top">
            <a href="WebForm1.aspx">
                <img src="image/niunanlogo.jpg" /></a>
            <!--超链接到首页-->
            <a href="https://www.baidu.com/" target="_blank">
                <img src="image/tg029logo.gif" /></a>
        </div>
        <div id="search">
            搜索条件：
            <asp:RadioButton ID="radTitle" GroupName="cond" runat="server" Text=" 标题" Checked="true" /><!--GroupName使组归为一类，让两个选择按钮产生互斥的效果-->
            <asp:RadioButton ID="radContent" GroupName="cond" runat="server" Text=" 内容　" />
            <!--内容前加一个空格，调整单选按钮和文本之间的距离-->
            <asp:TextBox ID="txtKey" runat="server" CssClass="textbox"></asp:TextBox><!--CssClass属性，看CSS文件里面的txtbox标记-->
            <asp:ImageButton ID="ImageButton1" ImageUrl="~/image/search.gif" runat="server" /><!--添加图片按钮-->
        </div>
        <div id="main"> <!--保证其他的框架在main下面，以main框架为基本-->
            <!--新闻分类-->
            <div id="category" class="commonfrm">
                <h4>新闻分类</h4>
                <ul>
                    <!--前面的黑点-->
                    <li><a href="#">首　　页</a></li>
                    <!--里面a标记的标记的样式优先于li标记的样式，首页中间用全角空格-->
                    <li><a href="#">体育新闻</a></li>
                    <li><a href="#">财经新闻</a></li>
                    <li><a href="#">社会新闻</a></li>
                </ul>
            </div>
            <!--最新新闻-->
            <div id="newnews" class="commonfrm">
                <h4>最新新闻</h4>
                <table>
                    <tr>
                        <th class="th_category">所属类别</th>
                        <th>新闻标题</th>
                        <th class="th_time">发布时间</th>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">[体育新闻]</a></td>
                        <td><a href="#">NBA状元秀</a></td>
                        <td class="td_time">2016年10月1日22:11:39</td>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">[体育新闻]</a></td>
                        <td><a href="#">NBA状元秀</a></td>
                        <td class="td_time">2016年10月1日22:11:39</td>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">[体育新闻]</a></td>
                        <td><a href="#">NBA状元秀</a></td>
                        <td class="td_time">2016年10月1日22:11:39</td>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">[体育新闻]</a></td>
                        <td><a href="#">NBA状元秀</a></td>
                        <td class="td_time">2016年10月1日22:11:39</td>
                    </tr>
                </table>
            </div>
            <!--热点新闻-->
            <div id="hotnews" class="commonfrm">
                <h4>热点新闻</h4>
                <table>
                    <tr>
                        <th class="th_category">所属类别</th>
                        <th>新闻标题</th>
                        <th class="th_time">发布时间</th>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">[体育新闻]</a></td>
                        <td><a href="#">NBA状元秀</a></td>
                        <td class="td_time">2016年10月1日22:11:39</td>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">[体育新闻]</a></td>
                        <td><a href="#">NBA状元秀</a></td>
                        <td class="td_time">2016年10月1日22:11:39</td>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">[体育新闻]</a></td>
                        <td><a href="#">NBA状元秀</a></td>
                        <td class="td_time">2016年10月1日22:11:39</td>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">[体育新闻]</a></td>
                        <td><a href="#">NBA状元秀</a></td>
                        <td class="td_time">2016年10月1日22:11:39</td>
                    </tr>
                </table>
            </div>
        </div>
        <div id="footer">版权所有  &copy;<a href="http://blog.csdn.net/gnd15732625435?viewmode=contents" target="_blank">琚建飞</a>&amp;<a href="https://www.baidu.com/" target="_blank">百度网</a></div>
    </form>
</body>
</html>
