<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="05_01_ViewFlightScheduld.aspx.cs" Inherits="_05_User_05_01_ViewFlightScheduld" %>

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


        <div class="row">
            <div class="x_panel">
                <div class="x_title">
                    <h2>View Flight Scheduld </h2>
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

                    <div class="row">
                        <div class="form-group col-md-2">
                            <label runat="server">
                                From Date
                            </label>

                            <asp:TextBox runat="server" CssClass="form-control" ID="txtFromDate" Width="100%"></asp:TextBox>

                            <asp:CalendarExtender Animated="true" FirstDayOfWeek="Sunday"
                                DefaultView="Days" Format="dd/MM/yyyy" runat="server" Enabled="True" TargetControlID="txtFromDate" ID="CalendarExtender1">
                            </asp:CalendarExtender>

                        </div>
                        <div class="form-group col-md-2">
                            <label runat="server">
                                To Date                      
                            </label>
                            <asp:TextBox runat="server" CssClass="form-control" ID="txtToDate" Width="100%" />
                            <asp:CalendarExtender Animated="true" FirstDayOfWeek="Sunday"
                                DefaultView="Days" Format="dd/MM/yyyy" runat="server" Enabled="True" TargetControlID="txtToDate" ID="CalendarExtender2">
                            </asp:CalendarExtender>
                        </div>
                        <div class="form-group col-md-2">
                            <asp:Button Style="margin-top: 15%" OnClick="btnViewbyDate_Click" runat="server" Text="View" CssClass="btn btn-default" ID="btnViewbyDate"></asp:Button>
                        </div>



                    </div>


                    <div class="row">
                        <div class="form-group col-md-2">
                            <label runat="server">
                                Source
                            </label>

                            <asp:DropDownList runat="server" CssClass="form-control" ID="ddlSource" Width="100%"></asp:DropDownList>
                        </div>
                        <div class="form-group col-md-2">
                            <label runat="server">
                                Destination                     
                            </label>
                            <asp:DropDownList runat="server" CssClass="form-control" ID="ddlDestination" Width="100%" />
                        </div>
                        <div class="form-group col-md-2">
                             <asp:Button Style="margin-top: 15%" OnClick="btnViewBySd_Click" runat="server" Text="View" CssClass="btn btn-default" ID="btnViewBySd"></asp:Button>
                        </div>



                    </div>

                </div>
            </div>

        </div>


        <div class="x_panel" tabindex="0">
            <section id="mail" style="background-color: white;">
                <div class="x_title">
                    <h2>Flight Scheduld</h2>
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
                    </p>   <asp:HiddenField ID="hfId" runat="server" />

                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="upCrudGrid" runat="server">
                        <ContentTemplate>
                            <asp:GridView ID="gvViewScheduld" runat="server" OnRowCommand="gvViewScheduld_RowCommand" AllowPaging="true" PageSize="20" class="table table-responsive" AutoGenerateColumns="False"
                                CellPadding="3" DataKeyNames="Id"
                                ForeColor="Black" AllowSorting="True"
                                GridLines="Vertical" BackColor="White" BorderColor="#999999"
                                BorderStyle="Solid" BorderWidth="1px">
                                <AlternatingRowStyle BackColor="#B6E6F5" />
                                <Columns>
                                    <asp:BoundField DataField="Id" HeaderText="Id" />

                                    <asp:BoundField DataField="FlightName" HeaderText="Flight Name" />
                                    <asp:BoundField DataField="Date" HeaderText="Date" />
                                    <asp:BoundField DataField="Time" HeaderText="Time" />
                                    <asp:BoundField DataField="Source" HeaderText="Source" />
                                    <asp:BoundField DataField="Destination" HeaderText="Destination" />


                                    <asp:ButtonField CommandName="editrecord" ControlStyle-CssClass="btn btn-default btn-sm" ButtonType="Button"
                                        Text="Book" />
                                  
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








    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContentPlaceHolder" runat="Server">


    <!-- pace -->
    <script src="../assets/js/pace/pace.min.js"></script>

</asp:Content>




