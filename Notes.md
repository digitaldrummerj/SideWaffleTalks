#Side Waffle Notes:

[http://www.sidewaffle.com/](http://www.sidewaffle.com/)

[https://github.com/ligershark/side-waffle](https://github.com/ligershark/side-waffle)
##Installation
* Need to have VS2013 SDK installed

##Add new templates

* Fork the project
* Clone it to your computer
* Install the Visual Studio 2012 SDK or Visual Studio 2013 SDK.
	* [VS 2013 SDK Download](http://www.microsoft.com/en-us/download/details.aspx?id=30668)	
	* [VS2013 SDK Download](http://www.microsoft.com/en-us/download/details.aspx?id=40758)
* Open the solution in Visual Studio
* Watch this video tutorial
* After adding your templates, send us a pull request
* Only high quality templates with broad appeal will be accepted
* SideWaffle templates can be installed in both Visual Studio 2012 and 2013, regardless of the version you use for creating new templates.

## How to create project template
[https://github.com/ligershark/side-waffle/wiki/How-to-create-a-project-template](https://github.com/ligershark/side-waffle/wiki/How-to-create-a-project-template)

## How to create item template

## How to create code snippet

##Resources
* [Channel 9 Visual Studio Toolbox](http://channel9.msdn.com/Shows/Visual-Studio-Toolbox/SideWaffle) 
* [Sayed Hashimi YouTube How to create VS project templates](http://www.youtube.com/watch?v=z33jOo75CH4)
* [Sayed Hashimi Blog (several videos)](http://sedodream.com/2013/10/11/SideWaffleHowToCreateYourOwnVSTemplatePack.aspx)


##Demo Project Template

* Create new solution
* add VSIX project
* Fill in Product Name, Author, and Description for source.extension.vsixmanifest
* Install-Package TemplateBuilder -pre
* Add new class library project.  NunitProjectTemplate
* Config Manager for solution and turn off building NunitProjectTemplate
* Right-Click on VSIX project.  Select add -> Add Template Reference (Side Waffle Project) 
* Pick NunitProjectTemplate
* Reload Project
* Notice that Solution Explorer thinks NunitProjectTemplate.csproj doesn't exist.  It is ok.
* To NunitProjectTemplate project add new item.  Extensibility -> Side Waffle -> SideWaffle Project Template Files.  Name doesn't actually matter.
	* Change TemplateInfo Path. <TemplateInfo Path="CSharp\JustinTest"/>
	* Remove the *.csproj from the exclude list.
* Open _project.vstemplate.xml
	* Change Name
	* Change Description
* Ctrl+F5 to launch Instance

##Demo Item Template

* Create folder in VSIX called ItemTemplates
* Create Folder in ItemTemplates called CSharp
* Right-Click CSharp and select SideWaffle create new ItemTemplate
* Rename the file(s) under Definitions from *.vstemplat- to *.vstemplate
* Delete Readme.txt
* Add cs file
* Changed cs file properties to Build Action: Content and Include in VSIX = true
* Update CSharp.vstemplate to include cs file
* Update the content in the relevant *.vstemplate files

<VSTemplate Version="3.0.0" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" Type="Item">
  <TemplateData>
	<ProjectType>CSharp</ProjectType>
	
	<DefaultName>NunitTest.cs</DefaultName>
	<Name>JustinsNunitTestFile</Name>
	<Description>Justin's Nunit Test file to go along with the NunitProjectTemplate.  Create a new file with all of the Nunit setup done.</Description>    
	<Icon>icon.png</Icon>
	<NumberOfParentCategoriesToRollUp>1</NumberOfParentCategoriesToRollUp>
  </TemplateData>
  <TemplateContent>
	<References />
	 
	<ProjectItem ReplaceParameters="true">NunitTest.cs</ProjectItem>
	
  </TemplateContent>
</VSTemplate>

	
##Demo Snippet

* Add Folders Snippets -> CSharp -> JustinsSnippets
* Add CodeSnippet file called NunitTest.snippet
* Add Package Definition Files
	* // C# snippets
	* [$RootKey$\Languages\CodeExpansions\CSharp\Paths]
	* "JustinsSnippets"="$PackageFolder$\Snippets\CSharp\JustinsSnippets"
* Add Asset 
	* Type: VSPackage
	* File On filesystem
	* Snippets.pkgdef
* Changed snippet file properties to Build Action: Content and Include in VSIX = true
<?xml version="1.0" encoding="utf-8" ?>
<CodeSnippets xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
	<CodeSnippet Format="1.0.0">
		<Header>
			<Title>NUnitTest</Title>
			<Shortcut>NUnitTest</Shortcut>
			<Description>Test method stub for an nunit test</Description>
			<Author>Justin James</Author>
			<SnippetTypes>
				<SnippetType>Expansion</SnippetType>
			</SnippetTypes>
		</Header>
		<Snippet>
			<Declarations>
				<Literal Editable="true">
					<ID>testname</ID>
					<ToolTip>Method Test to use</ToolTip>
					<Default>Test1</Default>
				</Literal>
				<Literal Editable="true">
					<ID>notimplemented</ID>
					<ToolTip>Replace with your test.</ToolTip>
					<Default>Assert.Fail("Not Implemented");</Default>
				</Literal>
			</Declarations>
			<Code Language="CSharp">
				<![CDATA[
		[Test]
		public void $testname$()
		{
			$notimplemented$
		}
		]]>
			</Code>
		</Snippet>
	</CodeSnippet>
</CodeSnippets>
