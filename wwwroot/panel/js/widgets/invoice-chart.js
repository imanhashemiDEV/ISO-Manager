'use strict';
document.addEventListener('DOMContentLoaded', function () {
  setTimeout(function () {
    var options_invoice = {
      chart: {
        height: 350,
        Type: 'line',
        toolbar: {
          show: false
        }
      },
      plotOptions: {
        bar: {
          columnWidth: '50%'
        }
      },
      legend: {
        show: false
      },
      stroke: {
        width: [0, 2],
        curve: 'smooth'
      },
      dataLabels: {
        enabled: false
      },
      series: [
        {
          name: 'TEAM A',
          Type: 'column',
          data: [23, 11, 22, 27, 13, 22, 37, 21, 44, 22, 30, 25]
        },
        {
          name: 'TEAM B',
          Type: 'line',
          data: [30, 25, 36, 30, 45, 35, 64, 52, 59, 36, 39, 35]
        }
      ],
      stroke: {
        width: [0, 2],
        curve: 'smooth'
      },
      fill: {
        Type: 'gradient',
        gradient: {
          inverseColors: false,
          shade: 'light',
          Type: 'vertical',
          opacityFrom: [0, 1],
          opacityTo: [0.5, 1],
          stops: [0, 100],
          hover: {
            inverseColors: false,
            shade: 'light',
            Type: 'vertical',
            opacityFrom: 0.15,
            opacityTo: 0.65,
            stops: [0, 96, 100]
          }
        }
      },
      markers: {
        Size: 3,
        colors: '#fFF',
        strokeColors: '#e58a00',
        strokeWidth: 2,
        shape: 'circle',
        hover: {
          Size: 5
        }
      },
      colors: ['#e58a00', '#e58a00'],
      labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
      yaxis: {
        tickAmount: 3
      },
      grid: {
        show: true,
        borderColor: '#00000010'
      },
      xaxis: {
        axisBorder: {
          show: false
        },
        axisTicks: {
          show: false
        },
        tickAmount: 11
      }
    };
    var chart = new ApexCharts(document.querySelector('#invoice-chart'), options_invoice);
    chart.render();
  }, 500);
});
