# AzurePrecompiledFunctionTemplate
This repository contains a Visual Studio 2017 solution (c#) that can be used as a template to get you started with Microsoft Azure precompiled functions.

The solution is intendet to be used as starting point for more complex and complete function apps. It may seem like overkill for just a single function within a function app but it's real benefit comes up with function apps that contain 10, 20 or more functions...

## Why use precompiled functions?
At the time of writing (March 2017) Azure functions do not have unit testing possibilities and support for Intellisense as we love it within Visual Studio is lacking also. 

With precompiled functions you can benefit from all the productivity stuff that is available within your Visual Studio IDE (including unit testing and Intellisense).

## Template contents
The Visual Studio solution contains two projects. First there is the "AzurePrecompiledFunctionTemplate.csproj" with the actual source code and there is also a MSTest V2 "AzurePrecompiledFunctionTemplateTest.csproj" test project for you to get started. Read the [overview](https://github.com/logischdenker/AzurePrecompiledFunctionTemplate/blob/master/AzurePrecompiledFunctionTemplate/Overview.md) to get a better understanding of the project structure.

## How to get started
1. Create a new Azure Function App within the Azure portal
2. Upload the needed files to your Azure Function App. There are many ways to do this -> here is one via [FTP upload](https://github.com/logischdenker/AzurePrecompiledFunctionTemplate/blob/master/FtpDeployment.md)
3. Test if everything works via the Azure portal
4. Start coding your own precompiled function...

A note on automated triggers: They will not run continuously unless you make sure that your function app is "always on"! [Read the documentation about this issue.](https://github.com/Azure/Azure-Functions/wiki/Enable-Always-On-when-running-on-dedicated-App-Service-Plan)

## How to contribute
Clone the repository and work with it. If you find it helpful and want to contribute to make this template solution even more helpful for others, please feel free to create pull requests. I'd be more than happy to get you involved!
