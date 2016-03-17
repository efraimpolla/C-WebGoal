Para executar local:

Baixar a solução e abrir em um visual studio 2015.

Procurar o projeto de nome Agenda.Web, com o botão direito setar como projeto inicial.

Compilar o projeto para o Nuget fazer o download das dependencias.

Em Tools> Nuget Package Manager > Package manager console.

Na janela que abrir escolher em Default project Agenda.EntityFramework.

Caso deseje mudar o banco de dados ir no arquivo Web.config da raiz do projeto Agenda.Web e editar a string de conexão.

Executar o comando update-database.

Executar o projeto.

Logar usando como usuario admin e senha 123qwe.

Clicar no menu agenda.

nNo primeiro campo digitar a quantidade de números que será inserido na agenda.

No segundo campo inserir os números de telefone separados por virgulas, não usar caracteres não numéricos.

Clicar no botão calcular.
