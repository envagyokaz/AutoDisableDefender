# Download
## If you have git installed:
1. Navigate to the folder where you want to place the program
2. git clone https://github.com/envagyokaz/AutoDisableDefender.git

## If you don't have git installed 
1. Download the .zip
2. Extract it to a folder of your choice

#### The executable's path is : 
"yourPath\\AutoDisableDefender\bin\Debug\net8.0\AutoDisableDefender.exe"

For running the program you'll need administrator priviliges and if you wanted to edit, you have to run the Visual Studio as an administrator. 

# Automatization
For automatic running you have to use the Windows Task Scheduler. There go to the main library called "Task Scheduler Lybrary", and there Create a new task:
1. On the **General** tab name the task whatever you want; you can add a description too
2. At the security options select your user that will run the program, check the "Run only when user is logged on" radio button, and check the "Run with highest priviliges" checkbox, and configure the task for your operation system on the bottom. 
3. On the **Triggers** tab click on New. In the dropdown list select On workstation unlock, select "Any user", and on the bottom enable it. Then click OK. 
4. On the **Actions** tab add a new action. The action sould be "Start a program", then browse the AutoDisabeDefender.exe. 
5. On the **Conditions** tab uncheck all checkboxes.
6. On the **Setings tab** check the firs 4 checkoboxes, and leavethe values on default. On the bottom set "Stop existing instance". Then close this window with OK.
7. Now it supposed to work. 
