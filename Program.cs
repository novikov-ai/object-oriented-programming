using MethodsInvokation;

// Covariance: 
Dummy dummy = new DerivedDummy();
dummy.Do(); // DerivedDummy does

// dummy.SomethingNew(); // can't invoke that

// Polymorphism:
DerivedDummy derivedDummy = new DerivedDummy();
derivedDummy.Make("hello"); // Dummy made: hello
derivedDummy.Make(123); // DerivedDummy made: 123