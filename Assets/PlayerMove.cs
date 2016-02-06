using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    public float speed;
    public float rotate;
    enum posType { LEFT,CENTER,RIGHT};
    posType currentPos = posType.CENTER;
    // Use this for initialization
    void Start () {
        
	}
	void Update()
    {
        Rotate();

        ChangeType();
    }
	// Update is called once per frame
	void FixedUpdate () {
    //    if(Input.GetKey(KeyCode.A))
    //    GetComponent<Rigidbody>().AddForce(new Vector3(-1f * speed, 0f, 0f) * Time.deltaTime);
    //    if(Input.GetKey(KeyCode.D))
    //GetComponent<Rigidbody>().AddForce(new Vector3(1f * speed, 0f, 0f) * Time.deltaTime);
    //    if (Input.GetKey(KeyCode.W))
    //        GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, 1f * speed) * Time.deltaTime);
    //    if (Input.GetKey(KeyCode.S))
    //        GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, -1f * speed) * Time.deltaTime);
    switch(currentPos)
        {
            case posType.LEFT:
                {
                    transform.position = new Vector3(0f, transform.position.y, 3f);
                    break;
                }
            case posType.RIGHT:
                {
                    transform.position = new Vector3(0f, transform.position.y, -4f);
                    break;
                }
            case posType.CENTER:
                {
                    transform.position = new Vector3(0f, transform.position.y, 0f);
                    break;
                }
        }
    }
    void ChangeType()
    {
        if(Input.GetKey(KeyCode.A) && currentPos == posType.CENTER)
        {
            currentPos = posType.LEFT;
        }
        if (Input.GetKey(KeyCode.D) && currentPos == posType.CENTER)
        {
            currentPos = posType.RIGHT;
        }
        if (Input.GetKey(KeyCode.A) && currentPos == posType.RIGHT)
        {
            currentPos = posType.CENTER;
        }
        if (Input.GetKey(KeyCode.D) && currentPos == posType.LEFT)
        {
            currentPos = posType.CENTER;
        }
    }
    
    void Rotate()
    {
        transform.Rotate(new Vector3(0f, 0f, 1f * rotate));
    }
}
