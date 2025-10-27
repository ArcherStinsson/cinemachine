using UnityEngine;

public class CamaraLenta : MonoBehaviour
{
    public GameObject camaraNormal;
    public GameObject camaraLenta;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            Time.timeScale = 0.3f;
            
            camaraNormal.SetActive(false);
            camaraLenta.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            Time.timeScale = 1f;
            
            camaraNormal.SetActive(true);
            camaraLenta.SetActive(false);
        }
    }
}
