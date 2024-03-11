using CovarianceContravariance;

// covariance
IEnumerable<Base> example;

example = new List<Base>();
example = new List<Derived>();


// contravariance
Doer.Make(Base.Magic); // out: Magic is happening here: base hello
Doer.Make(Derived.Magic); // out: Magic is happening here: base hello

// contravariance in arrays
string[] arr = new string[5];
object[] arrObj = new object[5];

arrObj = arr;