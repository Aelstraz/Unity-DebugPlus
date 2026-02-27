# DebugPlus

## Overview
DebugPlus is a utility class designed to provide additional logging capabilities for Unity projects. It includes functions to write log messages to a debug file, and logging collections.

## Usage

### 1. Writing to Debug File
You can use the `WriteToDebugFile` function to log messages to a debug file. The function takes three parameters:
- `data`: The message or data you want to write to the debug file.
- `fileName` (optional): The name of the file to write to. If not provided, it defaults to `"debug.txt"` in the root directory of your project (`Application.dataPath`).
- `folderPath` (optional): The path of the folder where the file should be created. If not provided, it uses the default path (`Application.dataPath`).

#### Example Usage
```csharp
using UsefulUtilities;

public class Example : MonoBehaviour
{
    void Start()
    {
        DebugPlus.WriteToDebugFile("Starting the game.", "log.txt", "Logs");
    }
}
```

### 2. Logging Collections
DebugPlus provides methods to log collections of different types, such as arrays, lists, queues, linked lists, stacks, ArrayLists, SortedLists, SortedSets, SortedDictionaries, HashTables, and HashSets. You can specify a separator for the output.

#### Example Usage
```csharp
using UsefulUtilities;

public class Example : MonoBehaviour
{
    void Start()
    {
        DebugPlus.LogCollection(new int[] { 1, 2, 3, 4 }, " - ");
    }
}
```

## Documentation

### 3. Public Functions

| Function Name | Description |
| --- | --- |
| `WriteToDebugFile(string data, string fileName = DEBUG_FILE_NAME, string folderPath = null)` | Writes a log message to a debug file. |
| `LogCollection<T>(T[] collection, string seperator = ", ")` | Logs an array of any type. |
| `LogCollection<T>(NativeArray<T> collection, string seperator = ", ") where T : struct` | Logs a native array of any struct. |
| `LogCollection<T>(List<T> collection, string seperator = ", ")` | Logs a list of any type. |
| `LogCollection<T>(Queue<T> collection, string seperator = ", ")` | Logs a queue of any type. |
| `LogCollection(Queue collection, string seperator = ", ")` | Logs a queue of any type. |
| `LogCollection<T>(LinkedList<T> collection, string seperator = ", ")` | Logs a linked list of any type. |
| `LogCollection<T>(Stack<T> collection, string seperator = ", ")` | Logs a stack of any type. |
| `LogCollection(Stack collection, string seperator = ", ")` | Logs a stack of any type. |
| `LogCollection(ArrayList collection, string seperator = ", ")` | Logs an ArrayList of any type. |
| `LogCollection(SortedList collection, string seperator = ", ")` | Logs a SortedList of any type. |
| `LogCollection<K, V>(SortedList<K, V> collection, string seperator = ", ")` | Logs a SortedList of key-value pairs with any types for keys and values. |
| `LogCollection(Hashtable collection, string seperator = ", ")` | Logs a Hashtable of any type for keys and values. |
| `LogCollection<T>(SortedSet<T> collection, string seperator = ", ")` | Logs a SortedSet of any type. |
| `LogCollection<K, V>(SortedDictionary<K, V> collection, string seperator = ", ")` | Logs a SortedDictionary of key-value pairs with any types for keys and values. |
| `LogCollection<K, V>(Dictionary<K, V> collection, string seperator = ", ")` | Logs a Dictionary of key-value pairs with any types for keys and values. |
| `LogCollection<T>(HashSet<T> collection, string seperator = ", ")` | Logs a HashSet of any type. |
