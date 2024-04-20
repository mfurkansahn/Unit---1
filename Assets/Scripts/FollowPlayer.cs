using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    Vector3 cameraPositionOffset = new Vector3(0, 6, - 7); //yolu, oyuncuyu ve engelleri g�recek �ekilde ayarla

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + cameraPositionOffset; //Kamera konumunu oyuncunun konuma e�itle sonras�nda telafi etti�in(d�zelti�in) kamera konumunu ekle
    }
}
