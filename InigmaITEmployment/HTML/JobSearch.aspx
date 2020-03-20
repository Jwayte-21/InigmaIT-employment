<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JobSearch.aspx.cs" Inherits="InigmaITEmployment.HTML.JobSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>JobSearch</title>
</head>

<body style="height: 749px">
    
        <h1>JobSearch</h1>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
        </div>
        <asp:ListBox ID="lstJobBox" runat="server" style="z-index: 1; left: 14px; top: 231px; position: absolute; height: 222px; width: 550px"></asp:ListBox>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 22px; top: 172px; position: absolute; width: 459px"></asp:TextBox>
        <asp:Button ID="btnSearchJob" runat="server" style="z-index: 1; left: 505px; top: 171px; position: absolute; height: 23px; width: 71px" Text="Search" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 24px; top: 484px; position: absolute; right: 1147px" Text="Add Job" />
        <asp:Button ID="btnViewJob" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 29px; top: 625px; position: absolute; height: 26px; width: 389px" Text="View Job" />
        <asp:Button ID="btnUpdateJob" runat="server" OnClick="Button1_Click1" style="z-index: 1; left: 26px; top: 529px; position: absolute; width: 396px" Text="Update Job" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 28px; top: 578px; position: absolute; height: 25px; width: 393px" Text="Delete Job" />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="z-index: 1; left: 34px; top: 674px; position: absolute; right: 1156px" Text="Home" />
    </form>
    
</body>
</html>