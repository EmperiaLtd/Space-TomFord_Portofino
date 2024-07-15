@echo off

:: Set source path and file name
set "sourcePath=D:\Plugins\ffmpeg\ffmpeg.exe"
set "fileName=ffmpeg.exe"

:: Check if the source file exists
if not exist "%sourcePath%" (
    echo Source file does not exist.
    exit /b
)

:: Create a folder named "ffmpeg" in the current directory
mkdir "ffmpeg"

:: Copy the file from the source to the "ffmpeg" folder in the current directory
copy /y "%sourcePath%" ".\ffmpeg\%fileName%"

echo File copied to the 'ffmpeg' folder in the current directory.
echo -------------------------------------------------------------------------------

:: Set source path and file name for the config file
set "configSourcePath=D:\Plugins\Config\Emperia3DKitConfig.ini"
set "configFileName=Emperia3DKitConfig.ini"

:: Check if the config source file exists
if not exist "%configSourcePath%" (
    echo Config source file does not exist.
    exit /b
)
:: Create a folder named "ffmpeg" in the current directory
mkdir "Config"

:: Copy the config file from the source to the "Config" folder in the current directory
copy /y "%configSourcePath%" ".\Config\%configFileName%"

echo -------------------------------------------------------------------------------
echo Deleting PDB files in "Binaries\Win64" folder...
del /s "Binaries\Win64\*.pdb"
echo PDB files deleted.

echo Deleting files and folders in "Intermediate" folder...
rmdir /s /q "Intermediate"
echo Intermediate files and folders deleted.
echo -------------------------------------------------------------------------------

echo Deleting "Private" and "Public" folders in "Source\EmperiaTool\" folder...
rmdir /s /q "Source\EmperiaTool\Private"
rmdir /s /q "Source\EmperiaTool\Public"
echo "Private" and "Public" folders deleted.
echo -------------------------------------------------------------------------------

echo Deleting "Private" and "Public" folders in "Source\EmperiaHTMLMenu\" folder...
rmdir /s /q "Source\EmperiaHTMLMenu\Source\Private"
rmdir /s /q "Source\EmperiaHTMLMenu\Source\Public"
echo "Private" and "Public" folders deleted.
echo -------------------------------------------------------------------------------


echo Deleting "Private" and "Public" folders in "Source\EmperiaToolEditor\" folder...
rmdir /s /q "Source\EmperiaToolEditor\Private"
rmdir /s /q "Source\EmperiaToolEditor\Public"
echo "Private" and "Public" folders deleted.
echo -------------------------------------------------------------------------------



echo Replacing text in "Source\EmperiaTool\EmperiaTool.Build.cs"...
powershell -Command "(Get-Content 'Source\EmperiaTool\EmperiaTool.Build.cs') | ForEach-Object { $_ -replace 'PrecompileForTargets = PrecompileTargetsType.Any;', 'bUsePrecompiled=true;' } | Set-Content 'Source\EmperiaTool\EmperiaTool.Build.cs'"
echo Text replaced in C# file.
echo -------------------------------------------------------------------------------

echo Replacing text in "Source\EmperiaTool\EmperiaHTMLMenu.Build.cs"...
powershell -Command "(Get-Content 'Source\EmperiaHTMLMenu\EmperiaHTMLMenu.Build.cs') | ForEach-Object { $_ -replace 'PrecompileForTargets = PrecompileTargetsType.Any;', 'bUsePrecompiled=true;' } | Set-Content 'Source\EmperiaTool\EmperiaTool.Build.cs'"
echo Text replaced in C# file.
echo -------------------------------------------------------------------------------


echo Replacing text in "Source\EmperiaTool\EmperiaToolEditor.Build.cs"...
powershell -Command "(Get-Content 'Source\EmperiaToolEditor\EmperiaToolEditor.Build.cs') | ForEach-Object { $_ -replace 'PrecompileForTargets = PrecompileTargetsType.Any;', 'bUsePrecompiled=true;' } | Set-Content 'Source\EmperiaTool\EmperiaTool.Build.cs'"
echo Text replaced in C# file.
echo -------------------------------------------------------------------------------


echo All tasks completed.
pause