using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float carSpeed = 20.0f;

    [SerializeField]
    float carTurnSpeed = 40.0f;

    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Arac� belli bir h�zda ileri ve geri gidecek �ekilde ayarlama
        transform.Translate(Vector3.forward * Time.deltaTime * carSpeed * verticalInput);

        //Arac� belli bir h�zda sa�a ve sola gidecek �ekilde ayarlama
        transform.Rotate(Vector3.up * Time.deltaTime * carTurnSpeed * horizontalInput);
    }
}