using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCharacter : MonoBehaviour
{

    public GameObject prefabCubanGuy;
    int itCubanGuy;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            itCubanGuy++;
            GameObject clone = Instantiate(prefabCubanGuy);
            clone.name = "Cuban_" + itCubanGuy;
        }
    }
}
