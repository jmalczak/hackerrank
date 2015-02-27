using System;
using System.Collections.Generic;
using System.IO;
class Solution {

    static void partition(int[] ar) {
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        var splitItem = ar[0];

        for(int i = 1; i < ar.Length; i++) {
            if(ar[i] < splitItem) {
                left.Add(ar[i]);
            } else {
                right.Add(ar[i]);
            }
        }

        foreach(var i in left) {
            Console.Write(string.Format("{0} ", i));
        }

        Console.Write(string.Format("{0} ", splitItem));

        foreach(var i in right) {
            Console.Write(string.Format("{0} ", i));
        }
    }
    
    static void Main(String[] args) {
           
           int _ar_size;
           _ar_size = Convert.ToInt32(Console.ReadLine());
           int [] _ar =new int [_ar_size];
           String elements = Console.ReadLine();
           String[] split_elements = elements.Split(' ');
           for(int _ar_i=0; _ar_i < _ar_size; _ar_i++) {
                  _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]); 
           }

           partition(_ar);
    }
}
