# AzurePrecompiledFunctionTemplate
This repository contains a Visual Studio 2017 solution (c#) that can be used as a template to get you started with Microsoft Azure precompiled functions.

## Why use precompiled functions?
At the time of writing Azure functions do not have unit testing possibilities and support for Intellisense as we love it within Visual Studio is lacking also. 

With precompiled functions you can benefit from all the productivity stuff that is available within your Visual Studio IDE (including unit testing and Intellisense).

## Template contents
The Visual Studio solution contains two projects. First there is the "AzurePrecompiledFunctionTemplate.csproj" with the actual source code and there is also a MSTest V2 "AzurePrecompiledFunctionTemplateTest.csproj" test project for you to get started. Read https://github.com/logischdenker/AzurePrecompiledFunctionTemplate/blob/master/AzurePrecompiledFunctionTemplate/Overview.md to get a better understanding of the project structure.

## How to get started
1. Create a new Azure Function App within the Azure portal
2. Upload the needed files to your Azure Function App. There are many ways to do this -> here is one
3. Test if everything works via the Azure portal
4. Start coding you own precompiled function...
