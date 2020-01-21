'use strict';

angular.module('newApp')
    .controller('RegisterCtrl', ['$scope', '$state', '$http', '$window', '$localStorage', '$rootScope', 'toaster', function ($scope, $state, $http, $window, $localStorage, $rootScope,toaster){
        var vm = this;
        vm.username = "";
        vm.password = "";
        
    }]);