# Welcome to Emegenler

![](https://i.ibb.co/dbm6P7f/emegenler-crop-logo.png")

## Overview

Emegenler is **RBAC(Role Base Access Control)** for Views on Asp.Net Core Mvc projects. Simply you can restrict element (html tags) based on users and groups. 
Emegenler is **flexiable**,

If you **have already users groups logic**, you can integrate that to Emegenler using Emegenler Fluent Api.

or

If you **don't have users groups logic**, you can use directly to Emegenler users group logic on Emegenler Fluent Api

Let's get started!

## Installation

You can easily install Emegenler using Nuget

`Nuget package install command here`

## Getting Started

After install Nuget package to your Mvc project. **You need to set some Configuration on Startup.cs**
First of all, you should define **data source for Emegenler**, in ConfigureServices method we define that.

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

This commands achieve migration operations and inject EmegenlerMiddleware controller to out application.

Now you ready for use Emegenler in action!