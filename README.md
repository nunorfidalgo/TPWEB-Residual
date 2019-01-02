# Tema: Residual

# Alunos/Colaboradores
* [Nuno Fidalgo](https://github.com/nunorfidalgo) [21140369], email: a21140369@isec.pt
* [Nuno Sousa](https://github.com/nuno-brio) [21260812], email: a21260812@isec.pt

## Descrição
Implementação de um sistema Web para gestão de resíduos que fornece um conjunto de serviços de recolha de materiais recicláveis do tipo papel/cartão, vidro/louça, óleos alimentares, pilhas, lâmpadas, material elétrico e eletrónico, pequenos objetos de metal, objetos em plástico e a recolha de materiais poluentes do género combustíveis pesados, pneus, baterias, tintas, solventes, óleos pesados, pesticidas e outros... Para estes últimos tipos de resíduos pretende-se criar um serviço de recolha direta, tendo em consideração que a recolha de determinados materiais recicláveis é uma tarefa difícil e perigosa, que exige a existência, ou a disponibilidade, de meios adequados ao transporte.

## Trabalho Prático de Programação WEB 2018/2019 - ISEC
* Desenvolvido em Visual Studio Community Edition 2017;
* Com auxilio de: 
	- [Entity Framework Power Tools Beta 4](https://marketplace.visualstudio.com/items?itemName=EntityFrameworkTeam.EntityFrameworkPowerToolsBeta4);
	- [Entity Framework 6 Power Tools Community Edition](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EntityFramework6PowerToolsCommunityEdition);
	- [Entity Framework](https://www.nuget.org/packages/EntityFramework)
	- [IdentityUserRoleManagement ](https://www.nuget.org/packages/IdentityUserRoleManagement/);
	- [OpenStreetMaps: Leaflet Example](https://github.com/asmaloney/Leaflet_Example);

## Tarefas
- [x] Criação inicial do projeto usando o GitHub;
- [x] Criação dos modelos de dados iniciais;
	- [x] Uso de DataAnotations;
- [x] Modelos:
	- [x] Utilizador (alterado para usar com o AplicationUser);
	- [x] TipoUtilizador (enum -> alterado para usar as entity Roles);
	- [x] Recolhas;
	- [x] TiposMateriais (enum)
	- [x] Veículos;
	- [x] TiposVeiculo (enum);
	- [ ] EcoPontos;
	- [x] TiposMateriaisReciclaveis (enum);
	- [x] TipoMateriaisPoloentes (enum);
	- [x] Markers( para os marcadorse do mapa);
- [x] Abordagem de "Code First" para a criação da base de dados;
	- [x] Vamos fazer uso das ferramentas "Entity Framework Power Tools" como forma de criar a base de dados sem estarmos constantemente a adicionar migrações e a fazer updates para corrigir erros;
- [x] Instalar o Entity Framework;
	- [x] Tools->NuGet Package Manager->Manage NuGet Package Manager for Solution:
	- [x] Procurar por "EntityFramework" instalar a versão > 6.0 
- [x] Contexto da base de dados;
	- [x] Criação do contexto: Models\ResidualContext deriva do ApplicationDbContext, evitamos desta forma o uso de dois contextos de BD;
	- [x] Relação de 1-1 com o Utilizador e o AplicationUser, verificar com o uso da ferramenta Entity Framework Power Tools selecionando o ResidualContext->Entity Framework->View Entity Data Model (Read Only);
		- [x] Retiramos a relação de 1-1 com o utilizador devido a não conseguirmos definir a Foreignkey com o Id do AplicationUser;
	- [x] Alterar o nome da BD no "connectionString" em web.config;
	- [x] Remover ResidualContext de forma a ficarmos apenas com o AplicationContext;
- [x] Correção das relações das tabelas criadas;
	- [x] Validações de dados;
- [x] Activar migrações: 
	- [x] Tools->NuGet Package Manager->Package Manager Console;
	- [x] Enable-Migrations -> Enable-Migrations -ContextTypeName TPWEB_Residual.Models.ResidualContext;
	- [x] Add-Migration MigracaoInicial;
	- [x] Update-Database (Não esqueçer de selecionar a opção de "Show all files" no "Solution Explorer" e se abrir o "Server Explorer" em View->Other Windows);
- [x] Instalar e configurar o "IdentityUserRoleManagement";
	- [x] Tools->NuGet Package Manager->Manage NuGet Package Manager for Solution:
	- [x] Procurar por "IdentityUserRoleManagement" e instalar
	- [ ] Configurar IdentityUserRoleManagement;
- [ ] Inicialização de dados nas tabelas;
	- [ ] startup.cs: Adicionar a funcção de inicialização;
	- [ ] Slide 68 Teorica CodeFirst1 (para gerar um admin, operador e cidadoes na BD para testar na defesa e durant o decurso do projecto)
	- [x] Função feita, mas não está a ser possivel testar;
	- [ ] Tem de se mudar para o ficheiro Configurations.cs na pasta Migrations;
- [ ] Verificar validações de dados nos formularios (importante);
	- [x] Registo de login ja tem algumas verificações iniciais;
	- [x] Recolhas com algumas verificações;
- [x] Registo e login feito;
	- [ ] Tem de ser alterado;
	- [ ] Em falta, operadores e admins (criar uma "pasta" tipo "http:/localhost/acessos" para os acessos admin e op);
- [x] Criar os controladores e gerar as views com recurso ao "scaffolding";
	- [x] Remover Utilizadores, integrar com o ApplicationUser do modelo IdentityModels;
	- [ ] Remover TipoUtilizadores, vamos usar as Roles para lidar com os varios tipos;
	- [x] Gerar as Recolhas;
		- [x] Corrigi a duplicação dos tipos de material das Recolhas
		- [ ] Corrigi a data para mostrar a data/hora
	- [x] Gerar os Veiculos;
	- [ ] Falta informação; EcoPontos -> ler enuciado!!!!
	- [ ] Não esquecer as autorizações nas páginas;
	- [ ] Definir vistas e controladores para operações específicas;
	- [ ] Criar vistas e controladores para operações específicas;
- [ ] Extras:
	- [x] OpenStreetMaps(Leaflet)
		- [x] Colocar o mapa a funcionar;
		- [x] Mostrar mapa de Coimbra;
		- [x] Os marcadores estão a funcionar com informação nos popups;
		- [ ] Adicionar EcoPontos na zona de Coimbra;
	- [ ] Pontos Electrão
	- [ ] EcoPilhas
	- [ ] Pilhão
	- [ ] ERSUC
	- [ ] Uso de Ajax no projeto;
	- [ ] Envio de mails; host free email server ASP.NET;
	- [ ] Facebook/Google/Twitter? ver-> App_Start\Startup.Auth.cs;
	- [ ] Integração Gmaps para ver moradas;
- [ ] Embelezar o front end;
	- [x] Titulo da aplicação (titulo e footer);
	- [ ] Menus
		- [x] Adicionei: Recolhas e Veiculos
	- [ ] Cores de fundo em verde (ecologico);
	- [ ] Imagens de fundo nas várias secções;
	- [ ] Colocar os links para os extras (ver tarefa anterior [Extras]):
- [ ] Exportar o diagrama final da base de dados ao gerar o modelo ER com "Entity Framework Power Tools" e salvar como imagems para colocar no relatório e no github;
	- [ ] falar do uso desta ferramenta para o desenvolvimento do trabalho e em diminuição de fazer migrações;
	- [ ] exportar a base de dados para ficheiro .sql -> colocar no relatorio;
- [ ] Preparar a entrega do trabalho com a Base de Dados, retirar as pastas "obj", "bin", ".vs" e "Packages" do projecto;
- [ ] Colocar o projeto do GitHub publico;
  

## NOTAS:
- [ ] Como fazer logs? "logs class asp.net mvc" ("logger", "nlog") catalogando erros e gerando logs;

## Dúvidas
- [x] Criar uma class pessoas para os cidadoes/operadores/admins?
	- [x] fazer uso da Roles para os tipos de utilizador;
- [x] É obrigatorio o uso de Extensions  mais expeficicamente "Sessions"; Não.