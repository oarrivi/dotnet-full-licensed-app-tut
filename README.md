# dotnet-full-licensed-app-tut
This is a full example about how a developer can protect a very simple application using the Microsoft .NET classes for licensing.
The explanation will be available in my [blog](http://theartoftheleftfoot.blogspot.com "The Art of the Left Foot")

The app is quite silly. It is a Windows Console application that prints the system date and time.
The app will run until 10 times without a valid license, in "demo" version. After these 10 times, it won't work again until license is provided.
There are two licenses: A standard version which only prints system date; and a full version which prints date and time.
