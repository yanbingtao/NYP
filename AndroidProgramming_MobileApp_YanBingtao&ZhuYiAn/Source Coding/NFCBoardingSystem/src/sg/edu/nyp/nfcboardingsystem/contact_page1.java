package sg.edu.nyp.nfcboardingsystem;

import java.io.UnsupportedEncodingException;
import java.util.ArrayList;
import java.util.List;

import android.app.Activity;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.nfc.NdefMessage;
import android.nfc.NdefRecord;
import android.nfc.NfcAdapter;
import android.nfc.NfcManager;
import android.nfc.Tag;
import android.os.Bundle;
import android.os.Parcelable;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

public class contact_page1 extends Activity{
	NfcAdapter adapter;
	PendingIntent pendingIntent;
	Tag tag;
	TextView txtRead;
	String text;
	String text2;
	String text3;
	TextView txtName,txtContact,txtEmail;
	TextView dataName,dataMobile,dataEmail;

	TextView txtTelNumber;
	TextView txtEmailAddress;
	//configurebuttontogonextpage
	Button btnContinue;
	
	//private static final int REQUEST_CODE = 10;

	//DATABASE-----------------------------------------------
		private contact_databasehandler db;
		ListView lvInfo;
		//EditText txtName, txtMobile;
		ArrayList<String> ArrayofName = new ArrayList<String>();
		List<contact_info> contacts;
		static ArrayAdapter<String> dbAdapter;
		//DATABASE_END-------------------------------------------------
		
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.contact_page1);
        
      //BTNContinue Presses, then do this
        btnContinue = (Button) findViewById(R.id.btnContinue);
        btnContinue.setOnClickListener(new View.OnClickListener() {
        	public void onClick(View v) {
        	if ((txtName.getText().length() == 0) ||(txtContact.getText().length() == 0)||(txtEmail.getText().length() == 0))
        	   	{
        		Toast.makeText(getApplication(), "Please tap to get information first, then continue!", Toast.LENGTH_LONG).show();
        	   	}
          	else {
        	// go to next page
        	Intent intent = new Intent(getApplicationContext(), contact_page2.class);
        	//startActivityForResult(intent, REQUEST_CODE);
        	
        	txtTelNumber=  (TextView) findViewById(R.id.textViewContact);
        	// Receive number
        	txtEmailAddress =(TextView) findViewById(R.id.textViewEmail);
        	// For SPINNER--------------------------------------------------------
        	intent.putExtra("Phone",txtTelNumber.getText().toString());
        	intent.putExtra("Email", txtEmailAddress.getText().toString());
        	startActivity(intent);
        	}
        	}
        	});
        
            //SPinner_END----------------------------------------------------------
        
        
    //read nfc tag and display    
    txtRead = (TextView) findViewById(R.id.textView2);
    txtName=(TextView) findViewById(R.id.textView2);
    txtContact=(TextView) findViewById(R.id.textViewContact);
    txtEmail=(TextView) findViewById(R.id.textViewEmail);
    
    NfcManager manager = (NfcManager) this.getSystemService(Context.NFC_SERVICE);
    adapter = manager.getDefaultAdapter();

    pendingIntent = PendingIntent.getActivity(this, 0, new
    Intent(this,getClass()).addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP), 0);
    //Display
    lvInfo = (ListView) findViewById(R.id.listView1);
    dataName = (TextView) findViewById(R.id.textView2);
    dataMobile = (TextView) findViewById(R.id.textViewContact);
    dataEmail = (TextView) findViewById(R.id.textViewEmail);


    db = new contact_databasehandler(this);
    dbAdapter = new ArrayAdapter<String>(this,
    android.R.layout.simple_list_item_1, android.R.id.text1, ArrayofName);
    lvInfo.setAdapter(dbAdapter);
    lvInfo.setOnItemClickListener(new OnItemClickListener() {
    public void onItemClick(AdapterView<?> parent, View view,
    int position, long id) {
    dataName.setText(contacts.get(position).getName());
    dataMobile.setText(contacts.get(position).getMobile());
    dataEmail.setText(contacts.get(position).getEmail());
    }
    });
    DisplayAll();
    }
    
  //DATA--------------------------------------------------
    public void DisplayAll() {
    	contacts = db.getAllContacts();
    	ArrayofName.clear();
    	for (contact_info cn : contacts) {
    	ArrayofName.add(cn.getId() + ".\t" + cn.getName() + ", " + cn.getMobile()+ ", " + cn.getEmail());
    	}
    	dbAdapter.notifyDataSetChanged();
    	}
    
    	public void AddContact(View view)
    	{
    	if ((txtName.getText().length() == 0) ||(txtContact.getText().length() == 0)||(txtEmail.getText().length() == 0))
    	
    		{Toast.makeText(this, "Please tap to get information first, then add to database!",
    		 Toast.LENGTH_LONG).show();
    		}
    	else {
    		contact_info tmp = new contact_info(dataName.getText().toString(),dataMobile.getText().toString(),dataEmail.getText().toString());
    		db.addContact(tmp);
    		DisplayAll();
    		Toast.makeText(this, "Contact Added!", Toast.LENGTH_LONG).show();
    		}
    	}
    	
    	public void DeleteContact(View view)
    	{
    		if ((txtName.getText().length() == 0) ||(txtContact.getText().length() == 0)||(txtEmail.getText().length() == 0))
    	    	{
    			Toast.makeText(this, "Please tap to get information first, then delete from database!",
    	    	Toast.LENGTH_LONG).show();
    			}
    		
    	    else {
    	    	contact_info tmp = new contact_info(dataName.getText().toString(),
    			dataMobile.getText().toString(),dataEmail.getText().toString());
    	    	db.deleteContact(tmp);
    	    	DisplayAll();
    	    	Toast.makeText(this, "Contact Deleted!", Toast.LENGTH_LONG).show();
    	    }
    	}
    	
    	
    //DATA--------------------------------------------------





    @Override
    protected void onResume() {
    super.onResume();
    adapter.enableForegroundDispatch(this, pendingIntent, null, null);
    }

    @Override
    protected void onPause() {
    super.onPause();
    adapter.disableForegroundDispatch(this);
    }

    @Override
    protected void onNewIntent(Intent intent) {
    	tag = intent.getParcelableExtra(NfcAdapter.EXTRA_TAG);
    	Toast.makeText(getBaseContext(), "Tag Detected!", Toast.LENGTH_LONG).show();
    	
    	NdefMessage[] msgs;
    	if (NfcAdapter.ACTION_NDEF_DISCOVERED.equals(intent.getAction())) {
    		Parcelable[] rawMsgs = intent.getParcelableArrayExtra(NfcAdapter.EXTRA_NDEF_MESSAGES);
    		
    	String content = "";
    	if (rawMsgs != null) {
    		msgs = new NdefMessage[rawMsgs.length];
    		

    		
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
    				content += new String(   payload,  langCodeLen + 1  , payload.length -langCodeLen - 1, textEncoding) +  "\n";
    				
    		} catch (UnsupportedEncodingException e) {
    			e.printStackTrace();
    }
    }
    		if (recordType.equals("U")) {
    			content += new String(payload) + "\n";
    	}
    }
    }
    	}
    	//txtRead.setText(content);
    	txtRead.setText(content);

    	String[] array=txtRead.getText().toString().split("\n");
    	
    	txtName.setText(array[0]);
    	txtContact.setText(array[1]);
    	txtEmail.setText(array[2]);
    	}
    }

}
