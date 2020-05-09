package sg.edu.nyp.nfcboardingsystem;

import android.content.ContentValues;
import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.os.Environment;

public class DatabaseHandler extends SQLiteOpenHelper{
	private static final int DATABASE_VERSION = 1;         
	private static final String DATABASE_NAME = 
			Environment.getExternalStorageDirectory().toString() + "/pass_info.db";       
	
	private static final String TABLE_CONTACT = "PassengerInfo";       
  
	private static final String KEY_ID = "id";     
	private static final String KEY_PASSENGERNAME = "passengername";    
	private static final String KEY_PASSPORTNUMBER = "passportnumber";        
	private static final String KEY_Nationality = "Nationality";
	private static final String KEY_Gender = "Gender";
	private static final String KEY_ETNo = "ETNo";
	
	private static final String KEY_FlightNumber = "FlightNumber";
	private static final String KEY_FromDeparture = "From_departure";
	private static final String KEY_ToDestination = "To_destination";
	private static final String KEY_SeatNumber = "SeatNumber";
	private static final String KEY_BoardingGate = "BoardingGate";
	private static final String KEY_BoardingTime = "BoardingTime";
	private static final String KEY_Date = "Date";
	
	public DatabaseHandler(Context context) {         
		super(context, DATABASE_NAME, null, DATABASE_VERSION);     
	}       
	
	// Creating Tables     
	@Override    
	public void onCreate(SQLiteDatabase db) {         
		String CREATE_CONTACTS_TABLE = "CREATE TABLE " + TABLE_CONTACT + "("                
				+ KEY_ID + " INTEGER PRIMARY KEY," + KEY_PASSENGERNAME + " TEXT,"
				+ KEY_PASSPORTNUMBER 
				
				+" TEXT," + KEY_Nationality+" TEXT," 
				+ KEY_Gender +" TEXT," + KEY_ETNo + " TEXT," 
				+ KEY_FlightNumber +" TEXT," + KEY_FromDeparture +" TEXT,"
				+ KEY_ToDestination + " TEXT," + KEY_SeatNumber + " TEXT," 
				+ KEY_BoardingGate + " TEXT," + KEY_BoardingTime + " TEXT," 
				+ KEY_Date 
				
				+ " TEXT)";         
		
		db.execSQL(CREATE_CONTACTS_TABLE);     
	}       
	
	// Upgrading database     
	@Override    
	public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {         
		  
	}
	


	public void addInfo(database_info databaseinfo) {     
		SQLiteDatabase db = this.getWritableDatabase();      
		ContentValues values = new ContentValues();  
		
		values.put(KEY_PASSENGERNAME, databaseinfo.getPassengerName());    
		values.put(KEY_PASSPORTNUMBER, databaseinfo.getPassportNumber());  
		values.put(KEY_Nationality, databaseinfo.getNationality());    
		values.put(KEY_Gender, databaseinfo.getGender()); 
		values.put(KEY_ETNo, databaseinfo.getETNo());  
		values.put(KEY_FlightNumber, databaseinfo.getFlightNumber());    
		values.put(KEY_FromDeparture, databaseinfo.getFromDeparture());  
		values.put(KEY_ToDestination, databaseinfo.getToDestination());    
		values.put(KEY_SeatNumber, databaseinfo.getSeatNumber());  
		values.put(KEY_BoardingGate, databaseinfo.getBoardingGate());  
		values.put(KEY_BoardingTime, databaseinfo.getBoardingTime());    
		values.put(KEY_Date, databaseinfo.getDate());  
		
		db.insert(TABLE_CONTACT, null, values);     
		db.close(); 
	} 
}
