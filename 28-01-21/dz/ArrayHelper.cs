
using System;
namespace dz {

class ArrayHelper{

public static string Pop(ref string[] array)

        {
            string RemoveItem = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return RemoveItem;

        }
        public static int Pop(ref int[] array)
        {
            int RemoveItem = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return RemoveItem;
        }
        public static double Pop(ref double[] array)
        {
            double RemoveItem = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return RemoveItem;
        }
        public static decimal Pop(ref decimal[] array)
        {
            decimal RemoveItem = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return RemoveItem;
        }
        public static float Pop(ref float[] array)
        {
            float RemoveItem = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return RemoveItem;
        }
        public static int Push(ref string[] array, string push)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = push;
            return array.Length;
        }
        public static int Push(ref int[] array, int push)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = push;
            return array.Length;
        }
        public static int Push(ref double[] array, double push)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = push;
            return array.Length;
        }
        public static int Push(ref decimal[] array, decimal push)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = push;
            return array.Length;
        }
        public static int Push(ref float[] array, float push)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = push;
            return array.Length;
        }
        public static string Shift(ref string[] array)
        {
            Array.Reverse(array);
            string shift = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            Array.Reverse(array);
            return shift;
        }
        public static int Shift(ref int[] array)
        {
            Array.Reverse(array);
            int shift = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            Array.Reverse(array);
            return shift;
        }
        public static double Shift(ref double[] array)
        {
            Array.Reverse(array);
            double shift = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            Array.Reverse(array);
            return shift;
        }
        public static decimal Shift(ref decimal[] array)
        {
            Array.Reverse(array);
            decimal shift = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            Array.Reverse(array);
            return shift;
        }
        public static float Shift(ref float[] array)
        {
            Array.Reverse(array);
            float shift = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            Array.Reverse(array);
            return shift;
        }
        public static int UnShift(ref string[] array, string unShift)
        {
            Array.Reverse(array);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = unShift;
            Array.Reverse(array);
            return array.Length;

        }
        public static int UnShift(ref int[] array, int unShift)
        {
            Array.Reverse(array);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = unShift;
            Array.Reverse(array);
            return array.Length;
        }
        public static int UnShift(ref double[] array, double unShift)
        {
            Array.Reverse(array);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = unShift;
            Array.Reverse(array);
            return array.Length;
        }
        public static int UnShift(ref decimal[] array, decimal unShift)
        {
            Array.Reverse(array);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = unShift;
            Array.Reverse(array);
            return array.Length;

        }
        public static int UnShift(ref float[] array, float unShift)
        {
            Array.Reverse(array);
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = unShift;
            Array.Reverse(array);
            return array.Length;
        }
    }
}