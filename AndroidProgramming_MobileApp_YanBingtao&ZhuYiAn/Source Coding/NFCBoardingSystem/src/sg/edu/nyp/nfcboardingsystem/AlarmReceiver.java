package sg.edu.nyp.nfcboardingsystem;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.media.Ringtone;
import android.media.RingtoneManager;
import android.net.Uri;
import android.widget.Toast;

public class AlarmReceiver extends BroadcastReceiver {

	
	 @Override
	 public void onReceive(Context arg0, Intent arg1) {
	  Toast.makeText(arg0, R.string.it_s_time_for_boarding_, Toast.LENGTH_LONG).show();
	  Uri alarmUri=RingtoneManager.getDefaultUri(RingtoneManager.TYPE_ALARM);
		if (alarmUri ==null)
		{
			alarmUri=RingtoneManager.getDefaultUri(RingtoneManager.TYPE_NOTIFICATION);
		}
		
		Ringtone ringtone=RingtoneManager.getRingtone(arg0, alarmUri);
		ringtone.play();
		
	}
}
