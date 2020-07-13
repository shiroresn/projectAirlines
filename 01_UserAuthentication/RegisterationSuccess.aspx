<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterationSuccess.aspx.cs" Inherits="Pages_04_UserAuthentication_RegisterationSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Asian Airlines | Registration Page</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <!-- Bootstrap 3.3.6 -->
    <link rel="stylesheet" href="Assets/bootstrap/css/bootstrap.min.css" />
    <!-- Font Awesome -->
    <link href="Assets/bootstrap/fonts/font-awesome.min.css" rel="stylesheet" />
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="Assets/dist/css/AdminLTE.min.css" />
    <!-- iCheck -->
    <link rel="stylesheet" href="Assets/plugins/iCheck/square/blue.css" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->
</head>
<body class="hold-transition register-page">
    <div class="register-box">
        <div class="register-logo">
            <a href="../../index2.html"><b style="color: red">Asian</b> Airlines</a>
        </div>

        <div class="register-box-body">
            <p class="login-box-msg">Register a new user</p>

            <form runat="server" id="form1">
              <h3> Your Registered Successfully. </h3>
                <br>
                Your UserName: <asp:Label ID="lblUserName" runat="server" Font-Bold="true"/>
                    <br>
                    And Password : <asp:Label ID="lblPassword" runat="server" Font-Bold="true"/>
               <br>
                   <a href="04_02_Login.aspx" class="text-center">Login Here.</a>
            </form>


         

        </div>
        <!-- /.form-box -->
    </div>
    <!-- /.register-box -->

    <!-- jQuery 2.2.3 -->
    <script src="Assets/plugins/jQuery/jquery-2.2.3.min.js"></script>
    <!-- Bootstrap 3.3.6 -->
    <script src="Assets/bootstrap/js/bootstrap.min.js"></script>
    <!-- iCheck -->
    <script src="Assets/plugins/iCheck/icheck.min.js"></script>
    <script>
        $(function () {
            $('input').iCheck({
                checkboxClass: 'icheckbox_square-blue',
                radioClass: 'iradio_square-blue',
                increaseArea: '20%' // optional
            });
        });
</script>
</body>
</html>
