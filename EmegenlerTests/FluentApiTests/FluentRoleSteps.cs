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
    public class FluentRoleSteps
    {
        private readonly IEmegenlerUWork _uWork;
        private readonly IFluentApi _fluent;
        Action act;
        public FluentRoleSteps()
        {
            FakeContextGenerator fContextGenerate = new FakeContextGenerator();
            _uWork = new EmegenlerUWork(fContextGenerate.GetContext());
            _fluent = new FluentApi(_uWork);


        }
        [When(@"We pass valid RoleIdentifier to Create method from FluentRole class")]
        public void WhenWePassValidRoleIdentifierToCreateMethodFromFluentRoleClass()
        {
            act = () => { _fluent.Role.Create("Deneme"); };
        }

        [Then(@"Create method should finish without exception on FluentRole class")]
        public void ThenCreateMethodShouldFinishWithoutExceptionOnFluentRoleClass()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"We pass empty RoleIdentifier to Create method from FluentRole class")]
        public void WhenWePassEmptyRoleIdentifierToCreateMethodFromFluentRoleClass()
        {
            act = () => { _fluent.Role.Create(""); };
        }

        [Then(@"Create method should throw exception on empty RoleIdentifier from FluentRole class")]
        public void ThenCreateMethodShouldThrowExceptionOnEmptyRoleIdentifierFromFluentRoleClass()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass null RoleIdentifier to Create method from FluentRole class")]
        public void WhenWePassNullRoleIdentifierToCreateMethodFromFluentRoleClass()
        {
            act = () => { _fluent.Role.Create(null); };
        }

        [Then(@"Create method should throw exception on null RoleIdentifier from FluentRole class")]
        public void ThenCreateMethodShouldThrowExceptionOnNullRoleIdentifierFromFluentRoleClass()
        {
            act.Should().Throw<NullReferenceException>();
        }

        [When(@"We pass valid RoleId to Get method from FluentRole class")]
        public void WhenWePassValidRoleIdToGetMethodFromFluentRoleClass()
        {
            act = () => { _fluent.Role.Get(1000); };
        }

        [Then(@"Get method should return valid EmegelerRole entity from FluentRole class")]
        public void ThenGetMethodShouldReturnValidEmegelerRoleEntityFromFluentRoleClass()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"We pass RoleId with zero value to Get method from FluentRole class")]
        public void WhenWePassRoleIdWithZeroValueToGetMethodFromFluentRoleClass()
        {
            act = () => { _fluent.Role.Get(0); };
        }

        [Then(@"Get method should throw exception on RoleId with zero value")]
        public void ThenGetMethodShouldThrowExceptionOnRoleIdWithZeroValue()
        {
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [When(@"We pass RoleId with negative value to Get method from FluentRole class")]
        public void WhenWePassRoleIdWithNegativeValueToGetMethodFromFluentRoleClass()
        {
            act = () => { _fluent.Role.Get(-1); };
        }

        [Then(@"Get method should throw exception on RoleId with negative value")]
        public void ThenGetMethodShouldThrowExceptionOnRoleIdWithNegativeValue()
        {
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [When(@"We pass valid Page and PageSize prop on Take method from FluentRole class")]
        public void WhenWePassValidPageAndPageSizePropOnTakeMethodFromFluentRoleClass()
        {
            act = () => { _fluent.Role.Take(1,1); };
        }

        [Then(@"Take method should return List of EmegenlerRole entites from FluentRole class")]
        public void ThenTakeMethodShouldReturnListOfEmegenlerRoleEntitesFromFluentRoleClass()
        {
            act.Should().NotThrow<Exception>();
        }

        [When(@"We pass valid Page prop but PageSize value is less than one to Take method from FluenRole class")]
        public void WhenWePassValidPagePropButPageSizeValueİsLessThanOneToTakeMethodFromFluenRoleClass()
        {
            act = () => { _fluent.Role.Take(1, 0); };
        }

        [Then(@"Take method should throw exception on when PageSize value is less than one from FluentRole class")]
        public void ThenTakeMethodShouldThrowExceptionOnWhenPageSizeValueİsLessThanOneFromFluentRoleClass()
        {
            act.Should().Throw<IndexOutOfRangeException>();
        }

        [When(@"We pass valid PageSize prop but Page value is less than one to Take method from FluenRole class")]
        public void WhenWePassValidPageSizePropButPageValueİsLessThanOneToTakeMethodFromFluenRoleClass()
        {
            act = () => { _fluent.Role.Take(0, 1); };
        }

        [Then(@"Take method should throw exception on when Page value is less than one from FluentRole class")]
        public void ThenTakeMethodShouldThrowExceptionOnWhenPageValueİsLessThanOneFromFluentRoleClass()
        {
            act.Should().Throw<IndexOutOfRangeException>();
        }

    }
}
