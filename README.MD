ANTES DE TUDO:

Primeiramente agradecer pela oportunidade.
Pessoal eu fiz um MVP, portanto não tem tudo que poderia ter, me desculpem por isso, e aqui eu peço um pouco de empatia tem muitos testes que tenho que fazer.

O que não fiz:

- Embora o documento com o desenho da arquitetura tenha uma arquitetura de microserviços - para vocês saberem que eu sei. Eu desenvolvi uma arquitetura monolitica para agiizar o desenvolvimento.
- Não coloquei a aplicação em container, então por favor rodar no IISExpress
- Não fiz front, não deu tempo, mas acredito que o mais importante era a API e a arquitetura para vaga de vocês.
- Não desenvolvi testes, normalmente desenvolvo,  mas quis agilizar o desenvolvimento.
- Não utilizei um padrão de notificação e nem criei logs.
- Não fiz autenticação


O que fiz:

- Endpoint para fazer os lançamentos (assumi que apenas inclusões eram necessárias para manter o histórico dos lançamentos, e inclui um campo de observação para justificar um lançamento corrigindo outro).
- Endpoint para gerar o relatório (O agrupamento está pode tipo(débito ou crédito), moeda, e mês).
- Arquitetura DDD
- Desenho no Draw.IO (No raiz) - Arquivo: CashFlowSolution.drawio
- EntityFrameworkCore - usando MIgrations
- Injeção de dependencia
- Minimum API

Como rodar:

- Atualizar o appsettings.config (com a string de conexão
- Rodar o comando:  dotnet ef database update --project CashFlow.Repository
- Executar o Visual Studio no IISExpress
- Testar a API no SWAGGER

Pessoal, espero que considerem tudo que fiz, e agradeço a oportunidade.