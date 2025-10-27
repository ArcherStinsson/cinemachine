using UnityEngine;
using Unity.Cinemachine; // para usar Cinemachine 3.0

public class ZoomCinemachineBasico : MonoBehaviour
{
    public CinemachineCamera camara; // arrastra tu cámara aquí
    public float zoom = 5f;           // velocidad de zoom

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            camara.Lens.OrthographicSize -= zoom * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            camara.Lens.OrthographicSize += zoom * Time.deltaTime;
        }
    }
}
