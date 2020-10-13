using UnityEngine;

public class ExplodeCubes : MonoBehaviour {
	private void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "Cube"){
			for(int i == collision.transform.childCount - 1; i >= 0; i--){
				Transform child = collision.transform.GetChild(i);
				child.gameObject.AddComponent<Rigidbody>();
				child.gameObject.GetComponent<Rigidbody>().AddExplosionForce(70f, Vector3.up, 5f);
				childSetParent(null);

			}
			Destroy(collision.gameObject);
			_collisionSet = true;

		}
	}
    
}
