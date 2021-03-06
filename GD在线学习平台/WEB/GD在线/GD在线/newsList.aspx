﻿<%@ Page Title="资源列表-GD在线学习平台" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="newsList.aspx.cs" Inherits="GD在线学习平台.WebForm3" %>

<%@ Register Src="~/control/NewsCategory.ascx" TagPrefix="uc1" TagName="NewsCategory" %>


<%--上面的title，可以设置网页标签的名字 --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--资源分类-->
    <uc1:NewsCategory runat="server" ID="NewsCategory" />
    <!--资源列表-->
    <div id="newslist" class="commonfrm">
        <h4>
            <asp:Label ID="lblCaName" runat="server" Text="　"></asp:Label></h4>
        <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False" BorderWidth="0px" GridLines="None" EmptyDataText="该类别下暂无资源！">
            <Columns>
                <asp:TemplateField HeaderText="所属分类" HeaderStyle-CssClass="th_category">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="资源标题">
                     <ItemTemplate>
                        <a href='newsContent.aspx?newsid=<%#Eval("id")%>' target="_blank" title='<%#Eval("title") %>'><%# StringTruncat(Eval("title").ToString(),18,"...") %></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="发布时间" HeaderStyle-CssClass="th_time" ItemStyle-CssClass="td_time">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("createTime") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("createTime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
