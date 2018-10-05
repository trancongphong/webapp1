## Setup a SonarCloud on VSTS with source from GitHub repository for dotnet core project
SonarCloud is the code quality cloud service provided by SonarSource.
It depends on Sonarqube and 

### Prerequisites
1. VSTS account
2. GitHub account

### Setting up the environment
    Go to https://sonarcloud.io and log in with GitHub Account.
    Click on create new project( can be Create manually) and input project name, project key and Click Create.
    Generate token (save the project key and token to use in VSTS).
    Click continue and choose project language

### Procedures
```
1. Pipeline: choose the Agent pool
2. Get Reources
3. dotnet restore
4. Prepare analysis on SonarCloud
5. dotnet build
6. dotnet test
7. Run code Analysis
8. Publish Quanlity Gate Result
```
In those steps:
``` 
dotnet restore:
- Input path to projects need to restore
```
```
Prepare analysis on SonarCloud:
- SonarCloud Service Endpoint: 
    New -> 
        Connecttion name: project token name
        SonarCloud token: project token
- Organization: Your GitHub organization
- Project Key: your project key
- Advanced: -> Additional Properties -> sonar.cs.opencover.reportsPaths=**/*/coverage.opencover.xml
```
```
dotnet build:
- Input your solution file
```
```
dotnet test:
- Input path to test projects
- Arguments: 
/p:CollectCoverage=true /p:CoverletOutputFormat=opencover

And then, click on Save and Queue to build your analysis
```

Now in the tag Summary, you can see Analysis Report.

If it is the first time you run the Analysis, you need somethings to configure: 
```
1. Click on Detailed SonarCloud report 
2. Click on Manage branches
3. Delete all branch exception master
4. Rename master branch to get resource branch
5. Go to VSTS and Queue your project once time again.
```
### Notes

### Authors

### License