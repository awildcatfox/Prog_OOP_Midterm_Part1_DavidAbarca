### Part 1
[Page1](Training/Page1.md)

#### Q1: What does it mean to create an "instance" of an object?
when you creatre an instance of a class, you are creating a copy of that class
with its own set of member variables and methods
#### Q2: What does it mean when we say "Create a local variable"?
 the act of declaring a variable within a specific scope, such as 
 within a method, function, or block of code. Local variables are 
 accessible only within the scope in which they are defined. They 
 are temporary in nature and are typically used for storing data 
 that is needed temporarily within a specific portion of code.
#### Q3: The static keyword is a modifier, what does this modifier do to the members (fields, constructor, properties, and methods) of a class?
fields: all instances of the class share the same copy of the static field

constructors:  Static constructors are used to initialize static 
fields or perform any other static initialization tasks. They are 
called automatically before the first instance of the class is created 
or any static members are accessed.

properties: When a property is declared as static, it is associated 
with the class rather than with instances of the class. Static properties 
can be accessed directly through the class name without needing to create 
an instance of the class.

methods: Static methods belong to the class rather than to specific 
instances of the class. They can be called directly through the class 
name without needing to create an instance of the class.
#### Q4: Do you need an instance of an object to call a static method?

No, you do not need an instance of an object to call a static method.
Static methods belong to the class itself rather than to instances
of the class
#### Q5: Can you create an instance of a static class?
No, you cannot create an instance of a static class.
#### Q6: Can you manually call a static constructor? When is it called?
In C#, you cannot manually call a static constructor.The static 
constructor is called exactly once, and it is guaranteed to be 
called before any static members (fields, properties, or methods) 
are accessed, or before any instance of the class is created. 
#### Q7: Did you have to create an instance of MyDatabase to access Data? Why?
The Data property is accessed statically, and it provides access 
to the List<string> data without needing to create an instance of 
MyDatabase. This is because Data is associated with the class itself, 
not with instances of the class.
#### Q8: When you ran your code the line "This list is loading" appeared. Where did that come from and why did it appear when it did?
The line "The list is loading" appeared because it is written within
the static constructor of the MyDatabase class:
### Part 2
[Page2](Training/Page2.md)

#### Q9: What is encapsulation?
encapsulation is a programming concept that combines data and methods
into a single unit (class) and hides the internal details of the object, 
promoting data integrity, abstraction, and modularity in object-oriented 
systems.

#### Q10: What are the other two, or 3 depending on the source, pillars of object-oriented programming?
inheritance, Polymorphism, and abstraction
#### Q11: After our refactor of Product, it only has fields that are _blank_ among all the Objects in the database.
false
#### Q11: After our refactor of Product, it only has fields that are _blank_ among all the Objects in the database.
#### Q12: We made our DisplayProductInfo() method `virtual`. What does virtual do?

In object-oriented programming, marking a method
as virtual in a base class indicates that the method 
can be overridden (redefined) in derived classes.
#### Q13: Why do you think we made that method virtual ( only wrong answer is a blank answer. Give it a shot. )?
we made the method virtual so it could be easier to
change item names and prices without data conflicting

#### Q14: What does dervied mean in the context of inheritance?
"derived" refers to a class that inherits from another class,
known as the base class or superclass. The derived class inherits
the properties, methods, and behavior of the base class, and it
can extend or modify them as needed.

#### Q15: Is one class is derived, the class that it derives from is considered the "b___" class. What is it?
When one class is derived from another class, the class that
it derives from is considered the "base" class.

#### Q16: When inheriting from a parent class, which class member ( field, constructor, properties, or method ) do you HAVE to create in your child class?
When inheriting from a parent class, the class member that you must create in your child class is the constructor.

#### Q17: Our constructor has the syntax `public Groceries(string name, double price, string expiryDate) : base(name, price)`. What is this for?
public Groceries(string name, double price, string expiryDate): This
is the constructor of the Groceries class. It takes three parameters: name, 
price, and expiryDate. This constructor initializes members specific to the
Groceries class.

#### Q18: For our DisplayProductInfo() we now used the word `override` instead of `virtual`. Why is that? And what happens if we take the word `virtual` away from the method inside of Product?
When you mark a method in a derived class with the override keyword,
you're explicitly stating that this method is intended to replace the
implementation of a method with the same signature in the base class.
 If you remove the virtual keyword from the method inside the Product 
 class, it means that the method cannot be overridden in derived classes.
 Without virtual, the method in the base class cannot be redefined in
 derived classes using override. Therefore, if you remove virtual
 from DisplayProductInfo() in the Product class, the method cannot be overridden in the DiscountedProduct class (assuming you're using it as a base class), and you won't achieve the desired polymorphic behavior.

#### Q19: Because we inherited from Parent, what class members did we get access to in Groceries?
name and price

#### Q20: What access modifier is needed for everything in your project to have access to class members ( there are 2 that would work )?
public and internal 

#### Q21: When each instanced object called `DisplayProductInfo()` the output was different based on the object. Why is that?
The difference in output when each instance of an object calls
the DisplayProductInfo() method is due to polymorphism,Polymorphism 
allows objects of different types to be treated as objects of a common 
base type (in this case, the Product class) through a shared interface 
(in this case, the DisplayProductInfo() method), while still executing 
the appropriate implementation of the method based on the actual type 
of the object at runtime.

#### Q22: What were we able to store our child classes in a list of Product?
Clothing, Electronics, and Groceries are derived classes of Product

#### Q23: We were able to call DisplayProductInfo() on every object, even though each object was directly a Product. Why is that?
The ability to call the DisplayProductInfo() method on every object,
even though each object is directly of type Product, is due to
polymorphism and method overriding.

#### Q24: If I tried to access the Expiry Date field of a product, what would happen? Why would it happen?
compilation error. This is because the ExpiryDate field is not defined
in the Product class, and the compiler would not recognize it as a valid
member of the Product class.

## Part 3
[Page3](Training/Page3.md)
#### Q22: What were we able to store our child classes in a list of Product?
abstract keyword is used to define abstract classes and abstract 
members within those classes.

#### Question 23: The abstract method no longer has a body, why is that? We also removed the word virtual, how do virtual and abstract relate?
The reason the abstract method no longer has a body is because 
abstract methods are intended to be overridden by derived classes,
and they do not have a default implementation in the abstract class
itself. Abstract methods serve as placeholders for functionality that
must be implemented by any concrete (non-abstract) derived class.

The virtual and abstract keywords are related in the context 
of method overriding and inheritance:
#### Question 24: We turned our constructors accesible type to protected. What objects have access to the constructor now that it's protected. And since we turned our class abstractwhy doesn't it matter that we can't create new instance ofProduct` in main?
name, price, color, size, brand, experation date, basically other classes
Abstract classes are meant to serve as base classes for other
classes, and they typically define a common interface or behavior
that derived classes must implement.

#### Q25: The other classes didn't need to be changed. Specifically, the DisplayProductInfo() didn't need any changing when we swapped our method from virtual to abstract. Why?
When you declare a method as abstract in a base class, you're essentially
stating that the base class does not provide any implementation for this
method, but it requires all derived classes to implement it.

## Part 4
[Page4](Training/Page4.md)

#### Q26: We set our set to private. What does private mean? And why might we want to set our set to private for our connection string (take a guess)?

## Part 5
[Page5](Training/Page5.md)

#### Q27: What method is used to get the TYPE of an instance of an object?
#### Q28: What method can we use to check if one type is another?