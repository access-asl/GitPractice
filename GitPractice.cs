/**
File: GitPractice.cs
Purpose: Practice Exercise developed by Jacob Brower as a tool to learn the use of the GitHub platform

Author: Jacob Brower << jcb8561@g.rit.edu >>
	Contributing Author: Shantanav Saurav << ss9415@g.rit.edu >>

Testing protocol: Code was tested by being added as a component to an empty GameObject in an empty Unity scene. 
	Output was observed in the console upon 'playing' the scene.
*/

// Unused 'using' statements were removed (I won't usually do this but for a task this simple I thought "eh, why not")
using System;
using UnityEngine;

/**
This is to teach you guys how to use git, to have yall learn git better:
1.) Get the code from Github
2.) Locate the error(s)
3.) Fix the error(s)
4.) Upon doing that push your code to a a new branch labeled ad <YourName>GitPractice
5.) Make your output look exactly like the expected output.

UPDATE TO ADD:
    Goals set by aforementioned tasks have been achieved
 */
public class GitPractice : MonoBehaviour
{
    private int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

    void Start()
    {
        // Declare final output as String
        String arrayAsString = "";

        // Append individual elements of array to string in appropriate format as required by output
        foreach (int elem in arraySplicer(5, nums))
        {
            arrayAsString += elem + ",";
        }

        // Print final output to Unity Console
        Debug.Log(arrayAsString);
    }

    /**
    Splices an array at an index
    @idx the index to split the array
    @arrayToSplice the array to splice at a given index
    Expected output:
    6, 7, 8, 9, 0,
    Current output:
    IndexOutOfRangeException

    UPDATE TO ADD: 
        Expected output is now achieved
    */
    public T[] arraySplicer<T>(int index, T[] arrayToSplice)
    {
        // Declare length of spliced array as int
        int newArrayLen = arrayToSplice.Length - index;

        // Create new resultant array of said length
        T[] res = new T[newArrayLen];

        // Populate array with appropriate values
        for (int i = 0; i < newArrayLen; i++)
        {
            res[i] = arrayToSplice[i + index];
        }

        // Return spliced array
        return res;
    }

}
