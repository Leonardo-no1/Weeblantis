# Weeblantis

Weeblantis is a simple eccomerce application written with an Angular 12 front-end, backed by a .Net Core 3.1 Web API,
with data being persisted to an MSSQL Database.

## Installation
* First Clone/download the repository.

### To begin using the web api. Follow these steps:

* Use the Visual Studio package manager console to install run the database migrations, run:
```bash
update-database
```
* Open and run the productSeed.sql script pointing to the created WeeblantisDb databse, to bootstrap the product and cartegory tables

### To begin using the angular app. Follow these steps:

* Install Angular on your local system, you need Node.js
Angular requires an active LTS or maintenance LTS version of Node.js.
For more information on installing Node.js, see [NodeJs.org](https://nodejs.org) . If you are unsure what version of Node.js runs on your system,  in a terminal window run:
```bash
node -v
```
* Install the Angular CLI by running:
``` bash
npm install -g @angular/cli
```
* Install all necessary node packages by running:
```bash
npm install
```
