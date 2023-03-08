namespace Quiz1 {
    internal class Train {
        private int carriages;
        private int passengersPerCarriage;
        public double TicketPrice { get; set; }
        public int TicketsSold { get; set; }

        public Train(int carriages, int passengersPerCarriage) {
            this.carriages = carriages;
            this.passengersPerCarriage = passengersPerCarriage;
        }

        public Train(int carriages, int passengersPerCarriage, double ticketPrice, int ticketsSold) {
            this.carriages = carriages;
            this.passengersPerCarriage = passengersPerCarriage;
            this.TicketPrice = ticketPrice;
            this.TicketsSold = ticketsSold;
        }

        public int Carriages {
            get { return carriages; }
            set { carriages = value; }
        }

        public int PassengersPerCarriage {
            get { return passengersPerCarriage; }
            set { passengersPerCarriage = value; }
        }

        public double Revenue {
            get { return TicketPrice * TicketsSold; }
        }

        public string information() {
            return $@"
            Train Data:
            
            Train carrige count: {carriages},
            Passengers per carrige: {passengersPerCarriage}
            Total passengers: {carriages * passengersPerCarriage},
            Ticket price: {TicketPrice} 
            Tickets sold: {TicketsSold}
            Revenue: {Revenue}
            ";
        }
    }
}