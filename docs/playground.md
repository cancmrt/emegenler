# Playground

Playground purpose see Emegenler usage on working example and also real project example for usage Emegenler. 

You can access project code in here
http://www.burayaadresgelecek.com

If you wanna see Emegenler in action, you have 2 option.

1. Build and Run manually.
2. Pull Docker Image and Run.

### Build and Run manually

Clone project in here http://www.burayaadresgelecek.com

After that go inside of clone folder.

```
dotnet restore
```

```
dotnet build
```

```
dotnet run
```

Open http://localhost:5000

### Pull Docker Image and Run

If you have docker you can easily pull image and run that image:

```
docker run -p 9090:80 cancmrt/emegenler_mvc_playground:1.0.0
```

Open http://localhost:9090