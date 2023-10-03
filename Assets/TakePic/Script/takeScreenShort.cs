using UnityEngine;
using System.Collections;

// Saves screenshot as PNG file.
using System.IO;


public class takeScreenShort : MonoBehaviour
{
	public Camera activeCamera;
	public RenderTexture rt;
	public GameObject objectToShow;
//		private SpriteRenderer sr;
	public GameObject Frame;
	//public GameObject saveObject;
	public SaveImageFile saveIF;
	//public Sprite Khung;
	public AudioClip chupAnhAudio;
	public GameObject[] listbutton;
//		private GameManager.myAds _gm;
	//private Sprite mySP;
	//	private Texture2D tex;
	// Use this for initialization
	void Start ()
	{
		//	_gm = GameObject.FindObjectOfType<GameManager.myAds> ();
	
		Frame.SetActive (false);
		//	sr = objectToShow.GetComponent<SpriteRenderer> ();
//				if (saveObject != null)
//						saveIF = saveObject.GetComponent<SaveImageFile> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnMouseDown ()
	{

		for(int i=0; i<listbutton.Length;i++){
			listbutton[i].SetActive(false);
		}
		transform.gameObject.SetActive (false);

		takePicture ();
		objectToShow.transform.GetChild (0).gameObject.SetActive (true);
				
//		AudioManager.audioManager.PlaySingle(chupAnhAudio,false);
		Frame.SetActive (true);


		//	_gm.ShowInterStitial ();
				
	}

	void takePicture ()
	{

		
		// ofc you probably don't have a class that is called CameraController :P
		//Camera activeCamera = CameraController.getActiveCamera();
		
		// Initialize and render
		//	RenderTexture rt = new RenderTexture(width, height, 24);
		activeCamera.targetTexture = rt;
		activeCamera.Render ();
		RenderTexture.active = rt;
		  
		Texture2D tex = new Texture2D (rt.width, rt.height, TextureFormat.ARGB32, false);
		// Read pixels
		tex.ReadPixels (new Rect (0, 0, rt.width, rt.height), 0, 0);
		tex.Apply ();
		//var bytes = tex.EncodeToPNG ();
		//File.WriteAllBytes ("/mnt/sdcard/testWrite.png", bytes);
//		UM_Camera.Instance.SaveImageToGalalry(tex);
		if (saveIF != null)
			saveIF.tex = tex;
		//mySP = Sprite.Create (tex, new Rect (0, 0, tex.width, tex.height), new Vector2 (0.5F, 0.5F));
		objectToShow.GetComponent<SpriteRenderer> ().sprite = Sprite.Create (tex, new Rect (0, 0, tex.width, tex.height), new Vector2 (0.5F, 0.5F));
		// Clean up
		activeCamera.targetTexture = null;
		RenderTexture.active = null; 
		//	DestroyImmediate(rt);
		//	Debug.Log ("SAVED");
		
	}
}

