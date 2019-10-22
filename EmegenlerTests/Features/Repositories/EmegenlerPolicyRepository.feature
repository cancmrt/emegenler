Feature: EmegenlerPolicyRepository
	This repo should do listed operations
	Insert(Add,Edit) This difference based on id if you send entity with id to function this will update entity. If you don't have id this will add entity to db
	Get => We have to get spesific EmegenerPolicy with id
	Take => We can be get listed policies on database with using page and pageSize
	Delete We can be delete spesific ElemgenlerPolicy with id


@NormalCase-Insert
Scenario: With using Insert method we can be add new EmegenlerPolicy to db
When We pass new EmegenlerPolicy entity to our Insert method with zero id on entity
Then Insert method should add new EmegenlerPolicy entity to db return with success and new EmegenlerPolicy entity
@NormalCase-Insert
Scenario: With using Insert method we can update our exist EmegenlerPolicy entity
When We pass EmegenlerPolicy entity with non zero id to our Insert method
Then Insert method should edit EmegenlerPolicy and save to db after that should return success with updated EmegenlerPolicy entity

@ExceptionalCase-Insert
Scenario: If we pass null value to our Insert method, method should throw NullReferenceException
When We pass null value to Insert method
Then Insert method should throw NullReferenceException

@NormalCase-Get
Scenario: Get Method take EmegenlerPolicyId to get EmegenlerPolicy entity.
When We pass valid EmegenlerPolicyId to Get method
Then Get method should return valid EmegenlerPolicy entity with result success on valid EmegenlerPolicyId

@ExceptionalCase-Get
Scenario: Get method take zero as EmegenlerPolicyId
When We pass zero value as EmegenlerPolicyId to Get method
Then Get method should return state is fail and return Exception on EmegenlerPolicyId is zero

@ExceptionalCase-Get
Scenario: Get method take negative as EmegenlerPolicyId
When We pass negative value as EmegenlerPolicyId to Get method
Then Get method should return state is fail and return Exception on EmegenlerPolicyId is negative

@ExceptionalCase-Get
Scenario: Get method take valid EmegenlerPolicyId but id record not found in our databaser
When We pass valid id value as EmegenlerPolicyId to Get valid EmegenlerPolicyId from Get method
Then Get method should return state is fail and return KeyNotFoundException on EmegenlerPolicyId is valid but record not found in our database

@NormalCase-Take
Scenario: Take method getting page and pageSize attiribute if method take valid page and pageSize attirubute, method should return List of EmegenlerPoliciy entities
When We pass valid page and pageSize take method on EmegenlerPolicyRepository
Then Take method should return List of EmegenlerPolicy entites from EmegenlerPolicyRepository

@ExceptionalCase-Take
Scenario: Take method getting valid page but pageSize value is zero
When We pass valid page attirubute but pageSize attirubute value is zero on EmegenlerPolicyRepository's Take method
Then Take method should return fail status and should return Exception on zero value with pageSize attiribute from EmegenlerPolicyRepository
@ExceptionalCase-Take
Scenario: Take method gettig valid page attiribute but pageSize attirubute is negative
When We pass valid page attiribute but pageSize attirubute value is negative on EmegenlerPolicyRepository's Take method
Then Take method should return fail status and should return Exception on negative value with pageSize attirubute from EmegenlerPolicyRepository

@ExceptionalCase-Take
Scenario: Take method getting valid pageSize but page value is zero
When We pass valid pageSize attirubute but page attirubute value is zero on EmegenlerPolicyRepository's Take method
Then Take method should return fail status and should return Exception on zero value with page attiribute from EmegenlerPolicyRepository
@ExceptionalCase-Take
Scenario: Take method gettig valid pageSize attiribute but page attirubute is negative
When We pass valid pageSize attiribute but page attirubute value is negative on EmegenlerPolicyRepository's Take method
Then Take method should return fail status and should return Exception on negative value with page attirubute from EmegenlerPolicyRepository

@NormalCase-Delete
Scenario: Delete method take valid EmegenlerPolicy entity with Id and method should return Deleted EmegenlerPolicy entity
When We pass valid EmegenlerPolicy entity with Id
Then Delete method should return succuess status and should return deleted EmegenlerPolicy entity
@ExceptionalCase-Delete
Scenario: Delete method take valid EmegenlerPolicy without Id
When We pass valid EmegenlerPolicy entity without Id to Delete method
Then Delete method should return fail status and should return Exception on EmegenlerPolicy entity without Id from EmegenlerPolicyRepository
@ExceptionalCase-Delete
Scenario: Delete method take valid EmegenlerPolicy with Id value which is less than one
When We pass valid EmegenlerPolicy entity with Id value is equal to less than one on Delete method
Then Delete method should return fail status and should return Exception on EmegenlerPolicy entity with Id value is equal to less than one from EmegenlerPolicyRepository
@ExceptionalCase-Delete
Scenario: Delete method take null as a parameter on Delete method 
When We pass null EmegenlerPolicy entity to Delete method
Then Delete method should return fail status and should return Exception on null EmegenlerPolicy entity from EmegenlerPolicyRepository


