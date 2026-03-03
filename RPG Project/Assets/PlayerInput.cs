using UnityEngine;

public class PlayerInput : MonoBehaviour
{


    private void Start()
    {
        
    }


    private void Update()
    {

        if (Input.GetKey(KeyCode.W)) 
        {
            print("up");
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("left");
        }

        if (Input.GetKey(KeyCode.S))
        {
            print("down");
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("right");
        }




    }


}
