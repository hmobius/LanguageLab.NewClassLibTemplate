nuget
==========

Your classes are packaged up into this directory with the package task, ready for upload to Github Packages.

Setting up nuget
================

Create an access token on github for the package repository.
<!-- https://help.github.com/en/github/authenticating-to-github/creating-a-personal-access-token-for-the-command-line#creating-a-token -->

Copy the ClearTextPassword and add it and your user name to the command below to create an entry for the github package repo in your global nuget.config file - C:\Users\maharryd\AppData\Roaming\NuGet

nuget sources add -name "github" -Source https://nuget.pkg.github.com/<account>/index.json -Username <user> -Password <PAT>

<!-- See https://help.github.com/en/github/managing-packages-with-github-packages/configuring-dotnet-cli-for-use-with-github-packages for full details -->

Pushing packages to github
==========================

With nuget.config configured correctly, push them to github with

dotnet nuget push "nuget/[PACKAGENAME].nupkg" --source "github"

or failing that 

curl -vX PUT -u "username:token" -F package=@LanguageLab.LexicalEntities.x.y.z.nupkg https://nuget.pkg.github.com/mahardan-oup/

will work
