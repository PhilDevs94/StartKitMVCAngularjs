'use strict';

angular.module('newApp')
  .controller('stylingCtrl', function ($scope) {
      $scope.$on('$destroy', function () {
          $('table').each(function () {
              if ($.fn.dataTable.isDataTable($(this))) {
                  $(this).dataTable({
                      "bDestroy": true
                  }).fnDestroy();
              }
          });
      });
  });
