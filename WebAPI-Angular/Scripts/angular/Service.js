app.service("APIService", function ($http) {

    this.getCourses = function () {
        return $http.get("api/Courses");
    };

    this.saveCourses = function (item) {
        return $http(
            {
                method: 'post',
                data: item,
                url: 'api/Courses'
            });
    };
}); 