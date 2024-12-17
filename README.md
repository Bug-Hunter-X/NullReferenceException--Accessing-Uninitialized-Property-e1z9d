# NullReferenceException: Accessing Uninitialized Property in C#

This example demonstrates a common C# error: accessing an uninitialized property, leading to a `NullReferenceException`.  Uninitialized properties are frequently a cause of runtime errors in C#.  This repository shows the bug and how to fix it.

## Bug
The `bug.cs` file contains a class with a method that attempts to read a property's value without first assigning it. This results in a `NullReferenceException` at runtime.

## Solution
The `bugSolution.cs` file shows the corrected code. The property is given an initial value to prevent the exception.