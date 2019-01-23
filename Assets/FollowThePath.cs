using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowThePath : MonoBehaviour {

    //public Transform[] waypoints;
    public List<GameObject> waypoints = new List<GameObject>();


    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;

	// Use this for initialization
	private void Start () {
        /* foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag("WayPoint")){
			waypoints.Add(fooObj);
		}
        waypoints.Reverse(); */
        transform.position = waypoints[waypointIndex].transform.position;

       
	}
	
	// Update is called once per frame
	private void Update () {
        
        if (moveAllowed){
            Move();
        }
        
	}

    private void Move()
    {
        
        if (waypointIndex <= waypoints.Count - 1)
        {
            //LadderCheck();
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
            
        }
        

       }

        
}

