using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Generetion : MonoBehaviour {

    public int height;
    
  
    public GameObject obstacle;
    public  GameObject[] obstacles;
    private GameObject[] objcts;
    
    GameObject obj;
    public  int enemyCount;
    public List<Vector3> positons;
    
    void Awake()
    {
    
        height = Mathf.RoundToInt(transform.localScale.z)* 5;
        GenPositions();
        Initialize();
    }
    

	// Use this for initialization
	void Start () {
        // CreateDetail();
        objcts = GameObject.FindGameObjectsWithTag("Wall");
        FindPos();
    }
    
    
        GameObject CreateDetail()
    {
            
            for(int i=0;i<objcts.Length;i++)
            {
                obj = objcts[i];
                if (obj.transform.position.y > 8f)
                    return obj;
                else if (obj.transform.position.y < 8f)
                    continue;
            else
                    return null;
                
            }
        return obj;
    }
    public void Repos()
    {
        foreach(Transform t in transform)
        {
            if(t.tag == "Wall")
        
            t.gameObject.transform.position = new Vector3(20f, 20f, 20f);
        }
    }
 
     public   void FindPos()
    {
        for(int i=0;i< positons.Count;i++)
        {
            GameObject obj = CreateDetail();
            obj.transform.position = positons[i];
            obj.transform.parent = gameObject.transform;

        }
        

    }
    
    
   
    void Initialize()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            
            obstacles[i] = obstacle;
            obstacles[i].transform.position = new Vector3(10f, 10f, 10f);
            Instantiate(obstacle);
            // Instantiate(obstacles[i], new Vector3(10f, 10f, 10f), Quaternion.identity);
        }
    }

    public  void GenPositions()
    {
        enemyCount = Random.Range(3, 10);
        
        positons.Clear();
        Plane thisPlane = new Plane(enemyCount);
        int posX = Mathf.RoundToInt(transform.position.x);
        for (int i = posX - height; i <= posX + height; i +=2) 
        {
               
            int rand = RandomPos();
            if (rand > 1 && rand <= 2 )
            {
                positons.Add(new Vector3(i, 0f, thisPlane.Left));
               
            }
            
            else if (rand > 2 && rand <=3)
            {
                positons.Add(new Vector3(i, 0f, thisPlane.Center));
               
            }
            else if (rand > 3 && rand <=4)
            {
                positons.Add( new Vector3(i, 0f, thisPlane.Right));
               
            }
            if (rand > 4)
                continue;
        }
    }
    int RandomPos()
    {
       int rand = Random.Range(1, 6);
        return rand;
    }
    
	// Update is called once per frame
	void Update () {
        

    }
}
