using EmegenlerTests.FakeContext;
using FluentAssertions;
using Guard.Emegenler;
using Guard.Emegenler.FluentInterface;
using Guard.Emegenler.UnitOfWork;
using System;
using TechTalk.SpecFlow;

namespace EmegenlerTests.FluentApiTests
{
    [Binding]
    public class FluentPolicySteps
    {
        IEmegenlerUWork _uWork;
        IFluentApi _fluent;
        Action act;
        public FluentPolicySteps()
        {
            FakeContextGenerator fContextGenerate = new FakeContextGenerator();
            _uWork = new EmegenlerUWork(fContextGenerate.GetContext());
            _fluent = new FluentApi(_uWork);


        }



        [When(@"api\.Policy\.Create\(\)\.WithUser\(userIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); called")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddPageTypeofFakeClass_AccessGrantedCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddPage(typeof(FluentPolicySteps)).AccessGranted(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(userIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserUserIdentifier_AddPageTypeofFakeClass_AccessGrantedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(userIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessDenied\(\); called")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddPageTypeofFakeClass_AccessDeniedCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddPage(typeof(FluentPolicySteps)).AccessDenied(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(userIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessDenied\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserUserIdentifier_AddPageTypeofFakeClass_AccessDeniedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(roleIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); called")]
        public void WhenApi_Policy_Create_WithRoleRoleIdentifier_AddPageTypeofFakeClass_AccessGrantedCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddPage(typeof(FluentPolicySteps)).AccessGranted(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(roleIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleRoleIdentifier_AddPageTypeofFakeClass_AccessGrantedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(roleIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessDenied\(\); called")]
        public void WhenApi_Policy_Create_WithRoleRoleIdentifier_AddPageTypeofFakeClass_AccessDeniedCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddPage(typeof(FluentPolicySteps)).AccessDenied(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(roleIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessDenied\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleRoleIdentifier_AddPageTypeofFakeClass_AccessDeniedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(userIdentifier\)\.AddComponent\(identifier\)\.Show\(\); called")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddComponentİdentifier_ShowCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddComponent("divId").Show(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(userIdentifier\)\.AddComponent\(identifier\)\.Show\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserUserIdentifier_AddComponentİdentifier_ShowCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(userIdentifier\)\.AddComponent\(identifier\)\.Hide\(\); called")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddComponentİdentifier_HideCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddComponent("divId").Hide(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(userIdentifier\)\.AddComponent\(identifier\)\.Hide\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserUserIdentifier_AddComponentİdentifier_HideCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(roleIdentifier\)\.AddComponent\(identifier\)\.Show\(\); called")]
        public void WhenApi_Policy_Create_WithRoleRoleIdentifier_AddComponentİdentifier_ShowCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddComponent("divId").Show(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(roleIdentifier\)\.AddComponent\(identifier\)\.Show\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleRoleIdentifier_AddComponentİdentifier_ShowCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(roleIdentifier\)\.AddComponent\(identifier\)\.Hide\(\); called")]
        public void WhenApi_Policy_Create_WithRoleRoleIdentifier_AddComponentİdentifier_HideCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddComponent("divId").Hide(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(roleIdentifier\)\.AddComponent\(identifier\)\.Hide\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleRoleIdentifier_AddComponentİdentifier_HideCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddForm\(identifier\)\.ActionGranted\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddFormİdentifier_ActionGrantedCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddForm("formId").ActionGranted(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddForm\(identifier\)\.ActionGranted\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddFormİdentifier_ActionGrantedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddForm\(identifier\)\.Readonly\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddFormİdentifier_ReadonlyCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddForm("formId").Readonly(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddForm\(identifier\)\.Readonly\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddFormİdentifier_ReadonlyCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddForm\(identifier\)\.Hide\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddFormİdentifier_HideCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddForm("formId").Hide(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddForm\(identifier\)\.Hide\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddFormİdentifier_HideCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddForm\(identifier\)\.ActionGranted\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddFormİdentifier_ActionGrantedCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddForm("formId").ActionGranted(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddForm\(identifier\)\.ActionGranted\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddFormİdentifier_ActionGrantedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddForm\(identifier\)\.Readonly\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddFormİdentifier_ReadonlyCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddForm("formId").Readonly(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddForm\(identifier\)\.Readonly\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddFormİdentifier_ReadonlyCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddForm\(identifier\)\.Hide\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddFormİdentifier_HideCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddForm("formId").Hide(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddForm\(identifier\)\.Hide\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddFormİdentifier_HideCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddInput\(identifier\)\.Editable\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddInputİdentifier_EditableCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddInput("inputId").Editable(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddInput\(identifier\)\.Editable\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddInputİdentifier_EditableCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddInput\(identifier\)\.Readonly\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddInputİdentifier_ReadonlyCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddInput("inputId").Readonly(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddInput\(identifier\)\.Readonly\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddInputİdentifier_ReadonlyCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddInput\(identifier\)\.Hide\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddInputİdentifier_HideCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddInput("inputId").Hide(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddInput\(identifier\)\.Hide\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddInputİdentifier_HideCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddInput\(identifier\)\.Editable\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddInputİdentifier_EditableCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddInput("inputId").Editable(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddInput\(identifier\)\.Editable\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddInputİdentifier_EditableCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddInput\(identifier\)\.Readonly\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddInputİdentifier_ReadonlyCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddInput("inputId").Readonly(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddInput\(identifier\)\.Readonly\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddInputİdentifier_ReadonlyCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddInput\(identifier\)\.Hide\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddInputİdentifier_HideCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddInput("inputId").Hide(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddInput\(identifier\)\.Hide\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddInputİdentifier_HideCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddButton\(identifier\)\.ActionGranted\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddButtonİdentifier_ActionGrantedCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddButton("buttonId").ActionGranted(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddButton\(identifier\)\.ActionGranted\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddButtonİdentifier_ActionGrantedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddButton\(identifier\)\.Readonly\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddButtonİdentifier_ReadonlyCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddButton("buttonId").Readonly(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddButton\(identifier\)\.Readonly\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddButtonİdentifier_ReadonlyCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddButton\(identifier\)\.Hide\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddButtonİdentifier_HideCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddButton("buttonId").Hide(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddButton\(identifier\)\.Hide\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddButtonİdentifier_HideCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddButton\(identifier\)\.ActionGranted\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddButtonİdentifier_ActionGrantedCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddButton("buttonId").ActionGranted(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddButton\(identifier\)\.ActionGranted\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddButtonİdentifier_ActionGrantedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddButton\(identifier\)\.Readonly\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddButtonİdentifier_ReadonlyCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddButton("buttonId").Readonly(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddButton\(identifier\)\.Readonly\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddButtonİdentifier_ReadonlyCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddButton\(identifier\)\.Hide\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddButtonİdentifier_HideCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddButton("buttonId").Hide(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddButton\(identifier\)\.Hide\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddButtonİdentifier_HideCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddLink\(identifier\)\.ActionGranted\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddLinkİdentifier_ActionGrantedCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddLink("linkId").ActionGranted(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddLink\(identifier\)\.ActionGranted\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddLinkİdentifier_ActionGrantedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddLink\(identifier\)\.Readonly\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddLinkİdentifier_ReadonlyCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddLink("linkId").Readonly(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddLink\(identifier\)\.Readonly\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddLinkİdentifier_ReadonlyCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddLink\(identifier\)\.Hide\(\); called")]
        public void WhenApi_Policy_Create_WithUserİdentifier_AddLinkİdentifier_HideCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddLink("linkId").Hide(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(identifier\)\.AddLink\(identifier\)\.Hide\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserİdentifier_AddLinkİdentifier_HideCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddLink\(identifier\)\.ActionGranted\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddLinkİdentifier_ActionGrantedCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddLink("linkId").ActionGranted(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddLink\(identifier\)\.ActionGranted\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddLinkİdentifier_ActionGrantedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddLink\(identifier\)\.Readonly\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddLinkİdentifier_ReadonlyCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddLink("linkId").Readonly(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddLink\(identifier\)\.Readonly\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddLinkİdentifier_ReadonlyCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddLink\(identifier\)\.Hide\(\); called")]
        public void WhenApi_Policy_Create_WithRoleİdentifier_AddLinkİdentifier_HideCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddLink("linkId").Hide(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(identifier\)\.AddLink\(identifier\)\.Hide\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleİdentifier_AddLinkİdentifier_HideCall()
        {
            act.Should().NotThrow<Exception>();
        }









        [When(@"api\.Policy\.Create\(\)\.WithUser\(\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); called on WithUser method with empty UserIdentifier prop")]
        public void WhenApi_Policy_Create_WithUser_AddPageTypeofFakeClass_AccessGrantedCalledOnWithUserMethodWithEmptyUserIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by WithUser method with empty UserIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByWithUserMethodWithEmptyUserIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(null\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); called on WithUser method with null UserIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserNull_AddPageTypeofFakeClass_AccessGrantedCalledOnWithUserMethodWithNullUserIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by WithUser method with null UserIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByWithUserMethodWithNullUserIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); called on WithRole method with empty RoleIdentifier prop")]
        public void WhenApi_Policy_Create_WithRole_AddPageTypeofFakeClass_AccessGrantedCalledOnWithRoleMethodWithEmptyRoleIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by WithRole method with empty RoleIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByWithRoleMethodWithEmptyRoleIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(null\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); called on WithRole method with null RoleIdentifier prop")]
        public void WhenApi_Policy_Create_WithRoleNull_AddPageTypeofFakeClass_AccessGrantedCalledOnWithRoleMethodWithNullRoleIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddPage\(null\)\.AccessGranted\(\); called on AddPage method with null PageType prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddPageNull_AccessGrantedCalledOnAddPageMethodWithNullPageTypeProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by AddPage method with null PageType prop")]
        public void ThenNullReferanceExceptionThrowsByAddPageMethodWithNullPageTypeProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddComponent\(\)\.Show\(\); called on AddComponent method with empty ComponentIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddComponent_ShowCalledOnAddComponentMethodWithEmptyComponentIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by AddComponent method with empty ComponentIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddComponentMethodWithEmptyComponentIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddComponent\(null\)\.Show\(\); called on AddComponent method with null ComponentIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddComponentNull_ShowCalledOnAddComponentMethodWithNullComponentIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by AddComponent method with null ComponentIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddComponentMethodWithNullComponentIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddForm\(\)\.ActionGranted\(\); called on AddForm method with empty FormIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddForm_ActionGrantedCalledOnAddFormMethodWithEmptyFormIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by AddForm method with empty FormIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddFormMethodWithEmptyFormIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddForm\(null\)\.ActionGranted\(\); called on AddForm method with null FormIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddFormNull_ActionGrantedCalledOnAddFormMethodWithNullFormIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by AddForm method with null FormIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddFormMethodWithNullFormIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddInput\(\)\.Readonly\(\); called on AddInput method with empty InputIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddInput_ReadonlyCalledOnAddInputMethodWithEmptyInputIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by AddInput method with empty InputIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddInputMethodWithEmptyInputIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddInput\(null\)\.Readonly\(\); called on AddForm method with null InputIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddInputNull_ReadonlyCalledOnAddFormMethodWithNullInputIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by AddInput method with null InputIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddInputMethodWithNullInputIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddButton\(\)\.Readonly\(\); called on AddButton method with empty ButtonIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddButton_ReadonlyCalledOnAddButtonMethodWithEmptyButtonIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by AddButton method with empty ButtonIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddButtonMethodWithEmptyButtonIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddButton\(null\)\.Readonly\(\); called on AddButton method with null ButtonIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddButtonNull_ReadonlyCalledOnAddButtonMethodWithNullButtonIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by AddButton method with null ButtonIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddButtonMethodWithNullButtonIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddLink\(\)\.Readonly\(\); called on AddLink method with empty LinkIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddLink_ReadonlyCalledOnAddLinkMethodWithEmptyLinkIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by AddLink method with empty LinkIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddLinkMethodWithEmptyLinkIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddLink\(null\)\.Readonly\(\); called on AddLink method with null LinkIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddLinkNull_ReadonlyCalledOnAddLinkMethodWithNullLinkIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"NullReferanceException throws by AddLink method with null LinkIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddLinkMethodWithNullLinkIdentifierProp()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
