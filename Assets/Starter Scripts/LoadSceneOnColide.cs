using UnityEngine;
using System.Collections;

public class LoadSceneOnColide : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		//if (other.transform.root.CompareTag("Player"))
		//{
		Application.LoadLevel("Intro_to_VR_Start_Scene");
	}
}


//}

//OnCollisionEnter()
//{
//	application.LoadLevel(Adelaide Uni Room_e_Lab Render);
//}



// Update is called once per frame
//void Update () {
//
//}
//}