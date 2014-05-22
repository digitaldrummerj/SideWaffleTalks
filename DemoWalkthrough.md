#Side Waffle Demo:

[http://www.sidewaffle.com/](http://www.sidewaffle.com/)

[https://github.com/ligershark/side-waffle](https://github.com/ligershark/side-waffle)

##Required Software

* Install SideWaffle Extensions to Visual Studio
	* [http://visualstudiogallery.msdn.microsoft.com/a16c2d07-b2e1-4a25-87d9-194f04e7a698](http://visualstudiogallery.msdn.microsoft.com/a16c2d07-b2e1-4a25-87d9-194f04e7a698)
* Install the Visual Studio 2012 SDK or Visual Studio 2013 SDK.
	* [VS 2013 SDK Download](http://www.microsoft.com/en-us/download/details.aspx?id=30668)	
	* [VS2013 SDK Download](http://www.microsoft.com/en-us/download/details.aspx?id=40758)

##Demo Project Template

* Create new solution
* add VSIX project (make sure .NET 4.5 is selected)
* Fill in Product Name, Author, and Description for source.extension.vsixmanifest
* Install-Package TemplateBuilder -pre
* Add new class library project called NunitProjectTemplate
* Delete class1.cs
* Add existing to project 
	* Go to DemoAssets and add Class1.cs, Mother.cs, and TestBaseClass.cs
* Configuration Manager for solution and turn off building NunitProjectTemplate for debug and release
* Right-Click on VSIX project.  Select add -> Add Template Reference (Side Waffle Project) 
* Pick NunitProjectTemplate
* Reload Project
* Notice that Solution Explorer thinks NunitProjectTemplate.csproj doesn't exist.  It is ok.
* To NunitProjectTemplate project add new item.  Extensibility -> Side Waffle -> SideWaffle Project Template Files.  Name doesn't actually matter.
	* NOTE: Pre-Filled out one in DemoAssets
	* Change TemplateInfo Path. <TemplateInfo Path="CSharp\JustinTest"/>
	* Remove the *.csproj from the exclude list.
* Open _project.vstemplate.xml
	* Change Name
	* Change Description
* Ctrl+F5 to launch Instance

* WARNING: 1 issue with nuget package reference.  solution must be at same level at when you created the vsix.

##Demo Item Template

* Create folder structure in VSIX called ItemTemplates\NUnit 
	* * Empty dir structure available in DemoAssets to copy over
* Right-Click CSharp and select SideWaffle create new ItemTemplate
* Rename the file(s) under Definitions from *.vstemplat- to *.vstemplate
	* PRe-Filled out one available in DemoAssets
* Delete Readme.txt
* Add existing file from DemoAssets called NUnitTest.cs
* Changed cs file properties to Build Action: Content and Include in VSIX = true
* Update CSharp.vstemplate to include cs file
* Update the content in the relevant *.vstemplate files

##Demo Snippet

* Add Folders Snippets\CSharp\JustinsSnippets
	* Empty dir structure available in DemoAssets to copy over
* Add CodeSnippet file called NunitTest.snippet
	* replace contents with the contents from DemoAssets\NUnitTest.snippet
* Add Package Definition Files
	* // C# snippets
	* [$RootKey$\Languages\CodeExpansions\CSharp\Paths]
	* "JustinsSnippets"="$PackageFolder$\Snippets\CSharp\JustinsSnippets"
* Add Asset 
	* Type: VSPackage
	* File On filesystem
	* Snippets.pkgdef
* Changed snippet file properties to Build Action: Content and Include in VSIX = true



##Additional Resources
* [Channel 9 Visual Studio Toolbox](http://channel9.msdn.com/Shows/Visual-Studio-Toolbox/SideWaffle) 
* [Sayed Hashimi YouTube How to create VS project templates](http://www.youtube.com/watch?v=z33jOo75CH4)
* [Sayed Hashimi Blog (several videos)](http://sedodream.com/2013/10/11/SideWaffleHowToCreateYourOwnVSTemplatePack.aspx)
