<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AskQuestion.aspx.cs" Inherits="Question.AskQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style1">
        问主账号<asp:TextBox ID="UserID" runat="server"></asp:TextBox>
    </p>
    <p class="auto-style1">
        标题<asp:TextBox ID="tital" runat="server" Width="569px"></asp:TextBox>
    </p>
    <p class="auto-style1">
        内容<asp:TextBox ID="substance" runat="server" Height="142px" TextMode="MultiLine" Width="564px"></asp:TextBox>
    </p>
    <p class="auto-style1">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" />
    </p>
</asp:Content>
