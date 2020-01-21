'use strict';
angular.module('newApp')
    .run(
        ['$rootScope', '$state', '$stateParams',
            function ($rootScope, $state, $stateParams) {
                $rootScope.$state = $state;
                $rootScope.$stateParams = $stateParams;
                
                $rootScope.$on('$stateChangeStart', function (event, toState, toParams, fromState, fromParams) {
                   if (localStorage.getItem("UserLogged") != null) {
                       $rootScope.UserLogged = JSON.parse(localStorage.getItem("UserLogged"));
                   } else {
                       if (toState.name != 'account.login' && toState.name != 'account.register') {
                           event.preventDefault();
                           $state.go('account.login');
                       }
                   }
                });

            }
        ]
    )
    .config(
    ['$stateProvider', '$urlRouterProvider', 'JQ_CONFIG', 'MODULE_CONFIG',
        function ($stateProvider, $urlRouterProvider, JQ_CONFIG, MODULE_CONFIG) {
            var layout = "Home/app";
            $stateProvider
                .state('app', {
                    abstract: true,
                    url: '/app',
                    templateUrl: layout
                })
                .state('app.dashboard', {
                    url: '/dashboard',
                    templateUrl: '/home/dashboard',
                    resolve: {
                        deps: ['uiLoad', function (uiLoad) {
                            return uiLoad.load('/App/ctrl/DashboardController/dashboardCtrl.js'); // Resolve promise and load before view 
                        }]
                    }
                })
                .state('account', {
                    url: '/account',
                    template: '<div ui-view class="fade-in-right-big smooth"></div>'
                })
                .state('account.login', {
                    url: '/login',
                    templateUrl: '/account/login',
                    resolve: {
                        deps: ['uiLoad', function (uiLoad) {
                            return uiLoad.load('/App/ctrl/Login/loginCtrl.js'); // Resolve promise and load before view 
                        }]
                    }
                })
                .state('account.register', {
                    url: '/register',
                    templateUrl: '/account/register',
                    resolve: {
                        deps: ['uiLoad', function (uiLoad) {
                            return uiLoad.load('/App/ctrl/Register/registerCtrl.js'); // Resolve promise and load before view 
                        }]
                    }
                });
                
            $urlRouterProvider.otherwise('app/dashboard');


        function load(srcs, callback) {
        return {
            deps: ['$ocLazyLoad', '$q',
                function( $ocLazyLoad, $q ){
                var deferred = $q.defer();
                var promise  = false;
                srcs = angular.isArray(srcs) ? srcs : srcs.split(/\s+/);
                if(!promise){
                    promise = deferred.promise;
                }
                angular.forEach(srcs, function(src) {
                    promise = promise.then( function(){
                    if(JQ_CONFIG[src]){
                        return $ocLazyLoad.load(JQ_CONFIG[src]);
                    }
                    angular.forEach(MODULE_CONFIG, function(module) {
                        if( module.name == src){
                        name = module.name;
                        }else{
                        name = src;
                        }
                    });
                    return $ocLazyLoad.load(name);
                    } );
                });
                deferred.resolve();
                return callback ? promise.then(function(){ return callback(); }) : promise;
            }]
        }
        }


      }
    ]
  );
