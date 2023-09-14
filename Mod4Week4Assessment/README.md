# Week 4 Assessment

### Setup
* Fork and clone this repository
* Open your forked repo in Visual Studio.
* Complete the two exercises and the questions

## Exercise 1: Inheritance and Dependency Injection (8 points)

Open up `Program.cs` and run your program. It should run with no errors, if you get an error reach out to your instructor.

This exercise involves some refactoring and some new features.

**Step 1:** Currently there are two classess `Student` and `Teacher` that have a lot of repeated code between them. Create a new class `Person` that will be the base class. Then update `Student` and `Teacher` to be derived from `Person`. Include as much in your `Person` class as you can to keep your code DRY (Don't Repeat Yourself). 

**Testing Step 1:** Uncomment the code under "Step 1:" in the Main method. That code should now run without error.

**Step 2:** Implement a new class called `School` that uses dependency injection and takes in a list of people as a dependency. Implement a method called `ListBirthdays` in your school class that calls the `GetBirthday` method and prints to the console each student and teacher's birthday.

**Testing Step 2:** Uncomment the code under "Step 2:" in the Main method. That code should now run without error and output a bunch of names and birthdays.

Ungraded extra challenge: If you have time, improve the way the birthdays are output. Can you group them by month or by Student/Teacher?

### Exercise 2: Interfaces (4 points)
Open up `InterfacePractice.cs`. You should not need to run this file, you will just edit it.

**Step 1:** Take a look at the two classes `Car` and `Bicycle`. They both implement an interface called `InterfaceNameHere`. Replace all three uses of `InterfaceNameHere` with a fitting name for this interface.

**Step 2:** The interface has already been created for you on line 5. Fill in the details for any methods and/or properties that make sense based on the two classes implementing this interface.

## Questions (8 points)

Edit this file with your answers.

1. What are some of the benefits of using inheritance? (1 point)
     * One advantage is Reusable code so you don't have to repeat yourself. Another advantage is if you need to make a change in the parent class you can it in one place instead of everywhere. 
2. What might be some of the disadvantages of using inheritance? (1 point)
    * < the parent class and child classes are tightly coupled. Hence, If you change the parent class's code, it will affect all the child classes. Another disadvantage would be properties and methods of a parent class could go unused and add bloat to your classes. It can also be harder to debug classes when they use inheritance >  

3. How would you describe the difference between the base class and the derived class when working with inheritance? (1 point)
	* < the base or parent class is usually a lot more broad and holds code that will be widely reused by its child class. A child class inheirts those broad properties and methods from the base class, it also could contain information more specfic code that wouldn't make sence to put into the parent class. >  

4.  What happens if you define the same method in the parent class and the child class? (1 point)
	* < the method inside of the child class will overide the method inside of the parent class so you wouldn't be able to access the parent class method. Also the code would run, but you would get a compiler error telling you that.  > 

5. In your own words, how would you define an Interface? (1 point)
    * < An interface in OOP is a blueprint that defines what methods and properties a class should have, ensuring a consistent structure for different classes, but it doesn't dictate how those methods and properties should be implemented in each class. > 

6. Does a class implementing an interface need to implement all of the methods in that interface? Why or why not? (1 point)
    * < Yes, interfaces act as a contract and there is no actual implmentation of code in an interface. That happens in the class that inheirts from the interface. > 

7. Both Inheritance and Interfaces use the `:` symbol after a class name. If you're looking at a class, what's one thing that can help you determine if the class is implementing an interface of extending a base class? (1 point)
	* < An Interface should always start with an "I" when being named. You can also go in the a class or interfaces defintion in Visual Studio to see if its inheirting any classes or interfaces. >  

8. If asked in an interview, how would you describe the purpose of the IOC container in a .NET application? (1 point)
	* < "Great Question, IOC stands for Inversion of Contol and is a design pattern in programming that allows the developer to create a loosly coupled program. But If I'm entirely honest I don't have a super strong grasp on what an IOC container is. I do know that it is very closly tied to Dependency Injection and that they often go hand in hand. That said I would love to look into it later and come back to you with a better more well rounded answer.  >  


## Rubric

This assessment has a total of 20 points.  A score of 15 or higher is a pass.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
