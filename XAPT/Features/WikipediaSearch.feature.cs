#error The element <unitTestProvider> may only appear once in this section.
#error System.Configuration
#error Server stack trace: 
#error    at System.Configuration.ConfigurationElement.DeserializeElement(XmlReader reader, Boolean serializeCollectionKey)
#error    at System.Configuration.ConfigurationSection.DeserializeSection(XmlReader reader)
#error    at TechTalk.SpecFlow.Configuration.ConfigurationSectionHandler.CreateFromXml(String xmlContent)
#error    at TechTalk.SpecFlow.Configuration.ConfigurationLoader.Load(SpecFlowConfiguration specFlowConfiguration, ISpecFlowConfigurationHolder specFlowConfigurationHolder)
#error    at TechTalk.SpecFlow.Generator.Configuration.GeneratorConfigurationProvider.LoadConfiguration(SpecFlowConfiguration specFlowConfiguration, SpecFlowConfigurationHolder specFlowConfigurationHolder)
#error    at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at System.Runtime.Remoting.Messaging.StackBuilderSink._PrivateProcessMessage(IntPtr md, Object[] args, Object server, Object[]& outArgs)
#error    at System.Runtime.Remoting.Messaging.StackBuilderSink.SyncProcessMessage(IMessage msg)
#error Exception rethrown at [0]: 
#error    at System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg)
#error    at System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type)
#error    at TechTalk.SpecFlow.Generator.Interfaces.ITestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.AppDomain.RemoteAppDomainTestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.GeneratorServices.CreateTestGenerator()
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.IdeSingleFileGenerator.GenerateCode(String inputFilePath, String inputFileContent, GeneratorServices generatorServices, ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.IdeSingleFileGenerator.Generate(String inputFilePath, String inputFileContent, GeneratorServices generatorServices, CodeDomHelper codeDomHelper, ProjectSettings projectSettings)