nuget
==========

Your classes are packaged up into this directory with the package task, ready for upload to Github Packages.

Setting up nuget
================

[Create an access token on github for the package repository.](https://help.github.com/en/github/authenticating-to-github/creating-a-personal-access-token-for-the-command-line#creating-a-token)

Copy the ClearTextPassword and add it and your user name to the command below to create an entry for the github package repo in your global nuget.config file which you will find at C:\Users\<YOUR_WINDOWS_USERNAME>\AppData\Roaming\NuGet

`nuget sources add -name "github" -Source https://nuget.pkg.github.com/<GITHUB_ACCOUNT>/index.json -Username <GITHUB_USER> -Password <TOKEN>`

See https://help.github.com/en/github/managing-packages-with-github-packages/configuring-dotnet-cli-for-use-with-github-packages for full details

Pushing packages to github
==========================

With nuget.config configured correctly, push them to github with

`dotnet nuget push "nuget/[PACKAGENAME].nupkg" --source "github"`

or failing that 

`curl -vX PUT -u "<GITHUB_USER>:<TOKEN>" -F package=@[PACKAGENAME].x.y.z.nupkg https://nuget.pkg.github.com/<GITHUB_ACCOUNT>/`

will work
