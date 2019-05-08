using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    public Difference(int[] a)
    {
        this.elements = a;
    }
    public void computeDifference()
    {
        for (int i = 0; i < elements.Length - 1; i++)
        {
            for (int j = i + 1; j < elements.Length; j++)
            {
                if (elements[i] > elements[j])
                {
                    int saved = elements[i];
                    elements[i] = elements[j];
                    elements[j] = saved;
                }
            }
        }
        maximumDifference = elements[elements.Length - 1] - elements[0];
    }

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}