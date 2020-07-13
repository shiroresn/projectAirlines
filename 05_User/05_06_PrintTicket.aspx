<%@ Page Language="C#" AutoEventWireup="true" CodeFile="05_06_PrintTicket.aspx.cs" Inherits="_05_User_05_06_PrintTicket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="../assets/bootstrap-3.3.6-dist/css/bootstrap.css" rel="stylesheet" />

    <script src="../assets/js/jquery.min.js"></script>
    
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <script type="text/javascript">
        function PoPrint() {
            $("#btnPrint").hide();
            $("#btnCancel").hide();
            window.print();
        }

        </script>
            <div id="noprint" runat="server" class="row">
                <div class="header-top">
                    <div class="row">
                        <div class="col-md-2">
                        </div>
                        <div class="col-md-2">
                        </div>
                        <div class="col-md-12">
                     <center>
                               <label style="color:red" > Asian </label> Airlines
                       </center>
                        </div>


                    </div>
                </div>

                <div class="row">
                     <div class="col-md-6">
                     
                         </div>
                    <div class="col-md-6">
                        <div class="col-md-2">
                            <asp:Button ID="btnPrint" OnClientClick="PoPrint();" Height="30px" Width="100px" Style="float: right" Text="Print" runat="server" CssClass="btn btn-primary"  />
                        </div>
                        <div class="col-md-2">

                         
                        </div>
                          <div class="col-md-2">
                        <asp:Button ID="btnCancel" Height="30px" Width="100px" Style="float: left" Text="Back"  runat="server" CssClass="btn btn-primary" />

                    </div>
                    </div>

                    

                    <hr>
                </div>

            </div>

        </header>

        <div id="divprint" class="container">
            <asp:Panel ID="thisdivPrint" runat="server">

             
                         <center>       <asp:Label  runat="server" ID="lblEmailStat"/> <center>
                <center> <h3>Air Ticket </h3>      </center>
                <div runat="server" class="col-md-12" style="font-size: small;">
                    <div id="PrintHeader" runat="server" class="row" style="padding-bottom: 30px">
                    </div>

                    <table class="table table-responsive table-bordered">
                        <tr>
                            <th style="height: 150px; width: 300px; text-align: left">
                                <asp:Label ID="lblInvoiceAddresLbl" runat="server"> FLIGHT DETAILS</asp:Label>
                                <br>
                               Flight Number:
                                 <asp:Label ID="lblFlightNumber" runat="server" Style="font-size: 15px; text-align: left; width: 20%"></asp:Label>
                                <br>
                                Flight Name:
                                <asp:Label ID="LblFlightName" runat="server" Style="font-size: 15px; text-align: left;"></asp:Label>
                                <br>
                                Seat No
                                <asp:Label ID="lblSeatNo" runat="server" Style="font-size: 15px; text-align: left;"></asp:Label>
                                <br>
                                Ticket No:
                                <asp:Label ID="lblTicketNo" runat="server" />
                                <br>
                                Date:
                                <asp:Label ID="lblDate" runat="server" Style="font-size: 15px; text-align: left; width: 20%"></asp:Label>
                                <br>  
                                Time:
                                <asp:Label ID="lblTime" runat="server" Style="font-size: 15px; text-align: left; width: 20%"></asp:Label>


                            </th>
                            <th style="height: 150px; width: 300px; text-align: left">Passanger Deatails
                                <br>
                                No of Passangers:
                              <asp:Label ID="lblNoofPassangers" runat="server" Style="font-size: 15px; text-align: left; width: 20%"></asp:Label>
                                <br>
                                Source:
                                <asp:Label ID="lblSource" runat="server" Style="font-size: 15px; text-align: left;"></asp:Label>
                                <br>
                                Destination:
                                <asp:Label ID="lblDestination" runat="server" Style="font-size: 15px; text-align: left;"></asp:Label>
                                <br>
                                 Class:
                                <asp:Label ID="lblClass" runat="server" Style="font-size: 15px; text-align: left;"></asp:Label>
                                <br>
                               
                            </th>
                        </tr>
                   
                    </table>


                 

                    <table class="table table-responsive " id="studentdetails">

                        <caption>
                            <%-- <img width="100%" src="../assets/images/pr.png" />--%>
                        </caption>

                       
                        <tr>
                            <td>Total Amount:</td>
                            <td>
                                <asp:Label ID="lblTotalAmount"  runat="server" Font-Bold="true" />
                            </td>

                        </tr>


                       
                       
                    </table>


                   

                    <br>
                    <strong>Thanking You,
    <br>
                        FOR ASIAN AIRLINES
                        <br>
                       
                    </strong>

                </div>
                <br>
                <footer>
                  
                </footer>




            </asp:Panel>

        </div>

    </form>
</body>
</html>


