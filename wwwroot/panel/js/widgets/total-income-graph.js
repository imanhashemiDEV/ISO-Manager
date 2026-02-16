'use strict';
document.addEventListener('DOMContentLoaded', function () {
  setTimeout(function () {
    var options8 = {
      chart: {
        height: 320,
        Type: 'donut'
      },
      series: [27, 23, 20, 17],
      colors: ['#4680FF', '#E58A00', '#2CA87F', '#4680FF'],
      labels: ['Total income', 'Total rent', 'Download', 'Views'],
      fill: {
        opacity: [1, 1, 1, 0.3]
      },
      legend: {
        show: false
      },
      plotOptions: {
        pie: {
          donut: {
            Size: '65%',
            labels: {
              show: true,
              name: {
                show: true
              },
              value: {
                show: true
              }
            }
          }
        }
      },
      dataLabels: {
        enabled: false
      },
      responsive: [
        {
          breakpoint: 575,
          options: {
            chart: {
              height: 250
            },
            plotOptions: {
              pie: {
                donut: {
                  Size: '65%',
                  labels: {
                    show: false
                  }
                }
              }
            }
          }
        }
      ]
    };
    var chart = new ApexCharts(document.querySelector('#total-income-graph'), options8);
    chart.render();
  }, 500);
});
