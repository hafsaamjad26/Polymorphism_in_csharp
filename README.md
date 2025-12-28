# Polymorphism_in_csharp

## Introduction To Polymorphism

Polymorphism means **"many forms"**, and it occurs when we have many classes that are related to each other by inheritance.

Polymorphism is one of the four fundamental pillars of Object-Oriented Programming. In C#, polymorphism allows the same method to behave differently based on the object that is calling it.

This repository demonstrates polymorphism in C# using clear theory and practical code examples.

## Types of Polymorphism

There are two types of polymorphism

### 1. Static Polymorphism(Compile-Time Polymorphism)

Static polymorphism is achieved using **method overloading**.
In this type, multiple methods share the same name and data type (method signature) but differ in parameters.
They may differ in:

- number of parameters

- sequence of parameters

- data type of parameters

The decision about which method to call is made at **compile-time**.

### 2. Dynamic Polymorphism(Run-Time Polymorphism)

Dynamic polymorphism is achieved using **method overriding**.
In run-time polymorphism a base class reference can be used to point to an object of any of its derived classes
It requires:

- Inheritance

- The virtual keyword in the base class

- The override keyword in the derived class

The method call is resolved at runtime based on the object type.
The method in the base class must be declared with the *virtual* modifier, indicating that it can be overridden by a derived class.
The method in the derived class must use the *override* modifier to provide a specific implementation for the virtual method inherited from the base class.
---
## Benefits of Polymorphism
- Improves code flexibility
- Reduces duplication
- Makes applications scalable
- Widely used in real-world software projects

### Explanation of code examples  
You can see Code Examples in this repository

Example 1: Compile-Time Polymorphism

This example uses method overloading in a Calculator class.
The same Add() method works with different parameter lists.

Example 2: Runtime Polymorphism

This example demonstrates method overriding using a Shape base class and
derived classes Circle and Rectangle. A parent class reference is used to
call overridden methods at runtime.

Example 3: Bank Account System

This example demonstrates real-world use of runtime polymorphism.
The BankAccount class defines a virtual method CalculateInterest().
SavingsAccount and CurrentAccount override this method to provide
different interest calculations.

---

## Conclusion

Polymorphism allows developers to write flexible and reusable code.
By using polymorphism, applications become easier to extend and maintain. 

This repository provides both theoretical understanding and practical examples of polymorphism in C#.
