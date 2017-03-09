# Project Structure Overview
The folder structure of the solution is based on the folder structure of the official [Microsoft documentation](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference#folder-structure).

The `wwwroot` folder is the place where all the magic happens. Place each function within a separate sub folder, where the sub folder name will become the function name. Each folder must contain the `function.json` configuration file an a place holder `run.csx` file. We do not need to write code in the `run.csx` file because we are going to write our code within real c# classes.

The template contains an example for an `HttpTrigger` function. Feel free to extend your personal function at will. The only thing you have to take care of is that your method signature must match the required method signature of the function as it is configured within the Azure portal. 
