using EmegenlerTests.FakeContext;
using FluentAssertions;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.MethodReturner;
using Guard.Emegenler.UnitOfWork.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using Xunit;

namespace EmegenlerTests.RepositoryTests
{
    [Binding]
    [Collection("Sequential")]
    public class EmegenlerUserRoleIdentifierRepositorySteps
    {
        private readonly EmegenlerUserRoleIdentifierRepository repo;
        Returner<EmegenlerUserRoleIdentifier> result;
        Returner<IList<EmegenlerUserRoleIdentifier>> results;
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

        [When(@"We pass valid page and pageSize take method on EmegenlerUserRoleIdentifierRepository")]
        public void WhenWePassValidPageAndPageSizeTakeMethodOnEmegenlerUserRoleIdentifierRepository()
        {
            results = repo.Take(1, 1);
        }

        [Then(@"Take method should return List of EmegenlerUserRoleIdentifier entites from EmegenlerUserRoleIdentifierRepository")]
        public void ThenTakeMethodShouldReturnListOfEmegenlerUserRoleIdentifierEntitesFromEmegenlerUserRoleIdentifierRepository()
        {
            results.IsSuccess().Should().BeTrue();
            results.GetData().Count().Should().BeGreaterThan(0);
        }

        [When(@"We pass valid page attirubute but pageSize attirubute value is zero on EmegenlerUserRoleIdentifierRepository's Take method")]
        public void WhenWePassValidPageAttirubuteButPageSizeAttirubuteValueİsZeroOnEmegenlerUserRoleIdentifierRepositorySTakeMethod()
        {
            results = repo.Take(1, 0);
        }

        [Then(@"Take method should return fail status and should return Exception on zero value with pageSize attiribute from EmegenlerUserRoleIdentifierRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnZeroValueWithPageSizeAttiributeFromEmegenlerUserRoleIdentifierRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }

        [When(@"We pass valid page attiribute but pageSize attirubute value is negative on EmegenlerUserRoleIdentifierRepository's Take method")]
        public void WhenWePassValidPageAttiributeButPageSizeAttirubuteValueİsNegativeOnEmegenlerUserRoleIdentifierRepositorySTakeMethod()
        {
            results = repo.Take(1, -1);
        }

        [Then(@"Take method should return fail status and should return Exception on negative value with pageSize attirubute from EmegenlerUserRoleIdentifierRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnNegativeValueWithPageSizeAttirubuteFromEmegenlerUserRoleIdentifierRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }

        [When(@"We pass valid pageSize attirubute but page attirubute value is zero on EmegenlerUserRoleIdentifierRepository's Take method")]
        public void WhenWePassValidPageSizeAttirubuteButPageAttirubuteValueİsZeroOnEmegenlerUserRoleIdentifierRepositorySTakeMethod()
        {
            results = repo.Take(0, 1);
        }

        [Then(@"Take method should return fail status and should return Exception on zero value with page attiribute from EmegenlerUserRoleIdentifierRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnZeroValueWithPageAttiributeFromEmegenlerUserRoleIdentifierRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }

        [When(@"We pass valid pageSize attiribute but page attirubute value is negative on EmegenlerUserRoleIdentifierRepository's Take method")]
        public void WhenWePassValidPageSizeAttiributeButPageAttirubuteValueİsNegativeOnEmegenlerUserRoleIdentifierRepositorySTakeMethod()
        {
            results = repo.Take(-1, 0);
        }

        [Then(@"Take method should return fail status and should return Exception on negative value with page attirubute from EmegenlerUserRoleIdentifierRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnNegativeValueWithPageAttirubuteFromEmegenlerUserRoleIdentifierRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }

        [When(@"We pass valid EmegenlerUserRoleIdentifier entity with Id")]
        public void WhenWePassValidEmegenlerUserRoleIdentifierEntityWithId()
        {
            EmegenlerUserRoleIdentifier deleteUserRole = new EmegenlerUserRoleIdentifier
            {
                RoleIdentifierId = 1000
            };
            result = repo.Delete(deleteUserRole);
        }

        [Then(@"Delete method should return succuess status and should return deleted EmegenlerUserRoleIdentifier entity")]
        public void ThenDeleteMethodShouldReturnSuccuessStatusAndShouldReturnDeletedEmegenlerUserRoleIdentifierEntity()
        {
            result.IsSuccess().Should().BeTrue();
            result.GetData().Should().NotBeNull();
        }

        [When(@"We pass valid EmegenlerUserRoleIdentifier entity without Id to Delete method")]
        public void WhenWePassValidEmegenlerUserRoleIdentifierEntityWithoutIdToDeleteMethod()
        {
            EmegenlerUserRoleIdentifier deleteUserRole = new EmegenlerUserRoleIdentifier();
            result = repo.Delete(deleteUserRole);
        }

        [Then(@"Delete method should return fail status and should return Exception on EmegenlerUserRoleIdentifier entity without Id from EmegenlerUserRoleIdentifierRepository")]
        public void ThenDeleteMethodShouldReturnFailStatusAndShouldReturnExceptionOnEmegenlerUserRoleIdentifierEntityWithoutIdFromEmegenlerUserRoleIdentifierRepository()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass valid EmegenlerUserRoleIdentifier entity with Id value is equal to less than one on Delete method")]
        public void WhenWePassValidEmegenlerUserRoleIdentifierEntityWithIdValueİsEqualToLessThanOneOnDeleteMethod()
        {
            EmegenlerUserRoleIdentifier deleteUserRole = new EmegenlerUserRoleIdentifier
            {
                RoleIdentifierId = 0
            };
            result = repo.Delete(deleteUserRole);
        }

        [Then(@"Delete method should return fail status and should return Exception on EmegenlerUserRoleIdentifier entity with Id value is equal to less than one from EmegenlerUserRoleIdentifierRepository")]
        public void ThenDeleteMethodShouldReturnFailStatusAndShouldReturnExceptionOnEmegenlerUserRoleIdentifierEntityWithIdValueİsEqualToLessThanOneFromEmegenlerUserRoleIdentifierRepository()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass null EmegenlerUserRoleIdentifier entity to Delete method")]
        public void WhenWePassNullEmegenlerUserRoleIdentifierEntityToDeleteMethod()
        {
            result = repo.Delete(null);
        }

        [Then(@"Delete method should return fail status and should return Exception on null EmegenlerUserRoleIdentifier entity from EmegenlerUserRoleIdentifierRepository")]
        public void ThenDeleteMethodShouldReturnFailStatusAndShouldReturnExceptionOnNullEmegenlerUserRoleIdentifierEntityFromEmegenlerUserRoleIdentifierRepository()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }



    }
}
