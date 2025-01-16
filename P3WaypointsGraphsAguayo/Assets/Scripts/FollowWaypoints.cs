using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowWaypoints : MonoBehaviour {

  

    GameObject[] wps;
    GameObject currentNode;
    NavMeshAgent agent;

    

    public GameObject wpManager2;

    void Start() {
        Time.timeScale = 5.0f;
        wps = wpManager2.GetComponent<WPManager2>().waypoints;
      
        currentNode = wps[0];

        agent = this.GetComponent<NavMeshAgent>();

        // Invoke("GotoRuin", 2.0f);
    }

    public void GotoHeli() {

        //g.AStar(currentNode, wps[0]);
        agent.SetDestination(wps[0].transform.position);
        GotoHere(0);
    }

    public void GotoRuin() {

        //g.AStar(currentNode, wps[7]);
        agent.SetDestination(wps[7].transform.position);

        GotoHere(7);
    }

    public void GotoRock() {

        //g.AStar(currentNode, wps[1]);
        agent.SetDestination(wps[1].transform.position);
        GotoHere(1);
    }

    public void GotoFactory() {

        //g.AStar(currentNode, wps[4]);
        agent.SetDestination(wps[4].transform.position);
        GotoHere(4);
    }

    void GotoHere(int value) {

        
    }

    void LateUpdate() {

    }
}
