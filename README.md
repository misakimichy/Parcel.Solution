# Parcels

#### _C#, .NET: Job Board, 01/07/2020_
Create a website for a fictional shipping company that helps users calculate shipping estimates.

## Description
Create a website where the user can submit a form with the dimensions(width, height and length) and weight of a parcel, and display the cost to ship and the volume of a parcel with its dimensions in your site.

## Application should have:
- has `Parcel` class: It should contain a constructor, and getters and setters for each property. You should be able to create a new parcel and specify the dimensions and weight in the arguments.

- can take user input and use the data in the form to instantiate a `Parcel` object and display its dimensions and weight.

- When you call a method called `Volume()` on a `Parcel` instance, it should return the product of the sides.

- When you call a `CostToShip()` method on your parcel, return a cost based on a formula you make up.

- Display the cost to ship and the volume of a Parcel with its dimensions in your site.

- Returns an error message if any of the form fields are blank. Display an error message instead.

- User can only enter numbers into the form.

## Installation:
1. Clone this repo:
```
$ git clone https://github.com/misakimichy/Parcel.Solution.git
```

2. Use the following codes:

a) Command to build the project. Run this in Project directory:
```
$ dotnet build && $ dotnet run
```


b) Command for unit testing. Run this in Project.Tests directory:
```
$ dotnet restore && dotnet test
```

## Known Bugs
* No known bugs at this time.

## Support and contact details
 misaki.koonce@gmail.com

## Technologies Used
_Git, GitHub, Bootstrap, C# and ASP.NET Core MVP

## License
Copyright © 2020 under the MIT License
