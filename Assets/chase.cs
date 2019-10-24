using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{
	public string target_name = "Character";
	public float speed = 2.5F;
	public float inc = 0.5F;

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
    }

    // Update is called once per frame
    void Update()
    {   
        // float step =  speed * Time.deltaTime; // calculate distance to move
        float step =  speed * Time.timeScale; // calculate distance to move


        speed += inc * Time.deltaTime;
        
        foreach(chaser_info c in child_nodes)
        {
        	Vector3 dir = (target.position - c.cur.position).normalized;
        	Vector3 forw = c.cur.forward;
        	
        	c.rgd.velocity = dir * step;


        	c.cur.forward = dir;

        	// float cos = Vector3.Dot(forw,dir) / (forw.magnitude * dir.magnitude);
        	// float theta = Mathf.Acos(Mathf.Clamp(cos,-1,1));

        	// Debug.Log("");
        	// Debug.Log(cos);
        	// Debug.Log(theta);
        	// Debug.Log("");

        	// c.cur.RotateAround(c.cur.position, Vector3.up, theta );

        	// Vector3 angle = c.cur.eulerAngles;
        	// angle.y = theta * (Mathf.PI / 180f);
        	
        	// c.cur.Rotate(angle);
        	
        	// c.cur.eulerAngles = angle;
        }
    }
}
