<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="Three_M.reg.reg" %>

<!DOCTYPE html>
<html>
<link href="StyleSheet1.css" rel="stylesheet" />
<body>

<h3>Three-M System Information</h3>

<div>
  <form id="form1" runat="server">
    <label for="EMP_ID">ID</label>
    <asp:TextBox type="text" id="txtEmpID" name="EMP_ID" runat="server"></asp:TextBox>

    <label for="UID">Name</label>
    <asp:TextBox type="text" id="txtUid" name="UID" runat="server" placeholder="Your name.."></asp:TextBox>

    <label for="SALT">Password</label>
    <asp:TextBox type="password" id="txtPass" name="SALT" runat="server"  placeholder="Password"></asp:TextBox>
    
    <label for="UTYPE">Position</label>
      <asp:dropdownlist runat="server" id="ddlPosition" name="UTYPE">
          <asp:listitem text="-" value="-"></asp:listitem>
         <asp:listitem text="TOP USER" value="TOPUSER"></asp:listitem>
         <asp:listitem text="Director" value="Director"></asp:listitem>
         <asp:listitem text="Manager" value="Manager"></asp:listitem>
         <asp:listitem text="SPV" value="SPV"></asp:listitem>
         <asp:listitem text="Staff Officer" value="Staff Officer"></asp:listitem>
      </asp:dropdownlist>

      <asp:Button id="b1" Text="Submit" runat="server" OnClick="b1_Click" />
  </form>
</div>

</body>
</html>

