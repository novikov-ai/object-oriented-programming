using TaxonomyConflict;

var vehicleManual = new Vehicle(new TransmissionManual());
vehicleManual.ShiftGear();

var vehicleAuto = new Vehicle(new TransmissionAuto());
vehicleAuto.ShiftGear();