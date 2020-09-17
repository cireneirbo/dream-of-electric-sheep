# dream-of-electric-sheep
A web service that notifies users of their specified cryptocurrencies when a significant change in value is detected. 


###using
* Node.js
* C#
* https://www.twilio.com/docs/sms/send-messages
* https://reactjs.org/tutorial/tutorial.html
* https://docs.microsoft.com/en-us/aspnet/core/getting-started/?view=aspnetcore-3.1&tabs=windows



// created an asp.net core cli project
$ dotnet new webapp -o aspnetcoreapp

Welcome to .NET Core 3.1!
---------------------    
SDK Version: 3.1.401     

Telemetry
---------
The .NET Core tools collect usage data in order to help us improve your experience. The data is anonymous. It is collected by Microsoft and shared with the community. 
You can opt-out of telemetry by setting the DOTNET_CLI_TELEMETRY_OPTOUT environment variable to '1' or 'true' using your favorite shell.

Read more about .NET Core CLI Tools telemetry: https://aka.ms/dotnet-cli-telemetry

----------------
Explore documentation: https://aka.ms/dotnet-docs
Report issues and find source on GitHub: https://github.com/dotnet/core
Find out what's new: https://aka.ms/dotnet-whats-new
Learn about the installed HTTPS developer cert: https://aka.ms/aspnet-core-https
Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli-docs
Write your first app: https://aka.ms/first-net-core-app
--------------------------------------------------------------------------------------
Getting ready...
The template "ASP.NET Core Web App" was created successfully.
This template contains technologies from parties other than Microsoft, see https://aka.ms/aspnetcore/3.1-third-party-notices for details.

Processing post-creation actions...
Running 'dotnet restore' on aspnetcoreapp\aspnetcoreapp.csproj...
  Determining projects to restore...
  Restored C:\Users\kalefice\Documents\GitHub\dream-of-electric-sheep\aspnetcoreapp\aspnetcoreapp.csproj (in 443 ms).

Restore succeeded.


//created react app
$ npx create-react-app reactapp
npx: installed 98 in 37.113s

Creating a new React app in C:\Users\kalefice\Documents\GitHub\dream-of-electric-sheep\reactapp.

Installing packages. This might take a couple of minutes.
Installing react, react-dom, and react-scripts with cra-template...


> core-js@2.6.11 postinstall C:\Users\kalefice\Documents\GitHub\dream-of-electric-sheep\reactapp\node_modules\babel-runtime\node_modules\core-js
> node -e "try{require('./postinstall')}catch(e){}"


> core-js@3.6.5 postinstall C:\Users\kalefice\Documents\GitHub\dream-of-electric-sheep\reactapp\node_modules\core-js
> node -e "try{require('./postinstall')}catch(e){}"


> core-js-pure@3.6.5 postinstall C:\Users\kalefice\Documents\GitHub\dream-of-electric-sheep\reactapp\node_modules\core-js-pure
> node -e "try{require('./postinstall')}catch(e){}"

+ cra-template@1.0.3
+ react-scripts@3.4.3
+ react@16.13.1
+ react-dom@16.13.1
added 1598 packages from 745 contributors and audited 1602 packages in 1183.717s

66 packages are looking for funding
  run `npm fund` for details

found 0 vulnerabilities


