@ECHO OFF
REM A convenience script to avoid having to type "nant.exe /buildfile:BuildTest.build" every time
REM (especially since autocomplete doesn't work after the colon)     

REM The NuGet.exe is stored in the .nuget folder
..\.nuget\Nuget RESTORE ..\BuildTest.sln
IF ERRORLEVEL 1 GOTO nugetmissing

@ECHO ON

REM The Build file is located in BuildScripts folder
..\packages\NAnt.Portable.0.92\nant.exe /buildfile:BuildTest.build %*

@ECHO OFF

GOTO end

:nugetmissing
@ECHO Nuget.exe must be available in the machines PATH or in the BuildScripts directory.

:end