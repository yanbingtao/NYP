package sg.edu.nyp.nfcboardingsystem;

import java.io.IOException;
import java.io.UnsupportedEncodingException;
import java.util.List;
import java.util.Locale;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.PendingIntent;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.location.Address;
import android.location.Criteria;
import android.location.Geocoder;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.net.Uri;
import android.nfc.NdefMessage;
import android.nfc.NdefRecord;
import android.nfc.NfcAdapter;
import android.nfc.NfcManager;
import android.nfc.Tag;
import android.os.Bundle;
import android.os.Parcelable;
import android.speech.tts.TextToSpeech;
import android.util.Log;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class boardingpass_page1  extends Activity  implements LocationListener{

	NfcAdapter nfcAdapter;
	PendingIntent pendingIntent;
	Tag tag;
	TextView txtRead,txtReadPassengerName,txtReadPassportNumber,txtReadNationality,txtReadGender,txtReadETNo,
		     txtReadFlightNo,txtReadFrom,txtReadTo,txtReadSeatNo,txtReadBoardingGate,txtReadBoardingTime,txtReadDate;
	//for Text To Speech==============================
	String speechContent;
    EditText editTextSpeech;
    TextToSpeech textToSpeech;
    //================================================
	
    //For Address (Map)
    TextView txtAdd;
    LocationManager locationManager;
    String provider;
    double lat, lng;
    Button btnShowMap; 
    private Button mainBtn;
    
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.boardingpass_page1);
        
        //alert alarm
        mainBtn = (Button) findViewById(R.id.button);	
		mainBtn.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				openAlert(v);
			}
		});
        
        NfcManager manager = (NfcManager) this.getSystemService(Context.NFC_SERVICE);
		nfcAdapter = manager.getDefaultAdapter();
				
		pendingIntent = PendingIntent.getActivity(this, 0, 
			new Intent(this,getClass()).addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP), 0);
		
		txtRead = (TextView) findViewById(R.id.PassengerName);
		
		txtReadPassengerName = (TextView) findViewById(R.id.PassengerName);
		txtReadPassportNumber = (TextView) findViewById(R.id.Passport_number);
		txtReadNationality = (TextView) findViewById(R.id.Nationality);
		txtReadGender = (TextView) findViewById(R.id.Gender);
		txtReadETNo = (TextView) findViewById(R.id.ETNo);
		
		txtReadFlightNo = (TextView) findViewById(R.id.FlightNo);
		txtReadFrom =(TextView) findViewById(R.id.From);
		txtReadTo = (TextView) findViewById(R.id.To);
		txtReadSeatNo = (TextView) findViewById(R.id.SeatNo);
		txtReadBoardingGate = (TextView) findViewById(R.id.BoardingGate);
		txtReadBoardingTime = (TextView) findViewById(R.id.BoardingTime);
		txtReadDate = (TextView) findViewById(R.id.Date);
		
		//for Text To Speech===============
		editTextSpeech=(EditText)findViewById(R.id.SpeechTextContant);
        textToSpeech=new TextToSpeech(boardingpass_page1.this, new TextToSpeech.OnInitListener() {

            @Override
            public void onInit(int status) {
                if(status == TextToSpeech.SUCCESS){
                    int result=textToSpeech.setLanguage(Locale.US);
                    if(result==TextToSpeech.LANG_MISSING_DATA ||
                            result==TextToSpeech.LANG_NOT_SUPPORTED){
                        Log.e(getString(R.string.error), getString(R.string.this_language_is_not_supported));
                    }
                    //else{
                    //	ConvertTextToSpeech();
                    //}
                }
                else
                    Log.e(getString(R.string.error), getString(R.string.initilization_failed_));
            }
        });
		//=================================
		
        //For Address (Map)================
        txtAdd = (TextView) findViewById(R.id.Address);
        
        locationManager = (LocationManager) getSystemService(Context.LOCATION_SERVICE);
        
        Criteria criteria = new Criteria();
        provider = locationManager.getBestProvider(criteria, false);
        Location location = locationManager.getLastKnownLocation(provider);
        if (location != null) {
        Toast.makeText(this, R.string.provider_ + provider + R.string._has_been_selected_,
        Toast.LENGTH_SHORT).show();
        }  else 
        {
        	txtAdd.setText(R.string.address_not_available);
        }
        
        	//btnShowMap pressed, then do these:
        btnShowMap = (Button) findViewById(R.id.btnMap);
        btnShowMap.setOnClickListener(new View.OnClickListener() {              
	      	public void onClick(View v) { 	     
	      		Intent intent = null;
	      		intent = new Intent(Intent.ACTION_VIEW,
		        Uri.parse("geo:"+lat+","+lng));
	      		startActivity(intent);
	      	}
	      	});
        //=================================
    }
    
    private void openAlert(View view) {
		 AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(boardingpass_page1.this);
	     
		 alertDialogBuilder.setTitle(this.getTitle()+ " decision");
		 alertDialogBuilder.setMessage(R.string.would_you_like_to_set_an_alarm_);
		 // set positive button: Yes message
		 alertDialogBuilder.setPositiveButton("Yes",new DialogInterface.OnClickListener() {
				public void onClick(DialogInterface dialog,int id) {
					// go to a new activity of the app
					Intent positveActivity = new Intent(getApplicationContext(), PositiveActivity.class);
		            startActivity(positveActivity);	
				}
			  });
		 // set negative button: No message
		 alertDialogBuilder.setNegativeButton("No",new DialogInterface.OnClickListener() {
				public void onClick(DialogInterface dialog,int id) {
					// cancel the alert box and put a Toast to the user
					dialog.cancel();
					Toast.makeText(getApplicationContext(), R.string.please_remember_your_flight_time_do_not_miss_the_boarding_time_, 
							Toast.LENGTH_LONG).show();
				}
			});
		 // set neutral button: Exit the app message
		 alertDialogBuilder.setNeutralButton(R.string.exit_the_app,new DialogInterface.OnClickListener() {
				public void onClick(DialogInterface dialog,int id) {
					// exit the app and go to the HOME
			boardingpass_page1.this.finish();
				}
			});
		 
		 AlertDialog alertDialog = alertDialogBuilder.create();
		 // show alert
		 alertDialog.show();
	}

    
    @Override
   	protected void onResume() {
   		super.onResume();
   		
   		nfcAdapter.enableForegroundDispatch(this, pendingIntent, null, null);
   		
   		locationManager.requestLocationUpdates(provider, 400, 1, this);
    }
   		
   	@Override
   	protected void onPause() {
   		super.onPause();
   		
   		locationManager.removeUpdates(this);
   		
   		nfcAdapter.disableForegroundDispatch(this);
   		//for Text To Speech==================
   		if(textToSpeech != null){

        	textToSpeech.stop();
        	textToSpeech.shutdown();
        }
   		//====================================
   	}
   	
   	//for Text To Speech==============================================
   	//when the btn "speech" pressed, do this
  
   	public void SpeechContentOnClick(View v){

        ConvertTextToSpeech();

    }
   	
   	// read out the text content
    private void ConvertTextToSpeech() {
    	speechContent = editTextSpeech.getText().toString();
    	
    	
        if(speechContent==null||"".equals(speechContent))
        {
        	speechContent = getString(R.string.content_not_available);
        	textToSpeech.speak(speechContent, TextToSpeech.QUEUE_FLUSH, null);
        }
        else
        {   
        	textToSpeech.speak(speechContent, TextToSpeech.QUEUE_FLUSH, null);
        //textToSpeech.speak("Passenger"+txtRead0+"    ", TextToSpeech.QUEUE_FLUSH, null);
    	//textToSpeech.speak("Boarding Time"+txtRead5+"on the day of"+txtRead6, TextToSpeech.QUEUE_FLUSH, null);
        }
    }
  //===================================================================
    
   	@Override
	protected void onNewIntent(Intent intent) {
		tag = intent.getParcelableExtra(NfcAdapter.EXTRA_TAG);
		Toast.makeText(getBaseContext(), R.string.tag_detected_, Toast.LENGTH_LONG).show();
		
		NdefMessage[] msgs;
		if (NfcAdapter.ACTION_NDEF_DISCOVERED.equals(intent.getAction())) {
			Parcelable[] rawMsgs = intent.getParcelableArrayExtra(NfcAdapter.EXTRA_NDEF_MESSAGES);
			
			if (rawMsgs != null) {
				msgs = new NdefMessage[rawMsgs.length];
				String content = "";
				
				for (int i=0; i < rawMsgs.length; i++) {
					msgs[i] = (NdefMessage) rawMsgs[i];
					NdefRecord[] records = msgs[i].getRecords();
					
					for (int j=0; j < records.length; j++) {
						NdefRecord record = records[j];
						byte[] payload = record.getPayload();
						String recordType = new String(record.getType());
						
						if (recordType.equals("T")) {
							String textEncoding = ((payload[0] & 0200) == 0) ? "UTF-8" : "UTF-16";
							try {
								int langCodeLen= payload[0] & 0077;
								content += new String(payload, langCodeLen + 1, payload.length - langCodeLen - 1, textEncoding) + "\n"; 															
							} catch (UnsupportedEncodingException e) {
								e.printStackTrace();
							}
						}
						
						if (recordType.equals("U")) {
							content += new String(payload) + "\n";
						}
					}
				}
				txtRead.setText(content);
				
				String[] tmp = txtRead.getText().toString().split("\n");
	
				txtReadPassengerName.setText(tmp[0]);
				txtReadPassportNumber.setText(tmp[1]);
				txtReadNationality.setText(tmp[2]);
				txtReadGender.setText(tmp[3]);
				txtReadETNo.setText(tmp[4]);
				
				//txtReadFlightNo,txtReadFrom,txtReadTo,txtReadSeatNo,txtReadBoardingGate
				txtReadFlightNo.setText(tmp[5]);
				txtReadFrom.setText(tmp[6]);
				txtReadTo.setText(tmp[7]);
				txtReadSeatNo.setText(tmp[8]);
				txtReadBoardingGate.setText(tmp[9]);
				txtReadBoardingTime.setText(tmp[10]);
				txtReadDate.setText(tmp[11]);
				
				
				//for Text To Speech===============
				editTextSpeech=(EditText)findViewById(R.id.SpeechTextContant);
		        

				editTextSpeech.setText(getString(R.string.passenger_name_)+tmp[0]+"\n"+getString(R.string.your_flight_number_is_)+tmp[5]+".\n"+getString(R.string.your_flight_is_from_)+tmp[6]+" to "+tmp[7]+"\n" + getString(R.string._your_boarding_gate_is_)+tmp[9], TextView.BufferType.EDITABLE);
				
				textToSpeech=new TextToSpeech(boardingpass_page1.this, new TextToSpeech.OnInitListener() {

		            @Override
		            public void onInit(int status) {
		                if(status == TextToSpeech.SUCCESS){
		                    int result=textToSpeech.setLanguage(Locale.US);
		                    if(result==TextToSpeech.LANG_MISSING_DATA ||
		                            result==TextToSpeech.LANG_NOT_SUPPORTED){
		                        Log.e(getString(R.string.error), getString(R.string.this_language_is_not_supported));
		                    }
		                    else{
		                    	ConvertTextToSpeech();
		                    }
		                }
		                else
		                    Log.e(getString(R.string.error), getString(R.string.initilization_failed_));
		            }
		        });
				//=================================
				
			}
		}	
	}

	@Override
	public void onLocationChanged(Location location) {
		// TODO Auto-generated method stub
		lat = location.getLatitude();
		lng = location.getLongitude();
		
		Geocoder geoCoder = new Geocoder(getBaseContext(), Locale.getDefault());
		 try {
		List<Address> addresses = geoCoder.getFromLocation(lat, lng, 1);
		if (addresses.size() > 0)
		txtAdd.setText("Address: " + addresses.get(0).getAddressLine(0)
		+ " Singapore "+ addresses.get(0).getPostalCode());
		 }
		 catch (IOException e) {
		Toast.makeText(this, "Error in reverse geocoding",
		 Toast.LENGTH_SHORT).show();
		 } 
	}

	@Override
	public void onStatusChanged(String provider, int status, Bundle extras) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void onProviderEnabled(String provider) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void onProviderDisabled(String provider) {
		// TODO Auto-generated method stub
		Toast.makeText(this, "Disabled provider " + provider,
				 Toast.LENGTH_SHORT).show();
	}
	
	

}
