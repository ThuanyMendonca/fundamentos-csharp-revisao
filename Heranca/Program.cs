
using Heranca;

var pessoaFisica = new PessoaFisica();
pessoaFisica.Id = 1;
pessoaFisica.Cpf = "1234567890";
pessoaFisica.Endereco = "Rua dos bobos";
pessoaFisica.Cidade = "Cidade Nova";
pessoaFisica.Cep = "08989097";

pessoaFisica.ImprimirDados();
pessoaFisica.ImprimirCpf();

var funcionario = new Funcionario();
funcionario.Id = 2;
funcionario.Cpf = "1234567890";
funcionario.Endereco = "Rua dos funcionarios";
funcionario.Cidade = "São Paulo";
funcionario.Cep = "123456781";
funcionario.ImprimirDados();
funcionario.ImprimirCpf();