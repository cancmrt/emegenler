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
namespace EmegenlerTests.Features.Repositories
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class EmegenlerPolicyRepositoryFeature : Xunit.IClassFixture<EmegenlerPolicyRepositoryFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "EmegenlerPolicyRepository.feature"
#line hidden
        
        public EmegenlerPolicyRepositoryFeature(EmegenlerPolicyRepositoryFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "EmegenlerPolicyRepository", @"	This repo should do listed operations
	Insert(Add,Edit) This difference based on id if you send entity with id to function this will update entity. If you don't have id this will add entity to db
	Get => We have to get spesific EmegenerPolicy with id
	Take => We can be get listed policies on database with using page and pageSize
	Delete We can be delete spesific ElemgenlerPolicy with id", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="With using Insert method we can be add new EmegenlerPolicy to db")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "With using Insert method we can be add new EmegenlerPolicy to db")]
        [Xunit.TraitAttribute("Category", "NormalCase-Insert")]
        public virtual void WithUsingInsertMethodWeCanBeAddNewEmegenlerPolicyToDb()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("With using Insert method we can be add new EmegenlerPolicy to db", null, new string[] {
                        "NormalCase-Insert"});
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
testRunner.When("We pass new EmegenlerPolicy entity to our Insert method with zero id on entity", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
testRunner.Then("Insert method should add new EmegenlerPolicy entity to db return with success and" +
                    " new EmegenlerPolicy entity", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="With using Insert method we can update our exist EmegenlerPolicy entity")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "With using Insert method we can update our exist EmegenlerPolicy entity")]
        [Xunit.TraitAttribute("Category", "NormalCase-Insert")]
        public virtual void WithUsingInsertMethodWeCanUpdateOurExistEmegenlerPolicyEntity()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("With using Insert method we can update our exist EmegenlerPolicy entity", null, new string[] {
                        "NormalCase-Insert"});
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
testRunner.When("We pass EmegenlerPolicy entity with non zero id to our Insert method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
testRunner.Then("Insert method should edit EmegenlerPolicy and save to db after that should return" +
                    " success with updated EmegenlerPolicy entity", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="If we pass null value to our Insert method, method should throw NullReferenceExce" +
            "ption")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "If we pass null value to our Insert method, method should throw NullReferenceExce" +
            "ption")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-Insert")]
        public virtual void IfWePassNullValueToOurInsertMethodMethodShouldThrowNullReferenceException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("If we pass null value to our Insert method, method should throw NullReferenceExce" +
                    "ption", null, new string[] {
                        "ExceptionalCase-Insert"});
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
testRunner.When("We pass null value to Insert method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
testRunner.Then("Insert method should throw NullReferenceException", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Get Method take EmegenlerPolicyId to get EmegenlerPolicy entity.")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Get Method take EmegenlerPolicyId to get EmegenlerPolicy entity.")]
        [Xunit.TraitAttribute("Category", "NormalCase-Get")]
        public virtual void GetMethodTakeEmegenlerPolicyIdToGetEmegenlerPolicyEntity_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Method take EmegenlerPolicyId to get EmegenlerPolicy entity.", null, new string[] {
                        "NormalCase-Get"});
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
testRunner.When("We pass valid EmegenlerPolicyId to Get method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
testRunner.Then("Get method should return valid EmegenlerPolicy entity with result success on vali" +
                    "d EmegenlerPolicyId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Get method take zero as EmegenlerPolicyId")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Get method take zero as EmegenlerPolicyId")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-Get")]
        public virtual void GetMethodTakeZeroAsEmegenlerPolicyId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get method take zero as EmegenlerPolicyId", null, new string[] {
                        "ExceptionalCase-Get"});
#line 29
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 30
testRunner.When("We pass zero value as EmegenlerPolicyId to Get method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
testRunner.Then("Get method should return state is fail and return Exception on EmegenlerPolicyId " +
                    "is zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Get method take negative as EmegenlerPolicyId")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Get method take negative as EmegenlerPolicyId")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-Get")]
        public virtual void GetMethodTakeNegativeAsEmegenlerPolicyId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get method take negative as EmegenlerPolicyId", null, new string[] {
                        "ExceptionalCase-Get"});
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 35
testRunner.When("We pass negative value as EmegenlerPolicyId to Get method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
testRunner.Then("Get method should return state is fail and return Exception on EmegenlerPolicyId " +
                    "is negative", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Get method take valid EmegenlerPolicyId but id record not found in our databaser")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Get method take valid EmegenlerPolicyId but id record not found in our databaser")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-Get")]
        public virtual void GetMethodTakeValidEmegenlerPolicyIdButİdRecordNotFoundİnOurDatabaser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get method take valid EmegenlerPolicyId but id record not found in our databaser", null, new string[] {
                        "ExceptionalCase-Get"});
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 40
testRunner.When("We pass valid id value as EmegenlerPolicyId to Get valid EmegenlerPolicyId from G" +
                    "et method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
testRunner.Then("Get method should return state is fail and return KeyNotFoundException on Emegenl" +
                    "erPolicyId is valid but record not found in our database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Take method getting page and pageSize attiribute if method take valid page and pa" +
            "geSize attirubute, method should return List of EmegenlerPoliciy entities")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Take method getting page and pageSize attiribute if method take valid page and pa" +
            "geSize attirubute, method should return List of EmegenlerPoliciy entities")]
        [Xunit.TraitAttribute("Category", "NormalCase-Take")]
        public virtual void TakeMethodGettingPageAndPageSizeAttiributeİfMethodTakeValidPageAndPageSizeAttirubuteMethodShouldReturnListOfEmegenlerPoliciyEntities()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Take method getting page and pageSize attiribute if method take valid page and pa" +
                    "geSize attirubute, method should return List of EmegenlerPoliciy entities", null, new string[] {
                        "NormalCase-Take"});
