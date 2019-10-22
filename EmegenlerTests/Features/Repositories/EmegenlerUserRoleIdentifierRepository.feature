Feature: EmegenlerUserRoleIdentifierRepository
	This repo should do listed operations
	Insert(Add,Edit) This will be the same method. If we send entity with id method update entity, if we send without id method should add entity to db
	Get We have to get spesific EmegenlerUserRoleIdentifier entity from db
	Take We should get list of EmegenlerUserRoleIdentifier entities from db
	Delete We should remove entity with spesific id

@NormalCase-Insert
Scenario: With using Insert method we can be add new EmegenlerUserRoleIdentifier to db
When We pass new EmegenlerUserRoleIdentifier entity to our Insert method with zero id on entity
Then Insert method should add new EmegenlerUserRoleIdentifier entity to db return with success and new EmegenlerRole entity
@NormalCase-Insert
Scenario: With using Insert method we can update our exist EmegenlerUserRoleIdentifier entity
When We pass EmegenlerUserRoleIdentifier entity with non zero id to our Insert method
Then Insert method should edit EmegenlerUserRoleIdentifier and save to db after that should return success with updated EmegenlerUserRoleIdentifier entity

@ExceptionalCase-Insert
Scenario: If we pass null value to our Insert method, method should throw NullReferenceException
When We pass null value to Insert method without EmegenlerUserRoleIdentifier entity
Then Insert method should throw NullReferenceException without EmegenlerUserRoleIdentifier on Returner

@NormalCase-Get
Scenario: Get Method take EmegenlerUserRoleIdentifierId to get EmegenlerUserRoleIdentifier entity.
When We pass valid EmegenlerUserRoleIdentifierId to Get method
Then Get method should return valid EmegenlerUserRoleIdentifier entity with result success on valid EmegenlerUserRoleIdentifierId

@ExceptionalCase-Get
Scenario: Get method take zero as EmegenlerUserRoleIdentifierId
When We pass zero value as EmegenlerUserRoleIdentifierId to Get method
Then Get method should return state is fail and return Exception on EmegenlerUserRoleIdentifierId is zero

@ExceptionalCase-Get
Scenario: Get method take negative as EmegenlerUserRoleIdentifierId
When We pass negative value as EmegenlerUserRoleIdentifierId to Get method
Then Get method should return state is fail and return Exception on EmegenlerUserRoleIdentifierId is negative

@ExceptionalCase-Get
Scenario: Get method take valid EmegenlerUserRoleIdentifierId but id record not found in our database
When We pass valid id value on EmegenlerUserRoleIdentifier entity to get with valid EmegenlerUserRoleIdentifierId from Get method
Then Get method should return state is fail and return KeyNotFoundException on EmegenlerUserRoleIdentifierId is valid but record not found in our database

@NormalCase-Take
Scenario: Take method getting page and pageSize attiribute if method take valid page and pageSize attirubute, method should return List of EmegenlerUserRoleIdentifier entities
When We pass valid page and pageSize take method on EmegenlerUserRoleIdentifierRepository
Then Take method should return List of EmegenlerUserRoleIdentifier entites from EmegenlerUserRoleIdentifierRepository

@ExceptionalCase-Take
Scenario: Take method getting valid page but pageSize value is zero
When We pass valid page attirubute but pageSize attirubute value is zero on EmegenlerUserRoleIdentifierRepository's Take method
Then Take method should return fail status and should return Exception on zero value with pageSize attiribute from EmegenlerUserRoleIdentifierRepository
@ExceptionalCase-Take
Scenario: Take method gettig valid page attiribute but pageSize attirubute is negative
When We pass valid page attiribute but pageSize attirubute value is negative on EmegenlerUserRoleIdentifierRepository's Take method
Then Take method should return fail status and should return Exception on negative value with pageSize attirubute from EmegenlerUserRoleIdentifierRepository

@ExceptionalCase-Take
Scenario: Take method getting valid pageSize but page value is zero
When We pass valid pageSize attirubute but page attirubute value is zero on EmegenlerUserRoleIdentifierRepository's Take method
Then Take method should return fail status and should return Exception on zero value with page attiribute from EmegenlerUserRoleIdentifierRepository
@ExceptionalCase-Take
Scenario: Take method gettig valid pageSize attiribute but page attirubute is negative
When We pass valid pageSize attiribute but page attirubute value is negative on EmegenlerUserRoleIdentifierRepository's Take method
Then Take method should return fail status and should return Exception on negative value with page attirubute from EmegenlerUserRoleIdentifierRepository

@NormalCase-Delete
Scenario: Delete method take valid EmegenlerUserRoleIdentifier entity with Id and method should return Deleted EmegenlerUserRoleIdentifier entity
When We pass valid EmegenlerUserRoleIdentifier entity with Id
Then Delete method should return succuess status and should return deleted EmegenlerUserRoleIdentifier entity
@ExceptionalCase-Delete
Scenario: Delete method take valid EmegenlerUserRoleIdentifier without Id
When We pass valid EmegenlerUserRoleIdentifier entity without Id to Delete method
Then Delete method should return fail status and should return Exception on EmegenlerUserRoleIdentifier entity without Id from EmegenlerUserRoleIdentifierRepository
@ExceptionalCase-Delete
Scenario: Delete method take valid EmegenlerUserRoleIdentifier with Id value which is less than one
When We pass valid EmegenlerUserRoleIdentifier entity with Id value is equal to less than one on Delete method
Then Delete method should return fail status and should return Exception on EmegenlerUserRoleIdentifier entity with Id value is equal to less than one from EmegenlerUserRoleIdentifierRepository
@ExceptionalCase-Delete
Scenario: Delete method take null as a parameter on Delete method 
When We pass null EmegenlerUserRoleIdentifier entity to Delete method
Then Delete method should return fail status and should return Exception on null EmegenlerUserRoleIdentifier entity from EmegenlerUserRoleIdentifierRepository

