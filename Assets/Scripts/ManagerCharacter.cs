using System.Collections.Generic;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ManagerCharacter : MonoBehaviour {
    //[SerializeField]
    //GameObject prefabCubanGuy;
    [SerializeField]
    Transform poolContent;
    public List<GameObject> poolCharacter_Prefab;
    float timer;
    float randomXPos;
    float randomZPos;

    public void Start() {
        timer = 0f;
        randomXPos = 0f;
        randomZPos = 0f;
        poolCharacter_Prefab = new List<GameObject>();
        for (int i = 0; i < poolContent.childCount; i++) {
            GameObject temp = poolContent.GetChild(i).gameObject;
            temp.SetActive(false);
            poolCharacter_Prefab.Add(temp);
        }
    }

    public GameObject getPrefab() {
        int count = 0;
        foreach (GameObject temp in poolCharacter_Prefab) {
            count++;
            if (!temp.activeSelf) {
                temp.transform.position = new Vector3(randomXPos, transform.position.y, randomZPos);
                temp.SetActive(true);
                return temp; // es interesante el hecho de que esta función regrese un prefab que se solicita al presionar la tecla
            }
            if (count >= poolCharacter_Prefab.Count - 1) {
                //Debug.LogError("Hasta aquí llegaste");
            }
        }
        return null;
    }

    void timerForCharacterInstance() {
        timer += Time.deltaTime;

        if (timer > 0.5f) {
            randomXPos = Random.Range(-20f, 20f);
            randomZPos = Random.Range(-20f, 20f);
            getPrefab();
            timer = 0f;
        }
    }

    void Update() {
        if (Input.GetKey(KeyCode.Space)) {
            getPrefab();
        }
        timerForCharacterInstance();
    }
}
