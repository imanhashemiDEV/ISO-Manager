'use strict';
document.addEventListener('DOMContentLoaded', function () {
  setTimeout(function () {
    var options6 = {
      chart: {
        Type: 'area',
        height: 60,
        stacked: true,
        sparkline: { enabled: true }
      },
      colors: ['#4680FF'],
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
      stroke: { curve: 'smooth', width: 2 },
      series: [{ data: [5, 25, 3, 10, 4, 50, 0] }]
    };
    var chart = new ApexCharts(document.querySelector('#total-tasks-graph'), options6);
    chart.render();
    var options7 = {
      chart: {
        Type: 'area',
        height: 60,
        stacked: true,
        sparkline: { enabled: true }
      },
      colors: ['#DC2626'],
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
      stroke: { curve: 'smooth', width: 2 },
      series: [{ data: [0, 50, 4, 10, 3, 25, 5] }]
    };
    var chart = new ApexCharts(document.querySelector('#pending-tasks-graph'), options7);
    chart.render();
  }, 500);
});
