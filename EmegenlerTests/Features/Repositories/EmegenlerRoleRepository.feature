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

@NormalCase-Get
Scenario: Get Method take EmegenlerRoleId to get EmegenlerRole entity.
When We pass valid EmegenlerRoleId to Get method
Then Get method should return valid EmegenlerRole entity with result success on valid EmegenlerRoleId

@ExceptionalCase-Get
Scenario: Get method take zero as EmegenlerRoleId
When We pass zero value as EmegenlerRoleId to Get method
Then Get method should return state is fail and return Exception on EmegenlerRoleId is zero

@ExceptionalCase-Get
Scenario: Get method take negative as EmegenlerRoleId
When We pass negative value as EmegenlerRoleId to Get method
Then Get method should return state is fail and return Exception on EmegenlerRoleId is negative

@ExceptionalCase-Get
Scenario: Get method take valid EmegenlerRoleId but id record not found in our databaser
When We pass valid id value as EmegenlerRoleId to Get valid EmegenlerRoleId from Get method
Then Get method should return state is fail and return KeyNotFoundException on EmegenlerRoleId is valid but record not found in our database

@NormalCase-Take
Scenario: Take method getting page and pageSize attiribute if method take valid page and pageSize attirubute, method should return List of EmegenlerRole entities
When We pass valid page and pageSize take method on EmegenlerRoleRepository
Then Take method should return List of EmegenlerRole entites from EmegenlerRoleRepository

@ExceptionalCase-Take
Scenario: Take method getting valid page but pageSize value is zero
When We pass valid page attirubute but pageSize attirubute value is zero on EmegenlerRoleRepository's Take method
Then Take method should return fail status and should return Exception on zero value with pageSize attiribute from EmegenlerRoleRepository
@ExceptionalCase-Take
Scenario: Take method gettig valid page attiribute but pageSize attirubute is negative
When We pass valid page attiribute but pageSize attirubute value is negative on EmegenlerRoleRepository's Take method
Then Take method should return fail status and should return Exception on negative value with pageSize attirubute from EmegenlerRoleRepository

@ExceptionalCase-Take
Scenario: Take method getting valid pageSize but page value is zero
When We pass valid pageSize attirubute but page attirubute value is zero on EmegenlerRoleRepository's Take method
Then Take method should return fail status and should return Exception on zero value with page attiribute from EmegenlerRoleRepository
@ExceptionalCase-Take
Scenario: Take method gettig valid pageSize attiribute but page attirubute is negative
When We pass valid pageSize attiribute but page attirubute value is negative on EmegenlerRoleRepository's Take method
Then Take method should return fail status and should return Exception on negative value with page attirubute from EmegenlerRoleRepository

@NormalCase-Delete
Scenario: Delete method take valid EmegenlerRole entity with Id and method should return Deleted EmegenlerRole entity
When We pass valid EmegenlerRole entity with Id
Then Delete method should return succuess status and should return deleted EmegenlerRole entity
@ExceptionalCase-Delete
Scenario: Delete method take valid EmegenlerPolicy without Id
When We pass valid EmegenlerRole entity without Id to Delete method
Then Delete method should return fail status and should return Exception on EmegenlerRole entity without Id from EmegenlerRoleRepository
@ExceptionalCase-Delete
Scenario: Delete method take valid EmegenlerRole with Id value which is less than one
When We pass valid EmegenlerRole entity with Id value is equal to less than one on Delete method
Then Delete method should return fail status and should return Exception on EmegenlerRole entity with Id value is equal to less than one from EmegenlerRoleRepository
@ExceptionalCase-Delete
Scenario: Delete method take null as a parameter on Delete method 
When We pass null EmegenlerRole entity to Delete method
Then Delete method should return fail status and should return Exception on null EmegenlerRole entity from EmegenlerRoleRepository
