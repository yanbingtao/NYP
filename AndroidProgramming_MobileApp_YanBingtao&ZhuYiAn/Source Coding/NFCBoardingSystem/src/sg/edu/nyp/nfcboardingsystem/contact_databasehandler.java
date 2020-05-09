package sg.edu.nyp.nfcboardingsystem;

import java.util.ArrayList;
import java.util.List;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.os.Environment;

public class contact_databasehandler extends SQLiteOpenHelper {

private static final int DATABASE_VERSION = 1;
	
	private static final String DATABASE_NAME =
			Environment.getExternalStorageDirectory().toString() + "/AirlineCompanyInfo.db";

	private static final String TABLE_CONTACT = "Airline_Company_Contact_Info";
	
	private static final String KEY_ID = "id";
	private static final String KEY_NAME = "name";
	private static final String KEY_MOBILE = "mobile";
	private static final String KEY_EMAIL = "email";
	
	public contact_databasehandler(Context context) {
		super(context, DATABASE_NAME, null, DATABASE_VERSION);
	}
	// Creating Tables
	@Override
	public void onCreate(SQLiteDatabase db) {
		String CREATE_CONTACTS_TABLE = "CREATE TABLE " + TABLE_CONTACT + "("
				+ KEY_ID + " INTEGER PRIMARY KEY," + KEY_NAME + " TEXT,"
				+ KEY_MOBILE + " TEXT,"+ KEY_EMAIL + " TEXT)";
		db.execSQL(CREATE_CONTACTS_TABLE);
}
	
	@Override
	public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
		// Drop older table if existed
		db.execSQL("DROP TABLE IF EXISTS " + TABLE_CONTACT);
		// Create tables again
		onCreate(db);
	}
	public contact_info getContact(int id) {
		SQLiteDatabase db = this.getReadableDatabase();
		Cursor cursor = db.query(TABLE_CONTACT, new String[] { KEY_ID,KEY_NAME,KEY_MOBILE,KEY_EMAIL}, KEY_ID + "=?",
				new String[] { String.valueOf(id) }, null, null, null, null);
		if (cursor != null)
			cursor.moveToFirst();
		contact_info contact;
		contact = new contact_info(Integer.parseInt(cursor.getString(0)),
				cursor.getString(1), cursor.getString(2), cursor.getString(3));
		return contact;
	}
	
	public List<contact_info> getAllContacts() {
		List<contact_info> contactList = new ArrayList<contact_info>();
		String selectQuery = "SELECT * FROM " + TABLE_CONTACT;
		SQLiteDatabase db = this.getWritableDatabase();
		Cursor cursor = db.rawQuery(selectQuery, null);
		// looping through all rows and adding to list
		if (cursor.moveToFirst()) {
			do {
				contact_info contact = new contact_info();
				contact.setId(Integer.parseInt(cursor.getString(0)));
				contact.setName(cursor.getString(1));
				contact.setMobile(cursor.getString(2));
				contact.setEmail(cursor.getString(3));
				contactList.add(contact);
			} while (cursor.moveToNext());
		}
		return contactList;
	}
	
	public int getContactsCount() {
		String countQuery = "SELECT * FROM " + TABLE_CONTACT;
		SQLiteDatabase db = this.getReadableDatabase();
		Cursor cursor = db.rawQuery(countQuery, null);
		cursor.close();
		return cursor.getCount();
	}
	
	public void addContact(contact_info contact) {
		SQLiteDatabase db = this.getWritableDatabase();
		ContentValues values = new ContentValues();
		values.put(KEY_NAME, contact.getName());
		values.put(KEY_MOBILE, contact.getMobile());
		values.put(KEY_EMAIL, contact.getEmail());
		db.insert(TABLE_CONTACT, null, values);
		db.close();
		}
	
	
		public void deleteContact(contact_info contact) {
		SQLiteDatabase db = this.getWritableDatabase();
		db.delete(TABLE_CONTACT, KEY_NAME + " = ?",
				new String[] { contact.getName() });
		
		db.close();
		}
}
