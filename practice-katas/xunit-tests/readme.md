# Environment Setup
2023
.Net 7
PC / Win 10
Visual Studio Code
- Using Extension **.NET Core Test Explorer**

cli setup:
```
mkdir learn
cd learn
dotnet new xunit -o Katas.Tests
dotnet new classlib -o Katas.Lib
// add Lib project reference to Tests project
dotnet add .\Katas.Tests\Katas.Tests.csproj reference .\Katas.Lib\Katas.Lib.csproj
cd Katas.Lib
dotnet add package FluentAssertions
dotnet add package xunit --version 2.4.2
code .
```




Copy and paste content from desired unit test file into Katas.Tests/UnitTest1.cs or however you prefer to do it.

Create the code to be tested in Katas.Lib/Class1.cs, etc.

Run tests.
