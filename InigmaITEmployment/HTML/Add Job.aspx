<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add Job.aspx.cs" Inherits="InigmaITEmployment.HTML.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Job</title>
</head>
<body style="height: 497px">
    <h1>Add Job</h1>
    <form id="form1" runat="server">
        <asp:Label ID="lblJobDescriptionAdd" runat="server" style="z-index: 1; left: 12px; top: 163px; position: absolute" Text="Job Description"></asp:Label>
        <asp:Label ID="lblDatePostedAdd" runat="server" style="z-index: 1; left: 15px; top: 311px; position: absolute" Text="Date Posted"></asp:Label>
        <asp:Label ID="lblStaffIdAdd" runat="server" style="z-index: 1; left: 13px; top: 363px; position: absolute" Text="Staff ID"></asp:Label>
        <div>
            <asp:Label ID="lblJobNameAdd" runat="server" style="z-index: 1; left: 13px; top: 119px; position: absolute" Text="Job Name"></asp:Label>
        </div>
        <asp:TextBox ID="txtAddJobName" runat="server" style="z-index: 1; left: 164px; top: 117px; position: absolute; width: 365px"></asp:TextBox>
        <asp:TextBox ID="txtAddJobDescription" runat="server" style="z-index: 1; left: 167px; top: 162px; position: absolute; width: 367px; height: 114px"></asp:TextBox>
        <asp:TextBox ID="txtAddDate" runat="server" style="z-index: 1; left: 163px; top: 308px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddStaffId" runat="server" style="z-index: 1; left: 164px; top: 360px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 252px; top: 479px; position: absolute; width: 63px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnCancelAdd" runat="server" OnClick="btnCancelAdd_Click" style="z-index: 1; left: 322px; top: 480px; position: absolute; width: 63px" Text="Cancel" />
        <asp:Label ID="lblAddError" runat="server" style="z-index: 1; left: 279px; top: 454px; position: absolute" Visible="False"></asp:Label>
        <asp:Label ID="lblAddEmployerID" runat="server" style="z-index: 1; left: 16px; top: 413px; position: absolute" Text="Employer ID"></asp:Label>
        <asp:TextBox ID="txtAddEmployerId" runat="server" style="z-index: 1; left: 160px; top: 410px; position: absolute; height: 18px"></asp:TextBox>
    </form>
</body>
</html>
