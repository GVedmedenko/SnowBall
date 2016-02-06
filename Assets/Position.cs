using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class Position : MonoBehaviour {
    
   public Boundary boundary;
    
	// Use this for initialization
	void Start () {

	
	}
	void FixedUpdate()
    {
    GetComponent<Rigidbody>().position = new Vector3(Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.zMax), GetComponent<Rigidbody>().position.y, Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax));

    }
	// Update is called once per frame
	void Update () {
	
	}


}
