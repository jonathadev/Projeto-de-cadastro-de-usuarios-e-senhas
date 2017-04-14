angular.module("app")
    .controller("AlunoController",
        function ($scope, $http, $filter) {
            $http.get("http://localhost:49621/api/aluno")
                .success(function (data) {
                    $scope.retorno = data;
                });


            // var aluno = {
            //  "id": 1,
            //   "nome": "Asdrubal123",
            //   "email": "teste1@teste.com",
            //    "dataNascimento": "1998-01-05T00:00:00Z",
            //    "ra": 123456,
            //  "cpf": "12345678901"
            //  }

            $scope.InsertAluno = function (aluno) {
                $http.post("http://localhost:49621/api/aluno", aluno);
                //.success(function (data) {
                //  $scope.retorno = data;
                //console.log(data);
                //  });
            }

            /*  $scope.DELETAR = function () {
                  $http({
                      method: 'DELETE',
                      url: "http://localhost:49621/api/aluno",
                      data: {
                          user: 1
                      },
                      headers: {
                          'Content-type': 'application/json;charset=utf-8'
                      }
                  })
              .then(function (response) {
                  console.log(response.data);
              }, function (rejection) {
                  console.log(rejection.data);
              });
              }
              */

            $scope.DELETAR = function (aluno) {
                $http.delete("http://localhost:49621/api/aluno/" + aluno.id);
            }

            $scope.ALTERAR = function (aluno) {
                $http.put("http://localhost:49621/api/aluno/" + aluno.id, aluno);
            }




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