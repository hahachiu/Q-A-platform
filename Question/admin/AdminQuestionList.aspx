<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Site2.Master" AutoEventWireup="true" CodeBehind="AdminQuestionList.aspx.cs" Inherits="Question.admin.AdminQuestionList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="QuestionID" DataSourceID="AQ" ForeColor="#333333" GridLines="None" OnRowUpdating="GridView1_RowUpdating" Width="998px" OnRowDeleting="GridView1_RowDeleting">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="QuestionID" HeaderText="问题编号" InsertVisible="False" ReadOnly="True" SortExpression="QuestionID" />
            <asp:BoundField DataField="Who_ask" HeaderText="问主账号" SortExpression="Who_ask" />
            <asp:BoundField DataField="Who_ans" HeaderText="答主账号" SortExpression="Who_ans" />
            <asp:BoundField DataField="Tital" HeaderText="标题" SortExpression="Tital" />
            <asp:BoundField DataField="substance" HeaderText="内容" SortExpression="substance" />
            <asp:BoundField DataField="Answer" HeaderText="答案" SortExpression="Answer" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
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
    <asp:SqlDataSource ID="AQ" runat="server" ConnectionString="Data Source=HAHA-chiu\MSSQLSERVER2008;Initial Catalog=Answer_Question;User ID=sa;Password=sa" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [QuestionID], [Who_ask], [Who_ans], [Tital], [substance], [Answer] FROM [Question]" DeleteCommand="proc_deleteQuestion" DeleteCommandType="StoredProcedure" UpdateCommand="proc_answerQuestion" UpdateCommandType="StoredProcedure">
        <DeleteParameters>
            <asp:Parameter Name="QuestionID" Type="Int32" />
            <asp:Parameter Direction="InputOutput" Name="deleteinfo" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="QuestionID" Type="Int32" />
            <asp:Parameter Name="Who_ans" Type="Int32" />
            <asp:Parameter Name="Answer" Type="String" />
            <asp:Parameter Direction="InputOutput" Name="answerinfo" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>

</asp:Content>
