#language: pt-br

Funcionalidade: Validar preferências de grid

Contexto: CT00 Estar logado no SinacorWEB
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "adm", senha "sinacor" e empresa "CORRETORA26A"
	Então o botão favorito do menu principal deve existir
	Dado eu estou na tela de notificações

	@SINACOR-28038
	Esquema do Cenário: SINACOR-28038 - Validar a visualização das colunas e ordenação no grid
	Dado eu clicar em Column Chooser e escolher as colunas para exibição <numero>, <datahoracriacao>, <titulo>, <descricao>, <usuariocriador>, <tiponotificacao>, <historico> 
	Então apresentará no grid as colunas selecionadas <numero>, <datahoracriacao>, <titulo>, <descricao>, <usuariocriador>, <tiponotificacao>, <historico>
	Dado eu fizer a ordenação no grid das colunas selecionadas <ordemnumero>, <ordemdatahoracriacao>, <ordemtitulo>, <ordemdescricao>, <ordemusuariocriador>, <ordemtiponotificacao>, <ordemhistorico>
	Então as colunas do grid permanecem na ordenação escolhida pelo usuário <ordemnumero>, <ordemdatahoracriacao>, <ordemtitulo>, <ordemdescricao>, <ordemusuariocriador>, <ordemtiponotificacao>, <ordemhistorico>
	Dado eu irei fazer logoff no Sinacor Web
	Então deverá efetuar logoff e voltar para a página de login do Sinacor Web
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "adm", senha "sinacor" e empresa "CORRETORA26A"
	Então o botão favorito do menu principal deve existir
	Dado eu estou na tela de notificações
	Então a visualização do grid deve apresentar as mesmas colunas selecionadas e a ordenação escolhida pelo usuario <numero>, <datahoracriacao>, <titulo>, <descricao>, <usuariocriador>, <tiponotificacao>, <historico>, <ordemnumero>, <ordemdatahoracriacao>, <ordemtitulo>, <ordemdescricao>, <ordemusuariocriador>, <ordemtiponotificacao>, <ordemhistorico>

	Exemplos: 
	| numero | datahoracriacao | titulo | descricao | usuariocriador | tiponotificacao | historico | ordemnumero | ordemdatahoracriacao | ordemtitulo | ordemdescricao | ordemusuariocriador | ordemtiponotificacao | ordemhistorico | 
	|s       |n                |s       |s          |n               |n                |n          |1            |                      |3            |2               |                     |                      |                |
	
	@SINACOR-28050
	Esquema do Cenário: SINACOR-28050 - Validar a visualização do grid com paginação
	Dado eu adicione "50" notificações com código da corretora "261"	
	Dado eu irei fazer logoff no Sinacor Web
	Então deverá efetuar logoff e voltar para a página de login do Sinacor Web
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "adm", senha "sinacor" e empresa "CORRETORA26A"
	Então o botão favorito do menu principal deve existir
	Dado eu estou na tela de notificações
	Dado eu clicar em Column Chooser e escolher as colunas para exibição <numero>, <datahoracriacao>, <titulo>, <descricao>, <usuariocriador>, <tiponotificacao>, <historico> 
	Então apresentará no grid as colunas selecionadas <numero>, <datahoracriacao>, <titulo>, <descricao>, <usuariocriador>, <tiponotificacao>, <historico>
	Dado eu fizer a ordenação no grid das colunas selecionadas <ordemnumero>, <ordemdatahoracriacao>, <ordemtitulo>, <ordemdescricao>, <ordemusuariocriador>, <ordemtiponotificacao>, <ordemhistorico>
	Então as colunas do grid permanecem na ordenação escolhida pelo usuário <ordemnumero>, <ordemdatahoracriacao>, <ordemtitulo>, <ordemdescricao>, <ordemusuariocriador>, <ordemtiponotificacao>, <ordemhistorico>
	Dado eu alterar a quantidade para aumentar a quantidade de registros e alterar a paginação para a visualização no grid <tamanhopagina>, <paginacao>
	Dado eu irei fazer logoff no Sinacor Web
	Então deverá efetuar logoff e voltar para a página de login do Sinacor Web
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "adm", senha "sinacor" e empresa "CORRETORA26A"
	Então o botão favorito do menu principal deve existir
	Dado eu estou na tela de notificações
	Então a visualização da quantidade de registros e paginação do grid com as mesmas informações efetuadas pelo usuário <tamanhopagina>, <paginacao>, <numeroregistrogrid>, <quantidaderegistropagina>
	Dado eu irei deletar os registros notificações

	Exemplos: 
	| numero | datahoracriacao | titulo | descricao | usuariocriador | tiponotificacao | historico | ordemnumero | ordemdatahoracriacao | ordemtitulo | ordemdescricao | ordemusuariocriador | ordemtiponotificacao | ordemhistorico | tamanhopagina | paginacao | numeroregistrogrid | quantidaderegistropagina |
	| s      | n               | s      | s         | n              | n               | n         | 1           |                      | 3           | 2              |                     |                      |                | 20            | 2         | 20641542           | Página 2 de 3 (50 itens) |

	@SINACOR-28118
	Esquema do Cenário: SINACOR-28118 - Validar a visualização das colunas e ordenação no grdi com preferências de usuários diferentes
	Dado eu clicar em Column Chooser e escolher as colunas para exibição <numero>, <datahoracriacao>, <titulo>, <descricao>, <usuariocriador>, <tiponotificacao>, <historico> 
	Então apresentará no grid as colunas selecionadas <numero>, <datahoracriacao>, <titulo>, <descricao>, <usuariocriador>, <tiponotificacao>, <historico>
	Dado eu fizer a ordenação no grid das colunas selecionadas <ordemnumero>, <ordemdatahoracriacao>, <ordemtitulo>, <ordemdescricao>, <ordemusuariocriador>, <ordemtiponotificacao>, <ordemhistorico>
	Então as colunas do grid permanecem na ordenação escolhida pelo usuário <ordemnumero>, <ordemdatahoracriacao>, <ordemtitulo>, <ordemdescricao>, <ordemusuariocriador>, <ordemtiponotificacao>, <ordemhistorico>
	Dado eu irei fazer logoff no Sinacor Web
	Então deverá efetuar logoff e voltar para a página de login do Sinacor Web
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "adm", senha "sinacor" e empresa "CORRETORA26A"
	Então o botão favorito do menu principal deve existir
	Dado eu estou na tela de notificações
	Então validar as preferências do usuário adm de colunas e ordenação no grid <numero>, <datahoracriacao>, <titulo>, <descricao>, <usuariocriador>, <tiponotificacao>, <historico>, <ordemnumero>, <ordemdatahoracriacao>, <ordemtitulo>, <ordemdescricao>, <ordemusuariocriador>, <ordemtiponotificacao>, <ordemhistorico>
	Dado eu irei fazer logoff no Sinacor Web
	Então deverá efetuar logoff e voltar para a página de login do Sinacor Web
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "qaautomacao", senha "12345678" e empresa "CORRETORA26A"
	Então o botão favorito do menu principal deve existir
	Dado eu estou na tela de notificações
	Então a visualização do grid deve apresentar diferentes preferencias das colunas selecionadas e a ordenação escolhida pelo usuario adm em relação ao usuário qaautomacao <numero>, <datahoracriacao>, <titulo>, <descricao>, <usuariocriador>, <tiponotificacao>, <historico>, <ordemnumero>, <ordemdatahoracriacao>, <ordemtitulo>, <ordemdescricao>, <ordemusuariocriador>, <ordemtiponotificacao>, <ordemhistorico>
	Dado eu irei fazer logoff no Sinacor Web
	Então deverá efetuar logoff e voltar para a página de login do Sinacor Web
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "adm", senha "sinacor" e empresa "CORRETORA26A"
	Então o botão favorito do menu principal deve existir
	Dado eu estou na tela de notificações
	Dado retornar preferencias usuario adm

	Exemplos: 
	| numero | datahoracriacao | titulo | descricao | usuariocriador | tiponotificacao | historico | ordemnumero | ordemdatahoracriacao | ordemtitulo | ordemdescricao | ordemusuariocriador | ordemtiponotificacao | ordemhistorico | 
	|s       |n                |s       |s          |n               |n                |n          |1            |                      |3            |2               |                     |                      |                |
	