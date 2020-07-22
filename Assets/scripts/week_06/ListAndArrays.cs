using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListAndArrays : MonoBehaviour
{
    // the basic annatomy of an array is Access type, data type , [] and then variable name
    public int[] myFirstIntArray;
    // an array to hold our ints, an array is a collection of items
    public List<int> myFirstIntList = new List<int>();
    // the basic annatomy of a list is Access type, list<data type>, variable name
    // then we have to initaliae it with an empty list using the new keyword to get an instance of our list class
    // a list to hold a collection of items
    
    void Start()
    {
        // this is an example of accessing elements of an array
        // arrays and lists always start at elemt 0
        // the easiest way to remember which element to access is whatever position you want -1
        Debug.Log("the first number in my array is: " + myFirstIntArray[0]);
        Debug.Log("the first number in my array is: " + myFirstIntArray[1]);
        Debug.Log("the first number in my array is: " + myFirstIntArray[2]);

        // an example of adding an element to an array
        myFirstIntArray = new int[] { 5, 4, 2, 7};
        // example of removing elements from an array
        myFirstIntArray = new int[] { 5, 2, 7 };
        // an example of getting the length of an arrayor how many items there are
        Debug.Log(myFirstIntArray.Length);

        // example of accessing the elements in a list, same behavior as an array
        Debug.Log("the first number in my list is: " + myFirstIntList[0]);
        Debug.Log("the first number in my list is: " + myFirstIntList[1]);
        Debug.Log("the first number in my list is: " + myFirstIntList[2]);

        // an example of adding an element to a list
        myFirstIntList.Add(9);
        // an example of removing an element
        myFirstIntList.Remove(5);
        // an example of using removeat, so remove the item from the element i define
        // list.count returns how long my list is
        // -1 allows me to take into account that the arrays and list starts at position 0
        myFirstIntList.RemoveAt(myFirstIntList.Count - 1);
        // this is an example of accessing a random element for my array or list
        // the key here here is Random.Range for int is inclusive meaning that whatever number is the max will be -1
        // this is great for us as array/list start at position 0 so, ao an array/list of 9 long has 8 elements
        // so if we did a random range between 0 and 9 we can only get a number between 0 and 8 meaning we wont get an
        // element out of range
        Debug.Log("acessing a random element from my list: " + myFirstIntList[Random.Range(0, myFirstIntList.Count)]);
    }
}
