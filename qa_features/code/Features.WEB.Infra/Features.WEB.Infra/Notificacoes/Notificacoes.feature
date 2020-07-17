Funcionalidade: Validar tela de notificações

Contexto: CT00 Estar logado no SinacorWEB
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "adm", senha "sinacor" e empresa "CORRETORA26A"
	Então o botão favorito do menu principal deve existir
	Dado eu estou na tela de notificações
	

	Cenário: SINACOR-15572 - Validar que está sendo permitido selecionar notificações
	Então a a seleção de notificações está presente

	Cenário: SINACOR-XXXX - Marcar notificação como lida
	Então marco uma notificação como lida
	Então um alerta contendo o texto "Deseja realmente marcar a(s) notificação(ções) selecionada(s)?" deve existir
	Então aceitar o alerta

	Cenário: SINACOR-15580 - Realizar a exportação de notificações 
	Quando realizo a exportação de uma notificação
	Então download dos dados de notificação é realizado