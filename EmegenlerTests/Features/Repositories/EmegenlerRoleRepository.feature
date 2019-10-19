Feature: EmegenlerRoleRepository
	This repo should do listed operations
	Insert(Add,Edit) This will be the same method. If we send entity with id method update entity, if we send without id method should add entity to db
	Get We have to get spesific EmegenlerRole entity from db
	Take We should get list of EmegenlerRole entities from db
	Delete We should remove entity with spesific id

@NormalCase-Insert
Scenario: With using Insert method we can be add new EmegenlerRole to db
When We pass new EmegenlerRole entity to our Insert method with zero id on entity
Then Insert method should add new EmegenlerRole entity to db return with success and new EmegenlerRole entity
@NormalCase-Insert
Scenario: With using Insert method we can update our exist EmegenlerRole entity
When We pass EmegenlerRole entity with non zero id to our Insert method
Then Insert method should edit EmegenlerRole and save to db after that should return success with updated EmegenlerRole entity

@ExceptionalCase-Insert
Scenario: If we pass null value to our Insert method, method should throw NullReferenceException
When We pass null value to Insert method without EmegenlerRole entity
Then Insert method should throw NullReferenceException without EmegenlerRole on Returner