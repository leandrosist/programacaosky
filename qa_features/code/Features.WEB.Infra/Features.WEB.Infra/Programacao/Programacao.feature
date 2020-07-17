Funcionalidade: Validar tela de programação SKY

Contexto: CT00 Estar na pagina da SKY
	Dado eu acesse a página "https://www.sky.com.br/" e feche o popup
	Então o logo da "SKY" deve existir
	
	Cenário: Validar texto e a hora que aparecem na programação é o mesmo que aparecem no modal
	Dado eu clico no link programação e clico na programação
	Então o texto e a hora que aparecem na programação devem ser os mesmos que aparecem no modal
