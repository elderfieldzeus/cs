using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualStudioProject
{
    internal class Arrays
    {
        private int[] arr;
        public Arrays(int size)
        {
            arr = new int[size];
            populateArray();
            displayArray();
        }

        public void populateArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = CLI.getInt("Enter element " + (i + 1) + ": ");
            }
        }

        public void displayArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                CLI.print(arr[i] + " ");
            }
        }
    }
}
