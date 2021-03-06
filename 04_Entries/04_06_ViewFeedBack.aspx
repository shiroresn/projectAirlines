﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeFile="04_06_ViewFeedBack.aspx.cs" Inherits="_04_Entries_04_06_ViewFeedBack" %>

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



                    <div class="messagealert" id="alert_container">
                    </div>



                <br>


        <div class="x_panel" tabindex="0">
            <section id="mail" style="background-color: white;">
                <div class="x_title">
                    <h2>View Feedback</h2>
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
                            <asp:GridView ID="gvFeedBack" runat="server"  AllowPaging="true" PageSize="20" class="table table-responsive" AutoGenerateColumns="False"
                                CellPadding="3" 
                                ForeColor="Black" AllowSorting="True"
                                GridLines="Vertical" BackColor="White" BorderColor="#999999"
                                BorderStyle="Solid" BorderWidth="1px">
                                <AlternatingRowStyle BackColor="#B6E6F5" />
                                <Columns>
                               

                                    <asp:BoundField DataField="Name" HeaderText=" Name" />
                                      <asp:BoundField DataField="Subject" HeaderText="Subject" />
                                    <asp:BoundField DataField="MobileNo" HeaderText="Contact No" />
                                    <asp:BoundField DataField="Message" HeaderText="Message" />
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


