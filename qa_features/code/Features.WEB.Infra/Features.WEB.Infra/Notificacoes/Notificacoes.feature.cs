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
namespace Features.WEB.Infra.Notificacoes
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Validar tela de notificações")]
    public partial class ValidarTelaDeNotificacoesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Notificacoes.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Validar tela de notificações", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
 testRunner.Given("eu acesse a página \"http://cldsn00353d.internalenv.corp:25153//login\" e faça logi" +
                    "n com o usuário \"adm\", senha \"sinacor\" e empresa \"CORRETORA26A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 5
 testRunner.Then("o botão favorito do menu principal deve existir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 6
 testRunner.Given("eu estou na tela de notificações", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-15572 - Validar que está sendo permitido selecionar notificações")]
        public virtual void SINACOR_15572_ValidarQueEstaSendoPermitidoSelecionarNotificacoes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-15572 - Validar que está sendo permitido selecionar notificações", null, ((string[])(null)));
#line 9
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 10
 testRunner.Then("a a seleção de notificações está presente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-XXXX - Marcar notificação como lida")]
        public virtual void SINACOR_XXXX_MarcarNotificacaoComoLida()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-XXXX - Marcar notificação como lida", null, ((string[])(null)));
#line 12
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 13
 testRunner.Then("marco uma notificação como lida", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 14
 testRunner.Then("um alerta contendo o texto \"Deseja realmente marcar a(s) notificação(ções) seleci" +
                    "onada(s)?\" deve existir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 15
 testRunner.Then("aceitar o alerta", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-15580 - Realizar a exportação de notificações")]
        public virtual void SINACOR_15580_RealizarAExportacaoDeNotificacoes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-15580 - Realizar a exportação de notificações", null, ((string[])(null)));
#line 17
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
this.FeatureBackground();
#line 18
 testRunner.When("realizo a exportação de uma notificação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 19
 testRunner.Then("download dos dados de notificação é realizado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
