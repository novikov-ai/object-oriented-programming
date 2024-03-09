using DynamicCohesion;

var vehicle = new Vehicle();
vehicle.Run(15); // Out: The vehicle drove about 15 yesterday

var moto = new Moto();
moto.Run(15); // Out: The MOTO drove about 15 yesterday
moto.Run("Dune"); // Out: The vehicle drove to Dune yesterday