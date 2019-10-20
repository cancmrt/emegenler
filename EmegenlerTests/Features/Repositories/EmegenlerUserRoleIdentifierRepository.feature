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
