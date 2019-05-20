﻿using System;
using System.Collections;
using System.Collections.Generic;


/**
This is to teach you guys how to use git, to have yall learn git better:
1.) Get the code from Github
2.) Locate the error(s)
3.) Fix the error(s)
4.) Upon doing that push your code to a a new branch labeled ad <YourName>GitPractice
5.) Make your output look exactly like the expected output.
 */
 public class GitPractice : MonoBehaviour
{
    private int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

    void main() {
        string numString;
        foreach(int i in arraySplicer(5, nums)){
            numString += i;
        }
        Console.Log(numString);
    }

        /**
    Splices an array at an index
    @idx the index to split the array
    @arrayToSplice the array to splice at a given index
    Expected output:
    6, 7, 8, 9, 0,
    Current output:
    IndexOutOfRangeException
     */
    public T[] arraySplicer<T>(int index, T[] arrayToSplice) {
        T[] res = new T[arrayToSplice.Length];
        for (int i = index; i <= arrayToSplice.Length; i++) {
            res[i-index] = arrayToSplice[i];
        }
        return res;
    }

}
