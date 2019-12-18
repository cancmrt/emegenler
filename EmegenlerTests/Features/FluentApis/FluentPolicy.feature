Feature: FluentPolicy
	This class will do policy operation with fluent interface. Should create policy, edit policy, delete policy and get policy and policies with using fluent interface
	Also you can use Query interface

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Page(pageIdentifier)->AccessGranted
	When User(userIdentifier)->Page(pageIdentifier)->AccessGranted written in Query
	Then Operation done without throw exception on User(userIdentifier)->Page(pageIdentifier)->AccessGranted query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Page(pageIdentifier)->AccessDenied
	When User(userIdentifier)->Page(pageIdentifier)->AccessDenied written in Query
	Then Operation done without throw exception on User(userIdentifier)->Page(pageIdentifier)->AccessDenied query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Component(componentIdentifier)->Show
	When User(userIdentifier)->Component(componentIdentifier)->Show written in Query
	Then Operation done without throw exception on User(userIdentifier)->Component(componentIdentifier)->Show query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Component(componentIdentifier)->Hide
	When User(userIdentifier)->Component(componentIdentifier)->Hide written in Query
	Then Operation done without throw exception on User(userIdentifier)->Component(componentIdentifier)->Hide query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Form(formIdentifier)->ActionGranted
	When User(userIdentifier)->Form(formIdentifier)->ActionGranted written in Query
	Then Operation done without throw exception on User(userIdentifier)->Form(formIdentifier)->ActionGranted query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Form(formIdentifier)->Readonly
	When User(userIdentifier)->Form(formIdentifier)->Readonly written in Query
	Then Operation done without throw exception on User(userIdentifier)->Form(formIdentifier)->Readonly query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Form(formIdentifier)->Hide
	When User(userIdentifier)->Form(formIdentifier)->Hide written in Query
	Then Operation done without throw exception on User(userIdentifier)->Form(formIdentifier)->Hide query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Input(inputIdentifier)->Editable
	When User(userIdentifier)->Input(inputIdentifier)->Editable written in Query
	Then Operation done without throw exception on User(userIdentifier)->Input(inputIdentifier)->Editable query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Input(inputIdentifier)->Readonly
	When User(userIdentifier)->Input(inputIdentifier)->Readonly written in Query
	Then Operation done without throw exception on User(userIdentifier)->Input(inputIdentifier)->Readonly query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Input(inputIdentifier)->Hide
	When User(userIdentifier)->Input(inputIdentifier)->Hide written in Query
	Then Operation done without throw exception on User(userIdentifier)->Input(inputIdentifier)->Hide query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Button(buttonIdentifier)->ActionGranted
	When User(userIdentifier)->Button(buttonIdentifier)->ActionGranted written in Query
	Then Operation done without throw exception on User(userIdentifier)->Button(buttonIdentifier)->ActionGranted query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Button(buttonIdentifier)->Readonly
	When User(userIdentifier)->Button(buttonIdentifier)->Readonly written in Query
	Then Operation done without throw exception on User(userIdentifier)->Button(buttonIdentifier)->Readonly query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Button(buttonIdentifier)->Hide
	When User(userIdentifier)->Button(buttonIdentifier)->Hide written in Query
	Then Operation done without throw exception on User(userIdentifier)->Button(buttonIdentifier)->Hide query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Link(linkIdentifier)->ActionGranted
	When User(userIdentifier)->Link(linkIdentifier)->ActionGranted written in Query
	Then Operation done without throw exception on User(userIdentifier)->Link(linkIdentifier)->ActionGranted query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Link(linkIdentifier)->Readonly
	When User(userIdentifier)->Link(linkIdentifier)->Readonly written in Query
	Then Operation done without throw exception on User(userIdentifier)->Link(linkIdentifier)->Readonly query

	@Query-NormalCase
	Scenario: Create policy with Query User(userIdentifier)->Link(linkIdentifier)->Hide
	When User(userIdentifier)->Link(linkIdentifier)->Hide written in Query
	Then Operation done without throw exception on User(userIdentifier)->Link(linkIdentifier)->Hide query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Page(pageIdentifier)->AccessGranted
	When Role(roleIdentifier)->Page(pageIdentifier)->AccessGranted written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Page(pageIdentifier)->AccessGranted query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Page(pageIdentifier)->AccessDenied
	When Role(roleIdentifier)->Page(pageIdentifier)->AccessDenied written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Page(pageIdentifier)->AccessDenied query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Component(componentIdentifier)->Show
	When Role(roleIdentifier)->Component(componentIdentifier)->Show written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Component(componentIdentifier)->Show query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Component(componentIdentifier)->Hide
	When Role(roleIdentifier)->Component(componentIdentifier)->Hide written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Component(componentIdentifier)->Hide query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Form(formIdentifier)->ActionGranted
	When Role(roleIdentifier)->Form(formIdentifier)->ActionGranted written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Form(formIdentifier)->ActionGranted query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Form(formIdentifier)->Readonly
	When Role(roleIdentifier)->Form(formIdentifier)->Readonly written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Form(formIdentifier)->Readonly query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Form(formIdentifier)->Hide
	When Role(roleIdentifier)->Form(formIdentifier)->Hide written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Form(formIdentifier)->Hide query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Input(inputIdentifier)->Editable
	When Role(roleIdentifier)->Input(inputIdentifier)->Editable written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Input(inputIdentifier)->Editable query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Input(inputIdentifier)->Readonly
	When Role(roleIdentifier)->Input(inputIdentifier)->Readonly written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Input(inputIdentifier)->Readonly query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Input(inputIdentifier)->Hide
	When Role(roleIdentifier)->Input(inputIdentifier)->Hide written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Input(inputIdentifier)->Hide query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Button(buttonIdentifier)->ActionGranted
	When Role(roleIdentifier)->Button(buttonIdentifier)->ActionGranted written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Button(buttonIdentifier)->ActionGranted query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Button(buttonIdentifier)->Readonly
	When Role(roleIdentifier)->Button(buttonIdentifier)->Readonly written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Button(buttonIdentifier)->Readonly query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Button(buttonIdentifier)->Hide
	When Role(roleIdentifier)->Button(buttonIdentifier)->Hide written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Button(buttonIdentifier)->Hide query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Link(linkIdentifier)->ActionGranted
	When Role(roleIdentifier)->Link(linkIdentifier)->ActionGranted written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Link(linkIdentifier)->ActionGranted query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Link(linkIdentifier)->Readonly
	When Role(roleIdentifier)->Link(linkIdentifier)->Readonly written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Link(linkIdentifier)->Readonly query

	@Query-NormalCase
	Scenario: Create policy with Query Role(roleIdentifier)->Link(linkIdentifier)->Hide
	When Role(roleIdentifier)->Link(linkIdentifier)->Hide written in Query
	Then Operation done without throw exception on Role(roleIdentifier)->Link(linkIdentifier)->Hide query

	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to page with access granted property
	When api.Policy.Create().WithUser(userIdentifier).AddPage(typeof(FakeClass)).AccessGranted(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(userIdentifier).AddPage(typeof(FakeClass)).AccessGranted(); call

	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to page with access denied property
	When api.Policy.Create().WithUser(userIdentifier).AddPage(typeof(FakeClass)).AccessDenied(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(userIdentifier).AddPage(typeof(FakeClass)).AccessDenied(); call

	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to page with access granted property
	When api.Policy.Create().WithRole(roleIdentifier).AddPage(typeof(FakeClass)).AccessGranted(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(roleIdentifier).AddPage(typeof(FakeClass)).AccessGranted(); call

	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to page with access denied property
	When api.Policy.Create().WithRole(roleIdentifier).AddPage(typeof(FakeClass)).AccessDenied(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(roleIdentifier).AddPage(typeof(FakeClass)).AccessDenied(); call

	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to component with show property
	When api.Policy.Create().WithUser(userIdentifier).AddComponent(identifier).Show(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(userIdentifier).AddComponent(identifier).Show(); call
	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to component with hide property
	When api.Policy.Create().WithUser(userIdentifier).AddComponent(identifier).Hide(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(userIdentifier).AddComponent(identifier).Hide(); call

	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to component with show property
	When api.Policy.Create().WithRole(roleIdentifier).AddComponent(identifier).Show(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(roleIdentifier).AddComponent(identifier).Show(); call
	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to component with hide property
	When api.Policy.Create().WithRole(roleIdentifier).AddComponent(identifier).Hide(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(roleIdentifier).AddComponent(identifier).Hide(); call

	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to form with action granted property
	When api.Policy.Create().WithUser(identifier).AddForm(identifier).ActionGranted(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddForm(identifier).ActionGranted(); call
	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to form with readonly property
	When api.Policy.Create().WithUser(identifier).AddForm(identifier).Readonly(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddForm(identifier).Readonly(); call
	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to form with hide property
	When api.Policy.Create().WithUser(identifier).AddForm(identifier).Hide(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddForm(identifier).Hide(); call

	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to form with action granted property
	When api.Policy.Create().WithRole(identifier).AddForm(identifier).ActionGranted(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddForm(identifier).ActionGranted(); call
	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to form with readonly property
	When api.Policy.Create().WithRole(identifier).AddForm(identifier).Readonly(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddForm(identifier).Readonly(); call
	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to form with hide property
	When api.Policy.Create().WithRole(identifier).AddForm(identifier).Hide(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddForm(identifier).Hide(); call

	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to input with editable property
	When api.Policy.Create().WithUser(identifier).AddInput(identifier).Editable(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddInput(identifier).Editable(); call
	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to input with readonly property
	When api.Policy.Create().WithUser(identifier).AddInput(identifier).Readonly(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddInput(identifier).Readonly(); call
	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to input with hide property
	When api.Policy.Create().WithUser(identifier).AddInput(identifier).Hide(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddInput(identifier).Hide(); call

	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to to input with editable property
	When api.Policy.Create().WithRole(identifier).AddInput(identifier).Editable(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddInput(identifier).Editable(); call
	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to input with readonly property
	When api.Policy.Create().WithRole(identifier).AddInput(identifier).Readonly(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddInput(identifier).Readonly(); call
	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to input with hide property
	When api.Policy.Create().WithRole(identifier).AddInput(identifier).Hide(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddInput(identifier).Hide(); call

	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to button with action granted property
	When api.Policy.Create().WithUser(identifier).AddButton(identifier).ActionGranted(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddButton(identifier).ActionGranted(); call
	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to button with readonly property
	When api.Policy.Create().WithUser(identifier).AddButton(identifier).Readonly(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddButton(identifier).Readonly(); call
	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to button with hide property
	When api.Policy.Create().WithUser(identifier).AddButton(identifier).Hide(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddButton(identifier).Hide(); call

	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to button with action granted property
	When api.Policy.Create().WithRole(identifier).AddButton(identifier).ActionGranted(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddButton(identifier).ActionGranted(); call
	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to button with readonly property
	When api.Policy.Create().WithRole(identifier).AddButton(identifier).Readonly(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddButton(identifier).Readonly(); call
	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to button with hide property
	When api.Policy.Create().WithRole(identifier).AddButton(identifier).Hide(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddButton(identifier).Hide(); call

	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to link with action granted property
	When api.Policy.Create().WithUser(identifier).AddLink(identifier).ActionGranted(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddLink(identifier).ActionGranted(); call
	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to link with readonly property
	When api.Policy.Create().WithUser(identifier).AddLink(identifier).Readonly(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddLink(identifier).Readonly(); call
	@Create-NormalCase
	Scenario: Create policy with user identifier and add policy to link with hide property
	When api.Policy.Create().WithUser(identifier).AddLink(identifier).Hide(); called
	Then Operation done without throw exception on api.Policy.Create().WithUser(identifier).AddLink(identifier).Hide(); call

	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to link with action granted property
	When api.Policy.Create().WithRole(identifier).AddLink(identifier).ActionGranted(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddLink(identifier).ActionGranted(); call
	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to link with readonly property
	When api.Policy.Create().WithRole(identifier).AddLink(identifier).Readonly(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddLink(identifier).Readonly(); call
	@Create-NormalCase
	Scenario: Create policy with role identifier and add policy to link with hide property
	When api.Policy.Create().WithRole(identifier).AddLink(identifier).Hide(); called
	Then Operation done without throw exception on api.Policy.Create().WithRole(identifier).AddLink(identifier).Hide(); call

	 @Create-ExceptionalCase
	 Scenario: Try to create policy with empty UserIdentifier
	 When api.Policy.Create().WithUser().AddPage(typeof(FakeClass)).AccessGranted(); called on WithUser method with empty UserIdentifier prop
	 Then NullReferanceException throws by WithUser method with empty UserIdentifier prop
	 @Create-ExceptionalCase
	 Scenario: Try to create policy with null UserIdentifier
	 When api.Policy.Create().WithUser(null).AddPage(typeof(FakeClass)).AccessGranted(); called on WithUser method with null UserIdentifier prop
	 Then NullReferanceException throws by WithUser method with null UserIdentifier prop
	 @Create-ExceptionalCase
	 Scenario: Try to create policy with empty RoleIdentifier
	 When api.Policy.Create().WithRole().AddPage(typeof(FakeClass)).AccessGranted(); called on WithRole method with empty RoleIdentifier prop
	 Then NullReferanceException throws by WithRole method with empty RoleIdentifier prop
	 @Create-ExceptionalCase
	 Scenario: Try to create policy with null RoleIdentifier
	 When api.Policy.Create().WithRole(null).AddPage(typeof(FakeClass)).AccessGranted(); called on WithRole method with null RoleIdentifier prop
	 Then NullReferanceException throws by WithRole method with null RoleIdentifier prop

	 @Create-ExceptionalCase
	 Scenario: Try to create policy with null PageType
	 When api.Policy.Create().WithUser(UserIdentifier).AddPage(null).AccessGranted(); called on AddPage method with null PageType prop
	 Then NullReferanceException throws by AddPage method with null PageType prop

	 @Create-ExceptionalCase
	 Scenario: Try to create policy with empty ComponentIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddComponent().Show(); called on AddComponent method with empty ComponentIdentifier prop
	 Then NullReferanceException throws by AddComponent method with empty ComponentIdentifier prop
	 @Create-ExceptionalCase
	 Scenario: Try to create policy with null ComponentIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddComponent(null).Show(); called on AddComponent method with null ComponentIdentifier prop
	 Then NullReferanceException throws by AddComponent method with null ComponentIdentifier prop

	 @Create-ExceptionalCase
	 Scenario: Try to create policy with empty FormIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddForm().ActionGranted(); called on AddForm method with empty FormIdentifier prop
	 Then NullReferanceException throws by AddForm method with empty FormIdentifier prop
	 @Create-ExceptionalCase
	 Scenario: Try to create policy with null FormIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddForm(null).ActionGranted(); called on AddForm method with null FormIdentifier prop
	 Then NullReferanceException throws by AddForm method with null FormIdentifier prop

	 @Create-ExceptionalCase
	 Scenario: Try to create policy with empty InputIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddInput().Readonly(); called on AddInput method with empty InputIdentifier prop
	 Then NullReferanceException throws by AddInput method with empty InputIdentifier prop
	 @Create-ExceptionalCase
	 Scenario: Try to create policy with null InputIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddInput(null).Readonly(); called on AddForm method with null InputIdentifier prop
	 Then NullReferanceException throws by AddInput method with null InputIdentifier prop

	 @Create-ExceptionalCase
	 Scenario: Try to create policy with empty ButtonIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddButton().Readonly(); called on AddButton method with empty ButtonIdentifier prop
	 Then NullReferanceException throws by AddButton method with empty ButtonIdentifier prop
	 @Create-ExceptionalCase
	 Scenario: Try to create policy with null ButtonIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddButton(null).Readonly(); called on AddButton method with null ButtonIdentifier prop
	 Then NullReferanceException throws by AddButton method with null ButtonIdentifier prop

	 @Create-ExceptionalCase
	 Scenario: Try to create policy with empty LinkIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddLink().Readonly(); called on AddLink method with empty LinkIdentifier prop
	 Then NullReferanceException throws by AddLink method with empty LinkIdentifier prop
	 @Create-ExceptionalCase
	 Scenario: Try to create policy with null LinkIdentifier
	 When api.Policy.Create().WithUser(UserIdentifier).AddLink(null).Readonly(); called on AddLink method with null LinkIdentifier prop
	 Then NullReferanceException throws by AddLink method with null LinkIdentifier prop
	 @Get-NormalCase
	Scenario: Get method take valid PolicyId and method should return valid EmegelerPolicy entity
	When We pass valid PolicyId to Get method from FluentPolicy class
	Then Get method should return valid EmegelerPolicy entity from FluentPolicy class
	@Get-ExceptionalCase
	Scenario:  Get method take PolicyId with zero value and method throw exception
	When We pass PolicyId with zero value to Get method from FluentPolicy class
	Then Get method should throw exception on PolicyId with zero value
	@Get-ExceptionalCase
	Scenario:  Get method take PolicyId with negative value and method throw exception
	When We pass PolicyId with negative value to Get method from FluentPolicy class
	Then Get method should throw exception on PolicyId with negative value

	@Take-NormalCase
	Scenario: Take method take valid Page and PageSize prop and method should return List of Policies
	When We pass valid Page and PageSize prop on Take method from FluentPolicy class
	Then Take method should return List of EmegelerPolicy entites from FluentPolicy class
	@Take-ExceptionalCase
	Scenario: Take method take valid Page but PageSize is less than one
	When We pass valid Page prop but PageSize value is less than one to Take method from FluentPolicy class
	Then Take method should throw exception on when PageSize value is less than one from FluentPolicy class
	@Take-ExceptionalCase
	Scenario: Take method take valid PageSize but Page is less than one
	When We pass valid PageSize prop but Page value is less than one to Take method from FluentPolicy class
	Then Take method should throw exception on when Page value is less than one from FluentPolicy class

	@Count-NormalCase
	Scenario: Count method when called return Count of Policies in EmegenlerTables from PolicyInterface
	When Count method called from Pplicy interface
	Then Count method should return Count of Policies in EmegenlerTables from PolicyInterface

	@Take.FromUser-NormalCase
	Scenario: api.Policy().Take().FromUser(identifier) method should get List of Policies belong to User
	When We pass valid identifier api.Policy().Take().FromUser(identifier) method
	Then api.Policy().Take().FromUser(identifier) should return List of Policies belong to User

	@Take.FromRole-NormalCase
	Scenario: api.Policy().Take().FromRole(identifier) method should get List of Policies belong to Role
	When We pass valid identifier api.Policy().Take().FromRole(identifier) method
	Then api.Policy().Take().FromRole(identifier) should return List of Policies belong to Role

	@Take.FromUser-ExceptionalCase
	Scenario: api.Policy().Take().FromUser(Empty) method should throw exception
	When We pass Empty value as User identifier to api.Policy().Take().FromUser(Empty) method
	Then api.Policy().Take().FromUser(Empty) method should throw exception

	@Take.FromUser-ExceptionalCase
	Scenario: api.Policy().Take().FromUser(null) method should throw exception
	When We pass Null value as User identifier to api.Policy().Take().FromUser(null) method
	Then api.Policy().Take().FromUser(null) method should throw exception

	@Take.FromRole-ExceptionalCase
	Scenario: api.Policy().Take().FromRole(Empty) method should throw exception
	When We pass Empty value as Role identifier to api.Policy().Take().FromRole(Empty) method
	Then api.Policy().Take().FromRole(Empty) method should throw exception

	@Take.FromRole-ExceptionalCase
	Scenario: api.Policy().Take().FromRole(null) method should throw exception
	When We pass Null value as Role identifier to api.Policy().Take().FromRole(null) method
	Then api.Policy().Take().FromRole(null) method should throw exception
	 