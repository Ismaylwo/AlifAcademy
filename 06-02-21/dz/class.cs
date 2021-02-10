using  System;
using System.Collections.Generic;
namespace dz
{
    static class ArrayHelper{
        
        public static T Pop<T>(ref T[] array){
           
            T RemoveItem = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return RemoveItem;
        }
        public static int Push<T>(ref T[] array , T push)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = push;
            return array.Length;
        }
        public static T Shift<T>(ref T[] array)
        {
            Array.Reverse(array);
            T shift = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            Array.Reverse(array);
            return shift;
        }
        public static int UnShift<T>(ref T[] array, T unShift)
        {
            Array.Reverse(array);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = unShift;
            Array.Reverse(array);
            return array.Length;
        } 
        public static T[] Slice<T>(ref T[] array)
        {
            T[] newArray = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }
        public static T[] Slice<T>(ref T[] array,  int Begin)
        {
            if (Begin < 0)
            {
                Begin = array.Length - Math.Abs(Begin);
            }
            int res = array.Length - Begin;
            T[] newArray = new T[res];
            for (int i = 0; i < res; i++)
            {
                newArray[i] = array[Begin + i];
            }
            return newArray;
        }
        public static T[] Slice<T>(ref T[] array, int Begin, int End)
        {
            if (Begin < 0)
            {
                Begin = array.Length - Math.Abs(Begin);
            }
            if (End < 0)
            {
                End = array.Length - Math.Abs(End);
            }
            int Res = End - Begin;
            T[] newArray = new T[Res];
            for (int i = 0; i < Res; i++)
            {
                newArray[i] = array[Begin + i];
            }
            return newArray;
        }
        
    }
}