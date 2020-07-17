using ConfigHelper;
using OpenQA.Selenium;
using SeleniumHelper;
using System;
using System.Configuration;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace Features.WEB.Infra
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // Isso aqui roda ANTES do teste inteiro!
            // Esse método não escreve nada no log de execução do teste, pois é um método que executa "fora" do escopo do teste
            // Porém, os logs podem ser vistos no log em texto do log4net (Execution.log)

            // Inicialização do log em texto (log4net)
            SeleniumBase.InitializeLogger();
            // Finaliza quaisquer drivers abertos
            Utils.EndProcess();

            // Recupera variáveis BDD do banco de dados local
            UtilsHelper.VariablesDB.GetAllVariablesInDB(ref SharedData.sharedVariables, ref SharedData.sharedObjects);
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            // Isso aqui roda ANTES de cada feature!
            // Esse método não escreve nada no log de execução do teste, pois é um método que executa "fora" do escopo do teste
            // Porém, os logs podem ser vistos no log em texto do log4net (Execution.log)
            // Carrega o arquivo de configuração 'env.conf' em memória
            ConfigBase.LoadConfigFile("env.conf");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Isso aqui roda ANTES de cada cenário/contexto/esquema do cenário!

            // Seta o browser da execução
            Browser browser = Browser.CHROME; //default é CHROME
            string strBrowser = ConfigurationManager.AppSettings["Browser"];
            if (!Enum.TryParse(strBrowser, out browser))
                browser = Browser.CHROME;

            SeleniumBase.LogInfo($"Preparando o WebDriver para o browser [{browser.ToString()}]...", "BeforeScenario");
            object obj = SharedData.GetObject("__WEBDRIVER__");
            // Se existir nenhum webdriver, aproveita o driver existente
            if (obj != null)
                SeleniumBase.ExistingLocalDriver((IWebDriver)obj);
            // se não existir nenhum driver aberto, cria um
            else
                SharedData.SetObject("__WEBDRIVER__", SeleniumBase.ConfigureLocalDriver(browser));
            // e compartilha
            SeleniumBase.LogInfo("OK!", "BeforeScenario");
        }

        [AfterStep]
        public void AfterStep()
        {
            // Isso aqui roda DEPOIS de cada step (frase)!

            // Captura se o step deu erro, e caso TRUE, tira uma print da tela WEB
            if (ScenarioContext.Current.TestError != null)
            {
                SeleniumBase.LogError(ScenarioContext.Current.TestError.StackTrace, null, "Specflow", false);
                SeleniumBase.TakePrint();
            }
            // verifica se o step é um THEN, caso TRUE, tira uma print da tela WEB!
            else if (ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString().Equals("Then"))
            {
                SeleniumBase.TakePrint();
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Isso aqui roda DEPOIS de cada cenário/contexto/esquema do cenário!

            // Compartilhando o driver atual
            SharedData.SetObject("__WEBDRIVER__", SeleniumBase.Driver);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            // Isso aqui roda DEPOIS de cada feature!
            // Esse método não escreve nada no log de execução do teste, pois é um método que executa "fora" do escopo do teste
            // Porém, os logs podem ser vistos no log em texto do log4net (Execution.log)
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // Isso aqui roda DEPOIS do teste inteiro!
            // Esse método não escreve nada no log de execução do teste, pois é um método que executa "fora" do escopo do teste
            // Porém, os logs podem ser vistos no log em texto do log4net (Execution.log)
			
            // Inicialização do log em texto (log4net)
            SeleniumBase.InitializeLogger();

            // Finaliza quaiser drivers abertos
            Utils.EndProcess();

            // Salva variáveis BDD no banco de dados local
            UtilsHelper.VariablesDB.StoreAllVariablesInDB(SharedData.sharedVariables, SharedData.sharedObjects);
        }
    }
}
