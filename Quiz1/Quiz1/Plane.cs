namespace Quiz1 {
    internal class Plane {
        private int fuelTankCapacity;
        private double distancePerKm;
        public int PassenersCapacity { get; set; }
        public int TicketsSold { get; set; }

        public Plane(int fuelTankCapacity, double distancePerKm) {
            this.fuelTankCapacity = fuelTankCapacity;
            this.distancePerKm = distancePerKm;
        }

        public Plane(int fuelTankCapacity, float distancePerKm, int passenersCapacity, int ticketsSold) {
            this.fuelTankCapacity = fuelTankCapacity;
            this.distancePerKm = distancePerKm;
            this.PassenersCapacity = passenersCapacity;
            this.TicketsSold = ticketsSold;
        }

        public int FuelTankCapacity {
            get { return fuelTankCapacity; }
            set { fuelTankCapacity = value; }
        }

        public double DistancePerKm {
            get { return distancePerKm; }
            set { distancePerKm = value; }
        }

        public double flightDistance(int fuelCapacity) {
            if (fuelCapacity > FuelTankCapacity) {
                throw new System.Exception("[Danger] Fuel capacity is greater then tank capacity!");
            }
            double distance = fuelCapacity * distancePerKm;
            return distance;
        }

        public double flightMaxDistance() {
            return flightDistance(fuelTankCapacity);
        }

        public string information() {
            return $@"
            Plane Data:

            Plane has maximum fuel capacity of {fuelTankCapacity}L
            Can fly {distancePerKm}km per liter of fuel
            Maximum flight distance: {flightMaxDistance()}km.
            It can house {PassenersCapacity} passengers.
            Tickets sold: {TicketsSold}.
            ";
        }
    }
}
