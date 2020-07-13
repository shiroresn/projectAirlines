<%@ Page Language="C#" AutoEventWireup="true" CodeFile="04_01_UserRegistration.aspx.cs" Inherits="Pages_04_UserAuthentication_04_01_UserRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Asian Airlines | Registration Page</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <!-- Bootstrap 3.3.6 -->
    <link href="Assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
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
                <div class="form-group has-feedback">
                    <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" placeholder="First Name" />
                    <span class="glyphicon glyphicon-user form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" placeholder="Last Name" />
                    <span class="glyphicon glyphicon-user form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <asp:TextBox type="email" ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email" />
                    <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control" placeholder="Mobile No" />
                    <span class="glyphicon glyphicon-phone form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <asp:TextBox ID="txtCity" runat="server" CssClass="form-control" placeholder="Address" />
                    <span class="glyphicon glyphicon-home form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <asp:DropDownList ID="ddlLocation" runat="server" CssClass="form-control">
                        <asp:ListItem Value="0">--Select City--</asp:ListItem>
                        <asp:ListItem Value="Mumbai">Mumbai</asp:ListItem>
                         <asp:ListItem Value="Nashik">Nashik</asp:ListItem>
                        <asp:ListItem Value="Pune">Pune</asp:ListItem>
                        <asp:ListItem Value="Nagpur">Nagpur</asp:ListItem>
                        <asp:ListItem Value="Delhi">Delhi</asp:ListItem>
                        <asp:ListItem Value="Chennai">Chennai</asp:ListItem>

                    </asp:DropDownList>
                    
                </div>
                <div class="form-group has-feedback">
                    <asp:DropDownList ID="ddlGender" runat="server" CssClass="form-control">
                        <asp:ListItem Value="0">--Select Gender-- </asp:ListItem>

                        <asp:ListItem Value="1">Male </asp:ListItem>
                        <asp:ListItem Value="2">Female </asp:ListItem>
                    </asp:DropDownList>

                </div>
                <div class="form-group has-feedback">
                    <asp:TextBox ID="txtPassword" runat="server" type="password" CssClass="form-control" placeholder="Password" />
                    <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <asp:TextBox ID="txtRePassword" runat="server" type="password" CssClass="form-control" placeholder="Retype password" />
                    <span class="glyphicon glyphicon-log-in form-control-feedback"></span>
                </div>
                <div class="row">
                    <div class="col-xs-8">
                        <div class="checkbox icheck">
                            <label>
                                <input type="checkbox">
                                I agree to the <a href="#">terms</a>
                            </label>
                        </div>
                    </div>
                    <!-- /.col -->
                    <div class="col-xs-4">
                        <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Text="Register" class="btn btn-primary btn-block btn-flat"></asp:Button>
                    </div>
                    <!-- /.col -->
                </div>
            </form>


            <a href="04_02_Login.aspx" class="text-center">I already have an Account.</a>

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
