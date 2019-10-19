using EmegenlerTests.FakeContext;
using FluentAssertions;
using Guard.Emegenler.DAL;
using Guard.Emegenler.Domains.Models;
using Guard.Emegenler.MethodReturner;
using Guard.Emegenler.UnitOfWork.Repositories;
using System;
using TechTalk.SpecFlow;

namespace EmegenlerTests.RepositoryTests
{
    [Binding]
    public class EmegenlerPolicyRepositorySteps
    {
        EmegenlerPolicyRepository repo;
        Returner<EmegenlerPolicy> result;
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

    }
}
