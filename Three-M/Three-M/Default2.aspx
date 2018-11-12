<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="Three_M.Default2" %>

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
    form select {
  width: 94%;
  padding: .5em .25em;
  margin: 0 3% 1em;
  font-size: 1.0em;
  border: 2px solid #000;
  outline: none;
  -webkit-transition: all 0.25s;
  -moz-transition: all 0.25s;
  -ms-transition: all 0.25s;
  -o-transition: all 0.25s;
  transition: all 0.25s;
  -webkit-border-radius: 5px;
  -moz-border-radius: 5px;
  border-radius: 5px;
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
    
    <form id="form1" method="post" runat="server">
      <label for="username">User Type</label>
      <%--<input  required name="login[username]" type="text" autocapitalize="off" autocorrect="off"/>--%>
        <select>
          <option value="volvo">Volvo</option>
          <option value="saab">Saab</option>
          <option value="opel">Opel</option>
          <option value="audi">Audi</option>
        </select>
      <button type="submit">Sign In</button>
    </form>
    
  </section>
  </div>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script  src="js/index.js"></script>
</body>
</html>
