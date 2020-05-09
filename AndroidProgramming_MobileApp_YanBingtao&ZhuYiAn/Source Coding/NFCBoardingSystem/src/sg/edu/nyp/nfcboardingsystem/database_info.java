package sg.edu.nyp.nfcboardingsystem;

public class database_info {
	private int id;
	private String passenger_name,passport_number,Nationality,Gender,ETNo,FlightNumber,strFrom,strTo,SeatNumber;
	private String BoardingGate,BoardingTime,Date;
	
	public database_info(){                 
	} 
	
	
	public database_info(String passenger_name, String passport_number
			,String Nationality,
			String Gender, String ETNo,String FlightNumber, String strFrom,
			String strTo, String SeatNumber,String BoardingGate, String BoardingTime,String Date){   
		      
		this.passenger_name = passenger_name;
		this.passport_number = passport_number;
		this.Nationality 	= Nationality;
		this.Gender 	= Gender;
		this.ETNo = ETNo;
		
		this.FlightNumber 	= FlightNumber;
		this.strFrom = strFrom;
		this.strTo = strTo;
		this.SeatNumber = SeatNumber;
		this.BoardingGate 	= BoardingGate;
		this.BoardingTime = BoardingTime;
		this.Date 	= Date;
		
	}   
	
	public database_info(int id, String passenger_name, String passport_number
			,String Nationality,
			String Gender, String ETNo,String FlightNumber, String strFrom,
			String strTo, String SeatNumber,String BoardingGate, String BoardingTime,String Date){   
		
		this.id 	= id;         
		this.passenger_name 	= passenger_name;
		this.passport_number = passport_number;
		this.Nationality 	= Nationality;
		this.Gender 	= Gender;
		this.ETNo = ETNo;
		this.FlightNumber 	= FlightNumber;
		this.strFrom = strFrom;
		this.strTo 	= strTo;
		this.SeatNumber = SeatNumber;
		this.BoardingGate 	= BoardingGate;
		this.BoardingTime = BoardingTime;
		this.Date 	= Date;
	}   
	
	
	public int getId() {
		return id; 
	}
	
	public void setId (int id){
		this.id = id;
	}
	
	
	public String getPassengerName() {
		return passenger_name;
	}
	
	public void setPassengerName(String passenger_name) {
		this.passenger_name = passenger_name;
	}

	
	public String getPassportNumber() {
		return passport_number;
	}
	
	public void setPassportNumber(String passport_number) {
		this.passport_number = passport_number;
	}


	public String getNationality() {
		return Nationality;
	}
	
	public void setNationality(String Nationality) {
		this.Nationality = Nationality;
	}
	
	public String getGender() {
		return Gender;
	}
	
	public void setGender(String Gender) {
		this.Gender = Gender;
	}
	
	public String getETNo() {
		return ETNo;
	}
	
	public void setETNo(String ETNo) {
		this.ETNo = ETNo;
	}
	
	public String getFlightNumber() {
		return FlightNumber;
	}
	
	public void setFlightNumber(String FlightNumber) {
		this.FlightNumber = FlightNumber;
	}
	
	public String getFromDeparture() {
		return strFrom;
	}
	
	public void setFromDeparture(String strFrom) {
		this.strFrom = strFrom;
	}
	
	public String getToDestination() {
		return strTo;
	}
	
	public void setToDestination(String strTo) {
		this.strTo = strTo;
	}
	
	public String getSeatNumber() {
		return SeatNumber;
	}
	
	public void setSeatNumber(String SeatNumber) {
		this.SeatNumber = SeatNumber;
	}
	
	
	public String getBoardingGate() {
		return BoardingGate;
	}
	
	public void setBoardingGate(String BoardingGate) {
		this.BoardingGate = BoardingGate;
	}
	
	public String getBoardingTime() {
		return BoardingTime;
	}
	
	public void setBoardingTime(String BoardingTime) {
		this.BoardingTime = BoardingTime;
	}
	
	public String getDate() {
		return Date;
	}
	
	public void setDate(String Date) {
		this.Date = Date;
	}
}