#line 44
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 45
testRunner.When("We pass valid page and pageSize take method on EmegenlerPolicyRepository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
testRunner.Then("Take method should return List of EmegenlerPolicy entites from EmegenlerPolicyRep" +
                    "ository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Take method getting valid page but pageSize value is zero")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Take method getting valid page but pageSize value is zero")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-Take")]
        public virtual void TakeMethodGettingValidPageButPageSizeValueİsZero()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Take method getting valid page but pageSize value is zero", null, new string[] {
                        "ExceptionalCase-Take"});
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 50
testRunner.When("We pass valid page attirubute but pageSize attirubute value is zero on EmegenlerP" +
                    "olicyRepository\'s Take method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
testRunner.Then("Take method should return fail status and should return Exception on zero value w" +
                    "ith pageSize attiribute from EmegenlerPolicyRepository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Take method gettig valid page attiribute but pageSize attirubute is negative")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Take method gettig valid page attiribute but pageSize attirubute is negative")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-Take")]
        public virtual void TakeMethodGettigValidPageAttiributeButPageSizeAttirubuteİsNegative()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Take method gettig valid page attiribute but pageSize attirubute is negative", null, new string[] {
                        "ExceptionalCase-Take"});
#line 53
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 54
testRunner.When("We pass valid page attiribute but pageSize attirubute value is negative on Emegen" +
                    "lerPolicyRepository\'s Take method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
testRunner.Then("Take method should return fail status and should return Exception on negative val" +
                    "ue with pageSize attirubute from EmegenlerPolicyRepository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Take method getting valid pageSize but page value is zero")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Take method getting valid pageSize but page value is zero")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-Take")]
        public virtual void TakeMethodGettingValidPageSizeButPageValueİsZero()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Take method getting valid pageSize but page value is zero", null, new string[] {
                        "ExceptionalCase-Take"});
#line 58
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 59
testRunner.When("We pass valid pageSize attirubute but page attirubute value is zero on EmegenlerP" +
                    "olicyRepository\'s Take method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
testRunner.Then("Take method should return fail status and should return Exception on zero value w" +
                    "ith page attiribute from EmegenlerPolicyRepository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Take method gettig valid pageSize attiribute but page attirubute is negative")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Take method gettig valid pageSize attiribute but page attirubute is negative")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-Take")]
        public virtual void TakeMethodGettigValidPageSizeAttiributeButPageAttirubuteİsNegative()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Take method gettig valid pageSize attiribute but page attirubute is negative", null, new string[] {
                        "ExceptionalCase-Take"});
#line 62
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 63
testRunner.When("We pass valid pageSize attiribute but page attirubute value is negative on Emegen" +
                    "lerPolicyRepository\'s Take method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
testRunner.Then("Take method should return fail status and should return Exception on negative val" +
                    "ue with page attirubute from EmegenlerPolicyRepository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Delete method take valid EmegenlerPolicy entity with Id and method should return " +
            "Deleted EmegenlerPolicy entity")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Delete method take valid EmegenlerPolicy entity with Id and method should return " +
            "Deleted EmegenlerPolicy entity")]
        [Xunit.TraitAttribute("Category", "NormalCase-Delete")]
        public virtual void DeleteMethodTakeValidEmegenlerPolicyEntityWithIdAndMethodShouldReturnDeletedEmegenlerPolicyEntity()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete method take valid EmegenlerPolicy entity with Id and method should return " +
                    "Deleted EmegenlerPolicy entity", null, new string[] {
                        "NormalCase-Delete"});
#line 67
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 68
testRunner.When("We pass valid EmegenlerPolicy entity with Id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
testRunner.Then("Delete method should return succuess status and should return deleted EmegenlerPo" +
                    "licy entity", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Delete method take valid EmegenlerPolicy without Id")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Delete method take valid EmegenlerPolicy without Id")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-Delete")]
        public virtual void DeleteMethodTakeValidEmegenlerPolicyWithoutId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete method take valid EmegenlerPolicy without Id", null, new string[] {
                        "ExceptionalCase-Delete"});
