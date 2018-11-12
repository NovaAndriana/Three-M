<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reg.aspx.cs" Inherits="Three_M.reg.reg" %>

<!DOCTYPE html>
<html>
<style>
input[type=text], select {
    width: 100%;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
}
input[type=password], select {
    width: 100%;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
}
input[type=submit] {
    width: 100%;
    background-color: #4CAF50;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}

input[type=submit]:hover {
    background-color: #45a049;
}

div {
    border-radius: 5px;
    background-color: #f2f2f2;
    padding: 20px;
}
</style>
<body>

<h3>Three-M System Information</h3>

<div>
  <form id="form1" runat="server">
    <label for="EMP_ID">ID</label>
    <asp:TextBox type="text" id="txtEmpID" name="EMP_ID" runat="server"></asp:TextBox>

    <label for="NAME">Name</label>
    <asp:TextBox type="text" id="txtName" name="NAME" runat="server" placeholder="Your name.."></asp:TextBox>

    <label for="GENDER">Gender</label>
    <select id="txtGender" name="GENDER" runat="server">
      <option value="Male">Male</option>
      <option value="Male">Female</option>
    </select>

    <label for="POSITION">Position</label>
    <select id="txtPosition" name="POSITION" runat="server">
      <option value="TOPUSER">TOP USER</option>
      <option value="Director">Director</option>
      <option value="Manager">Manager</option>
      <option value="SPV">SPV</option>
      <option value="Staff Officer">Staff Officer</option>
    </select>

    <label for="ADDRESS">Address</label>
    <asp:TextBox type="text" id="txtAddress" name="ADDRESS" runat="server"  placeholder="Address"></asp:TextBox>

    <label for="HANPHONE">Handphone</label>
    <asp:TextBox type="text" id="txtHandphone" name="HANPHONE" runat="server"  placeholder="Handphone"></asp:TextBox>
      
    <label for="EMAIL">Email</label>
    <asp:TextBox type="text" id="txtEmail" name="EMAIL" runat="server"  placeholder="Email"></asp:TextBox>

    <label for="SALT">Password</label>
    <asp:TextBox type="password" id="txtPass" name="SALT" runat="server"  placeholder="Password"></asp:TextBox>
      
    <input id="btnSubmit" type="submit" value="Submit">
  </form>
</div>

</body>
</html>

