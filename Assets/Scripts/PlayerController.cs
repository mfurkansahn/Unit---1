using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    string inputId; //Çoklu oyuncunun girdileri için id ekle

    [SerializeField]
    private float carSpeed = 20.0f;

    [SerializeField]
    float carTurnSpeed = 40.0f;

    public float horizontalInput;
    public float verticalInput;

    //[SerializeField]
    public Camera mainCamera;
    //[SerializeField]
    public Camera hoodCamera;
    //[SerializeField]
    public KeyCode switchCameraKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputId);
        verticalInput = Input.GetAxis("Vertical" + inputId);

        //Aracý belli bir hýzda ileri ve geri gidecek þekilde ayarlama
        transform.Translate(Vector3.forward * Time.deltaTime * carSpeed * verticalInput);

        //Aracý belli bir hýzda saða ve sola gidecek þekilde ayarlama
        transform.Rotate(Vector3.up * Time.deltaTime * carTurnSpeed * horizontalInput);

        //Kamerayý yapýlan tuþ atamasýyla deðiþtir
        if(Input.GetKeyDown(switchCameraKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
