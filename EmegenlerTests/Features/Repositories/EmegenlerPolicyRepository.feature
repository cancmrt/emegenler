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
