using SeleniumHelper;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Tracing;

namespace Features.WEB.Infra
{
    public class SpecFlowTestListener : ITraceListener
    {
        public SpecFlowTestListener()
        {
            var disableTrace = Environment.GetEnvironmentVariable(DisableTraceVariable);

            if (String.IsNullOrWhiteSpace(disableTrace))
                _listener = new DefaultListener();
        }

        public void WriteTestOutput(string message)
        {
            if (_listener != null)
            {
                _listener.WriteTestOutput(message);
                SeleniumBase.LogInfo(message, "Specflow", false);
            }
        }

        public void WriteToolOutput(string message)
        {
            if (_listener != null)
            {
                _listener.WriteToolOutput(message);
                SeleniumBase.LogInfo(message, "Specflow", false);
            }
        }

        private readonly ITraceListener _listener;

        private const string DisableTraceVariable = "DISABLE_SPECFLOW_TRACE_OUTPUT";
    }
}
