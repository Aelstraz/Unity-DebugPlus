using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Unity.Collections;
using UnityEngine;

namespace UsefulUtilities
{
    public static class DebugPlus
    {
        private const string DEBUG_FILE_NAME = "debug.txt";

        /// <summary>
        /// Writes to a debug file. By default, the file is written to Application.dataPath (Assets folder when running in Editor)
        /// </summary>
        /// <param name="data">The data to write to the debug file</param>
        /// <param name="fileName">Optional. The name of the file to write to. By default DEBUG_FILE_NAME is used</param>
        /// <param name="folderPath">The path of the folder to create the file in. By default (if is null) Application.dataPath will be used</param>
        public static void WriteToDebugFile(string data, string fileName = DEBUG_FILE_NAME, string folderPath = null)
        {
            try
            {
                if (string.IsNullOrEmpty(folderPath))
                {
                    File.WriteAllText(Path.Combine(Application.dataPath, fileName), data);
                }
                else
                {
                    File.WriteAllText(Path.Combine(folderPath, fileName), data);
                }
            }
            catch (Exception e)
            {
                Debug.LogError("Error writing to debug file: " + e.Message);
            }
        }

        #region Logging
        public static void LogCollection<T>(T[] collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection<T>(NativeArray<T> collection, string seperator = ", ") where T : struct
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection<T>(List<T> collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection<T>(Queue<T> collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection(Queue collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection<T>(LinkedList<T> collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection<T>(Stack<T> collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection(Stack collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection(ArrayList collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection(SortedList collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection<K, V>(SortedList<K, V> collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection(Hashtable collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection<T>(SortedSet<T> collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection<K, V>(SortedDictionary<K, V> collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection<K, V>(Dictionary<K, V> collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }

        public static void LogCollection<T>(HashSet<T> collection, string seperator = ", ")
        {
            Debug.Log(CollectionToString(collection, seperator));
        }
        #endregion

        #region ToStrings
        public static string CollectionToString<T>(T[] collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString<T>(NativeArray<T> collection, string seperator = ", ") where T : struct
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString<T>(List<T> collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString<T>(Queue<T> collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString(Queue collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString<T>(LinkedList<T> collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString<T>(Stack<T> collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString(Stack collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString(ArrayList collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString(SortedList collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString<K, V>(SortedList<K, V> collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString(Hashtable collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString<T>(SortedSet<T> collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString<K, V>(SortedDictionary<K, V> collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString<K, V>(Dictionary<K, V> collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString<T>(HashSet<T> collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }

        public static string CollectionToString<T>(T collection, string seperator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            return sb.AppendJoin(seperator, collection).ToString();
        }
        #endregion
    }
}