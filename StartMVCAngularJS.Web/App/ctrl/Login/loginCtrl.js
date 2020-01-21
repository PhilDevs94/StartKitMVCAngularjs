'use strict';

angular.module('newApp')
    .controller('LoginCtrl', ['$scope', '$state', '$http', '$window', '$localStorage', '$rootScope', 'toaster', function ($scope, $state, $http, $window, $localStorage, $rootScope,toaster){
        var vm = this;
        vm.username = "";
        vm.password = "";
        console.log("Login controller logged in now");
        vm.loginSubmitted = function(){
            console.log("Login to the service");
        }
    }
]);