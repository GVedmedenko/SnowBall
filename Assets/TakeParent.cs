using UnityEngine;
using System.Collections;

public class TakeParentSpeed : MonoBehaviour {

    Grid grid;
    Vector2 move;
	// Use this for initialization
	void Start () {
        grid = GetComponent<Grid>();
        move = new Vector2(grid.smoothX, grid.smoothY);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(move);
    }
    void Update()
    {
    }
}
