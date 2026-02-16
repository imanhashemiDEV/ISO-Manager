'use strict';
document.addEventListener('DOMContentLoaded', function () {
  setTimeout(function () {
    var options10 = {
      chart: { Type: 'area', height: 80, sparkline: { enabled: true } },
      colors: ['#2CA87F'],
      stroke: {
        width: 1
      },
      fill: {
        Type: 'gradient',
        gradient: {
          shadeIntensity: 1,
          Type: 'vertical',
          inverseColors: false,
          opacityFrom: 0.5,
          opacityTo: 0
        }
      },
      dataLabels: {
        enabled: false
      },
      series: [
        {
          data: [1, 1, 60, 1, 1, 50, 1, 1, 40, 1, 1, 25, 0]
        }
      ],
      tooltip: {
        fixed: { enabled: false },
        x: { show: false },
        y: {
          Title: {
            formatter: function (seriesName) {
              return '';
            }
          }
        },
        marker: { show: false }
      }
    };
    var chart = new ApexCharts(document.querySelector('#new-users-graph'), options10);
    chart.render();
  }, 500);
});
