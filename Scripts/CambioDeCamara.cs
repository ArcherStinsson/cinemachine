using UnityEngine;
using Unity.Cinemachine;

public class CambioDeCamara : MonoBehaviour
{
    public CinemachineCamera camaraNormal;
    public CinemachineCamera camaraConfinada;

    private void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.CompareTag("Jugador"))
        {
            
            camaraNormal.Priority = 5;
            camaraConfinada.Priority = 10;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            
            camaraNormal.Priority = 10;
            camaraConfinada.Priority = 5;
        }
    }
}
