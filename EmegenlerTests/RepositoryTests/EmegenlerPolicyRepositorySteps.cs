using EmegenlerTests.FakeContext;
using FluentAssertions;
using Guard.Emegenler.DAL;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.MethodReturner;
using Guard.Emegenler.UnitOfWork.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace EmegenlerTests.RepositoryTests
{
    [Binding]
    public class EmegenlerPolicyRepositorySteps
    {
        EmegenlerPolicyRepository repo;
        Returner<EmegenlerPolicy> result;
        Returner<IList<EmegenlerPolicy>> results;
        public EmegenlerPolicyRepositorySteps()
        {
            FakeContextGenerator fContextGenerate = new FakeContextGenerator();
            repo = new EmegenlerPolicyRepository(fContextGenerate.GetContext());

        }
        [When(@"We pass new EmegenlerPolicy entity to our Insert method with zero id on entity")]
        public void WhenWePassNewEmegenlerPolicyEntityToOurInsertMethodWithZeroİdOnEntity()
        {
            EmegenlerPolicy policy = new EmegenlerPolicy
            {
                PolicyElement = "Button",
                PolicyElementIdentifier = "canc",
                AccessProtocol = "Readonly",
                AuthBase = Guard.Emegenler.FluentInterface.Policy.Types.AuthBase.User,
                AuthBaseIdentifier = "1",
            };
            result = repo.Insert(policy);
        }

        [Then(@"Insert method should add new EmegenlerPolicy entity to db return with success and new EmegenlerPolicy entity")]
        public void ThenInsertMethodShouldAddNewEmegenlerPolicyEntityToDbReturnWithSuccessAndNewEmegenlerPolicyEntity()
        {
            result.IsSuccess().Should().BeTrue();
        }

        [When(@"We pass EmegenlerPolicy entity with non zero id to our Insert method")]
        public void WhenWePassEmegenlerPolicyEntityWithNonZeroİdToOurInsertMethod()
        {
            EmegenlerPolicy policy = new EmegenlerPolicy
            {
                PolicyId = 1000,
                PolicyElement = "Button",
                PolicyElementIdentifier = "canc",
                AccessProtocol = "Readonly",
                AuthBase = Guard.Emegenler.FluentInterface.Policy.Types.AuthBase.User,
                AuthBaseIdentifier = "1",
            };
            result = repo.Insert(policy);
        }

        [Then(@"Insert method should edit EmegenlerPolicy and save to db after that should return success with updated EmegenlerPolicy entity")]
        public void ThenInsertMethodShouldEditEmegenlerPolicyAndSaveToDbAfterThatShouldReturnSuccessWithUpdatedEmegenlerPolicyEntity()
        {
            result.IsSuccess().Should().BeTrue();
        }

        [When(@"We pass null value to Insert method")]
        public void WhenWePassNullValueToInsertMethod()
        {
            result = repo.Insert(null);
        }

        [Then(@"Insert method should throw NullReferenceException")]
        public void ThenInsertMethodShouldThrowNullReferenceException()
        {
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
        }
        [When(@"We pass valid EmegenlerPolicyId to Get method")]
        public void WhenWePassValidEmegenlerPolicyIdToGetMethod()
        {
            result = repo.Get(1000);
        }

        [Then(@"Get method should return valid EmegenlerPolicy entity with result success on valid EmegenlerPolicyId")]
        public void ThenGetMethodShouldReturnValidEmegenlerPolicyEntityWithResultSuccessOnValidEmegenlerPolicyId()
        {
            result.IsSuccess().Should().BeTrue();
            result.GetData().Should().NotBeNull();
        }

        [When(@"We pass zero value as EmegenlerPolicyId to Get method")]
        public void WhenWePassZeroValueAsEmegenlerPolicyIdToGetMethod()
        {
            result = repo.Get(0);
        }

        [Then(@"Get method should return state is fail and return Exception on EmegenlerPolicyId is zero")]
        public void ThenGetMethodShouldReturnStateİsFailAndReturnExceptionOnEmegenlerPolicyIdİsZero()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass negative value as EmegenlerPolicyId to Get method")]
        public void WhenWePassNegativeValueAsEmegenlerPolicyIdToGetMethod()
        {
            result = repo.Get(-1);
        }

        [Then(@"Get method should return state is fail and return Exception on EmegenlerPolicyId is negative")]
        public void ThenGetMethodShouldReturnStateİsFailAndReturnExceptionOnEmegenlerPolicyIdİsNegative()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass valid id value as EmegenlerPolicyId to Get valid EmegenlerPolicyId from Get method")]
        public void WhenWePassValidİdValueAsEmegenlerPolicyIdToGetValidEmegenlerPolicyIdFromGetMethod()
        {
            result = repo.Get(45);
        }

        [Then(@"Get method should return state is fail and return KeyNotFoundException on EmegenlerPolicyId is valid but record not found in our database")]
        public void ThenGetMethodShouldReturnStateİsFailAndReturnKeyNotFoundExceptionOnEmegenlerPolicyIdİsValidButRecordNotFoundİnOurDatabase()
        {
            result.IsSuccess().Should().BeFalse();
            result.IsFail().Should().BeTrue();
            result.GetException().Should().NotBeNull();
            result.GetData().Should().BeNull();
        }

        [When(@"We pass valid page and pageSize take method on EmegenlerPolicyRepository")]
        public void WhenWePassValidPageAndPageSizeTakeMethodOnEmegenlerPolicyRepository()
        {
            results = repo.Take(1, 1);
        }

        [Then(@"Take method should return List of EmegenlerPolicy entites from EmegenlerPolicyRepository")]
        public void ThenTakeMethodShouldReturnListOfEmegenlerPolicyEntitesFromEmegenlerPolicyRepository()
        {
            results.IsSuccess().Should().BeTrue();
            results.GetData().Count().Should().BeGreaterThan(0);

        }


        [When(@"We pass valid page attirubute but pageSize attirubute value is zero on EmegenlerPolicyRepository's Take method")]
        public void WhenWePassValidPageAttirubuteButPageSizeAttirubuteValueİsZeroOnEmegenlerPolicyRepositorySTakeMethod()
        {
            results = repo.Take(1, 0);
        }

        [Then(@"Take method should return fail status and should return Exception on zero value with pageSize attiribute from EmegenlerPolicyRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnZeroValueWithPageSizeAttiributeFromEmegenlerPolicyRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }

        [When(@"We pass valid page attiribute but pageSize attirubute value is negative on EmegenlerPolicyRepository's Take method")]
        public void WhenWePassValidPageAttiributeButPageSizeAttirubuteValueİsNegativeOnEmegenlerPolicyRepositorySTakeMethod()
        {
            results = repo.Take(1, -1);
        }

        [Then(@"Take method should return fail status and should return Exception on negative value with pageSize attirubute from EmegenlerPolicyRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnNegativeValueWithPageSizeAttirubuteFromEmegenlerPolicyRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }

        [When(@"We pass valid pageSize attirubute but page attirubute value is zero on EmegenlerPolicyRepository's Take method")]
        public void WhenWePassValidPageSizeAttirubuteButPageAttirubuteValueİsZeroOnEmegenlerPolicyRepositorySTakeMethod()
        {
            results = repo.Take(0, 1);
        }

        [Then(@"Take method should return fail status and should return Exception on zero value with page attiribute from EmegenlerPolicyRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnZeroValueWithPageAttiributeFromEmegenlerPolicyRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }

        [When(@"We pass valid pageSize attiribute but page attirubute value is negative on EmegenlerPolicyRepository's Take method")]
        public void WhenWePassValidPageSizeAttiributeButPageAttirubuteValueİsNegativeOnEmegenlerPolicyRepositorySTakeMethod()
        {
            results = repo.Take(-1, 1);
        }

        [Then(@"Take method should return fail status and should return Exception on negative value with page attirubute from EmegenlerPolicyRepository")]
        public void ThenTakeMethodShouldReturnFailStatusAndShouldReturnExceptionOnNegativeValueWithPageAttirubuteFromEmegenlerPolicyRepository()
        {
            results.IsSuccess().Should().BeFalse();
            results.IsFail().Should().BeTrue();
            results.GetException().Should().NotBeNull();
            results.GetData().Should().BeNull();
        }




    }
}
