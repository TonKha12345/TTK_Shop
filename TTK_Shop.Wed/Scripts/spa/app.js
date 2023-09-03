/// <reference path="../plugins/angular/ajax.googleapis.com_ajax_libs_angularjs_1.8.2_angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller('schoolController', schoolController);
myApp.service('Validator', Validator);
//myApp.controller('studentController', studentController);
//myApp.controller('teacherController', teacherController);
//DECLARE
schoolController.$inject = ['$scope','Validator']
function schoolController($scope ,Validator) {
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber($scope.num);
    }

    $scope.num = 1;
}

//function studentController($scope) {
//    $scope.message = "This is my message from student";
//}

//function teacherController($scope) {
//    $scope.message = "This is my message from teacher";
//}


function Validator() {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'This is even';
        }
        else {
            return 'This is odd';
        }
    }
}