using UnityEngine;
using System.Collections;

//public class SoundPlayStereo1 : MonoBehaviour {

// Use this for initialization
//void Start () {

//}

// Update is called once per frame
//	void Update () {

//	}
//}


public class SoundPlayStereo1 : MonoBehaviour
{
	//	public AudioClip BottlesClank;    // Add your Audi Clip Here;
	// This Will Configure the  AudioSource Component; 
	// MAke Sure You added AudioSouce to death Zone;
	//	void Start ()   
	//	{
	//	GetComponent<AudioSource> ().playOnAwake = false;
	//		GetComponent<AudioSource> ().clip = BottlesClank ;
	//	}        
	//-------------------------------------------------
	void OnTriggerEnter()  //Plays Sound Whenever collision detected
	{

		GetComponent<AudioSource> ().Play ();

	}
	//-----------------------------------------------




	// Make sure that deathzone has a collider, box, or mesh.. ect..,
	// Make sure to turn "off" collider trigger for your deathzone Area;
	// Make sure That anything that collides into deathzone, is rigidbody;
}