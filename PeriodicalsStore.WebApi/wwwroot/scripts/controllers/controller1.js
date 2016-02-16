function controller1($scope, testApi) {
    $scope.testHello = "Hello from controller1";
    $scope.collection = null;
    $scope.getSomeData = function() {
        testApi.load().then(function (data) {
            $scope.collection = data.plain();
            console.log($scope.collection);

        }, function(error) {
            console.log(error);
        });
    }
    $scope.getSomeData();
};

app.controller('controller1Ctrl', controller1);