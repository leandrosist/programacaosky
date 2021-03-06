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
namespace Features.WEB.Infra.Preferencias
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Validar preferências de grid")]
    public partial class ValidarPreferenciasDeGridFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Preferencias.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-br"), "Validar preferências de grid", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 5
#line 6
 testRunner.Given("eu acesse a página \"http://cldsn00353d.internalenv.corp:25153//login\" e faça logi" +
                    "n com o usuário \"adm\", senha \"sinacor\" e empresa \"CORRETORA26A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 7
 testRunner.Then("o botão favorito do menu principal deve existir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 8
 testRunner.Given("eu estou na tela de notificações", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-28038 - Validar a visualização das colunas e ordenação no grid")]
        [NUnit.Framework.CategoryAttribute("SINACOR-28038")]
        [NUnit.Framework.TestCaseAttribute("s", "n", "s", "s", "n", "n", "n", "1", "", "3", "2", "", "", "", null)]
        public virtual void SINACOR_28038_ValidarAVisualizacaoDasColunasEOrdenacaoNoGrid(string numero, string datahoracriacao, string titulo, string descricao, string usuariocriador, string tiponotificacao, string historico, string ordemnumero, string ordemdatahoracriacao, string ordemtitulo, string ordemdescricao, string ordemusuariocriador, string ordemtiponotificacao, string ordemhistorico, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SINACOR-28038"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-28038 - Validar a visualização das colunas e ordenação no grid", null, @__tags);
#line 11
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 12
 testRunner.Given(string.Format("eu clicar em Column Chooser e escolher as colunas para exibição {0}, {1}, {2}, {3" +
                        "}, {4}, {5}, {6}", numero, datahoracriacao, titulo, descricao, usuariocriador, tiponotificacao, historico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 13
 testRunner.Then(string.Format("apresentará no grid as colunas selecionadas {0}, {1}, {2}, {3}, {4}, {5}, {6}", numero, datahoracriacao, titulo, descricao, usuariocriador, tiponotificacao, historico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 14
 testRunner.Given(string.Format("eu fizer a ordenação no grid das colunas selecionadas {0}, {1}, {2}, {3}, {4}, {5" +
                        "}, {6}", ordemnumero, ordemdatahoracriacao, ordemtitulo, ordemdescricao, ordemusuariocriador, ordemtiponotificacao, ordemhistorico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 15
 testRunner.Then(string.Format("as colunas do grid permanecem na ordenação escolhida pelo usuário {0}, {1}, {2}, " +
                        "{3}, {4}, {5}, {6}", ordemnumero, ordemdatahoracriacao, ordemtitulo, ordemdescricao, ordemusuariocriador, ordemtiponotificacao, ordemhistorico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 16
 testRunner.Given("eu irei fazer logoff no Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 17
 testRunner.Then("deverá efetuar logoff e voltar para a página de login do Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 18
 testRunner.Given("eu acesse a página \"http://cldsn00353d.internalenv.corp:25153//login\" e faça logi" +
                    "n com o usuário \"adm\", senha \"sinacor\" e empresa \"CORRETORA26A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 19
 testRunner.Then("o botão favorito do menu principal deve existir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 20
 testRunner.Given("eu estou na tela de notificações", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 21
 testRunner.Then(string.Format("a visualização do grid deve apresentar as mesmas colunas selecionadas e a ordenaç" +
                        "ão escolhida pelo usuario {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}" +
                        ", {11}, {12}, {13}", numero, datahoracriacao, titulo, descricao, usuariocriador, tiponotificacao, historico, ordemnumero, ordemdatahoracriacao, ordemtitulo, ordemdescricao, ordemusuariocriador, ordemtiponotificacao, ordemhistorico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-28050 - Validar a visualização do grid com paginação")]
        [NUnit.Framework.CategoryAttribute("SINACOR-28050")]
        [NUnit.Framework.TestCaseAttribute("s", "n", "s", "s", "n", "n", "n", "1", "", "3", "2", "", "", "", "20", "2", "20641542", "Página 2 de 3 (50 itens)", null)]
        public virtual void SINACOR_28050_ValidarAVisualizacaoDoGridComPaginacao(
                    string numero, 
                    string datahoracriacao, 
                    string titulo, 
                    string descricao, 
                    string usuariocriador, 
                    string tiponotificacao, 
                    string historico, 
                    string ordemnumero, 
                    string ordemdatahoracriacao, 
                    string ordemtitulo, 
                    string ordemdescricao, 
                    string ordemusuariocriador, 
                    string ordemtiponotificacao, 
                    string ordemhistorico, 
                    string tamanhopagina, 
                    string paginacao, 
                    string numeroregistrogrid, 
                    string quantidaderegistropagina, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SINACOR-28050"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-28050 - Validar a visualização do grid com paginação", null, @__tags);
#line 28
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 29
 testRunner.Given("eu adicione \"50\" notificações com código da corretora \"261\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 30
 testRunner.Given("eu irei fazer logoff no Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 31
 testRunner.Then("deverá efetuar logoff e voltar para a página de login do Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 32
 testRunner.Given("eu acesse a página \"http://cldsn00353d.internalenv.corp:25153//login\" e faça logi" +
                    "n com o usuário \"adm\", senha \"sinacor\" e empresa \"CORRETORA26A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 33
 testRunner.Then("o botão favorito do menu principal deve existir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 34
 testRunner.Given("eu estou na tela de notificações", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 35
 testRunner.Given(string.Format("eu clicar em Column Chooser e escolher as colunas para exibição {0}, {1}, {2}, {3" +
                        "}, {4}, {5}, {6}", numero, datahoracriacao, titulo, descricao, usuariocriador, tiponotificacao, historico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 36
 testRunner.Then(string.Format("apresentará no grid as colunas selecionadas {0}, {1}, {2}, {3}, {4}, {5}, {6}", numero, datahoracriacao, titulo, descricao, usuariocriador, tiponotificacao, historico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 37
 testRunner.Given(string.Format("eu fizer a ordenação no grid das colunas selecionadas {0}, {1}, {2}, {3}, {4}, {5" +
                        "}, {6}", ordemnumero, ordemdatahoracriacao, ordemtitulo, ordemdescricao, ordemusuariocriador, ordemtiponotificacao, ordemhistorico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 38
 testRunner.Then(string.Format("as colunas do grid permanecem na ordenação escolhida pelo usuário {0}, {1}, {2}, " +
                        "{3}, {4}, {5}, {6}", ordemnumero, ordemdatahoracriacao, ordemtitulo, ordemdescricao, ordemusuariocriador, ordemtiponotificacao, ordemhistorico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 39
 testRunner.Given(string.Format("eu alterar a quantidade para aumentar a quantidade de registros e alterar a pagin" +
                        "ação para a visualização no grid {0}, {1}", tamanhopagina, paginacao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 40
 testRunner.Given("eu irei fazer logoff no Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 41
 testRunner.Then("deverá efetuar logoff e voltar para a página de login do Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 42
 testRunner.Given("eu acesse a página \"http://cldsn00353d.internalenv.corp:25153//login\" e faça logi" +
                    "n com o usuário \"adm\", senha \"sinacor\" e empresa \"CORRETORA26A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 43
 testRunner.Then("o botão favorito do menu principal deve existir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 44
 testRunner.Given("eu estou na tela de notificações", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 45
 testRunner.Then(string.Format("a visualização da quantidade de registros e paginação do grid com as mesmas infor" +
                        "mações efetuadas pelo usuário {0}, {1}, {2}, {3}", tamanhopagina, paginacao, numeroregistrogrid, quantidaderegistropagina), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 46
 testRunner.Given("eu irei deletar os registros notificações", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("SINACOR-28118 - Validar a visualização das colunas e ordenação no grdi com prefer" +
            "ências de usuários diferentes")]
        [NUnit.Framework.CategoryAttribute("SINACOR-28118")]
        [NUnit.Framework.TestCaseAttribute("s", "n", "s", "s", "n", "n", "n", "1", "", "3", "2", "", "", "", null)]
        public virtual void SINACOR_28118_ValidarAVisualizacaoDasColunasEOrdenacaoNoGrdiComPreferenciasDeUsuariosDiferentes(string numero, string datahoracriacao, string titulo, string descricao, string usuariocriador, string tiponotificacao, string historico, string ordemnumero, string ordemdatahoracriacao, string ordemtitulo, string ordemdescricao, string ordemusuariocriador, string ordemtiponotificacao, string ordemhistorico, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SINACOR-28118"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SINACOR-28118 - Validar a visualização das colunas e ordenação no grdi com prefer" +
                    "ências de usuários diferentes", null, @__tags);
#line 53
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
this.FeatureBackground();
#line 54
 testRunner.Given(string.Format("eu clicar em Column Chooser e escolher as colunas para exibição {0}, {1}, {2}, {3" +
                        "}, {4}, {5}, {6}", numero, datahoracriacao, titulo, descricao, usuariocriador, tiponotificacao, historico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 55
 testRunner.Then(string.Format("apresentará no grid as colunas selecionadas {0}, {1}, {2}, {3}, {4}, {5}, {6}", numero, datahoracriacao, titulo, descricao, usuariocriador, tiponotificacao, historico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 56
 testRunner.Given(string.Format("eu fizer a ordenação no grid das colunas selecionadas {0}, {1}, {2}, {3}, {4}, {5" +
                        "}, {6}", ordemnumero, ordemdatahoracriacao, ordemtitulo, ordemdescricao, ordemusuariocriador, ordemtiponotificacao, ordemhistorico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 57
 testRunner.Then(string.Format("as colunas do grid permanecem na ordenação escolhida pelo usuário {0}, {1}, {2}, " +
                        "{3}, {4}, {5}, {6}", ordemnumero, ordemdatahoracriacao, ordemtitulo, ordemdescricao, ordemusuariocriador, ordemtiponotificacao, ordemhistorico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 58
 testRunner.Given("eu irei fazer logoff no Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 59
 testRunner.Then("deverá efetuar logoff e voltar para a página de login do Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 60
 testRunner.Given("eu acesse a página \"http://cldsn00353d.internalenv.corp:25153//login\" e faça logi" +
                    "n com o usuário \"adm\", senha \"sinacor\" e empresa \"CORRETORA26A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 61
 testRunner.Then("o botão favorito do menu principal deve existir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 62
 testRunner.Given("eu estou na tela de notificações", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 63
 testRunner.Then(string.Format("validar as preferências do usuário adm de colunas e ordenação no grid {0}, {1}, {" +
                        "2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}", numero, datahoracriacao, titulo, descricao, usuariocriador, tiponotificacao, historico, ordemnumero, ordemdatahoracriacao, ordemtitulo, ordemdescricao, ordemusuariocriador, ordemtiponotificacao, ordemhistorico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 64
 testRunner.Given("eu irei fazer logoff no Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 65
 testRunner.Then("deverá efetuar logoff e voltar para a página de login do Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 66
 testRunner.Given("eu acesse a página \"http://cldsn00353d.internalenv.corp:25153//login\" e faça logi" +
                    "n com o usuário \"qaautomacao\", senha \"12345678\" e empresa \"CORRETORA26A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 67
 testRunner.Then("o botão favorito do menu principal deve existir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 68
 testRunner.Given("eu estou na tela de notificações", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 69
 testRunner.Then(string.Format("a visualização do grid deve apresentar diferentes preferencias das colunas seleci" +
                        "onadas e a ordenação escolhida pelo usuario adm em relação ao usuário qaautomaca" +
                        "o {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}", numero, datahoracriacao, titulo, descricao, usuariocriador, tiponotificacao, historico, ordemnumero, ordemdatahoracriacao, ordemtitulo, ordemdescricao, ordemusuariocriador, ordemtiponotificacao, ordemhistorico), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 70
 testRunner.Given("eu irei fazer logoff no Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 71
 testRunner.Then("deverá efetuar logoff e voltar para a página de login do Sinacor Web", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 72
 testRunner.Given("eu acesse a página \"http://cldsn00353d.internalenv.corp:25153//login\" e faça logi" +
                    "n com o usuário \"adm\", senha \"sinacor\" e empresa \"CORRETORA26A\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 73
 testRunner.Then("o botão favorito do menu principal deve existir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 74
 testRunner.Given("eu estou na tela de notificações", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 75
 testRunner.Given("retornar preferencias usuario adm", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
