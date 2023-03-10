# Unwired Models

Open-source **Commons Features** developed to facilitate the creation of a new project in .Net, providing some commons features.

## ✨ Important
> Some names have been changed to have a U prefix. The idea is to make it easier to identify the lib's Types/Models
The old names will carry over for backwards compatibility. But in future versions they will be removed. 

- 👉 [Nuget Package](https://www.nuget.org/packages/Unwired.Models) - `nuget page`

> Something is missing? Submit a new `product feature request` using the [issues tracker](https://github.com/leandrocavalheiro/unwired.models/issues)..

## ✨ Using the library

> 👉 **Step 1** - Install library into project

- **Package Manager**

```bash
$ Install-Package Unwired.Models
```

- **.Net CLI**

```bash
$ dotnet add package Unwired.Models
```

> 👉 **Step 2** - Register Service
In program.cs, add the call for services.AddUnwiredModels. This register it's necessary for use Criptography Methods.
```bash
IHost host = Host.CreateDefaultBuilder(args)
                        .ConfigureServices(services =>
                        {
                            var configuration = services.BuildServiceProvider().GetService<IConfiguration>();
                            services.AddUnwiredModels();        
                            services.AddHostedService<Worker>();
                        })
                        .Build();
host.Run();
```

The model UnwiredAccessor will be scope registered. Use IUnwiredAccessor for Dependency Injection.

> 👉 **Step 3** - Use the Models
Complete Documentation WIP


All other existing extensions methods and those that may be added in the future will be listed on the Wiki.
## ✨ Contacts

> 📧 **Email** - leo.cavalheiro.ti@gmail.com
