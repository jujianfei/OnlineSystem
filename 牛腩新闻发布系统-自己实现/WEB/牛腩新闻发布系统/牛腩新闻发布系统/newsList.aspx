<%@ Page Title="新闻列表-牛腩新闻发布系统" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="newsList.aspx.cs" Inherits="牛腩新闻发布系统.WebForm3" %>

<%@ Register Src="~/control/NewsCategory.ascx" TagPrefix="uc1" TagName="NewsCategory" %>


<%--上面的title，可以设置网页标签的名字 --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--新闻分类-->
    <uc1:NewsCategory runat="server" ID="NewsCategory" />
    <!--新闻列表-->
    <div id="newslist" class="commonfrm">
        <h4>
            <asp:Label ID="lblCaName" runat="server" Text="　"></asp:Label></h4>
        <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False" BorderWidth="0px" GridLines="None" EmptyDataText="该类别下暂无新闻！">
            <Columns>
                <asp:TemplateField HeaderText="所属分类" HeaderStyle-CssClass="th_category">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="新闻标题">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("title") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("title") %>'></asp:Label>
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
