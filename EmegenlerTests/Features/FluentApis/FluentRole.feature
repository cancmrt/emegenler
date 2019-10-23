Feature: FluentRole
	This interface should do:
	Create Role in Emegenler
	Get Role in Emegenler
	Take Role in Emegenler

@Create-NormalCase
Scenario: Create method take valid RoleIdentifier and method should finish without exception
	When We pass valid RoleIdentifier to Create method from FluentRole class
	Then Create method should finish without exception on FluentRole class
@Create-ExceptionalCase
Scenario: Create method take empty RoleIdentifier method should throw exception
	When We pass empty RoleIdentifier to Create method from FluentRole class
	Then Create method should throw exception on empty RoleIdentifier from FluentRole class
@Create-ExceptionalCase
Scenario: Create method take null RoleIdentifier method should throw exception
	When We pass null RoleIdentifier to Create method from FluentRole class
	Then Create method should throw exception on null RoleIdentifier from FluentRole class
@Get-NormalCase
Scenario: Get method take valid RoleId and method should return valid EmegenlerRole entity
	When We pass valid RoleId to Get method from FluentRole class
	Then Get method should return valid EmegelerRole entity from FluentRole class
@Get-ExceptionalCase
Scenario:  Get method take RoleId with zero value and method throw exception
	When We pass RoleId with zero value to Get method from FluentRole class
	Then Get method should throw exception on RoleId with zero value
@Get-ExceptionalCase
Scenario:  Get method take RoleId with negative value and method throw exception
	When We pass RoleId with negative value to Get method from FluentRole class
	Then Get method should throw exception on RoleId with negative value
@Take-NormalCase
Scenario: Take method take valid Page and PageSize prop and method should return List of Roles
	When We pass valid Page and PageSize prop on Take method from FluentRole class
	Then Take method should return List of EmegenlerRole entites from FluentRole class
@Take-ExceptionalCase
Scenario: Take method take valid Page but PageSize is less than one
	When We pass valid Page prop but PageSize value is less than one to Take method from FluenRole class
	Then Take method should throw exception on when PageSize value is less than one from FluentRole class
@Take-ExceptionalCase
Scenario: Take method take valid PageSize but Page is less than one
	When We pass valid PageSize prop but Page value is less than one to Take method from FluenRole class
	Then Take method should throw exception on when Page value is less than one from FluentRole class
