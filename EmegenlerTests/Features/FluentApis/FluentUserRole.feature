Feature: FluentUserRole
	This interface should easliy asssing user to role or should do vice versa
	Should Get UserRole entity with loaded Update and Delete functionality
	Should Take List of UserRole entites wih Loaded Update and Delete functionality to each one

@AssociateUser-NormalCase
Scenario: api.UserRole.AssociateUser(identifier).ToRole(identifier) method interface should add new relation beetween user identifier and role identifier
	When We pass valid AssociateUser(identifier) and ToRole(identifier) to FLuentUserRole api
	Then FluentUserRole api should not throw exception on valid AssociateUser(identifier) and ToRole(identifier) passage on method
@AssociateRole-NormalCase
Scenario: api.UserRole.AssociateRole(identifier).ToUser(identifier) method interface should add new relation beetween user identifier and role identifier
	When We pass valid AssociateRole(identifier) and ToUser(identifier) to FLuentUserRole api
	Then FluentUserRole api should not throw exception on valid AssociateRole(identifier) and ToUser(identifier) passage on method

@AssociateUser-ExceptionalCase
Scenario: api.UserRole.AssociateUser(Empty).ToRole(identifier) method interface should throw exception
	When We pass not valid AssociateUser(Empty) and valid ToRole(identifier) to FluentUserRoleApi
	Then FluentUserRole api should throw exception on not valid AssociateUser(Empty) and ToRole(identifier) passage on method
@AssociateUser-ExceptionalCase
Scenario: api.UserRole.AssociateUser(null).ToRole(identifier) method interface should throw exception
	When We pass not valid AssociateUser(null) and valid ToRole(identifier) to FluentUserRoleApi
	Then FluentUserRole api should throw exception on not valid AssociateUser(null) and ToRole(identifier) passage on method

@AssociateUser-ExceptionalCase
Scenario: api.UserRole.AssociateUser(identifier).ToRole(Empty) method interface should throw exception
	When We pass not valid AssociateUser(identifier) and valid ToRole(Empty) to FluentUserRoleApi
	Then FluentUserRole api should throw exception on not valid AssociateUser(identifier) and ToRole(Empty) passage on method
@AssociateUser-ExceptionalCase
Scenario: api.UserRole.AssociateUser(identifier).ToRole(null) method interface should throw exception
	When We pass not valid AssociateUser(identifier) and valid ToRole(null) to FluentUserRoleApi
	Then FluentUserRole api should throw exception on not valid AssociateUser(identifier) and ToRole(null) passage on method


@AssociateRole-ExceptionalCase
Scenario: api.UserRole.AssociateRole(Empty).ToUser(identifier) method interface should throw exception
	When We pass not valid AssociateRole(Empty) and valid ToUser(identifier) to FluentUserRoleApi
	Then FluentUserRole api should throw exception on not valid AssociateRole(Empty) and ToUser(identifier) passage on method
@AssociateRole-ExceptionalCase
Scenario: api.UserRole.AssociateRole(null).ToUser(identifier) method interface should throw exception
	When We pass not valid AssociateRole(null) and valid ToUser(identifier) to FluentUserRoleApi
	Then FluentUserRole api should throw exception on not valid AssociateRole(null) and ToUser(identifier) passage on method

@AssociateRole-ExceptionalCase
Scenario: api.UserRole.AssociateRole(identifier).ToUser(Empty) method interface should throw exception
	When We pass not valid AssociateRole(identifier) and valid ToUser(Empty) to FluentUserRoleApi
	Then FluentUserRole api should throw exception on not valid AssociateRole(identifier) and ToUser(Empty) passage on method
@AssociateRole-ExceptionalCase
Scenario: api.UserRole.AssociateRole(identifier).ToUser(null) method interface should throw exception
	When We pass not valid AssociateRole(identifier) and valid ToUser(null) to FluentUserRoleApi
	Then FluentUserRole api should throw exception on not valid AssociateRole(identifier) and ToUser(null) passage on method

@Count-NormalCase
Scenario: Count method when called return Count of UserRoleIdentifiers in EmegenlerTables from RoleInterface
	When Count method called from UserRole interface
	Then Count method should return Count of UserRoles in EmegenlerTables from UserRoleInterface