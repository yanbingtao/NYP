package sg.edu.nyp.nfcboardingsystem;


import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class checkin_page2 extends Activity{

	
	String strName, strPassport, strNationality, strGender, strETNo;

	String strFlightNo,strFrom,strTo,strSeatNo;
	EditText txtFlightNo, txtFrom, txtTo, txtSeatNo;
	Button btnNextPage;
	private static final int REQUEST_CODE=10;
	
	 @Override
	 protected void onCreate(Bundle savedInstanceState){
		 super.onCreate(savedInstanceState);
		 setContentView(R.layout.checkin_page2);
		 
		//Getting inputs from previous Activity
		    Bundle extras = getIntent().getExtras();
		    
		     strName = extras.getString("Name");
        	 strPassport = extras.getString("Passport");
        	 strNationality = extras.getString("Nationality");
        	 strGender = extras.getString("Gender");
        	 strETNo = extras.getString("ETNo");
		//write the info to the textview    
		    TextView textView1 = (TextView) findViewById(R.id.textView1);
		    textView1.setText(strName + 
		    		" (" + strPassport +" "+ strGender + ") ." + "\n" +strNationality+
		    		"\n" +strETNo);
		    

		//Read info from this page
		    txtFlightNo = (EditText) findViewById(R.id.FlightNumber);
		    txtFrom = (EditText) findViewById(R.id.From);
		    txtTo = (EditText) findViewById(R.id.To);
		    txtSeatNo = (EditText) findViewById(R.id.SeatNo);
			
			btnNextPage=(Button) findViewById(R.id.button1);
			
			btnNextPage.setOnClickListener(new View.OnClickListener() {              
	        	public void onClick(View v) {  
	        		
		        	strFlightNo = txtFlightNo.getText().toString();
		        	strFrom = txtFrom.getText().toString();
		        	strTo = txtTo.getText().toString();
		        	strSeatNo = txtSeatNo.getText().toString();
		        	
		        		
		        	Intent intent = new Intent(getApplicationContext(),
		        		 		                           checkin_page3.class);
					intent.putExtra("Name", strName);
					intent.putExtra("Passport", strPassport);
					intent.putExtra("Nationality", strNationality);
					intent.putExtra("Gender", strGender);
					intent.putExtra("ETNo", strETNo);
					intent.putExtra("FlightNo", strFlightNo);
					intent.putExtra("From", strFrom);
					intent.putExtra("To", strTo);
					intent.putExtra("SeatNo", strSeatNo);
					
					//REQUIST CODE******************************************
					startActivityForResult(intent, REQUEST_CODE);
	        	}
		 });
		
	 }
}
