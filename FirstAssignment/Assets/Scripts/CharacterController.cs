using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private float speed = 2f;

    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }
    }

    private void Jump()
    {
        characterBody.AddForce(Vector3.up * 300f);
    }

}
