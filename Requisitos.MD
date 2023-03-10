## Requisitos Funcionais e Não funcionais

Requisito | Descrição
------------ | -------------
RF | O sistema deve conter uma página de login com sessão de usuáriol
RF | Cada usuário deve ter seu acesso restrito de acordo com o seu perfil de usuário 
RF | O sistema deve ser capaz de `emitir uma nota fiscal`
RF | O sistema deve ser capaz de obter o resultado de uma emissão de NF assim como cancelar e buscar NFs
RF | O sistema deve gerar dashboards para gestão das NFS
RF | O sistema deve buscar NFS de acordo com o cliente e/ou serviços 
RF | O sistema deve possuir um CRUD de serviços, categorias, usuários e clientes
RNF | As senhas devem ser criptografadas de modo que nem os desenvolvedores consigam decifrar
RNF | Deverá ser criada uma sessão que irá gerar uma instância do usuário
RNF | Deverá ser utilizado o banco de dados MySQL na versão >8 como serviço de banco de dados
RNF | Deverá ser utilizado a API fornecida pela Senior para fazer a manipulação de NFS
RNF-Sistema | Enxugar o máximo possível as configurações e variáveis de memória desnecessárias ao sistema
RNF-Sistema | Obter um sistema com o melhor desempenho possível, utilizando cache quando necessário
RNF-Sistema | Realizar o tratamento geral de exceções, para evitar gargalos
RNF-Sistema | Obter logs específicos das informações e erros de acordo com sua natureza em um arquivo *.txt*
RNF-Sistema | Garantir a não ocorrência de problemas de multithreading como deadlocks e starvations
RNF-Sistema | Utilizar perfis de usuários nas configurações do projeto para os diferentes desenvolvedores deste sistema de acordo com seu ambiente
RNF-Sistema | Realizar a migração da base de dados, schema, tableas e colunas para a versão mais atual dos dados, toda vez que o projeto for executado
