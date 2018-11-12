<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Three_M.Default" %>

<!DOCTYPE html>
<html lang="en" >

<head>
  <meta charset="UTF-8">
  <title>Three-M System Information</title>
  <meta name="viewport" content="initial-scale=1.0, width=device-width" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css">
      <link rel="stylesheet" href="css/style.css">
<style type="text/css">
    body {
    color: #797979;
    background: #f1f2f7 url(../images/b.jpg) repeat;
    font-family: 'Open Sans', sans-serif;
    padding: 0px !important;
    margin: 0px !important;
    font-size: 13px;
}
</style>
</head>
<body>
  <div class="login_form">
  <setion class="login-wrapper">
  
    <div class="logo">
		 <%--<a target="_blank" rel="noopener" href="https://unrealnavigation.com">--%>
		 <img src="images/logo-login.png" alt=""></a>
    </div>
    
    <form id="form1" method="post" runat="server" action="Default2.aspx">
      <label for="username">User Name</label>
      <input  required name="login[username]" type="text" autocapitalize="off" autocorrect="off"/>
      
      <label for="password">Password</label>
      <input class="password" required name="login[password]" type="password" />
      <div class="hide-show">
        <span>Show</span>
      </div>
      <button type="submit">Submit</button>
    </form>
    
  </section>
  </div>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script  src="js/index.js"></script>
</body>
</html>
