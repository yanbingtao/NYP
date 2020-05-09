package sg.edu.nyp.nfcboardingsystem;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;

public class contact_page2 extends Activity{

	
	Spinner spinner;
	Button btnIntent; 
	
	//TextView dataMobile,txtRead; 
	
	protected void onCreate(Bundle savedInstanceState) {
		 super.onCreate(savedInstanceState);
		 setContentView(R.layout.contact_page2);
		

		 
		
		 
		 //Populating the Spinner
		 spinner = (Spinner) findViewById(R.id.spinner1);

		 ArrayAdapter adapter = ArrayAdapter.createFromResource(this,
				 R.array.spinner, android.R.layout.simple_spinner_item);
		 
		 adapter.setDropDownViewResource(
				 android.R.layout.simple_spinner_dropdown_item);
		 
		 spinner.setAdapter(adapter);
		 btnIntent = (Button) findViewById(R.id.button1);
      	 btnIntent.setOnClickListener(new View.OnClickListener() {
			 
      		 
      		 
			// TextView dataMobile = (TextView) findViewById(R.id.textViewContact); 	
			
			 
			 
			 
			 public void onClick(View v) {
				 
		//**************Retrieve information from previous page to spinner
				 Bundle extras = getIntent().getExtras();
				 String strNumber = extras.getString ("Phone");
				 String strEmail = extras.getString ("Email");
		 
				 //if (strNumber=="")
				 //{
					// Toast.makeText(this, "Contact Empty!", Toast.LENGTH_LONG).show();
				 //}
				 //else
				 //{
				 int position = spinner.getSelectedItemPosition();
				 Intent intent = null;
				 switch (position) {
				 case 0:
		
					 
					intent = new Intent(Intent.ACTION_DIAL,Uri.parse("tel:" +  strNumber ));
					

					 break;
		 
				 case 1:
					 intent = new Intent(Intent.ACTION_VIEW,Uri.parse("smsto:" +  strNumber ));
					
		 
					 
					 intent.putExtra("address", strNumber);
					 intent.putExtra("sms_body", "--Generated by NFC Boarding System--");
					 intent.setType("vnd.android-dir/mms-sms");
					 
					 break;
				 case 2:
					 
			 		intent = new Intent(Intent.ACTION_SEND);
			 		intent.putExtra(Intent.EXTRA_EMAIL,	new String[] { strEmail });
			 		intent.putExtra(Intent.EXTRA_SUBJECT, "--Generated by NFC Boarding System--");
			 		intent.putExtra(Intent.EXTRA_TEXT, "--Generated by NFC Boarding System--");
			 		intent.setType("message/rfc822");
			 		
			 		break;
		 }
				 
		 if (intent != null) {
		 startActivity(intent);
		 }
		}
		//}
		 });
		 }
	
}
