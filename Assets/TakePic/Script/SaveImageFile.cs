using UnityEngine;
using System.Collections;
using System.IO;

public class SaveImageFile : MonoBehaviour
{
	public Texture2D tex;
	private float originalWidth = 480.0F; // define here the original resolution
	private float originalHeight = 800.0F; // you used to create the GUI contents
	private Vector3 scale;
	public GUISkin mySkin;
	public GameObject saveSucess;
	public GameObject khung;
	public GameObject pic, picShow;
	public GameObject[] listButton;
	public GameObject btnTakePic;
	public GameObject finishJob;
	public GameObject takePic;
	public enum TypeChooseTake
	{
		other,
		lv10}
	;
	public TypeChooseTake type;
	//public typeChooseTake type;
	// Use this for initialization

	
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnMouseDown ()
	{
				
		savePic ();
	}

	public void savePic ()
	{

		if (tex != null) {
			//var bytes = tex.EncodeToPNG ();
			//	Debug.Log (System.DateTime.Now);
			//string myfilename = "/mnt/sdcard/DCIM/Camera/Princess_" + System.DateTime.Now.ToString ("hhmmssMMddyyyy") + ".png";

			//File.WriteAllBytes (myfilename, bytes);

			OpenDialog ();
//			saveSucess.SetActive(true);

            //AndroidJavaClass classPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
            //AndroidJavaObject objActivity = classPlayer.GetStatic<AndroidJavaObject> ("currentActivity");        
            //AndroidJavaClass classUri = new AndroidJavaClass ("android.net.Uri");        
            //AndroidJavaObject objIntent = new AndroidJavaObject ("android.content.Intent", new object[2] {
            //    "android.intent.action.cc",
            //    classUri.CallStatic<AndroidJavaObject> ("parse", "file://" + myfilename)
            //});        
            //objActivity.Call ("sendBroadcast", objIntent);

		}

	}

	// 200x300 px window will apear in the center of the screen.
	private Rect windowRect = new Rect (0, 240, 480, 200);
	// Only show it if needed.
	private bool show = false;
	
	void OnGUI ()
	{
		if (mySkin != null)
			GUI.skin = mySkin;
		scale.x = Screen.width / originalWidth; // calculate hor scale
		scale.y = Screen.height / originalHeight; // calculate vert scale
		scale.z = 1;
		var svMat = GUI.matrix; // save current matrix
		// substitute matrix - only scale is altered from standard
		GUI.matrix = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, scale);
		// draw your GUI controls here:
		if (show)
			windowRect = GUI.Window (0, windowRect, DialogWindow, "");
		//GUI.Box(Rect(10,10,200,50), "Box");
		//	GUI.Button(Rect(400,180,230,50), "Button");
		//...
		// restore matrix before returning
		GUI.matrix = svMat; // restore matrix

	}
	
	// This is the actual window.
	void DialogWindow (int windowID)
	{
		//float y = 50;
		GUI.Label (new Rect (5, 10, windowRect.width - 10, 20), "SAVED");
		
		if (GUI.Button (new Rect (5, 50, windowRect.width - 10, 50), "OK")) {
					
			show = false;
		}
	}
	
	// To open the dialogue from outside of the script.
	public void OpenDialog ()
	{

		//show = true;
		//panel.SetActive(true);
		saveSucess.SetActive(true);
//		if (type == TypeChooseTake.other) {
//			pic.GetComponent<SpriteRenderer> ().sprite = null;
//			picShow.SetActive (false);
//			saveSucess.SetActive (true);
//			for (int i=0; i<listButton.Length; i++) {
//				listButton [i].SetActive (true);
//			}
//			btnTakePic.SetActive (true);
//			Invoke ("DisableSave", 2);
//			khung.SetActive (false);
//		} else if (type == TypeChooseTake.lv10) {
//			finishJob.SetActive (true);
//			Destroy (takePic);
//		}

	}

	public void DisableSave ()
	{
		//saveSucess.SetActive (false);
	}

}

