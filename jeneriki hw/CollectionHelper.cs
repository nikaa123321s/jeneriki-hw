using System;
using System.Collections.Generic;

public class CollectionHelper
{
    /// <summary>
    /// Prints the elements of a collection in reverse order (from last to first).
    /// </summary>
    public static void PrintReverse<T>(IEnumerable<T> collection)
    {
        if (collection == null)
        {
            Console.WriteLine("Collection is null");
            return;
        }

        var list = new List<T>(collection);
        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(list[i]);
        }
    }

    /// <summary>
    /// Returns the first element of the collection.
    /// </summary>
    public static T GetFirstElement<T>(IEnumerable<T> collection)
    {
        if (collection == null)
            throw new ArgumentNullException(nameof(collection));

        foreach (var item in collection)
        {
            return item;
        }

        throw new InvalidOperationException("Collection is empty");
    }

    /// <summary>
    /// Returns the last element of the collection.
    /// </summary>
    public static T GetLastElement<T>(IEnumerable<T> collection)
    {
        if (collection == null)
            throw new ArgumentNullException(nameof(collection));

        var list = new List<T>(collection);
        if (list.Count == 0)
            throw new InvalidOperationException("Collection is empty");

        return list[list.Count - 1];
    }

    /// <summary>
    /// Checks if the collection contains the specified value.
    /// </summary>
    public static bool ContainsElement<T>(IEnumerable<T> collection, T value)
    {
        if (collection == null)
            throw new ArgumentNullException(nameof(collection));

        foreach (var item in collection)
        {
            if (EqualityComparer<T>.Default.Equals(item, value))
                return true;
        }

        return false;
    }

    /// <summary>
    /// Returns the number of elements in the collection (without using Length property).
    /// </summary>
    public static int CountElements<T>(IEnumerable<T> collection)
    {
        if (collection == null)
            throw new ArgumentNullException(nameof(collection));

        int count = 0;
        foreach (var item in collection)
        {
            count++;
        }

        return count;
    }

    /// <summary>
    /// Finds the index of the specified element in the collection.
    /// Returns -1 if the element is not found.
    /// </summary>
    public static int FindIndex<T>(IEnumerable<T> collection, T value)
    {
        if (collection == null)
            throw new ArgumentNullException(nameof(collection));

        int index = 0;
        foreach (var item in collection)
        {
            if (EqualityComparer<T>.Default.Equals(item, value))
                return index;
            index++;
        }

        return -1;
    }
}
