'use strict';
angular.module('newApp')
    .run(
        ['$rootScope', '$state', '$stateParams',
            function ($rootScope, $state, $stateParams) {
                $rootScope.$state = $state;
                $rootScope.$stateParams = $stateParams;
                
                $rootScope.$on('$stateChangeStart', function (event, toState, toParams, fromState, fromParams) {
                //   if (localStorage.getItem("UserLogged") != null) {
                //       $rootScope.UserLogged = JSON.parse(localStorage.getItem("UserLogged"));
                //   } else {
                //       if (toState.name != 'account.login' && toState.name != 'account.register') {
                //           event.preventDefault();
                //           $state.go('account.login');
                //       }
                //   }
                });

            }
        ]
    )
    .config(function ($routeProvider) {
        $routeProvider
          .when('/', {
              templateUrl: 'dashboard/dashboard.html',
              controller: 'dashboardCtrl'
          })
          .when('/frontend', {
              templateUrl: 'frontend/frontend.html',
              controller: 'frontendCtrl'
          })
          .when('/charts', {
              templateUrl: 'charts/charts/charts.html',
              controller: 'chartsCtrl'
          })
          .when('/financial-charts', {
              templateUrl: 'charts/financialCharts/financialCharts.html',
              controller: 'financialChartsCtrl'
          })
          .when('/ui-animations', {
              templateUrl: 'uiElements/animations/animations.html',
              controller: 'animationsCtrl'
          })
          .when('/ui-buttons', {
              templateUrl: 'uiElements/Buttons/buttons.html',
              controller: 'buttonsCtrl'
          })
          .when('/ui-components', {
              templateUrl: 'uiElements/components/components.html',
              controller: 'componentsCtrl'
          })
          .when('/ui-helperClasses', {
              templateUrl: 'uiElements/helperClasses/helperClasses.html',
              controller: 'helperClassesCtrl'
          })
          .when('/ui-icons', {
              templateUrl: 'uiElements/icons/icons.html',
              controller: 'iconsCtrl'
          })
          .when('/ui-modals', {
              templateUrl: 'uiElements/modals/modals.html',
              controller: 'modalsCtrl'
          })
          .when('/ui-nestableList', {
              templateUrl: 'uiElements/nestableList/nestableList.html',
              controller: 'nestableListCtrl'
          })
          .when('/ui-notifications', {
              templateUrl: 'uiElements/notifications/notifications.html',
              controller: 'notificationsCtrl'
          })
          .when('/ui-portlets', {
              templateUrl: 'uiElements/portlets/portlets.html',
              controller: 'portletsCtrl'
          })
          .when('/ui-tabs', {
              templateUrl: 'uiElements/Tabs/tabs.html',
              controller: 'tabsCtrl'
          })
          .when('/ui-treeView', {
              templateUrl: 'uiElements/treeView/treeView.html',
              controller: 'treeViewCtrl'
          })
          .when('/ui-typography', {
              templateUrl: 'uiElements/typography/typography.html',
              controller: 'typographyCtrl'
          })
          .when('/email-templates', {
              templateUrl: 'mailbox/mailbox-templates.html',
              controller: 'mailboxTemplatesCtrl'
          })
            .when('/forms-elements', {
                templateUrl: 'forms/elements/elements.html',
                controller: 'elementsCtrl'
            })
               .when('/forms-validation', {
                   templateUrl: 'forms/validation/validation.html',
                   controller: 'elementsCtrl'
               })
              .when('/forms-plugins', {
                  templateUrl: 'forms/plugins/plugins.html',
                  controller: 'pluginsCtrl'
              })
            .when('/forms-wizard', {
                templateUrl: 'forms/wizard/wizard.html',
                controller: 'wizardCtrl'
            })
            .when('/forms-sliders', {
                templateUrl: 'forms/sliders/sliders.html',
                controller: 'slidersCtrl'
            })
            .when('/forms-editors', {
                templateUrl: 'forms/editors/editors.html',
                controller: 'editorsCtrl'
            })
              .when('/forms-input-masks', {
                  templateUrl: 'forms/inputMasks/inputMasks.html',
                  controller: 'inputMasksCtrl'
              })
  
             //medias
          .when('/medias-croping', {
              templateUrl: 'medias/croping/croping.html',
              controller: 'cropingCtrl'
          })
          .when('/medias-hover', {
              templateUrl: 'medias/hover/hover.html',
              controller: 'hoverCtrl'
          })
          .when('/medias-sortable', {
              templateUrl: 'medias/sortable/sortable.html',
              controller: 'sortableCtrl'
          })
            //pages
          .when('/pages-blank', {
              templateUrl: 'pages/blank/blank.html',
              controller: 'blankCtrl'
          })
          .when('/pages-contact', {
              templateUrl: 'pages/contact/contact.html',
              controller: 'contactCtrl'
          })
          .when('/pages-timeline', {
              templateUrl: 'pages/timeline/timeline.html',
              controller: 'timelineCtrl'
          })
               //ecommerce
          .when('/ecom-cart', {
              templateUrl: 'ecommerce/cart/cart.html',
              controller: 'cartCtrl'
          })
          .when('/ecom-invoice', {
              templateUrl: 'ecommerce/invoice/invoice.html',
              controller: 'invoiceCtrl'
          })
          .when('/ecom-pricingTable', {
              templateUrl: 'ecommerce/pricingTable/pricingTable.html',
              controller: 'pricingTableCtrl'
          })
            //extra
          .when('/extra-fullCalendar', {
              templateUrl: 'extra/fullCalendar/fullCalendar.html',
              controller: 'fullCalendarCtrl'
          })
          .when('/extra-google', {
              templateUrl: 'extra/google/google.html',
              controller: 'googleCtrl'
          })
          .when('/extra-slider', {
              templateUrl: 'extra/slider/slider.html',
              controller: 'sliderCtrl'
          })
          .when('/extra-vector', {
              templateUrl: 'extra/vector/vector.html',
              controller: 'vectorCtrl'
          })
          .when('/extra-widgets', {
              templateUrl: 'extra/widgets/widgets.html',
              controller: 'widgetsCtrl'
          })
            //tables
          .when('/tables-dynamic', {
              templateUrl: 'tables/dynamic/dynamic.html',
              controller: 'dynamicCtrl'
          })
          .when('/tables-editable', {
              templateUrl: 'tables/editable/editable.html',
              controller: 'editableCtrl'
          })
          .when('/tables-filter', {
              templateUrl: 'tables/filter/filter.html',
              controller: 'filterCtrl'
          })
          .when('/tables-styling', {
              templateUrl: 'tables/styling/styling.html',
              controller: 'stylingCtrl'
          })
            //user
          .when('/user-profile', {
              templateUrl: 'user/profile/profile.html',
              controller: 'profileCtrl'
          })
          .when('/user-sessionTimeout', {
              templateUrl: 'user/sessionTimeout/sessionTimeout.html',
              controller: 'sessionTimeoutCtrl'
          })
            //layout
          .when('/layout-api', {
              templateUrl: 'layout/api.html',
              controller: 'apiCtrl'
          })
          .otherwise({
              redirectTo: '/'
          });
    }
  );
