<%@ Page Title="" Language="C#" MasterPageFile="~/admin/m_common.master" AutoEventWireup="true" CodeBehind="newsmanager.aspx.cs" Inherits="牛腩新闻发布系统.admin.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="M_ContentPlaceHolder" runat="server">
    <div id="ca_manager" class="round2">
        <h3>类别管理</h3>
        <div class="con">
            <div class="fontcolor">提示：点击新闻标题后，可进行对该新闻评论的删除</div>
            <table class="m_table">
                <tr>
                    <th class="number">序号</th>
                    <th>标题</th>
                    <th>修改</th>
                    <th class="del">删除</th>
                </tr>
                <asp:Repeater ID="repNews" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("id") %></td>
                        <td><a href='../newscontent.aspx?newsid=<%#Eval("id") %>' target="_blank"><%#Eval("title") %></a></td>
                        <td><a href='modnews.aspx?newsid=<%#Eval("id") %>' target="_blank">修改</a></td>
                        <td>
                            <asp:LinkButton ID="lbtnDel" OnClientClick="return confirm('删除新闻会连同其下评论一起删除,是否删除?')" OnClick="lbtnDel_Click" CommandArgument='<%#Eval("id") %>' runat="server">删除</asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>   
            </table>
        </div>
        <div class="footer">
            <p>&nbsp;</p>
            <!--&nbsp;空格-->
        </div>
    </div>
</asp:Content>
