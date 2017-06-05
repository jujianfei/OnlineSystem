<%@ Page Title="GD在线学习平台" Language="C#" MasterPageFile="~/admin/m_common.master" AutoEventWireup="true" ValidateRequest="false" CodeBehind="addnews.aspx.cs" Inherits="GD在线学习平台.admin.WebForm3" %>
<%@ Register assembly="FreeTextBox" namespace="FreeTextBoxControls" tagprefix="FTB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="M_ContentPlaceHolder" runat="server">
<div id="addnews" class="round2">
        <h3>添加资源</h3>

        <div class="con">
            <p>资源分类：<asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList></p>
            <p>资源标题：<asp:TextBox ID="txtTitle" runat="server" CssClass="newstitle"></asp:TextBox></p>
            <p>资源内容：</p>
            <p>
                <%--<asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" CssClass="newscontent"></asp:TextBox>--%>
                <FTB:FreeTextBox ID="ftbContent" Text="请在此输入新添加内容！" Language="zh-CN" width="500" Height="180" runat="server">
                </FTB:FreeTextBox>
            </p>
            <p style="margin-right:10px;">
                <asp:Button ID="btnAdd" runat="server" Text="添加资源" OnClick="btnAdd_Click" />
            </p>
        </div>
        <div class="footer">
            <p>&nbsp;</p>
            <!--&nbsp;空格-->
        </div>
    </div>
</asp:Content>
