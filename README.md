# BookOrderer

O Projeto está em .NET 6 e usa XUnit. Para rodar, é preciso ter as ferramentas necessárias. Como Visual Studio 19 e as dependencias necessárias.
Os testes podem ser executados independentes da solution estar em execução.

Separei a solução em camadas simples de Presentation, Application, Domain e  Test.
A camada de Presentation contém uma forma de testar a solução de forma manual e interativa pelo console (algo simples).
A camada de Application contém a Interface e Implementação da lógica da solução (SortBookService).
A Domain contém a classe Book que é usada pelas outras camadas.
E a camada de Testes, usando XUnite para validação da implementação da lógica da solução, passando os parâmetros propostos no arquivo de caso de teste.

