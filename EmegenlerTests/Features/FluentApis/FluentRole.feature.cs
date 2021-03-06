// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EmegenlerTests.Features.FluentApis
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class FluentRoleFeature : object, Xunit.IClassFixture<FluentRoleFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "FluentRole.feature"
#line hidden
        
        public FluentRoleFeature(FluentRoleFeature.FixtureData fixtureData, EmegenlerTests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FluentRole", "\tThis interface should do:\r\n\tCreate Role in Emegenler\r\n\tGet Role in Emegenler\r\n\tT" +
                    "ake Role in Emegenler", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void TestTearDown()
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
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create method take valid RoleIdentifier and method should finish without exceptio" +
            "n")]
        [Xunit.TraitAttribute("FeatureTitle", "FluentRole")]
        [Xunit.TraitAttribute("Description", "Create method take valid RoleIdentifier and method should finish without exceptio" +
            "n")]
        [Xunit.TraitAttribute("Category", "Create-NormalCase")]
        public virtual void CreateMethodTakeValidRoleIdentifierAndMethodShouldFinishWithoutException()
        {
            string[] tagsOfScenario = new string[] {
                    "Create-NormalCase"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create method take valid RoleIdentifier and method should finish without exceptio" +
                    "n", null, new string[] {
                        "Create-NormalCase"});
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
 testRunner.When("We pass valid RoleIdentifier to Create method from FluentRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then("Create method should finish without exception on FluentRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create method take empty RoleIdentifier method should throw exception")]
        [Xunit.TraitAttribute("FeatureTitle", "FluentRole")]
        [Xunit.TraitAttribute("Description", "Create method take empty RoleIdentifier method should throw exception")]
        [Xunit.TraitAttribute("Category", "Create-ExceptionalCase")]
        public virtual void CreateMethodTakeEmptyRoleIdentifierMethodShouldThrowException()
        {
            string[] tagsOfScenario = new string[] {
                    "Create-ExceptionalCase"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create method take empty RoleIdentifier method should throw exception", null, new string[] {
                        "Create-ExceptionalCase"});
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 13
 testRunner.When("We pass empty RoleIdentifier to Create method from FluentRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.Then("Create method should throw exception on empty RoleIdentifier from FluentRole clas" +
                        "s", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create method take null RoleIdentifier method should throw exception")]
        [Xunit.TraitAttribute("FeatureTitle", "FluentRole")]
        [Xunit.TraitAttribute("Description", "Create method take null RoleIdentifier method should throw exception")]
        [Xunit.TraitAttribute("Category", "Create-ExceptionalCase")]
        public virtual void CreateMethodTakeNullRoleIdentifierMethodShouldThrowException()
        {
            string[] tagsOfScenario = new string[] {
                    "Create-ExceptionalCase"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create method take null RoleIdentifier method should throw exception", null, new string[] {
                        "Create-ExceptionalCase"});
#line 16
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 17
 testRunner.When("We pass null RoleIdentifier to Create method from FluentRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.Then("Create method should throw exception on null RoleIdentifier from FluentRole class" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Get method take valid RoleId and method should return valid EmegenlerRole entity")]
        [Xunit.TraitAttribute("FeatureTitle", "FluentRole")]
        [Xunit.TraitAttribute("Description", "Get method take valid RoleId and method should return valid EmegenlerRole entity")]
        [Xunit.TraitAttribute("Category", "Get-NormalCase")]
        public virtual void GetMethodTakeValidRoleIdAndMethodShouldReturnValidEmegenlerRoleEntity()
        {
            string[] tagsOfScenario = new string[] {
                    "Get-NormalCase"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get method take valid RoleId and method should return valid EmegenlerRole entity", null, new string[] {
                        "Get-NormalCase"});
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 21
 testRunner.When("We pass valid RoleId to Get method from FluentRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then("Get method should return valid EmegelerRole entity from FluentRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Get method take RoleId with zero value and method throw exception")]
        [Xunit.TraitAttribute("FeatureTitle", "FluentRole")]
        [Xunit.TraitAttribute("Description", "Get method take RoleId with zero value and method throw exception")]
        [Xunit.TraitAttribute("Category", "Get-ExceptionalCase")]
        public virtual void GetMethodTakeRoleIdWithZeroValueAndMethodThrowException()
        {
            string[] tagsOfScenario = new string[] {
                    "Get-ExceptionalCase"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get method take RoleId with zero value and method throw exception", null, new string[] {
                        "Get-ExceptionalCase"});
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
 testRunner.When("We pass RoleId with zero value to Get method from FluentRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("Get method should throw exception on RoleId with zero value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Get method take RoleId with negative value and method throw exception")]
        [Xunit.TraitAttribute("FeatureTitle", "FluentRole")]
        [Xunit.TraitAttribute("Description", "Get method take RoleId with negative value and method throw exception")]
        [Xunit.TraitAttribute("Category", "Get-ExceptionalCase")]
        public virtual void GetMethodTakeRoleIdWithNegativeValueAndMethodThrowException()
        {
            string[] tagsOfScenario = new string[] {
                    "Get-ExceptionalCase"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get method take RoleId with negative value and method throw exception", null, new string[] {
                        "Get-ExceptionalCase"});
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 29
 testRunner.When("We pass RoleId with negative value to Get method from FluentRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("Get method should throw exception on RoleId with negative value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Take method take valid Page and PageSize prop and method should return List of Ro" +
            "les")]
        [Xunit.TraitAttribute("FeatureTitle", "FluentRole")]
        [Xunit.TraitAttribute("Description", "Take method take valid Page and PageSize prop and method should return List of Ro" +
            "les")]
        [Xunit.TraitAttribute("Category", "Take-NormalCase")]
        public virtual void TakeMethodTakeValidPageAndPageSizePropAndMethodShouldReturnListOfRoles()
        {
            string[] tagsOfScenario = new string[] {
                    "Take-NormalCase"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Take method take valid Page and PageSize prop and method should return List of Ro" +
                    "les", null, new string[] {
                        "Take-NormalCase"});
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 33
 testRunner.When("We pass valid Page and PageSize prop on Take method from FluentRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.Then("Take method should return List of EmegenlerRole entites from FluentRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Take method take valid Page but PageSize is less than one")]
        [Xunit.TraitAttribute("FeatureTitle", "FluentRole")]
        [Xunit.TraitAttribute("Description", "Take method take valid Page but PageSize is less than one")]
        [Xunit.TraitAttribute("Category", "Take-ExceptionalCase")]
        public virtual void TakeMethodTakeValidPageButPageSizeİsLessThanOne()
        {
            string[] tagsOfScenario = new string[] {
                    "Take-ExceptionalCase"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Take method take valid Page but PageSize is less than one", null, new string[] {
                        "Take-ExceptionalCase"});
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 37
 testRunner.When("We pass valid Page prop but PageSize value is less than one to Take method from F" +
                        "luenRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.Then("Take method should throw exception on when PageSize value is less than one from F" +
                        "luentRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Take method take valid PageSize but Page is less than one")]
        [Xunit.TraitAttribute("FeatureTitle", "FluentRole")]
        [Xunit.TraitAttribute("Description", "Take method take valid PageSize but Page is less than one")]
        [Xunit.TraitAttribute("Category", "Take-ExceptionalCase")]
        public virtual void TakeMethodTakeValidPageSizeButPageİsLessThanOne()
        {
            string[] tagsOfScenario = new string[] {
                    "Take-ExceptionalCase"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Take method take valid PageSize but Page is less than one", null, new string[] {
                        "Take-ExceptionalCase"});
#line 40
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 41
 testRunner.When("We pass valid PageSize prop but Page value is less than one to Take method from F" +
                        "luenRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.Then("Take method should throw exception on when Page value is less than one from Fluen" +
                        "tRole class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Count method when called return Count of Roles in EmegenlerTables from RoleInterf" +
            "ace")]
        [Xunit.TraitAttribute("FeatureTitle", "FluentRole")]
        [Xunit.TraitAttribute("Description", "Count method when called return Count of Roles in EmegenlerTables from RoleInterf" +
            "ace")]
        [Xunit.TraitAttribute("Category", "Count-NormalCase")]
        public virtual void CountMethodWhenCalledReturnCountOfRolesİnEmegenlerTablesFromRoleInterface()
        {
            string[] tagsOfScenario = new string[] {
                    "Count-NormalCase"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Count method when called return Count of Roles in EmegenlerTables from RoleInterf" +
                    "ace", null, new string[] {
                        "Count-NormalCase"});
#line 45
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 46
 testRunner.When("Count method called from Role interface", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("Count method should return Count of Roles in EmegenlerTables from RoleInterface", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                FluentRoleFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                FluentRoleFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
