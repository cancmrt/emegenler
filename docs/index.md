# Welcome to Emegenler

![](https://i.ibb.co/dbm6P7f/emegenler-crop-logo.png")

## Overview

Emegenler is **RBAC(Role Base Access Control)** for Views on Asp.Net Core Mvc projects. Simply you can restrict element (html tags) based on users and groups. 
Emegenler is **flexiable**,

If you **have already users groups logic**, you can integrate that to Emegenler using Emegenler Fluent Api.

or

If you **don't have users groups logic**, you can use directly to Emegenler users group logic on Emegenler Fluent Api.

> **Please feel free that your critics, reviews or contributes, we need that for better, long live open source**

Let's get started!

## Installation

You can easily install Emegenler using Nuget

`Install-Package Emegenler -Version 1.0.0`

## Getting Started

After install Nuget package to your Mvc project. **You need to set some Configuration on Startup.cs**
First of all, you should define **data source for Emegenler** in ConfigureServices method, we define that.

> *This examples show usage on Sqlite db*

``` c#
services.AddEmegenlerToSqliteServer("Data Source=EmegenlerTryDB.db;",
                new EmegenlerOptions
                {
                    PageAccessDeniedUrl = "/home/accessdenied",
                    ComponentDefaultBehaviour = ComponentDefaultBehaviour.Hide,
                    FormDefaultBehaviour = FormDefaultBehaviour.Hide

                }
);
```

**EmegenlerOptions class parameters define default behaviors for policies**. You can change that behaviors when you are adding Emegenler to data source.

After that in Configure method on Startup.cs you should use 


```c#
app.UseEmegenler();
```

This commands achieve migration operations and inject EmegenlerMiddleware controller to our application.

Now you ready for use Emegenler in action!

## How Emegenler is Working ?

Emegenler have own User, Group and Policy relations for persistency but not need to use this User and Group relations, you can use your own system still. If you don't have User, Group system don't worry Emegenler will handle to for you.

Emegenler User-Policies Group-Policies relations determinate with Identifier. You can choose any identifier for that relations(Identifier format is string you should convert your identifier to string)

For Example if you want define a policy just inject a fluent api and write:

```c#
 API.Policy.Create().WithUser(userId.ToString()).AddForm("#form").Readonly();
```

Of course you can write that policies for your Groups:

```c#
 API.Policy.Create().WithRole(groupId.ToString()).AddForm("#form").Readonly();
```

As you see in example you can pass your user or group identifier to Emegenler system.

After define your Policies, you can get easily through from Fluent Api:

```c#
var UserPolicies = API.Policy.Take().FromUser(user.Id.ToString()).ToList();
```

Or you can get group policies too:

```c#
var GroupPolicies = API.Policy.Take().FromRole(group.GroupId.ToString()).ToList();
```

Right, you define policies and you get now what? 

Now you should put your informaion on asp.net core claims, Emegenler use two claim property for checking

- NameIdentifier => This should your user id
- UserData = > This should your Policies data

While you define Policies you should look your view and you have to decide which area restrict, a page or form or button. After choose and a element you should import Emegenler TagHelper on view:

```c#
@addTagHelper Guard.Emegenler.TagOperations.TagHelpers.*, Guard.Emegenler
```

and then just put emegenler-guard attribute to your html tag

```html
<form id="HrReportForm" emegenler-guard>
```

Emegenler will do the rest...

## Details

In Emegenler Fluent Api we have three choises for begining

- Policy
- Role
- UserRole

### #Policy

This parameter should contain all Policies actions. Policy actions is:

- Count
- Create
- Get
- Take
- TakeList



#### Policy->Count

This method should give you a Count of Policies in Emegenler system. For example you can use that method for pagination while Taking Policies as a List on system.

```c#
API.Policy.Count()
```



#### Policy->Create

This method give ability to you Create policies in system. Create method have extensions for easy creation process these are:

- **WithUser(Identifier):** This method add to chain of creation process to tell this policies should create for this user. 

  ```c#
  API.Policy.Create().WithUser(Identifier)
  ```

- **WithRole(Identifier):** This method add to chain of creation process to tell this policies should create for this role(group). 

  ```c#
  API.Policy.Create().WithRole(Identifier)
  ```

After choose identifier type, you should decide which html tag you want to restrict. Emegenler have bunch of options:

- **AddPage(Identifier):** This method block or gain access **to your restricted page**. Identifier should url of our Mvc application. You can also use ***** for restrict rest of url what ever. 

  ```c#
  API.Policy.Create().WithRole(Identifier).AddPage("/page/home")
  ```

  or

  ```c#
  API.Policy.Create().WithUser(Identifier).AddPage("/page/menu/*")
  ```

  AddPage method have two different restrict ability method:

  - ***AccessDenied():*** Give ability to denied access page in your policy 

    ```c#
    API.Policy.Create().WithUser(Identifier).AddPage("/page/menu/*").AccessDenied()
    ```

  - ***AccessGranted():*** Give ability to access page in your policy 

    ```c#
    API.Policy.Create().WithUser(Identifier).AddPage("/page/menu/*").AccessDenied()
    ```

    

- **AddComponent(Identifier):** This method block or gain access **to your div or script tags.** Identifier should be id or class definition of html tag.

  ```c#
  API.Policy.Create().WithRole(Identifier).AddComponent("#id")
  ```

  or

  ```c#
  API.Policy.Create().WithUser(Identifier).AddComponent("#id")
  ```

  AddComponent method have two different restrict ability

  - ***Hide():*** Give ability to hide div or script tag in your policy

    ```c#
    API.Policy.Create().WithRole(Identifier).AddComponent("#id").Hide()
    ```

  - ***Show():*** Give ability to show div or script tag in your policy

    ```c#
    API.Policy.Create().WithUser(Identifier).AddComponent("#id").Show()
    ```

  

- **AddForm(Identifier):** This method block or gain access to **your form tags**. Identifier should be id or class definition of html tag.

  ```c#
  API.Policy.Create().WithRole(Identifier).AddForm("#id")
  ```

  or

  ```c#
  API.Policy.Create().WithUser(Identifier).AddForm("#id")
  ```

  AddForm method have three different restrict ability

  - ***ActionGranted():*** Give ability to action(save, post, get) on form tag in your policy

    ```c#
    API.Policy.Create().WithRole(Identifier).AddForm("#id").ActionGranted()
    ```

  - ***Readony():*** Give ability to read-only inputs on form tag in your policy

    ```c#
    API.Policy.Create().WithUser(Identifier).AddForm("#id").Readonly()
    ```

  - ***Hide():*** Give ability to hide inputs on form tag in your policy

    ```c#
    API.Policy.Create().WithRole(Identifier).AddForm("#id").Hide()
    ```



- **AddInput(Identifier):** This method block or gain access **to your input tags(input, select, textarea).** Identifier should be id or class definition of html tag

  AddInput method have three different restrict ability

  - ***Editable():*** Give ability to edit on input(select textarea too..) tag in your policy

    ```c#
    API.Policy.Create().WithRole(Identifier).AddInput("#id").Editable()
    ```

  - ***Readonly():*** Give ability to read-only area on input tag in your policy

    ```c#
    API.Policy.Create().WithRole(Identifier).AddInput("#id").Readonly()
    ```

  - ***Hide():*** Give ability to hide on input tag in your policy

    ```c#
    API.Policy.Create().WithRole(Identifier).AddInput("#id").Hide()
    ```



- **AddButton(Identifier):** This method block or gain access **to your button tags.** Identifier should be id or class definition of html tag

  AddButton method have three different restrict ability

  - ***ActionGranted():*** Give ability to action(link, submit etc.) on button tag in your policy

    ```c#
    API.Policy.Create().WithRole(Identifier).AddButton("#id").ActionGranted()
    ```

  - ***Readonly():*** Give ability to read-only area on button tag in your policy

    ```c#
    API.Policy.Create().WithRole(Identifier).AddButton("#id").Readonly()
    ```

  - ***Hide():*** Give ability to hide on button tag in your policy

    ```c#
    API.Policy.Create().WithRole(Identifier).AddButton("#id").Hide()
    ```



- **AddLink(Identifier):** This method block or gain access **to your a tags.** Identifier should be id or class definition of html tag

  AddLink method have three different restrict ability

  - ***ActionGranted():*** Give ability to action(got to href) on a tag in your policy

    ```
    API.Policy.Create().WithRole(Identifier).AddLink("#id").ActionGranted()
    ```

    ***Readonly():*** Give ability to read-only area on a tag in your policy

  - ```c#
  API.Policy.Create().WithRole(Identifier).AddLink("#id").Readonly()
    ```
  
  - ***Hide():*** Give ability to hide on a tag in your policy

    ```c#
    API.Policy.Create().WithRole(Identifier).AddLink("#id").Hide()
    ```

  

#### Policy->Get

If you **want get known policy by id**, you can use Get method for that.  Get method take int Id for getting specific Policy. 

```c#
API.Policy.Get(1)
```

#### Policy->Take

Alright you create policy now y**ou should take policies by users or roles**. You can use Take method for that. Take method have two sub reflection:

- **FromRole(Identifier):** This method getting policies by specified role identifier. Method give List of Policies.

  ```c#
  API.Policy.Take().FromRole(Identifier)
  ```

- **FromUser():** This method getting policies by specified user identifier. Method give List of Policies.

  ```c#
  API.Policy.Take().FromUser(Identifier)
  ```



#### Policy->TakeList

If you **want take all policies in emegenler system**, you can use that method. TakeList method **have two parameter:**

- *Page :* This is current page of Policies
- *PageSize:* This is size of row on Page

Method give List of Policies without any restriction. 



### #Role

This parameter should contain all Role actions. Role actions is:

- Count
- Create
- Get
- Take

#### Role->Count

This method should give you a Count of Roles in Emegenler system. For example you can use that method for pagination while Taking Roles as a List on system.

```c#
API.Role.Count()
```

#### Role->Create

This method give ability to **create role in Emegenler system.** You can use this method **if you don't have any group(role) logic you own system.** If you **have already group(role) logic you don't need to use this method**, you can use own group(role) identifier on policy creation process.

```c#
API.Role.Create(Identifier)
```

#### Role->Get

If you **want get known role by id**, you can use Get method for that.  Get method take int Id for getting specific Role. 

```c#
API.Role.Get(1)
```

#### Role->Take

If you **want take all roles in emegenler system**, you can use that method. Take method **have two parameter:**

- *Page :* This is current page of Roles
- *PageSize:* This is size of row on Page

Method give List of Roles without any restriction. 



### #UserRole

This parameter should contain all User-Role relations actions. User-Role actions is:

- AssociateRole
- AssociateUser
- Count
- Get
- Take

#### UserRole->AssociateRole

If you want **associate role to user.**  You can use this method. AssociateRole method have one sub reflection:

- ToUser(Identifier): This method create relationship between role and user. 

  ```c#
  API.UserRole.AssociateRole(RoleIdentifier).ToUser(UserIdentifier)
  ```

#### UserRole->AssociateUser

If you want **associate user to role.**  You can use this method. AssociateUser method have one sub reflection:

- ToRole(Identifier): This method create relationship between user and role. 

  ```c#
  API.UserRole.AssociateUser(UserIdentifier).ToRole(RoleIdentifier)
  ```

#### UserRole->Count

This method should give you a Count of User-Role relations in Emegenler system. For example you can use that method for pagination while Taking User-Role relations as a List on system.

```c#
API.UserRole.Count()
```

#### UserRole->Get

If you **want get known user-role relation by id**, you can use Get method for that.  Get method take int Id for getting specific User-Role relations. 

```c#
API.UserRole.Get(1)
```

#### UserRole->Take

If you **want take all user-role relations in emegenler system**, you can use that method. Take method **have two parameter:**

- *Page :* This is current page of User-Roles
- *PageSize:* This is size of row on Page

Method give List of User-Roles without any restriction. 