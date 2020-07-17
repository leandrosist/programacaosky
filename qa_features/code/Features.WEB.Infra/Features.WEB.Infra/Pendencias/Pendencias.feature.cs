// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Features.WEB.Infra.Pendencias
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Validar tela de pendencias")]
    public partial class ValidarTelaDePendenciasFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Pendencias.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Validar tela de pendencias", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("eu acesse a página \"http://cldsn00248d:25153/login\" e faça login com o usuário \"a" +
                    "dm\", senha \"sinacor\" e empresa \"CORR25A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 5
 testRunner.Then("o botão favorito do menu principal deve existir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-6081 - Consultar top 5 de Pendências")]
        public virtual void SINACOR_6081_ConsultarTop5DePendencias()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-6081 - Consultar top 5 de Pendências", null, ((string[])(null)));
#line 7
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 8
 testRunner.Then("o grid top5 pendencias deve ser exibido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-6145 - Consultar Pendências")]
        public virtual void SINACOR_6145_ConsultarPendencias()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-6145 - Consultar Pendências", null, ((string[])(null)));
#line 10
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 11
 testRunner.Given("eu estou na tela de pendências", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 12
 testRunner.Then("a tabela de pendências deve possuir linhas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-6623 - Consultar Total de Pendências")]
        public virtual void SINACOR_6623_ConsultarTotalDePendencias()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-6623 - Consultar Total de Pendências", null, ((string[])(null)));
#line 14
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 15
 testRunner.Then("o botão pendencias deve existir contendo o total de pendencias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-6720 - Exibir nome da empresa no breadcrumb")]
        public virtual void SINACOR_6720_ExibirNomeDaEmpresaNoBreadcrumb()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-6720 - Exibir nome da empresa no breadcrumb", null, ((string[])(null)));
#line 17
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 18
 testRunner.Given("eu estou na tela de pendências", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 19
 testRunner.Then("Empresa selecionada é exibida no breadcrumb", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-XXXX -  Confirmar a resolução da pendencia")]
        public virtual void SINACOR_XXXX_ConfirmarAResolucaoDaPendencia()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-XXXX -  Confirmar a resolução da pendencia", null, ((string[])(null)));
#line 21
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 22
 testRunner.Given("eu estou na tela de pendências", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 23
 testRunner.When("eu pesquisar e resolver a pendência \"52986920\" com a observação \"Resolvido!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 24
 testRunner.Then("aceitar um alerta contendo o texto \"Deseja realmente resolver a(s) pendência(s) s" +
                    "elecionada(s)?\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 25
 testRunner.Then("aceitar um alerta contendo o texto \"Pendências resolvida com sucesso!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 26
 testRunner.And("a pendência \"52986920\" não deve estar presente na tabela de pendências", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-XXXX -  Não confirmar a resolução da pendencia")]
        public virtual void SINACOR_XXXX_NaoConfirmarAResolucaoDaPendencia()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-XXXX -  Não confirmar a resolução da pendencia", null, ((string[])(null)));
#line 31
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 32
 testRunner.Given("eu adicione \"1\" pendencias do módulo \"BMF\" com código da corretora \"20\" e função " +
                    "de acesso \"EXPA\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 33
 testRunner.Given("eu estou na tela de pendências", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 34
 testRunner.When("eu pesquisar e clicar sobre a pendência \"52986919\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 35
 testRunner.And("eu clicar no botão de resolver pendência", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 36
 testRunner.Then("cancelar um alerta contendo o texto \"Deseja realmente resolver a(s) pendência(s) " +
                    "selecionada(s)?\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 37
 testRunner.And("a pendência \"52986920\" deve estar presente na tabela de pendências", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion