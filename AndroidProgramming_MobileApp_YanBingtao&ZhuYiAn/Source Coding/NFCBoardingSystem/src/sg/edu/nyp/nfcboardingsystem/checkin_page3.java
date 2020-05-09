package sg.edu.nyp.nfcboardingsystem;

import java.io.IOException;
import java.nio.charset.Charset;
import java.util.ArrayList;
import java.util.Locale;

import android.app.Activity;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.nfc.FormatException;
import android.nfc.NdefMessage;
import android.nfc.NdefRecord;
import android.nfc.NfcAdapter;
import android.nfc.NfcManager;
import android.nfc.Tag;
import android.nfc.tech.Ndef;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class checkin_page3 extends Activity{

	NfcAdapter nfcAdapter;
	PendingIntent pendingIntent;
	String strName, strPassport, strNationality, strGender, strETNo,
		   strFlightNo,strFrom,strTo,strSeatNo;
	Tag tag;
	String strBoardingTime,strDate,strBoardingGate;
	//for BoardingTime
	int hour,min,month,day,year;
	
	//Database
		private DatabaseHandler db;
		EditText txtPassengerName, txtPassportNumber,txtNationality,txtGender,txtETNo,txtFlightNumber,txtFrom,
			     txtTo,txtSeatNumber,txtBoardingGate,txtBoardingTime,txtDate;
		ArrayList<String> ArrayofName = new ArrayList<String>();
		static ArrayAdapter<String> dbAdapter;
		//Database_end
	
	 @Override
	 protected void onCreate(Bundle savedInstanceState){
		 super.onCreate(savedInstanceState);
		 setContentView(R.layout.checkin_page3);
		 
		//Getting inputs from previous Activity
		    Bundle extras = getIntent().getExtras();
		    
		 strName = extras.getString("Name");
     	 strPassport = extras.getString("Passport");
     	 strNationality = extras.getString("Nationality");
     	 strGender = extras.getString("Gender");
     	 strETNo = extras.getString("ETNo");
     	 strFlightNo= extras.getString("FlightNo");
     	 strFrom= extras.getString("From");
     	 strTo= extras.getString("To");
     	 strSeatNo= extras.getString("SeatNo");
     	
     	//Database
      	db = new DatabaseHandler(this);
 		dbAdapter = new ArrayAdapter<String>(this, 
 			    	android.R.layout.simple_list_item_1, android.R.id.text1, ArrayofName);
      	 //Database_end
     	 
		//write the info to the textview    
		    TextView textView1 = (TextView) findViewById(R.id.textView1);
		    textView1.setText(strName + 
		    		" (" + strPassport +" "+ strGender + ") ." + "\n" +strNationality+
		    		"\n" +strETNo);
		    
		//NFC
		 NfcManager manager = (NfcManager) this.getSystemService(Context.NFC_SERVICE);
			nfcAdapter = manager.getDefaultAdapter();
		//Call Intent		
			pendingIntent = PendingIntent.getActivity(this, 0, 
			new Intent(this,getClass()).addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP), 0);
	 }

	 @Override
		protected void onResume() {
			super.onResume();
			nfcAdapter.enableForegroundDispatch(this, pendingIntent, null, null);
		}
			
		@Override
		protected void onPause() {
			super.onPause();
			nfcAdapter.disableForegroundDispatch(this);
		}

		@Override
		protected void onNewIntent(Intent intent) {
			tag = intent.getParcelableExtra(NfcAdapter.EXTRA_TAG);
			Toast.makeText(getBaseContext(), R.string.tag_detected_, Toast.LENGTH_LONG).show();
		}
		
		public void WritePassengerInfo(View v)
		//When btn Confirm Clicked, do these:
		{
			//Boarding Time
			EditText ed1=(EditText)findViewById(R.id.BoardingTime);
			strBoardingTime=ed1.getText().toString();
			
			EditText ed2=(EditText)findViewById(R.id.Date);
			strDate=ed2.getText().toString();
			
			EditText ed3=(EditText)findViewById(R.id.BoardingGate);
			strBoardingGate=ed3.getText().toString();
			


		
			//check any empty blanks
		if ((strName.length()<1)||(strPassport.length()<1)||(strNationality.length()<1)||(strGender.length()<1)
				||(strETNo.length()<1)||(strFlightNo.length()<1)||(strFrom.length()<1)||(strTo.length()<1)
				||(strSeatNo.length()<1)||(strBoardingGate.length()<1)||(strBoardingTime.length()<1)||(strDate.length()<1))
			{
				//if there where any fields haven't been filled, show this:
				Toast.makeText(this,"Please fill in all necessary fields!", Toast.LENGTH_LONG).show();
			}
		else{
			try
			{
				//see whether hour,min,month,day,year are in correct format
				//for boarding time (hhmm)
				//eg:2324/100=23
				hour= Integer.parseInt(strBoardingTime)/100;
				//eg:2324-2300=24
				min=Integer.parseInt(strBoardingTime)-hour*100;
				
				//for date (ddmmyyyy)
				day=Integer.parseInt(strDate)/1000000;
				month=(Integer.parseInt(strDate)-day*1000000)/10000;
				year=Integer.parseInt(strDate)-day*1000000-month*10000;
				
				//check boarding time in correct range (00~23)
				if ((hour>=0)&&(hour<=23))
				{
					if ((min>=00)&&(min<=59))
					{
						if ((day>=00)&&(day<=31))
						{
							if ((month>=01)&&(month<=12))
							{
								if ((year>2015))
								{
									//if all the time and date format are correct:
									//write
									try {
										if (tag != null) 
										{			
											NdefRecord txtRecord1 = createTextRecord(strName, 
													Locale.ENGLISH, true);
											NdefRecord txtRecord2 = createTextRecord(strPassport, 
													Locale.ENGLISH, true);
											NdefRecord txtRecord3 = createTextRecord(strNationality, 
													Locale.ENGLISH, true);
											NdefRecord txtRecord4 = createTextRecord(strGender, 
													Locale.ENGLISH, true);
											NdefRecord txtRecord5 = createTextRecord(strETNo, 
													Locale.ENGLISH, true);
											NdefRecord txtRecord6 = createTextRecord(strFlightNo, 
													Locale.ENGLISH, true);
											NdefRecord txtRecord7 = createTextRecord(strFrom, 
													Locale.ENGLISH, true);
											NdefRecord txtRecord8 = createTextRecord(strTo, 
													Locale.ENGLISH, true);
											NdefRecord txtRecord9 = createTextRecord(strSeatNo, 
													Locale.ENGLISH, true);
											NdefRecord txtRecord10 = createTextRecord(strBoardingGate, 
													Locale.ENGLISH, true);
											NdefRecord txtRecord11 = createTextRecord(strBoardingTime, 
													Locale.ENGLISH, true);
											NdefRecord txtRecord12 = createTextRecord(strDate, 
													Locale.ENGLISH, true);
											
											
											
											
											NdefRecord[] ndefRecords = {txtRecord1,txtRecord2,txtRecord3,
													txtRecord4,txtRecord5,txtRecord6,txtRecord7,txtRecord8,
													txtRecord9,txtRecord10,txtRecord11,txtRecord12};
											write(tag, ndefRecords);
											
											//Database
											//database_info tmp = new database_info("aa","11");
											database_info tmp = new database_info(
													strName,strPassport,strNationality,
													strGender,strETNo,strFlightNo,strFrom,strTo,strSeatNo,strBoardingGate,
													strBoardingTime,strDate);
											db.addInfo(tmp);											
											//Database_end
										}
										else 
											Toast.makeText(getBaseContext(), R.string.no_tag_detected_,                       
													Toast.LENGTH_LONG).show();
									} catch (IOException e) {
										e.printStackTrace();
									} catch (FormatException e) {
										e.printStackTrace();
									}	
									
									//if all the time and date format are correct_END
								}
								else
								{
									//if the year is smaller 2016, then show this msg:
									Toast.makeText(this,"Please enter the valid year", Toast.LENGTH_LONG).show();
								}
							}
							else
							{
								//if the month is out of the range, then show this msg:
								Toast.makeText(this,"Please enter the month form 01~12", Toast.LENGTH_LONG).show();
							}
						}
						else 
						{
							//if the day is out of the range, then show this msg:
							Toast.makeText(this,"Please enter the day form 00~31", Toast.LENGTH_LONG).show();
						
						}
					}
					else
					{
						//if the min is out of the range, then show this msg:
						Toast.makeText(this,"Please enter the Min form 00~59", Toast.LENGTH_LONG).show();
					}
				}
				else
				{
					//if the hour is out of the range, then show this msg:
					Toast.makeText(this, "Please enter the hour form 00~23", Toast.LENGTH_LONG).show();
				} 
				
			}
			catch (NumberFormatException e)
			{
				Toast.makeText(this, "Please enter the date and baording time in the correct format!",
						Toast.LENGTH_LONG).show();
			}
			}
			
			
		}

		private void write(Tag tag, NdefRecord[] ndefRecords) throws IOException, FormatException {
		//write to the tag
			NdefMessage ndefMessage = new NdefMessage(ndefRecords);
			Ndef ndef = Ndef.get(tag);
					
			try{
				if (ndef != null) {
					ndef.connect();
					ndef.writeNdefMessage(ndefMessage);
					ndef.close();
								
					Toast.makeText(this,R.string.tag_written_and_passenger_information_added_to_database_, Toast.LENGTH_LONG).show();
				}		
				else 
					Toast.makeText(this, R.string.tag_is_not_ndef_formatted_or_this_tag_is_ndef_ +
							R.string.formatted_but_under_a_vendor_specification_that_this_android_device_ + 
							R.string.does_not_implement_, Toast.LENGTH_LONG).show();
			} catch (Exception e) {
				Toast.makeText(this, e.toString(), Toast.LENGTH_LONG).show();
			}
		}

		
		public NdefRecord createTextRecord (String payload, Locale locale, 
				boolean encodeInUtf8) {
						
			byte[] langBytes = locale.getLanguage().getBytes(Charset.forName("US-ASCII"));
			Charset utfEncoding = encodeInUtf8 ? 
			Charset.forName("UTF-8") : Charset.forName("UTF-16");
			byte[] textBytes = payload.getBytes(utfEncoding);
			int utfBit = encodeInUtf8 ? 0 : (1<<7);
			char status = (char) (utfBit + langBytes.length);
		
			byte[] data = new byte[1 + langBytes.length + textBytes.length];
			data[0] = (byte) status;
			System.arraycopy(langBytes, 0, data, 1, langBytes.length);
			System.arraycopy(textBytes, 0, data, 1 + langBytes.length, textBytes.length);
					
			NdefRecord record = new NdefRecord(NdefRecord.TNF_WELL_KNOWN, 
			NdefRecord.RTD_TEXT, new byte[0], data);
			return record;
		}

}
