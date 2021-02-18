# Dream Of Electric Sheep
A web service that notifies users of their specified cryptocurrencies when a significant change in value is detected. Notifications can be either with email or text.

<b>What the project does</b>

<em>Dream Of Electric Sheep</em> utilizes the CoinMarketCap API ( https://coinmarketcap.com/api/documentation/v1/ ) to send the user mobile and email cryptocurrency price alerts when certain conditions have been met. The user must create an account with the web service to use the service, which enables them to customize their personal settings. 
`
For example, a user could set their alert for Bitcoin to trigger if the price of Bitcoin changes more than 1% of total value within a 6 hour period.
`

<b>Why the project is useful</b>

Dream Of Electric Sheep alerts crypto investors whenever a price change occurs taht the user is particularly interested in. Due to this, the user is never left in the dark about a potential buying or selling opportunity.


<b>How users can get started with the project</b>

Fork or clone the repo

from <em>/dream-of-electric-sheep</em> in the terminal, enter: 
`
cd ClientApp
`
this allows you to run npm commands in the ClientApp

from <em>/dream-of-electric-sheep/ClientApp</em> in the terminal, enter: 
`
npm install
`
this will install the necessary modules required.

in the <em>/dream-of-electric-sheep/ClientApp</em> directory, create a file called:
`
.env
`
add your CoinMarketCap.com API key to the <em>/dream-of-electric-sheep/ClientApp/.env</em> 
use content from <em>/dream-of-electric-sheep/ClientApp/example-env.js</em> as a reference, if needed.

from <em>/dream-of-electric-sheep</em> in the terminal, enter:
`
dotnet add package Twilio
`
this installs Twilio, see https://www.twilio.com/docs/libraries/csharp-dotnet/details for more

`
dotnet run
`
this launches a localhost server at http://localhost:5001/
type this into your browser window and enjoy the service :)




<b>Where users can get help with the project</b>

With any bugs or issues, please see:
`
https://github.com/cireneirbo/dream-of-electric-sheep/blob/master/.github/ISSUE_TEMPLATE/bug_report.md
`

For feature requests or suggestions, please see:
`
https://github.com/cireneirbo/dream-of-electric-sheep/blob/master/.github/ISSUE_TEMPLATE/feature_request.md
`

Otherwise, feel free to email me at: 
`
ejobrien315@gmail.com
`

<b>Maintained by:</b>

https://github.com/cireneirbo
