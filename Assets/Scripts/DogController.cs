using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    [SerializeField] private GameObject dog;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dog.transform.position = new Vector3(dog.transform.position.x + 1, dog.transform.position.y, dog.transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            dog.transform.position = new Vector3(dog.transform.position.x - 1, dog.transform.position.y, dog.transform.position.z);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            dog.transform.position = new Vector3(dog.transform.position.x, dog.transform.position.y, dog.transform.position.z - 1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            dog.transform.position = new Vector3(dog.transform.position.x, dog.transform.position.y, dog.transform.position.z + 1);
        }

        //Processing dog input for horizontal 
        //This does the trick: Input.GetAxis("Dog")
        //dog.transform.position = new Vector3(dog.transform.position.x + Input.GetAxis("HorizontalPlayer2"), dog.transform.position.y, dog.transform.position.z);
        //Processing Player2 input for vertical 
       // dog.transform.position = new Vector3(dog.transform.position.x, dog.transform.position.y + Input.GetAxis("VerticalPlayer2"), dog.transform.position.z);
    }
}
