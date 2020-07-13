<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeFile="04_07_Passangerlist.aspx.cs" Inherits="_04_Entries_04_07_Passangerlist" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script src="../assets/js/select/select2.full.js"></script>
    <link href="../assets/css/select/select2.min.css" rel="stylesheet" />
    <link href="../assets/Loader.css" rel="stylesheet" />
    <link href="../../StyleSheet1.css" rel="stylesheet" />
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form runat="server" id="form" class="form-horizontal form-label-left">



        <div class="row">
            <div class="x_panel">
                <div class="x_title">
                    <h2>View Passanger </h2>
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


                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:GridView ID="GridView1" CssClass="table table-responsive" runat="server" Width="700px"
                                AutoGenerateColumns="false" PageSize="5" HeaderStyle-BackColor="#6699ff" HeaderStyle-ForeColor="WhiteSmoke" AllowPaging="False">
                                <Columns>
                                    <asp:BoundField DataField="FirstName" HeaderText="First Name" HtmlEncode="true" />
                                    <asp:BoundField DataField="LastName" HeaderText="Last Name" HtmlEncode="true" />
                                    <asp:BoundField DataField="Email" HeaderText="Email" HtmlEncode="true" />
                                    <asp:BoundField DataField="Mobile" HeaderText="Mobile" HtmlEncode="true" />



                                </Columns>
                            </asp:GridView>
                            <asp:HiddenField ID="hdn" runat="server" />
                                            </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>


    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContentPlaceHolder" runat="Server">


    <script src="../assets/js/notify/pnotify.core.js"></script>
    <script src="../assets/js/notify/pnotify.nonblock.js"></script>
    <script src="../assets/js/notify/pnotify.buttons.js"></script>
    <!-- pace -->
    <script src="../assets/js/pace/pace.min.js"></script>
    <script type="text/javascript">

        var digitsOnly = /[1234567890]/g;
        var integerOnly = /[0-9\.]/g;
        var alphaOnly = /[A-Za-z ]/g;
        var alphaAndNum = /[A-Za-z0-9 ]/g;
        var usernameOnly = /[0-9A-Za-z\._-]/g;
        var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        var not_empty = /[\s]*/;


        function restrictInput(myfield, e, restrictionType, checkdot) {
            if (!e) var e = window.event
            if (e.keyCode) code = e.keyCode;
            else if (e.which) code = e.which;
            var character = String.fromCharCode(code);
            // if user pressed esc... remove focus from field...
            if (code == 27) { this.blur(); return false; }
            // ignore if the user presses other keys
            // strange because code: 39 is the down key AND ' key...
            // and DEL also equals .
            if (!e.ctrlKey && code != 9 && code != 8 && code != 36 && code != 37 && code != 38 && (code != 39 || (code == 39 &&
character == "'")) && code != 40) {
                if (character.match(restrictionType)) {
                    if (checkdot == "checkdot") {
                        return !isNaN(myfield.value.toString() + character);
                    }
                    else {
                        return true;
                    }
                }
                else {
                    return false;
                }
            }
        }

        function InsertUnit() {

            var UnitRecords = '';

            UnitRecords = $("#ContentPlaceHolder1_txtUnit").val();
            UnitTitle = $("#ContentPlaceHolder1_txtTitle").val();

            if (UnitRecords == "" || UnitTitle == "")
                notify('Alert', 'Please Enter Unit and Title', 'error')

            else {

                $.ajax({

                    url: "../00_MasterEntries/00_09_Unit.aspx/Insert",
                    type: "POST",
                    contentType: "application/json",
                    datatype: "json",
                    data: JSON.stringify({ par: UnitRecords, par2: UnitTitle }),
                    success: function (data) {
                        $("#ContentPlaceHolder1_txtUnit").val('');
                        $("#ContentPlaceHolder1_txtTitle").val('');
                        notify('Success', 'Unit Added Successfully', 'success')
                    },
                    failure: function (response) {
                        alert(response.d);
                    }
                });// end of ajax
            }// end of else
        };                    // end of function insert unit 

    </script>
</asp:Content>






