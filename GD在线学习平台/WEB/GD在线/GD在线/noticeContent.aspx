<%@ Page Title="资源列表-GD在线学习平台" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="noticeContent.aspx.cs" Inherits="GD在线.NoticeList" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="newscontent" class="commonfrm">
        <h4>
            <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
        </h4>
        <div style="text-indent:40px;">
            <p class="con">
                <asp:Label ID="lblContent" runat="server" Text="Label"></asp:Label>
            </p>

        </div>

        <p class="con_time">发布时间：<asp:Label ID="lblCreateTime" runat="server" Text="Label"></asp:Label></p>
    </div>
</asp:Content>
