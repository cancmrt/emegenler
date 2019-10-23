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
    public class EmegenlerRoleRepositorySteps
    {
        EmegenlerRoleRepository repo;
        Returner<EmegenlerRole> result;
        Returner<IList<EmegenlerRole>> results;
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
            result = repo.Get(50);
        }

        [Then(@"Get method should return state is fail and return KeyNotFoundException on EmegenlerRoleId is valid but record not found in our database")]
        public void ThenGetMethodShouldReturnStateİsFailAndReturnKeyNotFoundExceptionOnEmegenlerRoleIdİsValidButRecordNotFoundİnOurDatabase()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass valid page and pageSize take method on EmegenlerRoleRepository")]
        public void WhenWePassValidPageAndPageSizeTakeMethodOnEmegenlerRoleRepository()
        {
            results = repo.Take(1, 1);
        }

        [Then(@"Take method should return List of EmegenlerRole entites from EmegenlerRoleRepository")]
        public void ThenTakeMethodShouldReturnListOfEmegenlerRoleEntitesFromEmegenlerRoleRepository()
        {
            results.IsSuccess().Should().BeTrue();
            results.GetData().Count().Should().BeGreaterThan(0);
        }

        [When(@"We pass valid page attirubute but pageSize attirubute value is zero on EmegenlerRoleRepository's Take method")]
        public void WhenWePassValidPageAttirubuteButPageSizeAttirubuteValueİsZeroOnEmegenlerRoleRepositorySTakeMethod()
        {
            results = repo.Take(1, 0);
        }

        [Then(@"Take method should return fail status and should return Exception on zero value with pageSize attiribute from EmegenlerRoleRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnZeroValueWithPageSizeAttiributeFromEmegenlerRoleRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }

        [When(@"We pass valid page attiribute but pageSize attirubute value is negative on EmegenlerRoleRepository's Take method")]
        public void WhenWePassValidPageAttiributeButPageSizeAttirubuteValueİsNegativeOnEmegenlerRoleRepositorySTakeMethod()
        {
            results = repo.Take(1, -1);
        }

        [Then(@"Take method should return fail status and should return Exception on negative value with pageSize attirubute from EmegenlerRoleRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnNegativeValueWithPageSizeAttirubuteFromEmegenlerRoleRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }

        [When(@"We pass valid pageSize attirubute but page attirubute value is zero on EmegenlerRoleRepository's Take method")]
        public void WhenWePassValidPageSizeAttirubuteButPageAttirubuteValueİsZeroOnEmegenlerRoleRepositorySTakeMethod()
        {
            results = repo.Take(0, 1);
        }

        [Then(@"Take method should return fail status and should return Exception on zero value with page attiribute from EmegenlerRoleRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnZeroValueWithPageAttiributeFromEmegenlerRoleRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }

        [When(@"We pass valid pageSize attiribute but page attirubute value is negative on EmegenlerRoleRepository's Take method")]
        public void WhenWePassValidPageSizeAttiributeButPageAttirubuteValueİsNegativeOnEmegenlerRoleRepositorySTakeMethod()
        {
            results = repo.Take(-1, 1);
        }

        [Then(@"Take method should return fail status and should return Exception on negative value with page attirubute from EmegenlerRoleRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnNegativeValueWithPageAttirubuteFromEmegenlerRoleRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }

        [When(@"We pass valid EmegenlerRole entity with Id")]
        public void WhenWePassValidEmegenlerRoleEntityWithId()
        {
            EmegenlerRole deleteRole = new EmegenlerRole
            {
                RoledId = 1000
            };
            result = repo.Delete(deleteRole);
        }

        [Then(@"Delete method should return succuess status and should return deleted EmegenlerRole entity")]
        public void ThenDeleteMethodShouldReturnSuccuessStatusAndShouldReturnDeletedEmegenlerRoleEntity()
        {
            result.IsSuccess().Should().BeTrue();
            result.GetData().Should().NotBeNull();
        }

        [When(@"We pass valid EmegenlerRole entity without Id to Delete method")]
        public void WhenWePassValidEmegenlerRoleEntityWithoutIdToDeleteMethod()
        {
            EmegenlerRole deleteRole = new EmegenlerRole();
            result = repo.Delete(deleteRole);
        }

        [Then(@"Delete method should return fail status and should return Exception on EmegenlerRole entity without Id from EmegenlerRoleRepository")]
        public void ThenDeleteMethodShouldReturnFailStatusAndShouldReturnExceptionOnEmegenlerRoleEntityWithoutIdFromEmegenlerRoleRepository()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass valid EmegenlerRole entity with Id value is equal to less than one on Delete method")]
        public void WhenWePassValidEmegenlerRoleEntityWithIdValueİsEqualToLessThanOneOnDeleteMethod()
        {
            EmegenlerRole deleteRole = new EmegenlerRole
            {
                RoledId = 0
            };
            result = repo.Delete(deleteRole);
        }

        [Then(@"Delete method should return fail status and should return Exception on EmegenlerRole entity with Id value is equal to less than one from EmegenlerRoleRepository")]
        public void ThenDeleteMethodShouldReturnFailStatusAndShouldReturnExceptionOnEmegenlerRoleEntityWithIdValueİsEqualToLessThanOneFromEmegenlerRoleRepository()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass null EmegenlerRole entity to Delete method")]
        public void WhenWePassNullEmegenlerRoleEntityToDeleteMethod()
        {
            result = repo.Delete(null);
        }

        [Then(@"Delete method should return fail status and should return Exception on null EmegenlerRole entity from EmegenlerRoleRepository")]
        public void ThenDeleteMethodShouldReturnFailStatusAndShouldReturnExceptionOnNullEmegenlerRoleEntityFromEmegenlerRoleRepository()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }




    }
}
