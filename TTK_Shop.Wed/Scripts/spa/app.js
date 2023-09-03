/// <reference path="../plugins/angular/ajax.googleapis.com_ajax_libs_angularjs_1.8.2_angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller('schoolController', schoolController);
myApp.controller('studentController', studentController);
myApp.controller('teacherController', teacherController);
//DECLARE

function schoolController($scope) {
    $scope.message = "This is my message from school";
}

function studentController($scope) {
    $scope.message = "This is my message from student";
}

function teacherController($scope) {
    $scope.message = "This is my message from teacher";
}