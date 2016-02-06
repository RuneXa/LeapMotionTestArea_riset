using UnityEngine;
using System.Collections;

public class SoundOnHit : MonoBehaviour {

	/*Note :
	 * Script ini buat dipasang di object yang bakal ngeluarin bunyi
	 * Pre-req : Object yang dipasang harus punya component "AudioSource"
	 */

	[Header("Sound")] //Subject To Change : Bisa jadi nanti suaranya di pasang di array bukan di gameObjectnya langsung
	[SerializeField] AudioClip audioToPlay; //Suara yang dikeluarkan
	AudioSource sourceMgr; //AudioSource Component untuk handle suara

	[Header("Triggered By")]
	[SerializeField] GameObject obj; //Object yang ngebuat suara di object ini keluar, Syarat : Object tersebut punya collider + RigidBody

	void Start () {
		sourceMgr = this.GetComponent<AudioSource> ();
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name.CompareTo (obj.name) == 0) {
			sourceMgr.PlayOneShot(audioToPlay);
		}
	}

	void OnMouseOver(){
		//Debug.Log (this.gameObject.name);
		if (Input.GetMouseButtonDown (0)) {
			sourceMgr.PlayOneShot(audioToPlay);
		}
	}
	

}
