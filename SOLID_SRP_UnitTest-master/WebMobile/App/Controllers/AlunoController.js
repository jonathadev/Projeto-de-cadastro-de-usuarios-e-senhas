angular.module("app")
    .controller("AlunoController",
        function ($scope, $http) {
            $http.get("http://localhost:49621/api/aluno")
                .success(function (data) {
                    $scope.retorno = data;
                });

            $scope.hoje = new Date();

            $scope.iniciado = true; 


            $scope.finalizar = function () {
                $scope.iniciado = false;
            };

            $scope.iniciar = function () {
                $scope.iniciado = true;
            };


            $scope.ordenarPorId = function () {
                $scope.ordenadoPorId = !$scope.ordenadoPorId;
                $scope.retorno = $filter('orderBy')($scope.retorno, 'id', $scope.ordenadoPorId);
            }

            $scope.ordenarPorNome = function () {
                $scope.ordenadoPorNome = !$scope.ordenadoPorNome;
                $scope.retorno = $filter('orderBy')($scope.retorno, 'nome', $scope.ordenadoPorNome);
            }

            $scope.ordenarPorEmail = function () {
                $scope.ordenadoPorEmail = !$scope.ordenadoPorEmail;
                $scope.retorno = $filter('orderBy')($scope.retorno, 'Email', $scope.ordenadoPorEmail);
            }

            $scope.ordenarPorDataNascimento = function () {
                $scope.ordenadoPorDataNascimento = !$scope.ordenadoPorDataNascimento;
                $scope.retorno = $filter('orderBy')($scope.retorno, 'DataNascimento', $scope.ordenadoPorDataNascimento);
            }


            $scope.ordenarPorRa = function () {
                $scope.ordenadoPorRa = !$scope.ordenadoPorRa;
                $scope.retorno = $filter('orderBy')($scope.retorno, 'Ra', $scope.ordenadoPorRa);
            }

            $scope.ordenarPorCpf = function () {
                $scope.ordenadoPorCpf = !$scope.ordenadoPorCpf;
                $scope.retorno = $filter('orderBy')($scope.retorno, 'Cpf', $scope.ordenadoPorCpf);
            }
         
        });