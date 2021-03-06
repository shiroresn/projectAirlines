﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeFile="00_01_Flight.aspx.cs" Inherits="_00_MasterEntries_00_01_Flight" %>

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
        <div id="loader"></div>


        <div class="row">
            <div class="x_panel">
                <div class="x_title">
                    <h2>Add Flight </h2>
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



                    <br>
                    <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtCompanyName">
                            Flight Name <span class="required" style="color: red">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox runat="server" type="text" placeholder="Enter Flight Name" ID="txtFlightName" class="form-control" Width="80%" />

                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtCompanyName">
                            Flight Number <span class="required" style="color: red">*</span>
                        </label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox runat="server" type="text" placeholder="Enter Flight Naumber" ID="txtFlightNumber" class="form-control" Width="80%" />

                        </div>
                    </div>

                    <div class="form-group">
                        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtAddress">
                            Flight Service Provider <span class="required" style="color: red">*</span></label>
                        <div class="col-md-6 col-sm-6 col-xs-12">
                            <asp:TextBox runat="server" placeholder="Enter Flight Service Provider" ID="txtFlightSP" class="form-control" Width="80%">
                              
                            </asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-6 col-sm-6 col-xs-12 col-md-offset-3">

                            <asp:Button runat="server" OnClick="btnSubmit_Click" OnClientClick="return validateCreate();" ID="btnSubmit" Text="Submit" CssClass="btn btn-success" />

                            <a href="../DummyDefault.aspx" class="btn btn-primary">Cancel</a>
                        </div>
                    </div>
                </div>
            </div>

        </div>


        <div class="x_panel" tabindex="0">
            <section id="mail" style="background-color: white;">
                <div class="x_title">
                    <h2>View Flight Details</h2>
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
                    <p class="text-muted font-13 m-b-30">
                    </p>

                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="upCrudGrid" runat="server">
                        <ContentTemplate>
                            <asp:GridView ID="gvFlightInfo" runat="server" OnRowCommand="gvFlightInfo_RowCommand" AllowPaging="true" PageSize="20" class="table table-responsive" AutoGenerateColumns="False"
                                CellPadding="3" DataKeyNames="Id"
                                ForeColor="Black" AllowSorting="True"
                                GridLines="Vertical" BackColor="White" BorderColor="#999999"
                                BorderStyle="Solid" BorderWidth="1px">
                                <AlternatingRowStyle BackColor="#B6E6F5" />
                                <Columns>
                                    <asp:BoundField DataField="Id" HeaderText="Id" />
                                    <asp:BoundField DataField="FlightName" HeaderText="Flight Name" />
                                    <asp:BoundField DataField="FlightNumber" HeaderText="Flight Number" />
                                    <asp:BoundField DataField="FlightSP" HeaderText="Flight Service Provider" />

                                    <asp:ButtonField CommandName="editrecord" ControlStyle-CssClass="btn btn-default btn-sm" ButtonType="Button"
                                        Text="Edit" />
                                    <asp:ButtonField CommandName="deleterecord" ControlStyle-CssClass="btn btn-default btn-sm" ButtonType="Button"
                                        Text="Delete" />
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="#18aed3" Font-Bold="True" ForeColor="White" />
                                <PagerStyle CssClass="pagination-ys" />

                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>


                        </ContentTemplate>
                    </asp:UpdatePanel>

                </div>
            </section>
        </div>





        <!--Edit Cource Modal-->
        <div id="modal-edit" class="modal modal-message modal-info fade" style="display: none;" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <i class="glyphicon glyphicon-edit"></i>
                        <div class="modal-title">Edit City</div>
                    </div>
                    <asp:UpdatePanel ID="upEdit" runat="server">
                        <ContentTemplate>
                            <div class="modal-body">
                                <div class="form-group">
                                    <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtAddress">
                                        Flight Name<span class="required" style="color: red">*</span></label>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <asp:TextBox runat="server" placeholder="Enter Flight Name" ID="txtUpFlightName" class="form-control" Width="80%">
                              
                                        </asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtAddress">
                                        Flight Number <span class="required" style="color: red">*</span></label>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <asp:TextBox runat="server" placeholder="Enter Flight Number" ID="txtUpFlightNumber" class="form-control" Width="80%">
                              
                                        </asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="control-label col-md-3 col-sm-3 col-xs-12" for="txtAddress">
                                        Flight Service Provider <span class="required" style="color: red">*</span></label>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <asp:TextBox runat="server" placeholder="Enter Flight Service Provider" ID="txtFlightUpSP" class="form-control" Width="80%">
                              
                                        </asp:TextBox>
                                    </div>
                                </div>
                                <asp:HiddenField ID="hfId" runat="server" />
                            </div>
                            <div class="modal-footer">
                                <asp:Button runat="server" OnClick="btnEditFlight_Click"
                                    ID="btnEditFlight" Text="Update" CssClass="btn btn-default" />
                                <button type="button" class="btn btn-warning" data-dismiss="modal">Cancel</button>
                            </div>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="gvFlightInfo" EventName="RowCommand" />
                            <asp:AsyncPostBackTrigger ControlID="btnEditFlight" EventName="Click" />
                        </Triggers>
                    </asp:UpdatePanel>
                </div>
                <!-- / .modal-content -->
            </div>
            <!-- / .modal-dialog -->
        </div>
        <!--End Edit Cource Modal-->
        <!--Delete Modal Starts -->
        <div id="modal-delete" class="modal modal-message modal-danger fade" style="display: none;" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <i class="glyphicon glyphicon-trash"></i>
                        <div class="modal-title">Delete Flight</div>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="modal-body">
                                <asp:Label ID="lblDeleteBOld" Font-Bold="true" runat="server"> </asp:Label>
                                <asp:Label ID="lblDeleteMsg" runat="server"> </asp:Label>
                            </div>
                            <div class="modal-footer">
                                <asp:Button runat="server" ID="btnDelete" OnClick="btnDelete_Click" Text="Delete" CssClass="btn btn-danger" />
                                <button type="button" class="btn btn-primary" data-dismiss="modal">Cancel</button>
                            </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>


    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContentPlaceHolder" runat="Server">


    <!-- pace -->
    <script src="../assets/js/pace/pace.min.js"></script>
    <script type="text/javascript">
        function validateCreate() 
        { 
     
            if (document.getElementById('<%=txtFlightName.ClientID %>').value ==""){ 
                <%=txtFlightName.ClientID %>.focus();
                notify('Alert','Please Enter Flight Name','error')
                return false;
            }
            if (document.getElementById('<%=txtFlightNumber.ClientID %>').value == ""){
                <%=txtFlightNumber.ClientID %>.focus();
                notify('Alert','Please Enter Flight Number','error')
                return false;
            }
             if (document.getElementById('<%=txtFlightSP.ClientID %>').value == ""){
                <%=txtFlightSP.ClientID %>.focus();
                notify('Alert','Please Enter Flight Service Provider','error')
                return false;
            }
        }
    </script>
</asp:Content>





