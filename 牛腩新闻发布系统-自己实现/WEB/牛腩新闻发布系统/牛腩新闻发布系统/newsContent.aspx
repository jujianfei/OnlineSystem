<%@ Page Title="新闻内容-牛腩新闻发布系统" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="newsContent.aspx.cs" Inherits="牛腩新闻发布系统.WebForm5" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" type="text/javascript"> //javascript代码
        function changeCode() {
            var imgNode = document.getElementById("vimg");
            imgNode.src = "handler/WaterMark.ashx?t=" + (new Date()).valueOf();  // 这里加个时间的参数是为了防止浏览器缓存的问题  
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="newscontent" class="commonfrm">
        <h4>
            <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
        </h4>
        <p class="con">
            <asp:Label ID="lblContent" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="con_time">发布时间：<asp:Label ID="lblCreateTime" runat="server" Text="Label"></asp:Label></p>
        <a href="#com">我要评论</a>
    </div>
    <div id="newsreply" class="commonfrm">
        <h4>新闻评论</h4>
        <div id="emptydata" class="replay" runat="server">
            <p>该新闻目前暂无评论！</p>
        </div>
        <asp:Repeater ID="repComment" runat="server" OnItemDataBound="repComment_ItemDataBound">
            <ItemTemplate>
                <div class="replay">
                    <p class="con">
                        <%#Eval("content") %>
                    </p>
                    <p class="replay_info">
                        <asp:LinkButton ID="lbtnDelComment" OnClientClick="return confirm('是否确定删除该评论？')" OnClick="lbtnDelComment_Click" CommandArgument='<%#Eval("id") %>' runat="server" Visible="false">删除</asp:LinkButton>
                        评论者：<%#Eval("userIp").ToString().Substring(0,Eval("userIp").ToString().LastIndexOf(".")+1)+"*"%>评论时间：<%#Eval("createTime") %></p>
                    <hr />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <div class="addcomment">
        <asp:TextBox ValidationGroup="pinlun" ID="txtComment" runat="server" TextMode="MultiLine" Text="请在此输入评论内容!" Height="250" Width="600" CssClass="comment_con" onclick="this.select()"></asp:TextBox>
        <p>
            验证码：<a name="com">&nbsp;</a><img src="handler/WaterMark.ashx" id="vimg" alt="" onclick="changeCode()" />
            <asp:TextBox ID="txtCode" runat="server" ValidationGroup="pinlun" CssClass="txtcode"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="pinlun" ControlToValidate="txtCode" runat="server" ErrorMessage="请输入验证码！" Text="*"></asp:RequiredFieldValidator>
            <asp:Button ID="btnSub" ValidationGroup="pinlun" runat="server" Text="提交" OnClick="btnSub_Click" />
            <asp:ValidationSummary ValidationGroup="pinlun" ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="false" />

    </div>
</asp:Content>

