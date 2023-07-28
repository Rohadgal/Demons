using System.Collections;
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
        for(int i=0; i<contentTarget.transform.childCount; i++) {
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
        if(Vector3.Distance(target[itPosition].position, this.transform.position) < 1) {
            itPosition++;
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