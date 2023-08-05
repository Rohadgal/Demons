using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public List<Transform> target;

    public int itPosition;

    // Start is called before the first frame update
    void Start()
    {
        GameObject contentTarget = GameObject.Find("ContentTarget");
        target = new List<Transform>();
        //Debug.LogWarning("contentTarget.transform.childCount" + contentTarget.transform.childCount);
        for (int i=0; i<contentTarget.transform.childCount; i++) {
            target.Add(contentTarget.transform.GetChild(i).transform);
        }
        itPosition = 0;
        ShuffleArray.Shuffle(target);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move() {
        navAgent.SetDestination(target[itPosition].position);
           // Debug.Log("Distance: " + Vector3.Distance(target[itPosition].position, this.transform.position));
        if(Vector3.Distance(target[itPosition].position, this.transform.position) < 2f) { // si la distancia mínima no se cumple los personajes instanciados dejan de moverse hacia todos los targets y se quedan en el primer target que se les asigna al azar.
            itPosition++;
            //Debug.Log("position: " + itPosition);
            if(itPosition >= target.Count - 1) {
                itPosition = 0;
                ShuffleArray.Shuffle(target);
            }
        }
    }
}

public static class ShuffleArray{
    public static void Shuffle<T>(this IList<T> ts) {
        var count = ts.Count;
        var last = count - 1;
        for(var i = 0; i < last; ++i) {
            var r = UnityEngine.Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }
    }
}