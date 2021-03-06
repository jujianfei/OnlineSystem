﻿<%@ Page Title="" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="GD在线学习平台.WebForm2" %>

<%@ Register Src="~/control/NewsCategory.ascx" TagPrefix="uc1" TagName="NewsCategory" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--资源分类-->
    <uc1:NewsCategory runat="server" ID="NewsCategory" />
    <!--最新资源-->
    <div id="newnews" class="commonfrm"> <!--给最新资源设置id，用于样式控制-->
        <h4>最新资源</h4>
        <asp:GridView ID="gvNewNews" runat="server" AutoGenerateColumns="False" BorderWidth="0">
            <Columns>
                <asp:TemplateField HeaderText="所属类别" HeaderStyle-CssClass="th_category"> 
                    <ItemTemplate>
                        <!--利用Eval函数获取点击的类别ID-->
                        <a class="td_category" href='newsList.aspx?caid=<%#Eval("caId") %>'>[<%#Eval("name") %>]</a>
                    </ItemTemplate>
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="资源标题"> 
                    <ItemTemplate>
                        <a href='newsContent.aspx?newsid=<%#Eval("id")%>' target="_blank" title='<%#Eval("title") %>'><%# StringTruncat(Eval("title").ToString(),18,"...") %></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="发布时间" HeaderStyle-CssClass="th_time" ItemStyle-CssClass="td_time">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("createtime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <!--热点资源-->
    <div id="hotnews" class="commonfrm">
        <h4>热点资源</h4>
        <asp:GridView ID="gvHotNews" runat="server" AutoGenerateColumns="False" BorderWidth="0">
            <Columns>
                <asp:TemplateField HeaderText="所属类别" HeaderStyle-CssClass="th_category">
                    <ItemTemplate>
                        <a class="td_category" href='newsList.aspx?caid=<%#Eval("caId") %>'>[<%#Eval("name") %>]</a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="资源标题">
                    <ItemTemplate>
                        <a href='newsContent.aspx?newsid=<%#Eval("id")%>' target="_blank" title='<%#Eval("title") %>'><%# StringTruncat(Eval("title").ToString(),18,"...") %></a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="发布时间" HeaderStyle-CssClass="th_time" ItemStyle-CssClass="td_time">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("createtime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
