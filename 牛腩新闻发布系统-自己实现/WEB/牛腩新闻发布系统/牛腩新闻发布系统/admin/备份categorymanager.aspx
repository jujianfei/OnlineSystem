<%@ Page Title="类别管理-牛腩新闻发布系统" Language="C#" MasterPageFile="~/common.Master" AutoEventWireup="true" CodeBehind="备份categorymanager.aspx.cs" Inherits="牛腩新闻发布系统.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/manager_commen.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="m_category" class="round2">
        <h3>管理中心</h3>
        <div class="con">
            <p><a href="categorymanager.aspx">类别管理</a></p>
            <p><a href="newsmanager.aspx">新闻管理</a></p>
            <p><a href="addnews.aspx">添加新闻</a></p>
        </div>
        <div class="footer">
            <p>&nbsp;</p>
            <!--&nbsp;空格-->
        </div>
    </div>
    <div id="ca_manager" class="round2">
        <h3>类别管理</h3>
        <div class="con">
            <div class="fontcolor">提示：点击类别名称后可直接修改，回车或按鼠标点击页面其他地方后修改生效</div>
            <table class="m_table">
                <tr>
                    <th class="number">序号</th>
                    <th>类别名称</th>
                    <th class="del">删除</th>
                </tr>
                <tr>
                    <td >1</td>
                    <td>体育新闻</td>
                    <td> <a href="#">删除</a></td>
                </tr>
                <tr>
                    <td>1</td>
                    <td>体育新闻</td>
                    <td> <a href="#">删除</a></td>
                </tr>
                <tr>
                    <td>1</td>
                    <td>体育新闻</td>
                    <td> <a href="#">删除</a></td>
                </tr>
            </table>
        </div>
        <div class="footer">
            <p>&nbsp;</p>
            <!--&nbsp;空格-->
        </div>
    </div>
    <div id="add_ca" class="round2">
        <h3>添加类别</h3>
        <div class="con">
            请输入类别：<asp:TextBox ID="txtCaname" runat="server"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" Text="添加类别" />
        </div>
        <div class="footer">
            <p>&nbsp;</p>
            <!--&nbsp;空格-->
        </div>
    </div>
</asp:Content>
