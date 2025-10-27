using UnityEngine;

public class CamaraRapida : MonoBehaviour
{
    public GameObject camaraNormal;
    public GameObject camaraRapida;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            Time.timeScale = 2f;
            
            camaraNormal.SetActive(false);
            camaraRapida.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            Time.timeScale = 1f;
            
            camaraNormal.SetActive(true);
            camaraRapida.SetActive(false);
        }
    }
}
