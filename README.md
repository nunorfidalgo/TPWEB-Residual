# Tema: Residual

## Trabalho Prático de Programação WEB 2018/2019 - ISEC
* Desenvolvido em Visual Studio 2017;
* Com auxilio de: 
	- [Entity Framework Power Tools Beta 4](https://marketplace.visualstudio.com/items?itemName=EntityFrameworkTeam.EntityFrameworkPowerToolsBeta4);
	- [Entity Framework 6 Power Tools Community Edition](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EntityFramework6PowerToolsCommunityEdition);
	- [IdentityUserRoleManagement ](https://www.nuget.org/packages/IdentityUserRoleManagement/);

## Descrição
Implementação de um sistema Web para gestão de resíduos que fornece um conjunto de serviços de recolha de
materiais recicláveis do tipo papel/cartão, vidro/louça, óleos alimentares, pilhas, lâmpadas, material elétrico e eletrónico, pequenos
objetos de metal, objetos em plástico e a recolha de materiais poluentes do genero combustíveis pesados, pneus,
baterias, tintas, solventes, óleos pesados, pesticidas, outros...
Para os últimos tipos de residuos pretende-se criar um serviço de recolha direta, tendo em consideração que a recolha de determinados materiais 
recicláveis é uma tarefa difícil e perigosa, que exige a existência, ou a disponibilidade, de meios adequados de transporte.

## Tarefas
- [x] Criação inicial do projeto usando o GitHub;
- [x] Criação dos modelos de dados iniciais;
	- [x] Uso de DataAnotations;
- [x] Abordagem de "Code First" para a criação da base de dados;
- [x] Instalar o Entity Framework;
	- [x] Tools->NuGet Package Manager->Manage NuGet Package Manager for Solution:
	- [x] Procurar por "EntityFramework" instalar a versão > 6.0 
- [x] Contexto da base de dados;
	- [x] Criação do contexto: Models\ResidualContext deriva do ApplicationDbContext, evitamos desta forma o uso de dois contextos de BD;
	- [ ] Relação de 1-1 com o Utilizador e o AplicationUser, verificar com o uso da ferramenta Entity Framework Power Tools selecionando o ResidualContext->Entity Framework->View Entity Data Model (Read Only);
- [ ] Correção das relações das tabelas criadas;
	- [ ] Validações de dados;
- [ ] Activar migrações: 
	- [ ] Tools->NuGet Package Manager->Package Manager Console:
	- [ ] Enable-Migrations
	- [ ] Add-Migation <nome da migração>
	- [ ] Update-Database
- [ ] instalar e configurar o "IdentityUserRoleManagement";
	- [ ] Tools->NuGet Package Manager->Manage NuGet Package Manager for Solution:
	- [ ]  Procurar por "IdentityUserRoleManagement" e instalar
- [ ] startup.cs: Inserir dados SQL;
	- [ ] Averiguar se com a Fluent API é possivel inserir os dados ver slide 76 
- [ ] Validações de dados nos formularios!!!!!!!!!!!!!!!!
- [ ] Uso de Extensions "Sessions";
- [ ] Como fazer log?;
- [ ] Criar os controladores e gerar as views com recurso ao "scaffolding";
- [ ] Uso de Ajax no projeto;
- [ ] Envio de mails
- [ ] Facebook/Google/Twitter? ver-> App_Start\Startup.Auth.cs
- [ ] Embelezar o front end