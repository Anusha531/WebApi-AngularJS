app.controller('APIController', function ($scope, APIService) {
    getAllCourses();

    function getAllCourses() {
        var servCall = APIService.getCourses();
        servCall.then(function (d) {
            $scope.courses = d.data;
        }, function (error) {
            $log.error('Oops! Something went wrong while fetching the data.');
        });
    }

    $scope.saveCourses = function () {
        var item = {
            Title: $scope.Title,
            Credits: $scope.Credits
        };
        var saveItem = APIService.saveCourses(item);
        saveItem.then(function (d) {
            getAllCourses();
        }, function (error) {
            console.log('Oops! Something went wrong while saving the data.');
        });
    };
}); 