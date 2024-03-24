using GeneralHierarchy;
using GeneralHierarchy.NoneClosure;

// - - - EXAMPLE WITH GENERAL - - -
var gen1 = new General();
var gen2 = new General();

var animal = new Animal();

// init hash's: 58225482 / 54267293
System.Console.WriteLine($"{gen1.GetType()}: {gen1.GetHashCode()} / {gen2.GetHashCode()}"); 

General.AssignmentAttempt(ref gen1, gen2);

// assignment succeded: 54267293 / 54267293
// 58225482 -> 54267293 (with type General)
System.Console.WriteLine($"{gen1.GetType()}: {gen1.GetHashCode()} / {gen2.GetHashCode()}");

// init hash's: 54267293 / 33574638
System.Console.WriteLine($"{gen1.GetType()}: {gen1.GetHashCode()} / {animal.GetHashCode()}"); 

General.AssignmentAttempt(ref gen1, animal);

// assignment failed: 33736294 / 33574638
// 54267293 -> 33736294 (with type None)
System.Console.WriteLine($"{gen1.GetType()}: {gen1.GetHashCode()} / {animal.GetHashCode()}");

// - - - EXAMPLE WITH ANY - - -
var any1 = new Any();
var any2 = new Any();

var animal2 = new Animal();

// init hash's: 35191196 / 48285313
System.Console.WriteLine($"{any1.GetType()}: {any1.GetHashCode()} / {any2.GetHashCode()}"); 

Any.AssignmentAttempt(ref any1, any2);

// assignment succeded: 48285313 / 48285313
// 35191196 -> 48285313 (with type Any)
System.Console.WriteLine($"{any1.GetType()}: {any1.GetHashCode()} / {any2.GetHashCode()}");

// init hash's: 48285313 / 31914638
System.Console.WriteLine($"{any1.GetType()}: {any1.GetHashCode()} / {animal2.GetHashCode()}"); 

Any.AssignmentAttempt(ref any1, animal2);

// assignment failed: 18796293 / 31914638
// 48285313 -> 18796293 (with type None)
System.Console.WriteLine($"{any1.GetType()}: {any1.GetHashCode()} / {animal2.GetHashCode()}");