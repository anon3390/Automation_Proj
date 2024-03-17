@ECHO OFF
ECHO Demo Automation Executed Started.

call "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools\VsDevCmd.bat"

VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=dragAnddrop"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=Resizable"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=Selectable"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=Sortable"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=BookStoreApp"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=nested test"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=wait_for_alert"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=Alert click buttton"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=small test"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=new window"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=Confirmation alert"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=PrompTest"
VSTest.Console.exe "C:\Users\uhsye\source\repos\Automation_Proj\Automation_Proj\bin\Debug\Automation_Proj.dll" /TestCaseFilter:"TestCategory=Forms"



PAUSE