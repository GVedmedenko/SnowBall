using UnityEngine;
using System.Collections;

public class GrowUp : MonoBehaviour {

    public float growConst;
    bool flag = true;
	// Use this for initialization
	void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
        GrowByTime();
        if (transform.localScale.z > 3f)
            flag = false;
    }
    void GrowByTime()
    {
        if(flag)
        GetComponent<Transform>().localScale = new Vector3(transform.localScale.x * growConst, transform.localScale.y * growConst, transform.localScale.z * growConst);

    }
}
