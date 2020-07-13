﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.master" AutoEventWireup="true" CodeFile="DashBoard3.aspx.cs" Inherits="_03_Dashboards_DashBoard3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

     <!-- Bootstrap core CSS -->

  <link href="../css/bootstrap.min.css" rel="stylesheet" />
  
<link href="../assets/css/animate.min.css" rel="stylesheet" />
<link href="../assets/fonts/css/font-awesome.min.css" rel="stylesheet" />
  <!-- Custom styling plus plugins -->
    <link href="../assets/css/custom.css" rel="stylesheet" />
<%--  <link href="../css/custom.css" rel="stylesheet"/>--%>
  <link rel="../stylesheet" type="text/css" href="css/maps/jquery-jvectormap-2.0.3.css" />
  <link href="../css/icheck/flat/green.css" rel="stylesheet" />
  <link href="../css/floatexamples.css" rel="stylesheet" type="text/css" />

  <script src="../js/jquery.min.js"></script>
  <script src="../js/nprogress.js"></script>

  <script src="../js/jquery.min.js"></script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server" class="form-horizontal form-label-left">
        
        <div class="">

          <div class="row top_tiles" style="margin: 10px 0;">
            <div class="col-md-3 col-sm-3 col-xs-6 tile">
              <span>Total Sessions</span>
              <h2>231,809</h2>
              <span class="sparkline_one" style="height: 160px;">
                    <canvas width="200" height="60" style="display: inline-block; vertical-align: top; width: 94px; height: 30px;"></canvas>
                </span>
            </div>
            <div class="col-md-3 col-sm-3 col-xs-6 tile">
              <span>Total Revenue</span>
              <h2> 231,809 INR</h2>
              <span class="sparkline_one" style="height: 160px;">
                    <canvas width="200" height="60" style="display: inline-block; vertical-align: top; width: 94px; height: 30px;"></canvas>
                </span>
            </div>
            <div class="col-md-3 col-sm-3 col-xs-6 tile">
              <span>Total Sessions</span>
              <h2>231,809</h2>
              <span class="sparkline_two" style="height: 160px;">
                    <canvas width="200" height="60" style="display: inline-block; vertical-align: top; width: 94px; height: 30px;"></canvas>
                </span>
            </div>
            <div class="col-md-3 col-sm-3 col-xs-6 tile">
              <span>Total Sessions</span>
              <h2>231,809</h2>
              <span class="sparkline_one" style="height: 160px;">
                    <canvas width="200" height="60" style="display: inline-block; vertical-align: top; width: 94px; height: 30px;"></canvas>
                </span>
            </div>
          </div>
          <br />


          <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
              <div class="dashboard_graph x_panel">
                <div class="row x_title">
                  <div class="col-md-6">
                    <h3>Accounts Status <small></small></h3>
                  </div>
                  <div class="col-md-6">
                    <div id="reportrange" class="pull-right" style="background: #fff; cursor: pointer; padding: 5px 10px; border: 1px solid #ccc">
                      <i class="glyphicon glyphicon-calendar fa fa-calendar"></i>
                      <span>December 30, 2015 - July 10, 2016</span> <b class="caret"></b>
                    </div>
                  </div>
                </div>
                <div class="x_content">
                  <div class="demo-container" style="height:250px">
                    <div id="placeholder3xx3" class="demo-placeholder" style="width: 100%; height:250px;"></div>
                  </div>
                </div>
              </div>
            </div>
          </div>


        

        </div>

        <!-- footer content -->
        <footer>
          <div class="copyright-info">
           
          </div>
          <div class="clearfix"></div>
        </footer>
        <!-- /footer content -->

      
        </form>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="JSContentPlaceHolder" Runat="Server">
     <script src="../js/bootstrap.min.js"></script>

  <!-- bootstrap progress js -->
  <script src="../js/progressbar/bootstrap-progressbar.min.js"></script>
  <script src="../js/nicescroll/jquery.nicescroll.min.js"></script>
  <!-- icheck -->
  <script src="../js/icheck/icheck.min.js"></script>
  <!-- gauge js -->
  <script type="text/javascript" src="../js/gauge/gauge.min.js"></script>
 
<script src="../assets/js/gauge/gauge_demo.js"></script>
  <!-- daterangepicker -->
  <script type="text/javascript" src="../js/moment/moment.min.js"></script>
  <script type="text/javascript" src="../js/datepicker/daterangepicker.js"></script>
  <!-- chart js -->
  <script src="../js/chartjs/chart.min.js"></script>
  <!-- sparkline -->
  <script src="../assets/js/sparkline/jquery.sparkline.min.js"></script>

  <script src="../js/custom.js"></script>
  <!-- skycons -->
 
    <script src="../assets/js/skycons/skycons.min.js"></script>
  <!-- flot js -->
  <!--[if lte IE 8]><script type="text/javascript" src="js/excanvas.min.js"></script><![endif]-->
 <script type="text/javascript" src="../assets/js/flot/jquery.flot.js"></script>
  <script type="text/javascript" src="../assets/js/flot/jquery.flot.pie.js"></script>
  <script type="text/javascript" src="../assets/js/flot/jquery.flot.orderBars.js"></script>
  <script type="text/javascript" src="../assets/js/flot/jquery.flot.time.min.js"></script>
  <script type="text/javascript" src="../assets/js/flot/date.js"></script>
  <script type="text/javascript" src="../assets/js/flot/jquery.flot.spline.js"></script>
  <script type="text/javascript" src="../assets/js/flot/jquery.flot.stack.js"></script>
  <script type="text/javascript" src="../assets/js/flot/curvedLines.js"></script>
