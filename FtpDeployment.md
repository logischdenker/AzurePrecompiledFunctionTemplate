# FTP Deployment
One way (amongst many others) to get your precompiled functions up and running on Azure is to upload your source via FTP.

1. Make sure you have configured a FTP user for you function's app service
![start app service configuration](http://i.imgur.com/yT4DUkw.png)
![app service overview with FTP configuration](http://i.imgur.com/OzfIwaO.png)
If you do not have configured your FTP credentials yet you can do it here
![FTP credential configuration](http://i.imgur.com/KahurKx.png)

2. Build your solution. The build will output your dll to `wwwroot/shared`. All the dll or nuget dependencies of the template are set to `copy local = false` because they are automatically available within your Azure function app. Once you add dlls that are not available within the Azure environment automatically, make sure to set `copy local = true`. Read more details on the dependencies that are available by default [here](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference-csharp#importing-namespaces).

3. Finally upload the content of the `wwwroot` folder to `site/wwwroot` of your Azure function app service via an FTP client software of your choice.

Your function app should be up and running after the FTP upload.

At the time of writing there is an open issue regarding syncing triggers after an FTP deployment. Be sure to read https://github.com/Azure/Azure-Functions/issues/210 and follow the steps mentioned there, if you have problems in your deployment.
