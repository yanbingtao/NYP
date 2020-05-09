package sg.edu.nyp.nfcboardingsystem;


import android.app.Activity;
import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;


public class LoginActivity extends Activity {
	private EditText username;
	private EditText password;
	private Button login;
	private TextView loginLockedTV;
	private TextView attemptsLeftTV;
	private TextView numberOfRemainingLoginAttemptsTV;
	int numberOfRemainingLoginAttempts = 3;
	private static final int REQUEST_CODE = 10;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.login_view);
		setupVariables();
	}
	
	public void authenticateLogin(View view) {
		if (username.getText().toString().equals("test") && 
				password.getText().toString().equals("test")) {
			//Call for next page if user name and password matching
			Toast.makeText(getApplicationContext(), R.string.welcome_back_, 
			Toast.LENGTH_SHORT).show();
			//Intent boardingpass_page1 = new Intent(getApplicationContext(), boardingpass_page1.class);
            //startActivity(boardingpass_page1);	
            Intent intent = new Intent(getApplicationContext(), boardingpass_page1.class);
        	startActivityForResult(intent, REQUEST_CODE);
			//********************
		} else {
			Toast.makeText(getApplicationContext(), R.string.wrong_password_, 
					Toast.LENGTH_SHORT).show();
			numberOfRemainingLoginAttempts--;
			attemptsLeftTV.setVisibility(View.VISIBLE);
			numberOfRemainingLoginAttemptsTV.setVisibility(View.VISIBLE);
			numberOfRemainingLoginAttemptsTV.setText(Integer.toString(numberOfRemainingLoginAttempts));
			
			if (numberOfRemainingLoginAttempts == 0) {
				login.setEnabled(false);
				loginLockedTV.setVisibility(View.VISIBLE);
				loginLockedTV.setBackgroundColor(Color.RED);
				loginLockedTV.setText(R.string.login_locked_);
			}
		}
	}

	private void setupVariables() {
		username = (EditText) findViewById(R.id.usernameET);
		password = (EditText) findViewById(R.id.passwordET);
		login = (Button) findViewById(R.id.loginBtn);
		loginLockedTV = (TextView) findViewById(R.id.loginLockedTV);
		attemptsLeftTV = (TextView) findViewById(R.id.attemptsLeftTV);
		numberOfRemainingLoginAttemptsTV = (TextView) findViewById(R.id.numberOfRemainingLoginAttemptsTV);
		numberOfRemainingLoginAttemptsTV.setText(Integer.toString(numberOfRemainingLoginAttempts));
	}
	
}
	


