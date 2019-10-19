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

    }
}
