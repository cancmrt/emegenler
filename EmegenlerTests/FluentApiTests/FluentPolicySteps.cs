using EmegenlerTests.FakeContext;
using FluentAssertions;
using Guard.Emegenler;
using Guard.Emegenler.FluentInterface;
using Guard.Emegenler.UnitOfWork;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace EmegenlerTests.FluentApiTests
{
    [Binding]
    [Collection("Sequential")]
    public class FluentPolicySteps
    {
        private readonly IEmegenlerUWork _uWork;
        private readonly IEmegenlerFluentApi _fluent;
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
            act = () => { _fluent.Policy.Create().WithUser("1").AddPage("/home/privacy").AccessGranted(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(userIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserUserIdentifier_AddPageTypeofFakeClass_AccessGrantedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(userIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessDenied\(\); called")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddPageTypeofFakeClass_AccessDeniedCalled()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddPage("/home/privacy").AccessDenied(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithUser\(userIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessDenied\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithUserUserIdentifier_AddPageTypeofFakeClass_AccessDeniedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(roleIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); called")]
        public void WhenApi_Policy_Create_WithRoleRoleIdentifier_AddPageTypeofFakeClass_AccessGrantedCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddPage("/home/privacy").AccessGranted(); };
        }

        [Then(@"Operation done without throw exception on api\.Policy\.Create\(\)\.WithRole\(roleIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); call")]
        public void ThenOperationDoneWithoutThrowExceptionOnApi_Policy_Create_WithRoleRoleIdentifier_AddPageTypeofFakeClass_AccessGrantedCall()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(roleIdentifier\)\.AddPage\(typeof\(FakeClass\)\)\.AccessDenied\(\); called")]
        public void WhenApi_Policy_Create_WithRoleRoleIdentifier_AddPageTypeofFakeClass_AccessDeniedCalled()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddPage("/home/privacy").AccessDenied(); };
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
            act = () => { _fluent.Policy.Create().WithUser("").AddLink("linkId").Hide(); };
        }

        [Then(@"NullReferanceException throws by WithUser method with empty UserIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByWithUserMethodWithEmptyUserIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(null\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); called on WithUser method with null UserIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserNull_AddPageTypeofFakeClass_AccessGrantedCalledOnWithUserMethodWithNullUserIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithUser(null).AddLink("linkId").Hide(); };
        }

        [Then(@"NullReferanceException throws by WithUser method with null UserIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByWithUserMethodWithNullUserIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); called on WithRole method with empty RoleIdentifier prop")]
        public void WhenApi_Policy_Create_WithRole_AddPageTypeofFakeClass_AccessGrantedCalledOnWithRoleMethodWithEmptyRoleIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithRole("").AddLink("linkId").Hide(); };
        }

        [Then(@"NullReferanceException throws by WithRole method with empty RoleIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByWithRoleMethodWithEmptyRoleIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithRole\(null\)\.AddPage\(typeof\(FakeClass\)\)\.AccessGranted\(\); called on WithRole method with null RoleIdentifier prop")]
        public void WhenApi_Policy_Create_WithRoleNull_AddPageTypeofFakeClass_AccessGrantedCalledOnWithRoleMethodWithNullRoleIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithRole(null).AddLink("linkId").Hide(); };
        }

        [Then(@"NullReferanceException throws by WithRole method with null RoleIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByWithRoleMethodWithNullRoleIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddPage\(null\)\.AccessGranted\(\); called on AddPage method with null PageType prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddPageNull_AccessGrantedCalledOnAddPageMethodWithNullPageTypeProp()
        {
            act = () => { _fluent.Policy.Create().WithRole("1").AddPage(null).AccessDenied(); };
        }

        [Then(@"NullReferanceException throws by AddPage method with null PageType prop")]
        public void ThenNullReferanceExceptionThrowsByAddPageMethodWithNullPageTypeProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddComponent\(\)\.Show\(\); called on AddComponent method with empty ComponentIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddComponent_ShowCalledOnAddComponentMethodWithEmptyComponentIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddComponent("").Show(); };
        }

        [Then(@"NullReferanceException throws by AddComponent method with empty ComponentIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddComponentMethodWithEmptyComponentIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddComponent\(null\)\.Show\(\); called on AddComponent method with null ComponentIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddComponentNull_ShowCalledOnAddComponentMethodWithNullComponentIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddComponent(null).Show(); };
        }

        [Then(@"NullReferanceException throws by AddComponent method with null ComponentIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddComponentMethodWithNullComponentIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddForm\(\)\.ActionGranted\(\); called on AddForm method with empty FormIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddForm_ActionGrantedCalledOnAddFormMethodWithEmptyFormIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddForm("").ActionGranted(); };
        }

        [Then(@"NullReferanceException throws by AddForm method with empty FormIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddFormMethodWithEmptyFormIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddForm\(null\)\.ActionGranted\(\); called on AddForm method with null FormIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddFormNull_ActionGrantedCalledOnAddFormMethodWithNullFormIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddForm(null).ActionGranted(); };
        }

        [Then(@"NullReferanceException throws by AddForm method with null FormIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddFormMethodWithNullFormIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddInput\(\)\.Readonly\(\); called on AddInput method with empty InputIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddInput_ReadonlyCalledOnAddInputMethodWithEmptyInputIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddInput("").Readonly(); };
        }

        [Then(@"NullReferanceException throws by AddInput method with empty InputIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddInputMethodWithEmptyInputIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddInput\(null\)\.Readonly\(\); called on AddForm method with null InputIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddInputNull_ReadonlyCalledOnAddFormMethodWithNullInputIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddInput(null).Readonly(); };
        }

        [Then(@"NullReferanceException throws by AddInput method with null InputIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddInputMethodWithNullInputIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddButton\(\)\.Readonly\(\); called on AddButton method with empty ButtonIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddButton_ReadonlyCalledOnAddButtonMethodWithEmptyButtonIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddButton("").Readonly(); };
        }

        [Then(@"NullReferanceException throws by AddButton method with empty ButtonIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddButtonMethodWithEmptyButtonIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddButton\(null\)\.Readonly\(\); called on AddButton method with null ButtonIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddButtonNull_ReadonlyCalledOnAddButtonMethodWithNullButtonIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddButton(null).Readonly(); };
        }

        [Then(@"NullReferanceException throws by AddButton method with null ButtonIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddButtonMethodWithNullButtonIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddLink\(\)\.Readonly\(\); called on AddLink method with empty LinkIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddLink_ReadonlyCalledOnAddLinkMethodWithEmptyLinkIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddLink("").Readonly(); };
        }

        [Then(@"NullReferanceException throws by AddLink method with empty LinkIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddLinkMethodWithEmptyLinkIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"api\.Policy\.Create\(\)\.WithUser\(UserIdentifier\)\.AddLink\(null\)\.Readonly\(\); called on AddLink method with null LinkIdentifier prop")]
        public void WhenApi_Policy_Create_WithUserUserIdentifier_AddLinkNull_ReadonlyCalledOnAddLinkMethodWithNullLinkIdentifierProp()
        {
            act = () => { _fluent.Policy.Create().WithUser("1").AddLink(null).Readonly(); };
        }

        [Then(@"NullReferanceException throws by AddLink method with null LinkIdentifier prop")]
        public void ThenNullReferanceExceptionThrowsByAddLinkMethodWithNullLinkIdentifierProp()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass valid PolicyId to Get method from FluentPolicy class")]
        public void WhenWePassValidPolicyIdToGetMethodFromFluentPolicyClass()
        {
            act = () => { _fluent.Policy.Get(1000); };
        }

        [Then(@"Get method should return valid EmegelerPolicy entity from FluentPolicy class")]
        public void ThenGetMethodShouldReturnValidEmegelerPolicyEntityFromFluentPolicyClass()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"We pass PolicyId with zero value to Get method from FluentPolicy class")]
        public void WhenWePassPolicyIdWithZeroValueToGetMethodFromFluentPolicyClass()
        {
            act = () => { _fluent.Policy.Get(0); };
        }

        [Then(@"Get method should throw exception on PolicyId with zero value")]
        public void ThenGetMethodShouldThrowExceptionOnPolicyIdWithZeroValue()
        {
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [When(@"We pass PolicyId with negative value to Get method from FluentPolicy class")]
        public void WhenWePassPolicyIdWithNegativeValueToGetMethodFromFluentPolicyClass()
        {
            act = () => { _fluent.Policy.Get(-1); };
        }

        [Then(@"Get method should throw exception on PolicyId with negative value")]
        public void ThenGetMethodShouldThrowExceptionOnPolicyIdWithNegativeValue()
        {
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [When(@"We pass valid Page and PageSize prop on Take method from FluentPolicy class")]
        public void WhenWePassValidPageAndPageSizePropOnTakeMethodFromFluentPolicyClass()
        {
            act = () => { _fluent.Policy.Take(1,1); };
        }

        [Then(@"Take method should return List of EmegelerPolicy entites from FluentPolicy class")]
        public void ThenTakeMethodShouldReturnListOfEmegelerPolicyEntitesFromFluentPolicyClass()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"We pass valid Page prop but PageSize value is less than one to Take method from FluentPolicy class")]
        public void WhenWePassValidPagePropButPageSizeValueİsLessThanOneToTakeMethodFromFluentPolicyClass()
        {
            act = () => { _fluent.Policy.Take(1, 0); };
        }

        [Then(@"Take method should throw exception on when PageSize value is less than one from FluentPolicy class")]
        public void ThenTakeMethodShouldThrowExceptionOnWhenPageSizeValueİsLessThanOneFromFluentPolicyClass()
        {
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [When(@"We pass valid PageSize prop but Page value is less than one to Take method from FluentPolicy class")]
        public void WhenWePassValidPageSizePropButPageValueİsLessThanOneToTakeMethodFromFluentPolicyClass()
        {
            act = () => { _fluent.Policy.Take(0, 1); };
        }

        [Then(@"Take method should throw exception on when Page value is less than one from FluentPolicy class")]
        public void ThenTakeMethodShouldThrowExceptionOnWhenPageValueİsLessThanOneFromFluentPolicyClass()
        {
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [When(@"Count method called from Pplicy interface")]
        public void WhenCountMethodCalledFromPplicyİnterface()
        {
            act = () => { _fluent.Policy.Count(); };
        }

        [Then(@"Count method should return Count of Policies in EmegenlerTables from PolicyInterface")]
        public void ThenCountMethodShouldReturnCountOfPoliciesİnEmegenlerTablesFromPolicyInterface()
        {
            act.Should().NotThrow<Exception>();
        }


        [When(@"We pass valid identifier api\.Policy\(\)\.Take\(\)\.FromUser\(identifier\) method")]
        public void WhenWePassValidİdentifierApi_Policy_Take_FromUserİdentifierMethod()
        {
            act = () => { _fluent.Policy.Take().FromUser("1"); };
        }

        [Then(@"api\.Policy\(\)\.Take\(\)\.FromUser\(identifier\) should return List of Policies belong to User")]
        public void ThenApi_Policy_Take_FromUserİdentifierShouldReturnListOfPoliciesBelongToUser()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"We pass valid identifier api\.Policy\(\)\.Take\(\)\.FromRole\(identifier\) method")]
        public void WhenWePassValidİdentifierApi_Policy_Take_FromRoleİdentifierMethod()
        {
            act = () => { _fluent.Policy.Take().FromRole("Test"); };
        }

        [Then(@"api\.Policy\(\)\.Take\(\)\.FromRole\(identifier\) should return List of Policies belong to Role")]
        public void ThenApi_Policy_Take_FromRoleİdentifierShouldReturnListOfPoliciesBelongToRole()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"We pass Empty value as User identifier to api\.Policy\(\)\.Take\(\)\.FromUser\(Empty\) method")]
        public void WhenWePassEmptyValueAsUserİdentifierToApi_Policy_Take_FromUserEmptyMethod()
        {
            act = () => { _fluent.Policy.Take().FromUser(""); };
        }

        [Then(@"api\.Policy\(\)\.Take\(\)\.FromUser\(Empty\) method should throw exception")]
        public void ThenApi_Policy_Take_FromUserEmptyMethodShouldThrowException()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass Null value as User identifier to api\.Policy\(\)\.Take\(\)\.FromUser\(null\) method")]
        public void WhenWePassNullValueAsUserİdentifierToApi_Policy_Take_FromUserNullMethod()
        {
            act = () => { _fluent.Policy.Take().FromUser(null); };
        }

        [Then(@"api\.Policy\(\)\.Take\(\)\.FromUser\(null\) method should throw exception")]
        public void ThenApi_Policy_Take_FromUserNullMethodShouldThrowException()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass Empty value as Role identifier to api\.Policy\(\)\.Take\(\)\.FromRole\(Empty\) method")]
        public void WhenWePassEmptyValueAsRoleİdentifierToApi_Policy_Take_FromRoleEmptyMethod()
        {
            act = () => { _fluent.Policy.Take().FromRole(""); };
        }

        [Then(@"api\.Policy\(\)\.Take\(\)\.FromRole\(Empty\) method should throw exception")]
        public void ThenApi_Policy_Take_FromRoleEmptyMethodShouldThrowException()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass Null value as Role identifier to api\.Policy\(\)\.Take\(\)\.FromRole\(null\) method")]
        public void WhenWePassNullValueAsRoleİdentifierToApi_Policy_Take_FromRoleNullMethod()
        {
            act = () => { _fluent.Policy.Take().FromRole(null); };
        }

        [Then(@"api\.Policy\(\)\.Take\(\)\.FromRole\(null\) method should throw exception")]
        public void ThenApi_Policy_Take_FromRoleNullMethodShouldThrowException()
        {
            act.Should().Throw<NullReferenceException>();
        }



    }
}
