using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour {
    //Rigidbody bulletRB;

    void Update() {
        transform.Translate(Vector3.forward);
    }

    private void OnTriggerEnter(Collider other) {
        //if (other.gameObject.CompareTag("Target")) { 
        //    other.gameObject.SetActive(false);
        //}
        if (other.gameObject.CompareTag("Player")) {
            //Debug.Log("hells");
            other.gameObject.SetActive(false);
        }
    }
}
