using UnityEngine;
using System.Collections;
public class ObjectShake : MonoBehaviour {

	private Vector3 originPosition;
	private Quaternion originRotation;
	public float shake_decay = 0.019f;
	public float shake_intensity = 0.011f;
	public Vector3 position;
	int rand;
	private float temp_shake_intensity = 0;
	bool vib = true;
	bool loop = true;
	
	void OnGUI (){
		
	}
		
	void Update (){
			rand = Random.Range(1, 100);
			if (rand < 50) {
			Shake ();
			}
		if (temp_shake_intensity > 0){
			transform.position = originPosition + Random.insideUnitSphere * temp_shake_intensity;
			transform.rotation = new Quaternion(
				originRotation.x + Random.Range (-temp_shake_intensity,temp_shake_intensity) * .2f,
				originRotation.y + Random.Range (-temp_shake_intensity,temp_shake_intensity) * .2f,
				originRotation.z + Random.Range (-temp_shake_intensity,temp_shake_intensity) * .2f,
				originRotation.w + Random.Range (-temp_shake_intensity,temp_shake_intensity) * .2f);
				temp_shake_intensity -= shake_decay;
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		//Check for a match with the specified name on any GameObject that collides with your GameObject
		if (collision.gameObject.name == "student")
		{
			//If the GameObject's name matches the one you suggest, output this message in the console
			Debug.Log("Hit student");
			shake_decay = 0.0f;
			shake_intensity = 0.0f;
		}
			
	}
	
	void Shake(){
			originPosition = transform.position;
			originRotation = transform.rotation;
			temp_shake_intensity = shake_intensity;
	}
}