using UnityEngine;
using System.Collections;
using System.Linq;
public class Linker : MonoBehaviour {

   private static Vector3 link;

    public static Vector3 Link()
    {
        
        GameObject[] objcts = GameObject.FindGameObjectsWithTag("Link");
        for(int i = 0;i< objcts.Length;i++)
        {
            if (objcts[i].transform.position.x < -19f)
                link = objcts[i].transform.position;  
            
        }
        return link;
        
    }
}
