<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeFile="DashBoard1.aspx.cs" Inherits="_03_Dashboards_DashBoard1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <!-- Bootstrap core CSS -->
    <link href="../css/bootstrap.min.css" rel="stylesheet" />

    <link href="../assets/css/animate.min.css" rel="stylesheet" />
    <link href="../assets/fonts/css/font-awesome.min.css" rel="stylesheet" />
    <!-- Custom styling plus plugins -->
    <link href="../assets/css/custom.css" rel="stylesheet" />
    <link rel="../stylesheet" type="text/css" href="css/maps/jquery-jvectormap-2.0.3.css" />
    <script src="../assets/js/icheck/icheck.min.js"></script>
    <link href="../assets/css/floatexamples.css" rel="stylesheet" />
    <script src="../js/jquery.min.js"></script>
    <script src="../js/nprogress.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <form runat="server" class="form-horizontal form-label-left">
        <!-- page content -->

        <!-- top tiles -->
        <div class="row tile_count">
            <div class="animated flipInY col-md-2 col-sm-4 col-xs-4 tile_stats_count">
                <div class="left"></div>
                <div class="right">
                    <span class="count_top"><i class="fa fa-user"></i>Prospect Customers</span>
                    <div class="count">20</div>
                    <span class="count_bottom"><i class="green">4% </i>From last Week</span>
                </div>
            </div>
            <div class="animated flipInY col-md-2 col-sm-4 col-xs-4 tile_stats_count">
                <div class="left"></div>
                <div class="right">
                    <span class="count_top"><i class="fa fa-clock-o"></i>Total Online Enquires</span>
                    <div class="count">123</div>
                    <span class="count_bottom"><i class="green"><i class="fa fa-sort-asc"></i>3% </i>From last Week</span>
                </div>
            </div>
            <div class="animated flipInY col-md-2 col-sm-4 col-xs-4 tile_stats_count">
                <div class="left"></div>
                <div class="right">
                    <span class="count_top"><i class="fa fa-user"></i>Total Email Sent</span>
                    <div class="count green">1200</div>
                    <span class="count_bottom"><i class="green"><i class="fa fa-sort-asc"></i>34% </i>From last Week</span>
                </div>
            </div>
            <div class="animated flipInY col-md-2 col-sm-4 col-xs-4 tile_stats_count">
                <div class="left"></div>
                <div class="right">
                    <span class="count_top"><i class="fa fa-user"></i>Total Sms Sent</span>
                    <div class="count">800</div>
                    <span class="count_bottom"><i class="red"><i class="fa fa-sort-desc"></i>12% </i>From last Week</span>
                </div>
            </div>
            <div class="animated flipInY col-md-2 col-sm-4 col-xs-4 tile_stats_count">
                <div class="left"></div>
                <div class="right">
                    <span class="count_top"><i class="fa fa-user"></i>Remaining Sms </span>
                    <div class="count">2,315</div>
                    <span class="count_bottom"><i class="red"><i class="fa fa-sort-desc"></i>34% </i>From last Week</span>
                </div>
            </div>
            <div class="animated flipInY col-md-2 col-sm-4 col-xs-4 tile_stats_count">
                <div class="left"></div>
                <div class="right">
                    <span class="count_top"><i class="fa fa-user"></i>Email to Be sent Today</span>
                    <div class="count">128</div>
                    <span class="count_bottom"><i class="green"><i class="fa fa-sort-asc"></i>2% </i>From yesterday</span>
                </div>
            </div>
        </div>
        <!-- /top tiles -->
        <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="dashboard_graph">
                    <div class="row x_title">
                        <div class="col-md-6">
                            <h3>Digital Marketing  Activities <small>Email Marketing</small></h3>
                        </div>
                        <div class="col-md-6">
                            <div id="reportrange" class="pull-right" style="background: #fff; cursor: pointer; padding: 5px 10px; border: 1px solid #ccc">
                                <i class="glyphicon glyphicon-calendar fa fa-calendar"></i>
                                <span>December 30, 2015 - july 28, 2016</span> <b class="caret"></b>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-9 col-sm-9 col-xs-12">
                        <div id="placeholder33" style="height: 260px; display: none" class="demo-placeholder"></div>
                        <div style="width: 100%;">
                            <div id="canvas_dahs" class="demo-placeholder" style="width: 100%; height: 270px;"></div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3 col-xs-12 bg-white">
                        <div class="x_title">
                            <h2>Top Campaign Performance</h2>
                            <div class="clearfix"></div>
                        </div>
                        <div class="col-md-12 col-sm-12 col-xs-6">
                            <div>
                                <p>Facebook Campaign</p>
                                <div class="">
                                    <div class="progress progress_sm" style="width: 76%;">
                                        <div class="progress-bar bg-green" role="progressbar" data-transitiongoal="80"></div>
                                    </div>
                                </div>
                            </div>
                            <div>
                                <p>Twitter Campaign</p>
                                <div class="">
                                    <div class="progress progress_sm" style="width: 76%;">
                                        <div class="progress-bar bg-green" role="progressbar" data-transitiongoal="60"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-12 col-sm-12 col-xs-6">
                            <div>
                                <p>Conventional Media</p>
                                <div class="">
                                    <div class="progress progress_sm" style="width: 76%;">
                                        <div class="progress-bar bg-green" role="progressbar" data-transitiongoal="40"></div>
                                    </div>
                                </div>
                            </div>
                            <div>
                                <p>Bill boards</p>
                                <div class="">
                                    <div class="progress progress_sm" style="width: 76%;">
                                        <div class="progress-bar bg-green" role="progressbar" data-transitiongoal="50"></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
        </div>
        <br />

        <div class="row">

            <!-- Start to do list -->
            <div class="col-md-4 col-sm-4 col-xs-6">
                <div class="x_panel">
                    <div class="x_title">
                        <h2>To Do List <small>Sample tasks</small></h2>
                        <ul class="nav navbar-right panel_toolbox">
                            <li>
                                <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                            </li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                                <ul class="dropdown-menu" role="menu">
                                    <li>
                                        <a href="#">Settings 1</a>
                                    </li>
                                    <li>
                                        <a href="#">Settings 2</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <a class="close-link"><i class="fa fa-close"></i></a>
                            </li>
                        </ul>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">
                        <div class="">
                            <ul class="to_do">
                                <li>
                                    <p>
                                        <input type="checkbox" class="flat">
                                        Schedule meeting with new client
                                    </p>
                                </li>
                                <li>
                                    <p>
                                        <input type="checkbox" class="flat">
                                        Create email address for new intern
                                    </p>
                                </li>
                                <li>
                                    <p>
                                        <input type="checkbox" class="flat">
                                        Send Pdc Reminder
                                    </p>
                                </li>
                                <li>
                                    <p>
                                        <input type="checkbox" class="flat">
                                        Copy backups to offsite location
                                    </p>
                                </li>
                                <li>
                                    <p>
                                        <input type="checkbox" class="flat">
                                        Material truck fixie locavors mcsweeney
                                    </p>
                                </li>
                                <li>
                                    <p>
                                        <input type="checkbox" class="flat">
                                        Supply truck radhe krishna bakers
                                    </p>
                                </li>
                                <li>
                                    <p>
                                        <input type="checkbox" class="flat">
                                        Create po orders
                                    </p>
                                </li>
                                <li>
                                    <p>
                                        <input type="checkbox" class="flat">
                                        Meetings Techbona Softwares
                                    </p>
                                </li>
                                <li>
                                    <p>
                                        <input type="checkbox" class="flat">
                                        Meeting Account dept
                                    </p>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <!-- End to do list -->
            <div class="col-md-8 col-sm-8 col-xs-12">

                <div class="row">
                    <div class="col-md-12 col-sm-12 col-xs-12">
                        <div class="x_panel">
                            <div class="x_title">
                                <h2>Visitors location <small>geo-presentation</small></h2>
                                <ul class="nav navbar-right panel_toolbox">
                                    <li>
                                        <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                    </li>
                                    <li class="dropdown">
                                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                                        <ul class="dropdown-menu" role="menu">
                                            <li>
                                                <a href="#">Settings 1</a>
                                            </li>
                                            <li>
                                                <a href="#">Settings 2</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a class="close-link"><i class="fa fa-close"></i></a>
                                    </li>
                                </ul>
                                <div class="clearfix"></div>
                            </div>
                            <div class="x_content">
                                <div class="dashboard-widget-content">
                                    <div class="col-md-4 hidden-small">
                                        <h2 class="line_30">125.7k Views from 60 countries</h2>
                                        <table class="countries_list">
                                            <tbody>
                                                <tr>
                                                    <td>United States</td>
                                                    <td class="fs15 fw700 text-right">33%</td>
                                                </tr>
                                                <tr>
                                                    <td>France</td>
                                                    <td class="fs15 fw700 text-right">27%</td>
                                                </tr>
                                                <tr>
                                                    <td>Germany</td>
                                                    <td class="fs15 fw700 text-right">16%</td>
                                                </tr>
                                                <tr>
                                                    <td>Spain</td>
                                                    <td class="fs15 fw700 text-right">11%</td>
                                                </tr>
                                                <tr>
                                                    <td>Britain</td>
                                                    <td class="fs15 fw700 text-right">10%</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                    <div id="world-map-gdp" class="col-md-8 col-sm-12 col-xs-12" style="height: 230px;"></div>
                                </div>
                            </div>
                        </div>
                    </div>


                </div>


            </div>
        </div>
        <!-- footer content -->
        <footer>
            <div class="copyright-info">
                <p class="pull-right">
                </p>
            </div>
            <div class="clearfix"></div>
        </footer>
        <!-- /footer content -->

        <!-- /page content -->
    </form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="JSContentPlaceHolder" runat="Server">

    <script src="../assets/js/bootstrap.min.js"></script>
    <!-- gauge js -->
    <script type="text/javascript" src="../assets/js/gauge/gauge.min.js"></script>
    <script type="text/javascript" src="../assets/js/gauge/gauge_demo.js"></script>

    <!-- bootstrap progress js -->


    <script src="../assets/js/nicescroll/jquery.nicescroll.min.js"></script>
    <!-- icheck -->
    <script src="../js/icheck/icheck.min.js"></script>
    <!-- daterangepicker -->

    <script type="text/javascript" src="../assets/js/moment/moment.min.js"></script>
    <script type="text/javascript" src="../assets/js/datepicker/daterangepicker.js"></script>
    <!-- chart js -->

    <script src="../assets/js/chartjs/chart.min.js"></script>

    <script src="../assets/js/custom.js"></script>

    <!-- flot js -->
    <!--[if lte IE 8]>
     <script type="text/javascript" src="js/excanvas.min.js"></script><![endif]-->

    <script type="text/javascript" src="../assets/js/flot/jquery.flot.js"></script>
    <script type="text/javascript" src="../assets/js/flot/jquery.flot.pie.js"></script>
    <script type="text/javascript" src="../assets/js/flot/jquery.flot.orderBars.js"></script>
    <script type="text/javascript" src="../assets/js/flot/jquery.flot.time.min.js"></script>
    <script type="text/javascript" src="../assets/js/flot/date.js"></script>
    <script type="text/javascript" src="../assets/js/flot/jquery.flot.spline.js"></script>
    <script type="text/javascript" src="../assets/js/flot/jquery.flot.stack.js"></script>
    <script type="text/javascript" src="../assets/js/flot/curvedLines.js"></script>
    <script type="text/javascript" src="../assets/js/flot/jquery.flot.resize.js"></script>

    <script>
        $(document).ready(function () {
            // [17, 74, 6, 39, 20, 85, 7]
            //[82, 23, 66, 9, 99, 6, 2]
            var data1 = [
              [gd(2012, 1, 1), 17],
              [gd(2012, 1, 2), 74],
              [gd(2012, 1, 3), 6],
              [gd(2012, 1, 4), 39],
              [gd(2012, 1, 5), 20],
              [gd(2012, 1, 6), 85],
              [gd(2012, 1, 7), 7]
            ];

            var data2 = [
              [gd(2012, 1, 1), 82],
              [gd(2012, 1, 2), 23],
              [gd(2012, 1, 3), 66],
              [gd(2012, 1, 4), 9],
              [gd(2012, 1, 5), 119],
              [gd(2012, 1, 6), 6],
              [gd(2012, 1, 7), 9]
            ];
            $("#canvas_dahs").length && $.plot($("#canvas_dahs"), [
              data1, data2
            ], {
                series: {
                    lines: {
                        show: false,
                        fill: true
                    },
                    splines: {
                        show: true,
                        tension: 0.4,
                        lineWidth: 1,
                        fill: 0.4
                    },
                    points: {
                        radius: 0,
                        show: true
                    },
                    shadowSize: 2
                },
                grid: {
                    verticalLines: true,
                    hoverable: true,
                    clickable: true,
                    tickColor: "#d5d5d5",
                    borderWidth: 1,
                    color: '#fff'
                },
                colors: ["rgba(38, 185, 154, 0.38)", "rgba(3, 88, 106, 0.38)"],
                xaxis: {
                    tickColor: "rgba(51, 51, 51, 0.06)",
                    mode: "time",
                    tickSize: [1, "day"],
                    //tickLength: 10,
                    axisLabel: "Date",
                    axisLabelUseCanvas: true,
                    axisLabelFontSizePixels: 12,
                    axisLabelFontFamily: 'Verdana, Arial',
                    axisLabelPadding: 10
                    //mode: "time", timeformat: "%m/%d/%y", minTickSize: [1, "day"]
                },
                yaxis: {
                    ticks: 8,
                    tickColor: "rgba(51, 51, 51, 0.06)",
                },
                tooltip: false
            });

            function gd(year, month, day) {
                return new Date(year, month - 1, day).getTime();
            }
        });
  </script>

    <!-- worldmap -->
    <script type="text/javascript" src="../js/maps/jquery-jvectormap-2.0.3.min.js"></script>
    <script type="text/javascript" src="../js/maps/gdp-data.js"></script>
    <script type="text/javascript" src="../js/maps/jquery-jvectormap-world-mill-en.js"></script>
    <script type="text/javascript" src="../js/maps/jquery-jvectormap-us-aea-en.js"></script>
    <!-- pace -->

    <script src="../assets/js/pace/pace.min.js"></script>
    <script>
        $(function () {
            $('#world-map-gdp').vectorMap({
                map: 'world_mill_en',
                backgroundColor: 'transparent',
                zoomOnScroll: false,
                series: {
                    regions: [{
                        values: gdpData,
                        scale: ['#E6F2F0', '#149B7E'],
                        normalizeFunction: 'polynomial'
                    }]
                },
                onRegionTipShow: function (e, el, code) {
                    el.html(el.html() + ' (GDP - ' + gdpData[code] + ')');
                }
            });
        });
  </script>
    <!-- skycons -->

    <script src="../assets/js/skycons/skycons.min.js"></script>

    <script>
        var icons = new Skycons({
            "color": "#73879C"
        }),
          list = [
            "clear-day", "clear-night", "partly-cloudy-day",
            "partly-cloudy-night", "cloudy", "rain", "sleet", "snow", "wind",
            "fog"
          ],
          i;

        for (i = list.length; i--;)
            icons.set(list[i], list[i]);

        icons.play();
  </script>

    <!-- dashbord linegraph -->
    <script>
        Chart.defaults.global.legend = {
            enabled: false
        };

        var data = {
            labels: [
              "Symbian",
              "Blackberry",
              "Other",
              "Android",
              "IOS"
            ],
            datasets: [{
                data: [15, 20, 30, 10, 30],
                backgroundColor: [
                  "#BDC3C7",
                  "#9B59B6",
                  "#455C73",
                  "#26B99A",
                  "#3498DB"
                ],
                hoverBackgroundColor: [
                  "#CFD4D8",
                  "#B370CF",
                  "#34495E",
                  "#36CAAB",
                  "#49A9EA"
                ]

            }]
        };

        var canvasDoughnut = new Chart(document.getElementById("canvas1"), {
            type: 'doughnut',
            tooltipFillColor: "rgba(51, 51, 51, 0.55)",
            data: data
        });
  </script>
    <!-- /dashbord linegraph -->

    <!-- datepicker -->

    <script type="text/javascript">

        $(document).ready(function () {
     
            var cb = function (start, end, label) {
                console.log(start.toISOString(), end.toISOString(), label);
                $('#reportrange span').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'));
                //alert("Callback has fired: [" + start.format('MMMM D, YYYY') + " to " + end.format('MMMM D, YYYY') + ", label = " + label + "]");
            }

            var optionSet1 = {
                startDate: moment().subtract(29, 'days'),
                endDate: moment(),
                minDate: '01/01/2012',
                maxDate: '12/31/2015',
                dateLimit: {
                    days: 60
                },
                showDropdowns: true,
                showWeekNumbers: true,
                timePicker: false,
                timePickerIncrement: 1,
                timePicker12Hour: true,
                ranges: {
                    'Today': [moment(), moment()],
                    'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
                    'Last 7 Days': [moment().subtract(6, 'days'), moment()],
                    'Last 30 Days': [moment().subtract(29, 'days'), moment()],
                    'This Month': [moment().startOf('month'), moment().endOf('month')],
                    'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
                },
                opens: 'left',
                buttonClasses: ['btn btn-default'],
                applyClass: 'btn-small btn-primary',
                cancelClass: 'btn-small',
                format: 'MM/DD/YYYY',
                separator: ' to ',
                locale: {
                    applyLabel: 'Submit',
                    cancelLabel: 'Clear',
                    fromLabel: 'From',
                    toLabel: 'To',
                    customRangeLabel: 'Custom',
                    daysOfWeek: ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'],
                    monthNames: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'],
                    firstDay: 1
                }
            };
            $('#reportrange span').html(moment().subtract(29, 'days').format('MMMM D, YYYY') + ' - ' + moment().format('MMMM D, YYYY'));
            $('#reportrange').daterangepicker(optionSet1, cb);
            $('#reportrange').on('show.daterangepicker', function () {
                console.log("show event fired");
            });
            $('#reportrange').on('hide.daterangepicker', function () {
                console.log("hide event fired");
            });
            $('#reportrange').on('apply.daterangepicker', function (ev, picker) {
                console.log("apply event fired, start/end dates are " + picker.startDate.format('MMMM D, YYYY') + " to " + picker.endDate.format('MMMM D, YYYY'));
            });
            $('#reportrange').on('cancel.daterangepicker', function (ev, picker) {
                console.log("cancel event fired");
            });
            $('#options1').click(function () {
                $('#reportrange').data('daterangepicker').setOptions(optionSet1, cb);
            });
            $('#options2').click(function () {
                $('#reportrange').data('daterangepicker').setOptions(optionSet2, cb);
            });
            $('#destroy').click(function () {
                $('#reportrange').data('daterangepicker').remove();
            });
        });
  </script>
    <script>
        NProgress.done();
  </script>
    <!-- /datepicker -->
    <!-- /footer content -->


</asp:Content>

