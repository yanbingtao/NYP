package sg.edu.nyp.nfcboardingsystem;


import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class checkin_page1 extends Activity {
	TextView txtRead;
	EditText txtName, txtPassport, txtNationality, txtGender, txtETNo;
	Button btnNextPage;
	private static final int REQUEST_CODE=10;
	
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.checkin_page1);
        
        txtName = (EditText) findViewById(R.id.editText1);
        txtPassport = (EditText) findViewById(R.id.editText2);
		txtNationality = (EditText) findViewById(R.id.editText3);
		txtGender = (EditText) findViewById(R.id.editText4);
		txtETNo = (EditText) findViewById(R.id.editText5);
		btnNextPage=(Button) findViewById(R.id.button2);
		
		
		 btnNextPage.setOnClickListener(new View.OnClickListener() {              
	        	public void onClick(View v) {  
		        	String strName = txtName.getText().toString();
		        	String strPassport = txtPassport.getText().toString();
		        	String strNationality = txtNationality.getText().toString();
		        	String strGender = txtGender.getText().toString();
		        	String strETNo = txtETNo.getText().toString();
		        		
		        	Intent intent = new Intent(getApplicationContext(),
		        		 		                           checkin_page2.class);
					intent.putExtra("Name", strName);
					intent.putExtra("Passport", strPassport);
					intent.putExtra("Nationality", strNationality);
					intent.putExtra("Gender", strGender);
					intent.putExtra("ETNo", strETNo);
					
					//REQUIST CODE******************************************
					startActivityForResult(intent, REQUEST_CODE);
	        	}
		 });
    }

}
