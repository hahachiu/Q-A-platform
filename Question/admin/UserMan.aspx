<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Site2.Master" AutoEventWireup="true" CodeBehind="UserMan.aspx.cs" Inherits="Question.admin.UserMan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="用户账号" DataSourceID="Users" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting" Width="580px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:BoundField DataField="用户账号" HeaderText="用户账号" ReadOnly="True" SortExpression="用户账号" />
            <asp:BoundField DataField="用户密码" HeaderText="用户密码" SortExpression="用户密码" />
            <asp:BoundField DataField="用户名" HeaderText="用户名" SortExpression="用户名" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:SqlDataSource ID="Users" runat="server" ConnectionString="Data Source=HAHA-chiu\MSSQLSERVER2008;Initial Catalog=Answer_Question;User ID=sa;Password=sa" DeleteCommand="proc_deleteStudent" DeleteCommandType="StoredProcedure" InsertCommand="proc_insertStudent" InsertCommandType="StoredProcedure" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [用户账号], [用户密码], [用户名] FROM [StudentsUser]">
        <DeleteParameters>
            <asp:Parameter Name="UserID" Type="Int32" />
            <asp:Parameter Direction="InputOutput" Name="deleteinfo" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="UserName" Type="String" />
            <asp:Parameter Name="UserPassword" Type="String" />
            <asp:Parameter Direction="InputOutput" Name="insertinfo" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
    <br />
    <asp:Label ID="laluserName" runat="server" Text="用户名"></asp:Label>
&nbsp;<asp:TextBox ID="TexUserName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="laluserPassword" runat="server" Text="用户密码"></asp:Label>
    <asp:TextBox ID="TexUserPassword" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="添加用户" />
</asp:Content>
