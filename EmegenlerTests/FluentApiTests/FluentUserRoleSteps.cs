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
    public class FluentUserRoleSteps
    {
        private readonly IEmegenlerUWork _uWork;
        private readonly IFluentApi _fluent;
        Action act;

        public FluentUserRoleSteps()
        {
            FakeContextGenerator fContextGenerate = new FakeContextGenerator();
            _uWork = new EmegenlerUWork(fContextGenerate.GetContext());
            _fluent = new FluentApi(_uWork);


        }
        [When(@"We pass valid AssociateUser\(identifier\) and ToRole\(identifier\) to FLuentUserRole api")]
        public void WhenWePassValidAssociateUserİdentifierAndToRoleİdentifierToFLuentUserRoleApi()
        {
            act = () => { _fluent.UserRole.AssociateUser("1").ToRole("Manager"); };
        }

        [Then(@"FluentUserRole api should not throw exception on valid AssociateUser\(identifier\) and ToRole\(identifier\) passage on method")]
        public void ThenFluentUserRoleApiShouldNotThrowExceptionOnValidAssociateUserİdentifierAndToRoleİdentifierPassageOnMethod()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"We pass valid AssociateRole\(identifier\) and ToUser\(identifier\) to FLuentUserRole api")]
        public void WhenWePassValidAssociateRoleİdentifierAndToUserİdentifierToFLuentUserRoleApi()
        {
            act = () => { _fluent.UserRole.AssociateRole("manager").ToUser("1"); };
        }

        [Then(@"FluentUserRole api should not throw exception on valid AssociateRole\(identifier\) and ToUser\(identifier\) passage on method")]
        public void ThenFluentUserRoleApiShouldNotThrowExceptionOnValidAssociateRoleİdentifierAndToUserİdentifierPassageOnMethod()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"We pass not valid AssociateUser\(Empty\) and valid ToRole\(identifier\) to FluentUserRoleApi")]
        public void WhenWePassNotValidAssociateUserEmptyAndValidToRoleİdentifierToFluentUserRoleApi()
        {
            act = () => { _fluent.UserRole.AssociateUser("").ToRole("Manager"); };
        }

        [Then(@"FluentUserRole api should throw exception on not valid AssociateUser\(Empty\) and ToRole\(identifier\) passage on method")]
        public void ThenFluentUserRoleApiShouldThrowExceptionOnNotValidAssociateUserEmptyAndToRoleİdentifierPassageOnMethod()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass not valid AssociateUser\(null\) and valid ToRole\(identifier\) to FluentUserRoleApi")]
        public void WhenWePassNotValidAssociateUserNullAndValidToRoleİdentifierToFluentUserRoleApi()
        {
            act = () => { _fluent.UserRole.AssociateUser(null).ToRole("Manager"); };
        }

        [Then(@"FluentUserRole api should throw exception on not valid AssociateUser\(null\) and ToRole\(identifier\) passage on method")]
        public void ThenFluentUserRoleApiShouldThrowExceptionOnNotValidAssociateUserNullAndToRoleİdentifierPassageOnMethod()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass not valid AssociateUser\(identifier\) and valid ToRole\(Empty\) to FluentUserRoleApi")]
        public void WhenWePassNotValidAssociateUserİdentifierAndValidToRoleEmptyToFluentUserRoleApi()
        {
            act = () => { _fluent.UserRole.AssociateUser("1").ToRole(""); };
        }

        [Then(@"FluentUserRole api should throw exception on not valid AssociateUser\(identifier\) and ToRole\(Empty\) passage on method")]
        public void ThenFluentUserRoleApiShouldThrowExceptionOnNotValidAssociateUserİdentifierAndToRoleEmptyPassageOnMethod()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass not valid AssociateUser\(identifier\) and valid ToRole\(null\) to FluentUserRoleApi")]
        public void WhenWePassNotValidAssociateUserİdentifierAndValidToRoleNullToFluentUserRoleApi()
        {
            act = () => { _fluent.UserRole.AssociateUser("1").ToRole(null); };
        }

        [Then(@"FluentUserRole api should throw exception on not valid AssociateUser\(identifier\) and ToRole\(null\) passage on method")]
        public void ThenFluentUserRoleApiShouldThrowExceptionOnNotValidAssociateUserİdentifierAndToRoleNullPassageOnMethod()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass not valid AssociateRole\(Empty\) and valid ToUser\(identifier\) to FluentUserRoleApi")]
        public void WhenWePassNotValidAssociateRoleEmptyAndValidToUserİdentifierToFluentUserRoleApi()
        {
            act = () => { _fluent.UserRole.AssociateRole("").ToUser("1"); };
        }

        [Then(@"FluentUserRole api should throw exception on not valid AssociateRole\(Empty\) and ToUser\(identifier\) passage on method")]
        public void ThenFluentUserRoleApiShouldThrowExceptionOnNotValidAssociateRoleEmptyAndToUserİdentifierPassageOnMethod()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass not valid AssociateRole\(null\) and valid ToUser\(identifier\) to FluentUserRoleApi")]
        public void WhenWePassNotValidAssociateRoleNullAndValidToUserİdentifierToFluentUserRoleApi()
        {
            act = () => { _fluent.UserRole.AssociateRole(null).ToUser("1"); };
        }

        [Then(@"FluentUserRole api should throw exception on not valid AssociateRole\(null\) and ToUser\(identifier\) passage on method")]
        public void ThenFluentUserRoleApiShouldThrowExceptionOnNotValidAssociateRoleNullAndToUserİdentifierPassageOnMethod()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass not valid AssociateRole\(identifier\) and valid ToUser\(Empty\) to FluentUserRoleApi")]
        public void WhenWePassNotValidAssociateRoleİdentifierAndValidToUserEmptyToFluentUserRoleApi()
        {
            act = () => { _fluent.UserRole.AssociateRole("manager").ToUser(""); };
        }

        [Then(@"FluentUserRole api should throw exception on not valid AssociateRole\(identifier\) and ToUser\(Empty\) passage on method")]
        public void ThenFluentUserRoleApiShouldThrowExceptionOnNotValidAssociateRoleİdentifierAndToUserEmptyPassageOnMethod()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass not valid AssociateRole\(identifier\) and valid ToUser\(null\) to FluentUserRoleApi")]
        public void WhenWePassNotValidAssociateRoleİdentifierAndValidToUserNullToFluentUserRoleApi()
        {
            act = () => { _fluent.UserRole.AssociateRole("manager").ToUser(null); };
        }

        [Then(@"FluentUserRole api should throw exception on not valid AssociateRole\(identifier\) and ToUser\(null\) passage on method")]
        public void ThenFluentUserRoleApiShouldThrowExceptionOnNotValidAssociateRoleİdentifierAndToUserNullPassageOnMethod()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"Count method called from UserRole interface")]
        public void WhenCountMethodCalledFromUserRoleİnterface()
        {
            act = () => { _fluent.UserRole.Count(); };
        }

        [Then(@"Count method should return Count of UserRoles in EmegenlerTables from UserRoleInterface")]
        public void ThenCountMethodShouldReturnCountOfUserRolesİnEmegenlerTablesFromUserRoleInterface()
        {
            act.Should().NotThrow<Exception>();
        }


    }
}
