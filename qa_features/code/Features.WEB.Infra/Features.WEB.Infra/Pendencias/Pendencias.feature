Funcionalidade: Validar tela de pendencias

Contexto: CT00 Estar logado no SinacorWEB
	Dado eu acesse a página "http://cldsn00248d:25153/login" e faça login com o usuário "adm", senha "sinacor" e empresa "CORR25A"
	Então o botão favorito do menu principal deve existir
	
	Cenário: SINACOR-6081 - Consultar top 5 de Pendências
	Então o grid top5 pendencias deve ser exibido

	Cenário: SINACOR-6145 - Consultar Pendências
	Dado eu estou na tela de pendências
	Então a tabela de pendências deve possuir linhas

	Cenário: SINACOR-6623 - Consultar Total de Pendências
	Então o botão pendencias deve existir contendo o total de pendencias

	Cenário: SINACOR-6720 - Exibir nome da empresa no breadcrumb
	Dado eu estou na tela de pendências
	Então Empresa selecionada é exibida no breadcrumb

	Cenário: SINACOR-XXXX -  Confirmar a resolução da pendencia
	Dado eu estou na tela de pendências
	Quando eu pesquisar e resolver a pendência "52986920" com a observação "Resolvido!"
	Então aceitar um alerta contendo o texto "Deseja realmente resolver a(s) pendência(s) selecionada(s)?"
	Então aceitar um alerta contendo o texto "Pendências resolvida com sucesso!"
	E a pendência "52986920" não deve estar presente na tabela de pendências
	
#	| ola | ola2 | campo1 |
#	| a   | b    | c      |

	Cenário: SINACOR-XXXX -  Não confirmar a resolução da pendencia
	Dado eu adicione "1" pendencias do módulo "BMF" com código da corretora "20" e função de acesso "EXPA"
	Dado eu estou na tela de pendências
	Quando eu pesquisar e clicar sobre a pendência "52986919"
	E eu clicar no botão de resolver pendência
	Então cancelar um alerta contendo o texto "Deseja realmente resolver a(s) pendência(s) selecionada(s)?"
	E a pendência "52986920" deve estar presente na tabela de pendências