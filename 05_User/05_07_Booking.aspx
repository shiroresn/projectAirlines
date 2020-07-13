<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="05_07_Booking.aspx.cs" Inherits="_05_User_05_07_Booking" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script src="../assets/js/validator/validator.js"></script>

    <link href="../assets/fonts/css/font-awesome.css" rel="stylesheet" />
    <link href="../assets/css/icheck/flat/green.css" rel="stylesheet" />
    <script src="../assets/js/select/select2.full.js"></script>
    <link href="../assets/css/select/select2.min.css" rel="stylesheet" />

    
    <link href="../assets/Loader.css" rel="stylesheet" />
    <!--Validation code  -->
    <script type="text/javascript">
        function ShowMessage(message, messagetype) {
            var cssclass;
            switch (messagetype) {
                case 'Success':
                    cssclass = 'alert-success'
                    break;
                case 'Error':
                    cssclass = 'alert-danger'
                    break;
                case 'Warning':
                    cssclass = 'alert-warning'
                    break;
                default:
                    cssclass = 'alert-info'
            }
            $('#alert_container').append('<div id="alert_div"  style="margin: 0 0.5%; -webkit-box-shadow: 3px 4px 6px #999; "  class="alert fade in ' + cssclass + '"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a><strong>' + messagetype + '!</strong> <span>' + message + '</span></div>');
        }
    </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form runat="server" id="form" class="form-horizontal form-label-left">

        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <div class="row">
            <div class="x_panel">
                <div class="x_title">
                    <h2>Ticket Window </h2>
                    
                    <ul class="nav navbar-right panel_toolbox">
                        <li><a class="collapse-link"></a>
                        </li>
                        <li><a class="collapse-link"></a>
                        </li>
                        <li><a class="collapse-link"></a>
                        </li>
                        <li><a class="collapse-link"></a>
                        </li>
                        <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                        </li>
                    </ul>
                    <div class="clearfix"></div>
                </div>
                <div class="x_content">


                   <div class="messagealert" id="alert_container">
                    </div>

                    <center>
                    <asp:Label runat="server" Font-Bold="true" ID="Seats"/>
                        </center>
                    <br>
                    <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtCompanyName">
                            Flight Name 
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          
                            <asp:TextBox runat="server"  ReadOnly="true" ID="txtFlightName" class="form-control" Width="80%"  />
                        </div>
                    </div>
                     <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtCompanyName">
                            Flight Number 
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          
                            <asp:TextBox runat="server" ReadOnly="true"  ID="txtFlightNumber" class="form-control" Width="80%"  />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtCompanyName">
                             Departure Date 
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                        <asp:TextBox runat="server" ReadOnly="true" ID="txtDate" class="form-control" Width="80%"  />

                          
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtAddress">
                           Departure Time </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox runat="server" ReadOnly="true" ID="txtTime" class="form-control" Width="80%">
                              
                            </asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtAddress">
                            Source </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox runat="server" ReadOnly="true" ID="txtSource" class="form-control" Width="80%"/>
                        </div>
                    </div>
                       <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtAddress">
                            Destination </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <asp:TextBox runat="server" ReadOnly="true" ID="txtDestination" class="form-control" Width="80%"/>
                        </div>
                    </div>
                  <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtAddress">
                            Number of Passangers <span class="required" style="color: red">*</span></label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <asp:TextBox runat="server" Text="0" MaxLength="2" placeholder="Max 10 Passangers" ID="txtPassangers" class="form-control" Width="80%"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtAddress">
                         Select Class  </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                          <asp:DropDownList runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlFlightClass_SelectedIndexChanged" ID="ddlFlightClass" class="form-control" Width="80%">
                                <asp:ListItem Selected="True" Value="0">--Select--</asp:ListItem>
                                <asp:ListItem Value="1">Buisness Class</asp:ListItem>
                                <asp:ListItem Value="2">Executive Class-</asp:ListItem>
                                <asp:ListItem Value="3">Economy Class</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                    </div>
                    
                     <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtAddress">
                           Amount Payable <span class="required" style="color: red">*</span></label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                           <asp:TextBox runat="server" ReadOnly="true" ID="txtTotalAmount" class="form-control" Width="80%"/>
                        </div>
                    </div>
                   
                    
                    <div class="form-group">
                        <div class="col-md-6 col-sm-6 col-xs-12 col-md-offset-3">

                            <asp:Button runat="server" OnClick="btnSubmit_Click" OnClientClick="return validateCreate();" ID="btnSubmit" Text="Book Ticket" CssClass="btn btn-success" />

                            <a href="../DummyDefault.aspx" class="btn btn-primary">Cancel</a>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        



    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContentPlaceHolder" runat="Server">


    <!-- pace -->
    <script src="../assets/js/pace/pace.min.js"></script>
 
</asp:Content>