# C# NullReferenceException Bug Example

This repository contains a simple C# code example that demonstrates a common coding error: accessing a class property before it has been assigned a value.  This can lead to a `NullReferenceException` at runtime.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file provides a corrected version.

## How to reproduce the bug
1. Compile and run the `bug.cs` file.
2. Observe the `NullReferenceException` being thrown.

## How to fix the bug
Refer to the corrected code in `bugSolution.cs` which demonstrates how to avoid the exception by ensuring the property is initialized before access.