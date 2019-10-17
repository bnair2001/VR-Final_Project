using UnityEngine;
using System.Collections;

public class reset1 : MonoBehaviour {
	public AudioSource audioSource;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	//void Update()
	//{
		//if(Input.GetKeyDown(KeyCode.R))
			//Application.LoadLevel(0); //or whatever number your scene is
	void Update () {
	//	AudioSource = gameObject.AddComponent<AudioSource> ();
		if (Input.GetKeyDown (KeyCode.Space))
			audioSource.Play ();
	}
}

