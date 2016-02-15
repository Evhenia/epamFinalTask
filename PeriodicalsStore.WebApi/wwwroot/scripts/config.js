// This is ui router. You can read more here: https://github.com/angular-ui/ui-router
// PS. Almost all docs about angular are situated on the github.
app.config(function ($stateProvider, $urlRouterProvider, $locationProvider) {

    $urlRouterProvider.otherwise("/view1");
    // Uncoment it to have urls without #. Exapmple: http://localhost:4597/#/view1 and http://localhost:4597/view1
    $locationProvider.html5Mode(true);
    
    $stateProvider
        .state('view1', {
            url: "/view1",
            templateUrl: "/wwwroot/views/view1.html",
            controller: "controller1Ctrl"
        })
        .state('view2', {
            url: "/view2",
            templateUrl: "/wwwroot/views/view2.html",
            controller: "controller2Ctrl"
        });
});
