namespace Quiz1 {
    internal class Car {
        private string color;
        private int numberOfDoors;
        public string ownerLastName { get; set; }
        public string issuingCompany { get; set; }

        public Car(string color, int numberOfDoors) {
            this.color = color;
            this.numberOfDoors = numberOfDoors;
        }

        public Car(string color, int numberOfDoors, string ownerLastName, string issuingCompany) {
            this.color = color;
            this.numberOfDoors = numberOfDoors;
            this.ownerLastName = ownerLastName;
            this.issuingCompany = issuingCompany;
        }
            
        public string information() {
            return $@"
            Car Description:

            Color: {color},
            Number Of Doors: {numberOfDoors}
            Owner Last Name: {ownerLastName}
            Issuing Company: {issuingCompany}
            ";
        }
    }
}
