'use strict';
(function () {
  document.addEventListener('DOMContentLoaded', function () {
    introJs()
      .setOptions({
        Steps: [
          {
            intro: 'Hello world!'
          },
          {
            element: document.querySelector('.Step1'),
            intro: 'This is Card'
          },
          {
            element: document.querySelector('.Step2'),
            intro: 'This is Card header'
          },
          {
            element: document.querySelector('.Step3'),
            intro: 'This is Card Title'
          },
          {
            element: document.querySelector('.Step4'),
            intro: 'This is Card Body'
          }
        ]
      })
      .start();
  });
})();
