<%@ Page Title="" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="牛腩新闻发布系统.WebForm2" %>

<%@ Register Src="~/control/NewsCategory.ascx" TagPrefix="uc1" TagName="NewsCategory" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--新闻分类-->
    <uc1:NewsCategory runat="server" ID="NewsCategory" />
    <!--最新新闻-->
    <div id="newnews" class="commonfrm">
        <h4>最新新闻</h4>
        <asp:GridView ID="gvNewNews" runat="server" AutoGenerateColumns="False" BorderWidth="0">
            <Columns>
                <asp:TemplateField HeaderText="所属类别" HeaderStyle-CssClass="th_category">
                    <ItemTemplate>
                        <a class="td_category" href='newsList.aspx?caid=<%#Eval("caId") %>'>[<%#Eval("name") %>]</a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="新闻标题">
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
    <!--热点新闻-->
    <div id="hotnews" class="commonfrm">
        <h4>热点新闻</h4>
        <asp:GridView ID="gvHotNews" runat="server" AutoGenerateColumns="False" BorderWidth="0">
            <Columns>
                <asp:TemplateField HeaderText="所属类别" HeaderStyle-CssClass="th_category">
                    <ItemTemplate>
                        <a class="td_category" href='newsList.aspx?caid=<%#Eval("caId") %>'>[<%#Eval("name") %>]</a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="新闻标题">
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
