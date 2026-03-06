using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    [SerializeField] PlayerMovement _playerMovement;

    private void Update()
    {

        if (Input.GetKey(KeyCode.W)) 
        {
            _playerMovement.MovePlayer(Vector2.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _playerMovement.MovePlayer(Vector2.left);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _playerMovement.MovePlayer(Vector2.down);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _playerMovement.MovePlayer(Vector2.right);
        }




    }


}
