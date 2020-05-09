package sg.edu.nyp.nfcboardingsystem;


import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends Activity {
	
	Button btnCheckIn,btnBoardingPass,btnContactInfo;
	private static final int REQUEST_CODE = 10;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		btnCheckIn = (Button) findViewById(R.id.btnCheckIn);
		btnBoardingPass = (Button) findViewById(R.id.btnBoardingPass);
		btnContactInfo= (Button) findViewById(R.id.btnContactInfo);
		
		btnCheckIn.setOnClickListener(new View.OnClickListener()
        {
        	public void onClick(View v) 
        	{
        	 //call for the new page
        	Intent intent = new Intent(getApplicationContext(), checkin_page1.class);
        	startActivityForResult(intent, REQUEST_CODE);
        	}
        	});
        
		btnBoardingPass.setOnClickListener(new View.OnClickListener()
        {
        	public void onClick(View v) 
        	{
        	Intent intent = new Intent(getApplicationContext(), LoginActivity.class);
        	startActivityForResult(intent, REQUEST_CODE);
        	}
        	});
		
		btnContactInfo.setOnClickListener(new View.OnClickListener()
        {
        	public void onClick(View v) 
        	{
        	Intent intent = new Intent(getApplicationContext(), contact_page1.class);
        	startActivityForResult(intent, REQUEST_CODE);
        	}
        	});
		
	}
}
