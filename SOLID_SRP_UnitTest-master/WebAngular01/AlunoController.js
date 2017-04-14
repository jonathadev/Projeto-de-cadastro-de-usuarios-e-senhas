angular.module("app")
    .controller("AlunoController",
        function ($scope, $http) {
            $http.get("http://adasdasdadsadsasd.pe.hu/Api/aluno.json")
                .success(function (data) {
                    $scope.retorno = data;
                });

            $scope.iniciado = true;

            $scope.alunos = ['Aluno 1', 'Aluno 2', 'Aluno 3', 'Aluno 4'];

            $scope.finalizar = function () {
                $scope.iniciado = false;
            };

            $scope.iniciar = function () {
                $scope.iniciado = true;
            };
        });