using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
    public int X;
    public int Y;
    public float XOffset;
    public float YOffset;
    public GameObject myObject;



    // Start is called before the first frame update
    void Start()
    { 
        for(int i = 0; i < X; i++)
        {
            for(int j = 0; j < Y; j++)
            {
                Instantiate(myObject, new Vector2(i - XOffset, (j * -1) + YOffset), Quaternion.identity);
               // break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
