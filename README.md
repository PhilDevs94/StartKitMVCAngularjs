# Start Kit .Net Framework Using MVC Pattern

[![N|Solid](https://i.ibb.co/wCFZDtQ/logo.png)](https://nodesource.com/products/nsolid)
![N|Solid](https://www.paypalobjects.com/favicon.ico) : Buy me a coffee via email **phildevs94@gmail.com**

This project is built for who want a fast setup for your company or group or even your personal  project. I will give you guys an instruction to show you how to implement this project. 

# Project structure

  - There are total of 6 C# projects in the solution
  - One project is .NET web application project
  - Five C# library projects
  
Here are details for function and how to use each project:
  - **StartMVCAngularJS.Core** Library project: This project including your model for migration database I have included EntityDto, PersonDto and TaskDto inside of it as example for who haven't know about this framework yet. Feel free to work aroung on it. I have also set up the repository, Unit of Work for saving time on development, you don't have to do any setup more on the framework of project
  - **StartMVCAngularJS.Data** Library project: This project including your migration history, your datacontext to add database object inside of it, please make sure you put it in the right place. To add data object for data migration understanding what you are going to add to the data base, you need to add inside the following file : **DataContext.cs**, I also put an example on it, please take a look if you are not sure about it.
  - **StartMVCAngularJS.Domain** Library project: This project is quite simple, you are not going to directly using the model in **StartMVCAngularJS.Core** to standardlized the model to your front end but using View Model as a required fields from front-end to back-end. ViewModels could be different from the Models inside the origin model of Core project because they may have some extra information you want to export for Front-end.
  - **StartMVCAngularJS.Service** Library project: This project is including files that will implement all your CRUD (create, read, update and delete) method of your data object, remember parameters here is NOT from your data objects but from your ViewModels but there are a few tricky things here. First, The actually what you are going to call is just a task async function using ViewModel and inside of that will be another call to a function directly using Data object as the model. Check out my exmamples.
  - **StartMVCAngularJS.Ultilities** Library project: This project is including some ultilities you may want to add in projects, you can take a look at my example is GuidComb.cs, this file is to genegrate GUID as same as .NET framework provided but simpler than the origin one.
  - **StartMVCAngularJS Web Application Project**: This project is where magic happen, it contains Front-end and Odata controller to communicate with other library projects or you can call this is the "bridge" of your project. To use Odata you have to do following steps: 
  1. Add your EntitySet<ViewModel>("Your name of View Model in odata calling") in file WebApiConfig.cs
  2. Create odata controller in Folder Areas > Api > Controllers. I've already set up example in odata controllers so that you can easy to follow all these steps and implement these without too much complecated process.
  - All Front-end of the project in inside the App folder I will not talk about this very much here, you need to look carefully at those file following files and folder
  1. **js > config.router.js** : Containing the router of the web application.
  2. **js > main.js** : Containing some global variable you may want to keep or modified such as $scope, global variable for you can use in any controller
  3. **ctrl folder**: This folder is where you going to add your controller and handle data processing between front-end and back-end. 
  4. **Create new view**: You can create new view through Controller in MVC project, the name should be as same as the name of the controller in angularjs for save time when you need to check back.

![N|Solid](https://www.paypalobjects.com/favicon.ico) : A coffee just a few bucks im embrace me keep improving this **phildevs94@gmail.com**

**Free Start Kit project, Hell Yeah!**

