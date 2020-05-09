# LanguageLab.NewClassLibTemplate
This repository provides an easy template for creating a new github repo for a test-driven, C# .NET Standard class library. 
Go to [setup.md](SETUP.md) for instructions on how to get your project running once you have copied ths template.
If you are looking to create a command line app project, please use [LanguageLab.NewCmdLineAppTemplate](https://github.com/mahardan-oup/LanguageLab.NewCmdLineAppTemplate) instead.

This template has the features listed below. 

## Projects
- LanguageLab.NewClassLib is a C# 8.0, .NET Standard 2.1 class library project
- LanguageLab.NewClassLib.Tests is a C# 8.0, .NET Core 3.1, xUnit test project, targetting NewClassLib

## Documentation
- On build an XML documentation file is generated in the *docs* folder

## Code standards
- Code in both projects is checked on build against FxCop and StyleCop Analysers. These will generate warnings if code formatting does not meet standards.- Code in the test project is also checked by xunit analysers
- The two ruleset files in the root directory customise the Analysers.

## MSBuild tasks
tasks.json define five specific processes for the solution. Run them through VS Code or Visual Studio.
-  **build** is a straightforward debug build of both projects
-  **build release package** runs a release build of the class library, packages it into a nuget folder and saves it in the *nuget* folder.  
- **watch** runs dotnet watch. For use with test coverage
- **test** builds and runs the test project against Classlib, creating coverage stats for the tests and saving those stats in the *coverage* folder as lcov.info.
- **test report** runs the *test* task and then generates an easy to read test coverage report which can be accessed at *coverage\report\index.htm*

## Dependencies
This template uses following nuget packages
- *Microsoft.CodeAnalysis.FxCopAnalyzers*, *StyleCop.Analyzers* for code quality
- *Microsoft.NET.Test.Sdk*, *xunit*, *xunit.runner.visualstudio*, *xunit.analyzers*, *coverlet.msbuild*, *ReportGenerator*  for testing and code coverage in the tests project

## Folder structure
The template has the following structure
- **.vscode** contains basic build tasks
- **coverage** contains auto-generated code coverage files and reports. 
- **docs** contains auto-generated XML documentation files
- **lib** should contain any reference files for your project
- **nuget** contains auto-generated nuget packages for uploading to github packages \ local nuget server
- **src** is your source code projects folder
- **tests** is your test projects folder
- **.gitignore** is a copy of the [Visual Studio gitignore file](https://github.com/github/gitignore/blob/master/VisualStudio.gitignore) with Visual Studio Code additions and additional entries to ignore the contents of the *coverage*, *docs* and *nuget* folders.
- The two ruleset files govern some of the more over the top coding standards in the analysers. 