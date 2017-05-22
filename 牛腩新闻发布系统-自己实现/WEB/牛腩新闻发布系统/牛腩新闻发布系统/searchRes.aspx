<%@ Page Title="搜索结果-牛腩新闻发布系统" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="searchRes.aspx.cs" Inherits="牛腩新闻发布系统.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!--搜索结果列表-->
    <div id="searchres" class="commonfrm">
        <h4>搜索结果</h4>
        <asp:GridView ID="gvNews" PageSize="100" runat="server" AutoGenerateColumns="False" BorderWidth="0">
            <Columns>
                <asp:TemplateField HeaderText="所属类别" HeaderStyle-CssClass="th_category">
                    <ItemTemplate>
                        <a class="td_category" href='newsList.aspx?caid=<%#Eval("caId") %>'>[<%#Eval("name") %>]</a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="新闻标题">
                    <ItemTemplate>
                        <a href='newsconConten.aspx?newsid=<%#Eval("id")%>' target="_blank" title='<%#Eval("title") %>'><%# StringTruncat(Eval("title").ToString(),18,"...") %></a>
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
