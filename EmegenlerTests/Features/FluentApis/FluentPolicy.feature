Feature: FluentPolicy
	This class will do policy operation with fluent interface. Should create policy, edit policy, delete policy and get policy and policies with using fluent interface

	 @Create
	 Scenario: Try to create policy with empty UserIdentifier
	 When api.Policy.Create().WithUser().AddPage(typeof(FakeClass)).AccessGranted(); called on WithUser method with empty UserIdentifier prop
	 Then NullReferanceException throws by WithUser method with empty UserIdentifier prop
	 @Create
	 Scenario: Try to create policy with null UserIdentifier
	 When api.Policy.Create().WithUser(null).AddPage(typeof(FakeClass)).AccessGranted(); called on WithUser method with null UserIdentifier prop
	 Then NullReferanceException throws by WithUser method with null UserIdentifier prop
	 @Create
	 Scenario: Try to create policy with empty RoleIdentifier
	 When api.Policy.Create().WithRole().AddPage(typeof(FakeClass)).AccessGranted(); called on WithRole method with empty RoleIdentifier prop
	 Then NullReferanceException throws by WithRole method with empty RoleIdentifier prop
	 @Create
	 Scenario: Try to create policy with null RoleIdentifier
	 When api.Policy.Create().WithRole(null).AddPage(typeof(FakeClass)).AccessGranted(); called on WithRole method with null RoleIdentifier prop
	 Then NullReferanceException throws by WithRole method with empty RoleIdentifier prop

	 @Create
	 Scenario: Try to create policy with null PageType
	 When api.Policy.Create().WithUser(UserIdentifier).AddPage(null).AccessGranted(); called on AddPage method with null PageType prop
	 Then NullReferanceException throws by AddPage method with null PageType prop

	 @Create
	 Scenario: Try to create policy with empty ComponentIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddComponent().Show(); called on AddComponent method with empty ComponentIdentifier prop
	 Then NullReferanceException throws by AddComponent method with empty ComponentIdentifier prop
	 @Create
	 Scenario: Try to create policy with null ComponentIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddComponent(null).Show(); called on AddComponent method with null ComponentIdentifier prop
	 Then NullReferanceException throws by AddComponent method with null ComponentIdentifier prop

	 @Create
	 Scenario: Try to create policy with empty FormIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddForm().ActionGranted(); called on AddForm method with empty FormIdentifier prop
	 Then NullReferanceException throws by AddForm method with empty FormIdentifier prop
	 @Create
	 Scenario: Try to create policy with null FormIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddForm(null).ActionGranted(); called on AddForm method with null FormIdentifier prop
	 Then NullReferanceException throws by AddForm method with null FormIdentifier prop

	 @Create
	 Scenario: Try to create policy with empty InputIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddInput().Readonly(); called on AddInput method with empty InputIdentifier prop
	 Then NullReferanceException throws by AddInput method with empty InputIdentifier prop
	 @Create
	 Scenario: Try to create policy with null InputIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddInput(null).Readonly(); called on AddForm method with null InputIdentifier prop
	 Then NullReferanceException throws by AddInput method with null InputIdentifier prop

	 @Create
	 Scenario: Try to create policy with empty ButtonIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddButton().Readonly(); called on AddButton method with empty ButtonIdentifier prop
	 Then NullReferanceException throws by AddButton method with empty ButtonIdentifier prop
	 @Create
	 Scenario: Try to create policy with null ButtonIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddButton(null).Readonly(); called on AddButton method with null ButtonIdentifier prop
	 Then NullReferanceException throws by AddButton method with null ButtonIdentifier prop

	 @Create
	 Scenario: Try to create policy with empty LinkIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddLink().Readonly(); called on AddLink method with empty LinkIdentifier prop
	 Then NullReferanceException throws by AddLink method with empty LinkIdentifier prop
	 @Create
	 Scenario: Try to create policy with null LinkIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddLink(null).Readonly(); called on AddLink method with null LinkIdentifier prop
	 Then NullReferanceException throws by AddLink method with null LinkIdentifier prop
	 