#line 71
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 72
testRunner.When("We pass valid EmegenlerPolicy entity without Id to Delete method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
testRunner.Then("Delete method should return fail status and should return Exception on EmegenlerP" +
                    "olicy entity without Id from EmegenlerPolicyRepository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Delete method take valid EmegenlerPolicy with Id value which is less than one")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Delete method take valid EmegenlerPolicy with Id value which is less than one")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-Delete")]
        public virtual void DeleteMethodTakeValidEmegenlerPolicyWithIdValueWhichİsLessThanOne()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete method take valid EmegenlerPolicy with Id value which is less than one", null, new string[] {
                        "ExceptionalCase-Delete"});
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 76
testRunner.When("We pass valid EmegenlerPolicy entity with Id value is equal to less than one on D" +
                    "elete method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
testRunner.Then("Delete method should return fail status and should return Exception on EmegenlerP" +
                    "olicy entity with Id value is equal to less than one from EmegenlerPolicyReposit" +
                    "ory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Delete method take null as a parameter on Delete method")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "Delete method take null as a parameter on Delete method")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-Delete")]
        public virtual void DeleteMethodTakeNullAsAParameterOnDeleteMethod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete method take null as a parameter on Delete method", null, new string[] {
                        "ExceptionalCase-Delete"});
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 80
testRunner.When("We pass null EmegenlerPolicy entity to Delete method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
testRunner.Then("Delete method should return fail status and should return Exception on null Emege" +
                    "nlerPolicy entity from EmegenlerPolicyRepository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="TakePolicies Method take AuthType and Identifier to get List of EmegenlerPolicy e" +
            "ntity on belong to User.")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "TakePolicies Method take AuthType and Identifier to get List of EmegenlerPolicy e" +
            "ntity on belong to User.")]
        [Xunit.TraitAttribute("Category", "NormalCase-TakePolicies")]
        public virtual void TakePoliciesMethodTakeAuthTypeAndIdentifierToGetListOfEmegenlerPolicyEntityOnBelongToUser_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TakePolicies Method take AuthType and Identifier to get List of EmegenlerPolicy e" +
                    "ntity on belong to User.", null, new string[] {
                        "NormalCase-TakePolicies"});
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 85
testRunner.When("We pass valid AuthType amd Identifier to TakePolicies method for getting User Pol" +
                    "icies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
testRunner.Then("TakePolicies method should return valid List of EmegenlerPolicy entites with resu" +
                    "lt success on valid AuthType amd Identifier for getting User Policies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="TakePolicies Method take AuthType and Identifier to get List of EmegenlerPolicy e" +
            "ntity on belong to Role.")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "TakePolicies Method take AuthType and Identifier to get List of EmegenlerPolicy e" +
            "ntity on belong to Role.")]
        [Xunit.TraitAttribute("Category", "NormalCase-TakePolicies")]
        public virtual void TakePoliciesMethodTakeAuthTypeAndIdentifierToGetListOfEmegenlerPolicyEntityOnBelongToRole_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TakePolicies Method take AuthType and Identifier to get List of EmegenlerPolicy e" +
                    "ntity on belong to Role.", null, new string[] {
                        "NormalCase-TakePolicies"});
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 90
testRunner.When("We pass valid AuthType amd Identifier to TakePolicies method for getting Role Pol" +
                    "icies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
testRunner.Then("TakePolicies method should return valid List of EmegenlerPolicy entites with resu" +
                    "lt success on valid AuthType amd Identifier for getting Role Policies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="TakePolicies method take Empty value on Identifier")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "TakePolicies method take Empty value on Identifier")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-TakePolicies")]
        public virtual void TakePoliciesMethodTakeEmptyValueOnIdentifier()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TakePolicies method take Empty value on Identifier", null, new string[] {
                        "ExceptionalCase-TakePolicies"});
#line 94
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 95
testRunner.When("We pass Empty value as Identifier to TakePolicies method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
testRunner.Then("TakePolicies method should return state is fail and return Exception when Identif" +
                    "ier is Empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="TakePolicies method take Null value on Identifier")]
        [Xunit.TraitAttribute("FeatureTitle", "EmegenlerPolicyRepository")]
        [Xunit.TraitAttribute("Description", "TakePolicies method take Null value on Identifier")]
        [Xunit.TraitAttribute("Category", "ExceptionalCase-TakePolicies")]
        public virtual void TakePoliciesMethodTakeNullValueOnIdentifier()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TakePolicies method take Null value on Identifier", null, new string[] {
                        "ExceptionalCase-TakePolicies"});
#line 99
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 100
testRunner.When("We pass Null value as Identifier to TakePolicies method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
testRunner.Then("TakePolicies method should return state is fail and return Exception when Identif" +
                    "ier is Null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                EmegenlerPolicyRepositoryFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                EmegenlerPolicyRepositoryFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
