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
	[SerializeField] GameObject obj; //Object yang ngebuat suara di object ini keluar

	void Start () {
		sourceMgr = this.GetComponent<AudioSource> ();

		//WorkAround buat pemukul untuk sementara
		//obj = this.transform.parent.parent.GetComponent<HandControllerMediator>().getToolObj();
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag("Pemukul_")) {
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
