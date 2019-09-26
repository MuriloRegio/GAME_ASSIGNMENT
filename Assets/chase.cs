using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{
	public string target_name = "Character";
	public float speed = 2.5F;
	Transform target;

	private class chaser_info
	{
		public Rigidbody rgd;
		public Transform cur;

		public chaser_info(GameObject go)
		{
			this.rgd = go.GetComponent<Rigidbody>();
			this.cur = go.transform;
		}
	}

	List<chaser_info> child_nodes = new List<chaser_info>();

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find(target_name).transform;

        foreach(Transform child in transform)
        {
        	child_nodes.Add(
        		new chaser_info(
        			child.gameObject
        		)
        	);
        }
        // rgd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        float step =  speed * Time.deltaTime; // calculate distance to move

        
        foreach(chaser_info c in child_nodes)
        {
        	c.rgd.velocity = Vector3.MoveTowards(target.position, .ccur.position, step);
        }
    }
}
