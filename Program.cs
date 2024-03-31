using GeneralHierarchy.Generics;

var v1 = new Vector<Double>(5, 2, 3);
var v2 = new Vector<Double>(5.123, 123, 6.112);

Console.WriteLine(Enumerable.Sum(v1 + v2)); // 144.23499999999999

var v3 = new Vector<int>(5, 2, 3);
var v4 = new Vector<int>(6, 11, 1000);

Console.WriteLine(Enumerable.Sum(v3 + v4)); // 1027