using System;
using System.Linq;
public class Hello {
	public static void Main() {
		int[] arr={2,54,643,54,76,44,23,47,99,1};
		double avg = Queryable.Average(arr.AsQueryable());
		Console.WriteLine("Average: "+avg);
	}
}
