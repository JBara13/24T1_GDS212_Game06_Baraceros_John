using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPlayerInputs : MonoBehaviour
{

    //Player Objects
    [SerializeField]
    private GameObject Player1;
    [SerializeField]
    private GameObject Player2;


    void Update()
    {
        //Check if players are assigned
        if (Player1)
        {
            //Processing Player1 inputs
            if (Input.GetKey(KeyCode.A))
            {
                //Moves Player1
                //something like this
                Player1.transform.position = new Vector3(Player1.transform.position.x - 1, Player1.transform.position.y, Player1.transform.position.z);
            }
            if (Input.GetKey(KeyCode.D))
            {
                Player1.transform.position = new Vector3(Player1.transform.position.x + 1, Player1.transform.position.y, Player1.transform.position.z);

            }
            if (Input.GetKey(KeyCode.W))
            {
                Player1.transform.position = new Vector3(Player1.transform.position.x, Player1.transform.position.y, Player1.transform.position.z + 1);

            }
            if (Input.GetKey(KeyCode.S))
            {
                Player1.transform.position = new Vector3(Player1.transform.position.x, Player1.transform.position.y, Player1.transform.position.z - 1);

            }

            if (Player2)
            //Processing Player2 inputs
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //Moves Player2
                Player1.transform.position = new Vector3(Player1.transform.position.x - 1, Player1.transform.position.y, Player1.transform.position.z);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                //Moves Player2
                Player1.transform.position = new Vector3(Player1.transform.position.x + 1, Player1.transform.position.y, Player1.transform.position.z);

            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //Moves Player2
                Player1.transform.position = new Vector3(Player1.transform.position.x, Player1.transform.position.y, Player1.transform.position.z + 1);

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                //Moves Player2
                Player1.transform.position = new Vector3(Player1.transform.position.x, Player1.transform.position.y, Player1.transform.position.z - 1);

            }
        }
    }
}
