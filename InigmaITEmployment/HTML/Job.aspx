<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Job.aspx.cs" Inherits="InigmaITEmployment.HTML.Jobs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Job</title>
</head>
<body style="height: 676px">
        <h1>Job</h1>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblViewJobName" runat="server" style="z-index: 1; left: 20px; top: 113px; position: absolute" Text="Job Name"></asp:Label>
        <asp:Label ID="lblViewDescription" runat="server" style="z-index: 1; left: 17px; top: 151px; position: absolute" Text="Job Description"></asp:Label>
        <asp:Label ID="lblViewDate" runat="server" style="z-index: 1; left: 24px; top: 375px; position: absolute" Text="Date Posted"></asp:Label>
        <asp:TextBox ID="txtViewJob" runat="server" style="z-index: 1; left: 177px; top: 110px; position: absolute; width: 448px"></asp:TextBox>
        <asp:TextBox ID="txtViewDescription" runat="server" style="z-index: 1; left: 178px; top: 150px; position: absolute; width: 446px; height: 176px"></asp:TextBox>
        <asp:TextBox ID="txtViewDate" runat="server" style="z-index: 1; left: 180px; top: 375px; position: absolute"></asp:TextBox>
        <asp:Button ID="txtApply" runat="server" OnClick="txtApply_Click" style="z-index: 1; left: 284px; top: 483px; position: absolute; width: 63px" Text="Apply" />
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 357px; top: 484px; position: absolute; width: 63px" Text="Return" />
    </form>
</body>
</html>
