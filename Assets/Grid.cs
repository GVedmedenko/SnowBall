using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {
    private Vector3 move;
    public float smoothX;
    public float smoothY;
    public float speed;
    public float transformScale;
    private static Vector3 link;
    public Vector3 planePos;
    Generetion gen;
    
    // Use this for initialization
	void Start() {
        move = new Vector3(smoothX, smoothY, 0f);
        gen = GetComponent<Generetion>();
       
        
       
        
    }
    void Update()
    {
        if (transform.position.x >= transformScale)
        {
            gen.Repos();
        }
        
        
    }
    
    void LateUpdate()
    {
        OffFromScreen();
        
        
    }
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(move * speed);
    
            
    }
   

    void OffFromScreen()
    {
        if(transform.position.x >= transformScale)
        {
           
            
            gen.FindPos();
            gen.GenPositions();
            transform.position = Linker.Link();

        }
    }
}
