'use strict';
document.addEventListener('DOMContentLoaded', function () {
  setTimeout(function () {
    var options = {
      chart: {
        Type: 'area',
        height: 250,
        toolbar: {
          show: false
        }
      },
      colors: ['#e58a00', '#4680ff'],
      dataLabels: {
        enabled: false
      },
      legend: {
        show: true,
        position: 'top'
      },
      markers: {
        Size: 1,
        colors: ['#fff', '#fff', '#fff'],
        strokeColors: ['#e58a00', '#4680ff'],
        strokeWidth: 1,
        shape: 'circle',
        hover: {
          Size: 4
        }
      },
      stroke: {
        width: 2,
        curve: 'smooth'
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
      grid: {
        show: false
      },
      series: [
        {
          name: 'Revenue',
          data: [200, 320, 320, 275, 275, 400, 400, 300, 440, 320, 320, 275, 275, 400, 300, 440]
        },
        {
          name: 'Sales',
          data: [200, 250, 240, 300, 340, 320, 320, 400, 350, 250, 240, 300, 340, 320, 400, 350]
        }
      ],
      xaxis: {
        labels: {
          hideOverlappingLabels: true
        },
        axisBorder: {
          show: false
        },
        axisTicks: {
          show: false
        }
      }
    };
    var chart = new ApexCharts(document.querySelector('#revenue-sales-chart'), options);
    chart.render();
  }, 500);
});
