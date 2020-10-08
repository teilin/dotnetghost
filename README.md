# Dotnet Ghost Client

This is a simple client library to communicate with a Ghost blog engine through a Ghost integration.

## Getting started

TBC

## Development

The project contains of two projects, the main project that is the library and a test project. The test project is to test the client against a Ghost installation.

To get started, inside the test project there are a *appsettings.test.json.example*, clone this file and name the file *appsettings.test.json*. Then insert the Ghost integration variables that you can get from your Ghost installation.

Every test extends from the BaseTest class and in the Setup method of the test, the LoadTestSettings() method is called. This is where the test settings is loaded. Then the apiurl, api key for both the content api and the admin api is availble.