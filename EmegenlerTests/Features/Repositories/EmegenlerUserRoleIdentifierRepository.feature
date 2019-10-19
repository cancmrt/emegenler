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
