using MethodHidingPolicy;

var a = new A();
var b = new B();

// метод публичен в родительском классе А и публичен в его потомке B;
a.PublicDo();
b.PublicDo();

// метод скрыт в родительском классе А и скрыт в его потомке B.
// a.PrivateDo();
// b.PrivateDo();