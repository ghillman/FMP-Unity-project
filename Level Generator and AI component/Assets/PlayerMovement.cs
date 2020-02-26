using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float PlayerRotationX;
    public float PlayerRotationY;

    private Vector2 playerDirection;
    private Rigidbody2D MyRigid;

    public int NumberOfNodes;
    public Transform[] Node; //going to be used for path finding

    private float MousePositionX;
    private float MousePositionY;

    // Start is called before the first frame update
    void Start()
    {
        MyRigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Vector2 mousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

            transform.LookAt(Camera.main.ScreenToViewportPoint(Input.mousePosition));
            transform.rotation = new Quaternion( 0.0f, 0.0f, transform.rotation.z, transform.rotation.w);

            //MousePositionX = mousePosition.x;
            //MousePositionY = mousePosition.y;

            //PlayerRotationX = MousePositionX - transform.position.x;
            //PlayerRotationY = MousePositionY - transform.position.y;

            //playerDirection = new Vector2(PlayerRotationX, PlayerRotationY);

            //transform.up = playerDirection;
            
        }
       // MyRigid.velocity.up = Vector2.up * Time.deltaTime * 50; 
    }
}
