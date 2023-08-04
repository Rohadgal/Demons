    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    //Transform target;
    //public GameObject prefabCubanGuy;
    
    private void OnTriggerEnter(Collider other){
        //Transform closestTarget = null;
        //if(Vector3.Distance(this.transform.position, other.transform.position) < Vector3.Distance(this.transform.position, closestTarget.position)){
            //closestTarget = other.transform;
            transform.LookAt(other.transform.position);
       // }
    }
    

    /*void lookAt(){
         int count = 0;
        foreach(GameObject temp in poolMutantPrefab){
            count++;
            if(!temp.activeSelf){
                temp.SetActive(true);
                return temp;
            }

            if (count >= poolMutantPrefab.Count - 1){
                Debug.LogError("Hasta aquí llegaste");
            }
        }
        return null;
        
        Transform.lookAt(target)
    }*/
}
