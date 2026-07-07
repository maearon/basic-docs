using System;
using System.Collections.Generic;

namespace ListSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // BubbleSortAlgorithm();
            // SelectionSortAlgorithm();
            // InsertionSortAlgorithm();
            // FindMaxInArray();
            // FindSecondMaxInArray();
            // FindPrimeNumber();
            FindMaxOfThreeNumbers();
        }

        public static void BubbleSortAlgorithm()
        {
        	var a = new List<int> {1, 5, 2, 3, 7, 6};
            int n = a.Count;
        	for (int i = 0; i < n - 1; i++) 
			for (int j = 0; j < n - i - 1; j++) 
			if (a[j] > a[j + 1]) {// swap 
					int temp = a[j];
					a[j] = a[j + 1];
					a[j + 1] = temp;
				}
			foreach(var item in a)
   			Console.WriteLine(item);
        }

        public static void SelectionSortAlgorithm()
        {
        	var a = new List<int> {1, 5, 2, 3, 7, 6};
            int n = a.Count;
        	for (int i = 0; i < n - 1; i++)  
		    { 
		        int min = a[i]; //Tìm imin
		        for (int j = i+1; j < n; j++)  
		            if (a[j] < min) 
		            { 
		                min = a[j]; 	            
	                 	//Hoán đổi a[i] và a[j]
	                 	int temp = a[i]; 
	                 	a[i] = a[j]; 
	                 	a[j] = temp;
		            }
		    } 	
		    foreach(var item in a)
   			Console.WriteLine(item);
        }

        public static void InsertionSortAlgorithm()
        {
        	var a = new List<int> {1, 5, 2, 3, 7, 6};
            int n = a.Count;
        	for (int i = 1; i < n; i++)
			   {
			     int j=i-1;
			     int t=a[i];
			     while(j>=0&&t<a[j])
			     {
			       a[j+1]=a[j];
			       j--;
			     }
			     a[j+1]=t;
			   } 
			foreach(var item in a)
   			Console.WriteLine(item);    	
        }

        public static void FindMaxInArray()
        {
        	var a = new List<int> {1, 5, 2, 3, 7, 6};
            int n = a.Count;
            int max = a[0];
            for (int i = 1; i < n; i++)
            {
            	if (a[i] > max) max = a[i];
            }
            Console.WriteLine(max); 		
        }

        public static void FindSecondMaxInArray()
        {
        	var a = new List<int> {1, 5, 2, 3, 7, 6};
            int max = int.MinValue;
			int second = int.MinValue;
            foreach(var item in a)
            {
            	if (item > max) { second = max; max = item; }
            	else if (item > second) {second = item;}
            }
            Console.WriteLine(second); 		
        }

        public static void FindPrimeNumber()
        {
            for (int i = 1; i <= 7; i++)
            {
            	bool isPrime = true;
            	for (int j = 2; j < i; j++) 
            		if(i%j==0){
                		isPrime = false;
                		break;
            		}
            	if(isPrime) Console.WriteLine(i);
            }	
        }

        public static void FindMaxOfThreeNumbers()
        {
            int a = 1;
            int b = 3;
            int c = 2;
            int max = a;
            if(b>max) max=b;
            if(c>max) max=c;
            Console.WriteLine(max);
        }

    }
}
