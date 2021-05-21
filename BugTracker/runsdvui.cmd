cd /d "E:\VS repos\BugTracker" &msbuild "BugTracker.csproj" /t:sdvViewer /p:configuration="Debug" /p:platform="Any CPU" /p:SolutionDir="E:\VS repos\BugTracker" 
exit %errorlevel% 