Installing template dependencies using npm...
npm WARN tsutils@3.17.1 requires a peer of typescript@>=2.8.0 || >= 3.2.0-dev || >= 3.3.0-dev || >= 3.4.0-dev || >= 3.5.0-dev || >= 3.6.0-dev || >= 3.6.0-beta || >= 3.7.0-dev || >= 3.7.0-beta but none is installed. You must install peer dependencies yourself.
npm WARN optional SKIPPING OPTIONAL DEPENDENCY: fsevents@2.1.2 (node_modules\fsevents):
npm WARN notsup SKIPPING OPTIONAL DEPENDENCY: Unsupported platform for fsevents@2.1.2: wanted {"os":"darwin","arch":"any"} (current: {"os":"win32","arch":"x64"})      
npm WARN optional SKIPPING OPTIONAL DEPENDENCY: fsevents@1.2.13 (node_modules\jest-haste-map\node_modules\fsevents):
npm WARN notsup SKIPPING OPTIONAL DEPENDENCY: Unsupported platform for fsevents@1.2.13: wanted {"os":"darwin","arch":"any"} (current: {"os":"win32","arch":"x64"})     
npm WARN optional SKIPPING OPTIONAL DEPENDENCY: fsevents@1.2.13 (node_modules\watchpack-chokidar2\node_modules\fsevents):
npm WARN notsup SKIPPING OPTIONAL DEPENDENCY: Unsupported platform for fsevents@1.2.13: wanted {"os":"darwin","arch":"any"} (current: {"os":"win32","arch":"x64"})     
npm WARN optional SKIPPING OPTIONAL DEPENDENCY: fsevents@1.2.13 (node_modules\webpack-dev-server\node_modules\fsevents):
npm WARN notsup SKIPPING OPTIONAL DEPENDENCY: Unsupported platform for fsevents@1.2.13: wanted {"os":"darwin","arch":"any"} (current: {"os":"win32","arch":"x64"})     

+ @testing-library/jest-dom@4.2.4
+ @testing-library/react@9.5.0
+ @testing-library/user-event@7.2.1
added 36 packages from 57 contributors and audited 1638 packages in 32.043s

66 packages are looking for funding
  run `npm fund` for details

found 0 vulnerabilities

Removing template package using npm...

npm WARN tsutils@3.17.1 requires a peer of typescript@>=2.8.0 || >= 3.2.0-dev || >= 3.3.0-dev || >= 3.4.0-dev || >= 3.5.0-dev || >= 3.6.0-dev || >= 3.6.0-beta || >= 3.7.0-dev || >= 3.7.0-beta but none is installed. You must install peer dependencies yourself.
npm WARN optional SKIPPING OPTIONAL DEPENDENCY: fsevents@2.1.2 (node_modules\fsevents):
npm WARN notsup SKIPPING OPTIONAL DEPENDENCY: Unsupported platform for fsevents@2.1.2: wanted {"os":"darwin","arch":"any"} (current: {"os":"win32","arch":"x64"})      
npm WARN optional SKIPPING OPTIONAL DEPENDENCY: fsevents@1.2.13 (node_modules\jest-haste-map\node_modules\fsevents):
npm WARN notsup SKIPPING OPTIONAL DEPENDENCY: Unsupported platform for fsevents@1.2.13: wanted {"os":"darwin","arch":"any"} (current: {"os":"win32","arch":"x64"})     
npm WARN optional SKIPPING OPTIONAL DEPENDENCY: fsevents@1.2.13 (node_modules\webpack-dev-server\node_modules\fsevents):
npm WARN notsup SKIPPING OPTIONAL DEPENDENCY: Unsupported platform for fsevents@1.2.13: wanted {"os":"darwin","arch":"any"} (current: {"os":"win32","arch":"x64"})     
npm WARN optional SKIPPING OPTIONAL DEPENDENCY: fsevents@1.2.13 (node_modules\watchpack-chokidar2\node_modules\fsevents):
npm WARN notsup SKIPPING OPTIONAL DEPENDENCY: Unsupported platform for fsevents@1.2.13: wanted {"os":"darwin","arch":"any"} (current: {"os":"win32","arch":"x64"})     

removed 1 package and audited 1637 packages in 12.589s

66 packages are looking for funding
  run `npm fund` for details

found 0 vulnerabilities


Success! Created reactapp at C:\Users\kalefice\Documents\GitHub\dream-of-electric-sheep\reactapp
Inside that directory, you can run several commands:

  npm start
    Starts the development server.

  npm run build

removed 1 package and audited 1637 packages in 12.589s

66 packages are looking for funding
  run `npm fund` for details

found 0 vulnerabilities


Success! Created reactapp at C:\Users\kalefice\Documents\GitHub\dream-of-electric-sheep\reactapp
Inside that directory, you can run several commands:

  npm start
    Starts the development server.

  npm run build
    Bundles the app into static files for production.

  npm test

  npm run eject
    Removes this tool and copies build dependencies, configuration files
    and scripts into the app directory. If you do this, you can’t go back!

We suggest that you begin by typing:

  cd reactapp
  npm start

Happy hacking!