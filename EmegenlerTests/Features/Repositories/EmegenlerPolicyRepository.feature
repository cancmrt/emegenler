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