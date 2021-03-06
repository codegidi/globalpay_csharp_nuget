# Globalpay.Net

Globalpay.Net.SDK is a library for using the [Globalpay] API from .Net.


### Prerequisites

 This Library require .Net framework 4.6 or higher



### Installing
 Install this library from [Nuget](https://www.nuget.org/packages/Globalpay.Net.SDK)
 Or Click on NuGet manager in Visual Studios and search for GlobalPay.Net.SDK

### Usage
*    The steps for carrying out a transaction is as follows:
*    1. Get an access token by calling the Client Authorisation method
*    2. Use the access_token to send initiate your transaction by calling the Transaction initiaion method
*    3. Redirect to GlobalPay transaction interface using the redirectUri retured in the Transaction initiation call
*    4. After transaction has been done, you will be redirected to the provided redirectUrl provided with the transactionReference as a querystring
*    5. Validate the result by using the Retrieve transaction call


#### Client Authentication
    using GlobalPay.Net;
    var globalPayAuthentication = new GlobalPayAuthentication();
    var response = await globalPayAuthentication.AuthenticateClient(string _clientId, string _clientSecret, {optional BOOL isLive : #true for for live enviroment and false for staging default value false})

    var access_token = response.Access_token;


##### Transaction Initialization
    using GlobalPay.Net;
    var globalPayTransactions = new GlobalPayTransactions(ACCESS_TOKEN);
    var response = await globalPayTransactions.InitializeTransaction(string _returnurl, string _merchantreference, string _merchantid , string _description, string _totalamount, string _currencycode {currency code i.e NGN for naira}, string _customerEmail, string _customerNumber, string _customerFirstName, string _customerLastName, {optional BOOL isLive : #true for for live enviroment and false for staging default value false})

    if(response.status.statusCode){
        Response.AddHeader("Access-Control-Allow-Origin", "*");
        Response.AppendHeader("Access-Control-Allow-Origin", "*");
		Response.Redirect(response.redirectUri);
    }else{
	//Handle Error
	}

##### Transaction Verification
    using GlobalPay.Net;
    var globalPayTransactions = new GlobalPayTransactions(ACCESS_TOKEN);
    var response = await globalPayTransactions.RetrieveTransaction(string _merchantId, string _merchantReference, string _transactionReference, {optional BOOL isLive : #true for for live enviroment and false for staging default value false})

