using GeneralHierarchy.OpenClosedPrinciple;

var general = new General();
general.Do();

var derived = new Derived();
derived.Do();

var cantOverride = new CantOverride();
cantOverride.Do();