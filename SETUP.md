# Getting your project up and running using this template

## Create a new repo
- In github, create a new repo.
- Select this repo as the template if you have the option to do so. If not, click Import a Repository.
- Do not add a readme, .gitignore file or license as these are in the template already.

## Rename project and project files
The solution, project, namespace and appropriate files are all called **LanguageLab.NewClassLib** something. 
You'll need to change those to match your project name.

- Clone the new repo to your local machine
- Find *LanguageLab.NewClassLib* in all files and replace it with the name of your project.
- Rename the following files and directories
  - src\LanguageLab.NewClassLib
  - src\LanguageLab.NewClassLib.csproj
  - tests\LanguageLab.NewClassLib.Tests
  - tests\LanguageLab.NewClassLib.Tests.csproj
  - LanguageLab.NewClassLib.sln

## Restore packages and test tasks
- Restore all nuget packages to the project with `dotnet restore`.
- Check the project builds and tests correctly with `dotnet build` and `dotnet test`.
- Open **tasks.json** and update the path to the ReportGenerator dll in the *test report* task.
- Run the **test report** task and check the report is generated in the *coverage* folder.
- Run the **build release package** task and check a new nuget package is generated in the *nuget* folder.

## Optional : Enable code coverage
Test coverage is enabled with 
- the *.NET Core Test Explorer* and *Coverage Gutters* plugins for VS Code 
- the *ReportGenerator* and *Coverlet* nuget packages
- Install and enable both plugins. 
- Make sure that the test path hints in .vscode\settings.json point to valid directories
- In VS Code, click Enable Watch at bottom of IDE to switch Coverage Gutters on. You'll now see red \ amber \ green gutters to the side of the source code that has been run by any test in the test project.

## Optional : Set up nuget packages on github
Additional LanguageLab code packages are available via Nuget on Github Packages. If you need to set up github packages to act as nuget server:

1. [Create an access token on github for the package repository.](https://help.github.com/en/github/authenticating-to-github/creating-a-personal-access-token-for-the-command-line#creating-a-token)

2. Copy the ClearTextPassword and add it and your github account name to the command below to create an entry for the github package repo in your global nuget.config, `nuget sources add -name "github" -Source https://nuget.pkg.github.com/<GITHUB_ACCOUNT>/index.json -Username <GITHUB_USER> -Password <TOKEN>`

See https://help.github.com/en/github/managing-packages-with-github-packages/configuring-dotnet-cli-for-use-with-github-packages for full details

### Pulling packages from github packages
If you've set things up correctly, simply add a package to your csproj file as you would any other nuget package and run dotnet restore. If nuget is set up correctly it will check the github package repo for your packages after the main nuget server.

### Pushing packages to github packages
With nuget.config configured correctly, push them to github with

`dotnet nuget push "nuget/[PACKAGENAME].nupkg" --source "github"`

or failing that 

`curl -vX PUT -u "<GITHUB_USER>:<TOKEN>" -F package=@[PACKAGENAME].x.y.z.nupkg https://nuget.pkg.github.com/<GITHUB_ACCOUNT>/`

will work