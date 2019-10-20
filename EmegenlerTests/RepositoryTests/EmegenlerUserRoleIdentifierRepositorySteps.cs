using EmegenlerTests.FakeContext;
using FluentAssertions;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.MethodReturner;
using Guard.Emegenler.UnitOfWork.Repositories;
using System;
using TechTalk.SpecFlow;

namespace EmegenlerTests.RepositoryTests
{
    [Binding]
    public class EmegenlerUserRoleIdentifierRepositorySteps
    {
        EmegenlerUserRoleIdentifierRepository repo;
        Returner<EmegenlerUserRoleIdentifier> result;
        public EmegenlerUserRoleIdentifierRepositorySteps()
        {
            FakeContextGenerator fContextGenerate = new FakeContextGenerator();
            repo = new EmegenlerUserRoleIdentifierRepository(fContextGenerate.GetContext());

        }
        [When(@"We pass new EmegenlerUserRoleIdentifier entity to our Insert method with zero id on entity")]
        public void WhenWePassNewEmegenlerUserRoleIdentifierEntityToOurInsertMethodWithZeroİdOnEntity()
        {
            EmegenlerUserRoleIdentifier emegenlerUserRoleIdentifier = new EmegenlerUserRoleIdentifier
            {
                RoleIdentifier = "GGG",
                UserIdentifier = "1"
            };
            result = repo.Insert(emegenlerUserRoleIdentifier);
        }

        [Then(@"Insert method should add new EmegenlerUserRoleIdentifier entity to db return with success and new EmegenlerRole entity")]
        public void ThenInsertMethodShouldAddNewEmegenlerUserRoleIdentifierEntityToDbReturnWithSuccessAndNewEmegenlerRoleEntity()
        {
            result.IsSuccess().Should().BeTrue();
        }

        [When(@"We pass EmegenlerUserRoleIdentifier entity with non zero id to our Insert method")]
        public void WhenWePassEmegenlerUserRoleIdentifierEntityWithNonZeroİdToOurInsertMethod()
        {
            EmegenlerUserRoleIdentifier emegenlerUserRoleIdentifier = new EmegenlerUserRoleIdentifier
            {
                RoleIdentifierId = 1000,
                RoleIdentifier = "GGG",
                UserIdentifier = "1"
            };
            result = repo.Insert(emegenlerUserRoleIdentifier);
        }

        [Then(@"Insert method should edit EmegenlerUserRoleIdentifier and save to db after that should return success with updated EmegenlerUserRoleIdentifier entity")]
        public void ThenInsertMethodShouldEditEmegenlerUserRoleIdentifierAndSaveToDbAfterThatShouldReturnSuccessWithUpdatedEmegenlerUserRoleIdentifierEntity()
        {
            result.IsSuccess().Should().BeTrue();
        }

        [When(@"We pass null value to Insert method without EmegenlerUserRoleIdentifier entity")]
        public void WhenWePassNullValueToInsertMethodWithoutEmegenlerUserRoleIdentifierEntity()
        {
            result = repo.Insert(null);
        }

        [Then(@"Insert method should throw NullReferenceException without EmegenlerUserRoleIdentifier on Returner")]
        public void ThenInsertMethodShouldThrowNullReferenceExceptionWithoutEmegenlerUserRoleIdentifierOnReturner()
        {
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
        }

        [When(@"We pass valid EmegenlerUserRoleIdentifierId to Get method")]
        public void WhenWePassValidEmegenlerUserRoleIdentifierIdToGetMethod()
        {
            result = repo.Get(1000);
        }

        [Then(@"Get method should return valid EmegenlerUserRoleIdentifier entity with result success on valid EmegenlerUserRoleIdentifierId")]
        public void ThenGetMethodShouldReturnValidEmegenlerUserRoleIdentifierEntityWithResultSuccessOnValidEmegenlerUserRoleIdentifierId()
        {
            result.IsSuccess().Should().BeTrue();
            result.GetData().Should().NotBeNull();
        }

        [When(@"We pass zero value as EmegenlerUserRoleIdentifierId to Get method")]
        public void WhenWePassZeroValueAsEmegenlerUserRoleIdentifierIdToGetMethod()
        {
            result = repo.Get(0);
        }

        [Then(@"Get method should return state is fail and return Exception on EmegenlerUserRoleIdentifierId is zero")]
        public void ThenGetMethodShouldReturnStateİsFailAndReturnExceptionOnEmegenlerUserRoleIdentifierIdİsZero()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass negative value as EmegenlerUserRoleIdentifierId to Get method")]
        public void WhenWePassNegativeValueAsEmegenlerUserRoleIdentifierIdToGetMethod()
        {
            result = repo.Get(-1);
        }

        [Then(@"Get method should return state is fail and return Exception on EmegenlerUserRoleIdentifierId is negative")]
        public void ThenGetMethodShouldReturnStateİsFailAndReturnExceptionOnEmegenlerUserRoleIdentifierIdİsNegative()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass valid id value on EmegenlerUserRoleIdentifier entity to get with valid EmegenlerUserRoleIdentifierId from Get method")]
        public void WhenWePassValidİdValueOnEmegenlerUserRoleIdentifierEntityToGetWithValidEmegenlerUserRoleIdentifierIdFromGetMethod()
        {
            result = repo.Get(45);
        }

        [Then(@"Get method should return state is fail and return KeyNotFoundException on EmegenlerUserRoleIdentifierId is valid but record not found in our database")]
        public void ThenGetMethodShouldReturnStateİsFailAndReturnKeyNotFoundExceptionOnEmegenlerUserRoleIdentifierIdİsValidButRecordNotFoundİnOurDatabase()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }


    }
}
