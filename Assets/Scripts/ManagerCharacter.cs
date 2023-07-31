using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCharacter : MonoBehaviour
{

    public GameObject prefabCubanGuy;
    int itCubanGuy;

    public Transform poolContent;
    public List<GameObject> poolMutantPrefab;

    public void Start(){
        poolMutantPrefab = new List<GameObject>();
        for (int i = 0; i < poolContent.childCount; i++){
            GameObject temp = poolContent.GetChild(i).gameObject;
            temp.SetActive(false);
            poolMutantPrefab.Add(temp);
        }
    }

    public GameObject getPrefab(){
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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            //itCubanGuy++;
            //GameObject clone = Instantiate(prefabCubanGuy);
            //clone.name = "Cuban_" + itCubanGuy;
            getPrefab();
        }
    }
}
