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

    }
}
