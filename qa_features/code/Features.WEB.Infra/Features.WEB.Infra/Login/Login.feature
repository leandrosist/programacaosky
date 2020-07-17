Funcionalidade: Validar Login
	

	Cenário: SINACOR-0001 - Acessar Sinacor com credenciais validas e empresa valida
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "adm", senha "sinacor" e empresa "CORRETORA26A"
	Então o botão favorito do menu principal deve existir

	Cenário: SINACOR-0002 - Acessar Sinacor com credenciais invalidas
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "usuarioIncorreto" e senha "senhaIncorreta"
	Então o login não deve ser realizado

	Cenário: Sinacor-0003 - Acessar Sinacor com usuario vazio
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "" e senha "senhaIncorreta"
	Então o login não deve ser realizado

	Cenário: Sinacor-0004 - Acessar Sinacor com senha vazia
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "adm" e senha ""
	Então o login não deve ser realizado

	Cenário: Sinacor-0005 - Acessar Sinacor com usuario e senha vazia
	Dado eu acesse a página "http://cldsn00353d.internalenv.corp:25153//login" e faça login com o usuário "" e senha ""
	Então o login não deve ser realizado