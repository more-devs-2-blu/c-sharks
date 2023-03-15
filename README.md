# C-Sharks - Projeto Hackathon +Devs2Blu

<div align="center">
  <img width="250px" src="https://i.imgur.com/wVYsLd0.png" />
</div>

O objetivo do nosso projeto é criar uma solução que facilite a emissão e digitação de Notas Fiscais Eletrônicas (NFS-e).
Para isso, desenvolvemos um Sistema Web primáriamente em .NET MVC com cadastro de empresas, sessão de usuário, cadastros de ISQNs e emissão de nota fiscal pelo próprio sistema, além de uma API em Spring Boot para consumo de dados.

<br>
<hr>
## Tecnologias utilizadas
<br>

<div align="center">
    <img width="70rem" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" />
    <img width="70rem" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dot-net/dot-net-original-wordmark.svg" />
    <img width="70rem" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg" />
    <img width="70rem" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/css3/css3-original.svg" />
    <img width="70rem" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/bootstrap/bootstrap-original.svg" />
    <img width="70rem" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/javascript/javascript-original.svg" />
    <img width="70rem" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/mysql/mysql-original-wordmark.svg" />
    <img width="70rem" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/spring/spring-original.svg" />
</div>

<br>
<hr>
##### Funcionalidades

- Criação de usuários, sessão e autorização.
- Cadastro de empresas.
- Cadastro de serviços (ISQN).
- Emissão de Notas Fiscais Eletrônicas (NFS-e)
- Visualização de notas fiscais emitidas
- API para consumo de dados

<br>
<hr>
## Equipe

- Carlos Eduardo Júnior - https://github.com/juninhocb
- Alexandre Schwanke da Costa - https://github.com/AlexSchwC
- Patrick Weber - https://github.com/patrickrweber
- Mike Martins - https://github.com/Mikemartins1222
- Nicolas - https://github.com/mattosn
- Carlos Eduardo Xavier - https://github.com/Cxavier14

<br>
<hr>
## Como rodar o projeto
<!--
1. Clone o repositório: git clone https://github.com/more-devs-2-blu/c-sharks.
2. Tenha instalado o banco de dados MySQL, o programa cria o banco de dados automaticamente.
3. Abra o projeto Spring Boot em outra IDE e rode ele também.
4. Abra o projeto no Visual Studio e rode ele.
5. Entre na rota /ExcelHandler/RegisterAllTOMs para popular o banco do Spring.
-->
<br>
<hr>
# Conclusão

Desenvolver este projeto foi um grande desafio para nós, mas estamos muito felizes com o resultado. O Hackweek realmente é um oprtunidade
muito bacana para botar todo nosso conhecimento a prova e nos desfiar, aprendendo muito no processo!

<br>
<hr>
## Documentação

- Link protótipo do Figma: https://www.figma.com/file/NvaghkPyN2IsoJzYft0tRr/Gerenciador-de-Notas-Fiscais?t=MGlrPxseEfJpZBcl-0

## Requisitos Funcionais e Não funcionais

| Requisito   | Descrição                                                                                                                                |
| ----------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| RF          | O sistema deve conter uma página de login com sessão de usuário                                                                          |
| RF          | Cada usuário deve ter seu acesso restrito de acordo com o seu perfil de usuário                                                          |
| RF          | O sistema deve ser capaz de `emitir uma nota fiscal`                                                                                     |
| RF          | O sistema deve ser capaz de obter o resultado de uma emissão de NF assim como cancelar e buscar NFs                                      |
| RF          | O sistema deve gerar dashboards para gestão das NFS                                                                                      |
| RF          | O sistema deve buscar NFS de acordo com o cliente e/ou serviços                                                                          |
| RF          | O sistema deve possuir um CRUD de serviços, categorias, usuários e clientes                                                              |
| RNF         | As senhas devem ser criptografadas de modo que nem os desenvolvedores consigam decifrar                                                  |
| RNF         | Deverá ser criada uma sessão que irá gerar uma instância do usuário                                                                      |
| RNF         | Deverá ser utilizado o banco de dados MySQL na versão >8 como serviço de banco de dados                                                  |
| RNF         | Deverá ser utilizado a API fornecida pela Senior para fazer a manipulação de NFS                                                         |
| RNF-Sistema | Enxugar o máximo possível as configurações e variáveis de memória desnecessárias ao sistema                                              |
| RNF-Sistema | Obter um sistema com o melhor desempenho possível, utilizando cache quando necessário                                                    |
| RNF-Sistema | Realizar o tratamento geral de exceções, para evitar gargalos                                                                            |
| RNF-Sistema | Obter logs específicos das informações e erros de acordo com sua natureza em um arquivo _.txt_                                           |
| RNF-Sistema | Garantir a não ocorrência de problemas de multithreading como deadlocks e starvations                                                    |
| RNF-Sistema | Utilizar perfis de usuários nas configurações do projeto para os diferentes desenvolvedores deste sistema de acordo com seu ambiente     |
| RNF-Sistema | Realizar a migração da base de dados, schema, tableas e colunas para a versão mais atual dos dados, toda vez que o projeto for executado |

<sub>outras documentações</sub>

<br>
<hr>
## Capturas de tela

##### Tela de login

##### Dashboard

##### Cadastro de empresas

##### Cadastro de serviços

##### Emissão de Notas Fiscais Eletrônicas (NFS-e)

##### API para consumo de dados
