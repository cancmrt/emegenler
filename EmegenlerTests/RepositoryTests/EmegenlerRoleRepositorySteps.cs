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
    public class EmegenlerRoleRepositorySteps
    {
        EmegenlerRoleRepository repo;
        Returner<EmegenlerRole> result;
        public EmegenlerRoleRepositorySteps()
        {
            FakeContextGenerator fContextGenerate = new FakeContextGenerator();
            repo = new EmegenlerRoleRepository(fContextGenerate.GetContext());

        }
        [When(@"We pass new EmegenlerRole entity to our Insert method with zero id on entity")]
        public void WhenWePassNewEmegenlerRoleEntityToOurInsertMethodWithZeroİdOnEntity()
        {
            EmegenlerRole role = new EmegenlerRole
            {
                RoleIdentifier = "GGG"
            };
            result = repo.Insert(role);
        }

        [Then(@"Insert method should add new EmegenlerRole entity to db return with success and new EmegenlerRole entity")]
        public void ThenInsertMethodShouldAddNewEmegenlerRoleEntityToDbReturnWithSuccessAndNewEmegenlerRoleEntity()
        {
            result.IsSuccess().Should().BeTrue();
        }

        [When(@"We pass EmegenlerRole entity with non zero id to our Insert method")]
        public void WhenWePassEmegenlerRoleEntityWithNonZeroİdToOurInsertMethod()
        {
            EmegenlerRole role = new EmegenlerRole
            {
                RoledId = 1000,
                RoleIdentifier = "GGG"
            };
            result = repo.Insert(role);
        }

        [Then(@"Insert method should edit EmegenlerRole and save to db after that should return success with updated EmegenlerRole entity")]
        public void ThenInsertMethodShouldEditEmegenlerRoleAndSaveToDbAfterThatShouldReturnSuccessWithUpdatedEmegenlerRoleEntity()
        {
            result.IsSuccess().Should().BeTrue();
        }

        [When(@"We pass null value to Insert method without EmegenlerRole entity")]
        public void WhenWePassNullValueToInsertMethodWithoutEmegenlerRoleEntity()
        {
            result = repo.Insert(null);
        }

        [Then(@"Insert method should throw NullReferenceException without EmegenlerRole on Returner")]
        public void ThenInsertMethodShouldThrowNullReferenceExceptionWithoutEmegenlerRoleOnReturner()
        {
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
        }

        [When(@"We pass valid EmegenlerRoleId to Get method")]
        public void WhenWePassValidEmegenlerRoleIdToGetMethod()
        {
            result = repo.Get(1000);
        }

        [Then(@"Get method should return valid EmegenlerRole entity with result success on valid EmegenlerRoleId")]
        public void ThenGetMethodShouldReturnValidEmegenlerRoleEntityWithResultSuccessOnValidEmegenlerRoleId()
        {
            result.IsSuccess().Should().BeTrue();
            result.GetData().Should().NotBeNull();
        }

        [When(@"We pass zero value as EmegenlerRoleId to Get method")]
        public void WhenWePassZeroValueAsEmegenlerRoleIdToGetMethod()
        {
            result = repo.Get(0);
        }

        [Then(@"Get method should return state is fail and return Exception on EmegenlerRoleId is zero")]
        public void ThenGetMethodShouldReturnStateİsFailAndReturnExceptionOnEmegenlerRoleIdİsZero()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass negative value as EmegenlerRoleId to Get method")]
        public void WhenWePassNegativeValueAsEmegenlerRoleIdToGetMethod()
        {
            result = repo.Get(-1);
        }

        [Then(@"Get method should return state is fail and return Exception on EmegenlerRoleId is negative")]
        public void ThenGetMethodShouldReturnStateİsFailAndReturnExceptionOnEmegenlerRoleIdİsNegative()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass valid id value as EmegenlerRoleId to Get valid EmegenlerRoleId from Get method")]
        public void WhenWePassValidİdValueAsEmegenlerRoleIdToGetValidEmegenlerRoleIdFromGetMethod()
        {
            result = repo.Get(45);
        }

        [Then(@"Get method should return state is fail and return KeyNotFoundException on EmegenlerRoleId is valid but record not found in our database")]
        public void ThenGetMethodShouldReturnStateİsFailAndReturnKeyNotFoundExceptionOnEmegenlerRoleIdİsValidButRecordNotFoundİnOurDatabase()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }


    }
}
