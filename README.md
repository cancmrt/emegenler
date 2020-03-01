[![Build Status](https://travis-ci.com/cancmrt/emegenler.svg?branch=master)](https://travis-ci.com/cancmrt/emegenler)
[![Build Status](https://dev.azure.com/can1908/github/_apis/build/status/github-.NET%20Core%20with%20SonarCloud-CI%20(1)?branchName=master&jobName=Agent%20job%201)](https://dev.azure.com/can1908/github/_build/latest?definitionId=3&branchName=master)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=cancmrt_emegenler&metric=alert_status)](https://sonarcloud.io/dashboard?id=cancmrt_emegenler)

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