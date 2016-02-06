using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject toInst;
    public int p_Size;
	
     static Vector3 currentPos;
    
    Plane[] planes;
   
    
	// Use this for initialization
	void Awake () {
        
        currentPos = Vector3.zero;
        planes = new Plane[p_Size];
        GeneratePlanes();
        
    }
    void Start()
    {
        

    }
  
    void GeneratePlanes()
    {
        
        for(int i =0; i < planes.Length;i++)
        {
         
            Instantiate(toInst,currentPos , Quaternion.identity);
            currentPos = currentPos + new Vector3(-GameObject.FindWithTag("Ground").GetComponent<MeshFilter>().mesh.bounds.extents.x * 2, 0f, 0f);


        }
        
    }
  

    // Update is called once per frame
    void Update () {
        
    }

	

}
