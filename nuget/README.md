nuget
==========

Your classes are packaged up into this directory with the package task, ready for upload to Github Packages.

With nuget.config configured correctly + saved in the solution root folder, push them to github with

dotnet nuget push "nuget/[PACKAGENAME].nupkg" --source "github"

See https://help.github.com/en/github/managing-packages-with-github-packages/configuring-dotnet-cli-for-use-with-github-packages#installing-a-package for full details