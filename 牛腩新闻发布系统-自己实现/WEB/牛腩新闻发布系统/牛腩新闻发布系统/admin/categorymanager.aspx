<%@ Page Title="" Language="C#" MasterPageFile="~/admin/m_common.master" AutoEventWireup="true" CodeBehind="categorymanager.aspx.cs" Inherits="牛腩新闻发布系统.admin.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="M_ContentPlaceHolder" runat="server">
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
                <asp:Repeater ID="repCategory" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%#Eval ("id") %>
                            </td>
                            <td class="caname">
                                <%#Eval ("name") %>
                            </td>
                            <td>
                                <asp:LinkButton ID="lbtnDelCa_Click" runat="server" CommandArgument='<%#Eval ("id") %>' OnClientClick="return confirm('删除类别会导致其下新闻及评论全部删除，是否要删除！')" OnClick="lbtnDelCa_Click">删除</asp:LinkButton>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
             <div id="test"></div>
        </div>
        <div class="footer">
            <p>&nbsp;</p>
            <!--&nbsp;空格-->
        </div>
    </div>
    <div id="add_ca" class="round2">
        <h3>添加类别</h3>
        <div class="con">
            请输入类别：<asp:TextBox ID="txtCaname" runat="server" ValidationGroup="add_ca"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="add_ca" ControlToValidate="txtCaname" runat="server" ErrorMessage="请输入类别名称！" Text="*"></asp:RequiredFieldValidator>
            <asp:Button ID="btnAdd" runat="server" ValidationGroup="add_ca" UseSubmitBehavior="false" Text="添加类别" OnClick="btnAdd_Click" />
            <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="add_ca" runat="server" ShowMessageBox="true" ShowSummary="false"/>
        </div>
        <div class="footer">
            <p>&nbsp;</p>
            <!--&nbsp;空格-->
        </div>
    </div>
</asp:Content>
