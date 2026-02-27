# Unity-DebugPlus


## Table of Contents

1. **Introduction**
2. **Usage of DebugPlus Class**
3. **Functions and Their Usage**
4. **Examples**

---

### Introduction

Adds additional debug functionality such as; printing collections (arrays/lists etc.) and printing to a debug text file.

### Usage of DebugPlus Class

#### Writing to Debug File
To write to a debug file, you can use the `WriteToDebugFile` method. You need to specify the data you want to log and optionally the file name and folder path.

```csharp
DebugPlus.WriteToDebugFile("This is a test message.");
```

or

```csharp
DebugPlus.WriteToDebugFile("Another test message.", "app-debug.log");
```

#### Logging Collections
The `LogCollection` methods are used to log collections of data. They can be generic or non-generic, depending on the type of collection you want to log.

```csharp
int[] numbers = { 1, 2, 3 };
DebugPlus.LogCollection(numbers);

NativeArray<float> floatNumbers = new NativeArray<float>(new int[]{ 4, 5, 6 }, Allocator.Temp);
DebugPlus.LogCollection(floatNumbers);
```

#### Logging Additional Information
The `Log` method can be used to log any other information you want to include in your debug output.

```csharp
DebugPlus.Log("This is a test log message.");
```

### Examples

1. **Writing to File with Specific Folder Path**
   ```csharp
   DebugPlus.WriteToDebugFile("This is a test message.", "app-debug.log", "path/to/folder");
   ```

2. **Logging Collections with Formatting**
   ```csharp
   string[] strings = { "Hello", "World" };
   DebugPlus.LogCollection(strings, ", ");
   ```

3. **Additional Logging Example**
   ```csharp
   int result = 10 + 20;
   DebugPlus.Log("The result is: " + result);
   ```

This README file provides a comprehensive guide on how to use and understand the `DebugPlus` class in your project. It includes usage examples, explanations of each function, and additional resources for further learning.
