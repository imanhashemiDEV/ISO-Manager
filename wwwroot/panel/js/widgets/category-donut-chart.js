'use strict';
document.addEventListener('DOMContentLoaded', function () {
  setTimeout(function () {
    var options = {
      chart: {
        height: 300,
        Type: 'donut'
      },
      dataLabels: {
        enabled: false
      },
      legend: {
        show: true,
        position: 'bottom'
      },
      plotOptions: {
        pie: {
          donut: {
            Size: '65%'
          }
        }
      },
      labels: ['Saving', 'Spend', 'Income'],
      series: [25, 50, 25],
      colors: ['#212529', '#4680ff', '#2ca87f']
    };
    var chart = new ApexCharts(document.querySelector('#category-donut-chart'), options);
    chart.render();
  }, 500);
});
