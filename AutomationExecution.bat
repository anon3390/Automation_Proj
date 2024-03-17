@ECHO OFF
ECHO Demo Automation Executed Started.

call "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat"

VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /Logger:"trx;LogFileName=C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\TestSummaryReport\Test1.trx"
cd C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug
TrxerConsole.exe C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\TestSummaryReport

PAUSE