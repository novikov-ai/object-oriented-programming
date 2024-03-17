using GeneralHierarchy.OpenClosedPrinciple;

var general = new General();
general.Do(); // Invokation from General

var derived = new Derived();
derived.Do(); // Invokation from Derived

var cantOverride = new CantOverride();
cantOverride.Do(); // Invokation from CantOverride

// ! UNEXPECTED BEHAVIOUR !

General dd = new Derived();
dd.Do(); // Invokation from Derived

General ddd = new CantOverride();
ddd.Do(); // Invokation from Derived

General dddd = new DerivedFromCantOverride();
dddd.Do(); // Invokation from Derived