<script type="text/javascript" src="../assets/js/flot/jquery.flot.resize.js"></script>
  <!-- pace -->
  <script src="../assets/js/pace/pace.min.js"></script>
  <!-- flot -->

  <script>
    //random data
    var d1 = [
      [0, 1],
      [1, 9],
      [2, 6],
      [3, 10],
      [4, 5],
      [5, 17],
      [6, 6],
      [7, 10],
      [8, 7],
      [9, 11],
      [10, 35],
      [11, 9],
      [12, 12],
      [13, 5],
      [14, 3],
      [15, 4],
      [16, 9]
    ];

    //flot options
    var options = {
      series: {
        curvedLines: {
          apply: true,
          active: true,
          monotonicFit: true
        }
      },
      colors: ["#26B99A"],
      grid: {
        borderWidth: {
          top: 0,
          right: 0,
          bottom: 1,
          left: 1
        },
        borderColor: {
          bottom: "#7F8790",
          left: "#7F8790"
        }
      }
    };
    var plot = $.plot($("#placeholder3xx3"), [{
      label: " Revenue Collection",
      data: d1,
      lines: {
        fillColor: "rgba(150, 202, 89, 0.12)"
      }, //#96CA59 rgba(150, 202, 89, 0.42)
      points: {
        fillColor: "#fff"
      }
    }], options);
  </script>
  <!-- /flot -->
  <!--  -->
  <script>
    $('document').ready(function() {
      $(".sparkline_one").sparkline([2, 4, 3, 4, 5, 4, 5, 4, 3, 4, 5, 6, 7, 5, 4, 3, 5, 6], {
        type: 'bar',
        height: '40',
        barWidth: 9,
        colorMap: {
          '7': '#a1a1a1'
        },
        barSpacing: 2,
        barColor: '#26B99A'
      });

      $(".sparkline_two").sparkline([2, 4, 3, 4, 5, 4, 5, 4, 3, 4, 5, 6, 7, 5, 4, 3, 5, 6], {
        type: 'line',
        width: '200',
        height: '40',
        lineColor: '#26B99A',
        fillColor: 'rgba(223, 223, 223, 0.57)',
        lineWidth: 2,
        spotColor: '#26B99A',
        minSpotColor: '#26B99A'
      });

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
    });
  </script>
  <!-- -->
  <!-- datepicker -->
  <script type="text/javascript">
    $(document).ready(function() {

      var cb = function(start, end, label) {
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
      $('#reportrange').on('show.daterangepicker', function() {
        console.log("show event fired");
      });
      $('#reportrange').on('hide.daterangepicker', function() {
        console.log("hide event fired");
      });
      $('#reportrange').on('apply.daterangepicker', function(ev, picker) {
        console.log("apply event fired, start/end dates are " + picker.startDate.format('MMMM D, YYYY') + " to " + picker.endDate.format('MMMM D, YYYY'));
      });
      $('#reportrange').on('cancel.daterangepicker', function(ev, picker) {
        console.log("cancel event fired");
      });
      $('#options1').click(function() {
        $('#reportrange').data('daterangepicker').setOptions(optionSet1, cb);
      });
      $('#options2').click(function() {
        $('#reportrange').data('daterangepicker').setOptions(optionSet2, cb);
      });
      $('#destroy').click(function() {
        $('#reportrange').data('daterangepicker').remove();
      });
    });
  </script>
  <!-- /datepicker -->

  <!-- moris js -->
    <script src="../assets/js/moris/raphael-min.js"></script>
  <script src="../assets/js/moris/morris.min.js"></script>
  <script>
    $(function() {
      var day_data = [{
        "period": "Jan",
        "Hours worked": 80
      }, {
        "period": "Feb",
        "Hours worked": 125
      }, {
        "period": "Mar",
        "Hours worked": 176
      }, {
        "period": "Apr",
        "Hours worked": 224
      }, {
        "period": "May",
        "Hours worked": 265
      }, {
        "period": "Jun",
        "Hours worked": 314
      }];
      Morris.Bar({
        element: 'graph_bar',
        data: day_data,
        hideHover: 'always',
        xkey: 'period',
        barColors: ['#26B99A', '#34495E', '#ACADAC', '#3498DB'],
        ykeys: ['Hours worked', 'sorned'],
        labels: ['Hours worked', 'SORN'],
        xLabelAngle: 60
      });
    });
  </script>
  <!-- skycons -->
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
  <script>
    var opts = {
      lines: 12, // The number of lines to draw
      angle: 0, // The length of each line
      lineWidth: 0.4, // The line thickness
      pointer: {
        length: 0.75, // The radius of the inner circle
        strokeWidth: 0.042, // The rotation offset
        color: '#1D212A' // Fill color
      },
      limitMax: 'false', // If true, the pointer will not go past the end of the gauge
      colorStart: '#1ABC9C', // Colors
      colorStop: '#1ABC9C', // just experiment with them
      strokeColor: '#F0F3F3', // to see which ones work best for you
      generateGradient: true
    };
    var target = document.getElementById('foo2'); // your canvas element
    var gauge = new Gauge(target).setOptions(opts); // create sexy gauge!
    gauge.maxValue = 5000; // set max gauge value
    gauge.animationSpeed = 32; // set animation speed (32 is default value)
    gauge.set(3200); // set actual value
    gauge.setTextField(document.getElementById("gauge-text2"));
  </script>



</asp:Content>

