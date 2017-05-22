<%--
    *创建人：琚建飞
    *创建时间：2016年10月4日10:12:50
    *版权所有：信息技术提高班
    --%>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewsCategory.ascx.cs" Inherits="牛腩新闻发布系统.control.NewsCategory" %>
<div id="category" class="commonfrm">
        <h4>新闻分类</h4>
        <ul>
            <!--前面的黑点-->
            <li><a href="homePage.aspx">首　　页</a></li>
            <!--里面a标记的标记的样式优先于li标记的样式，首页中间用全角空格-->
            <asp:Repeater ID="repCategory" runat="server">
                <ItemTemplate>
                    <!--项模板，写要重复的语句-->
                    <li><a href='newsList.aspx?caid=<%# Eval("id")%>'><%# Eval("name")%></a></li>
                    <!--#Eval（“name”），绑定数据库中数据-->
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>