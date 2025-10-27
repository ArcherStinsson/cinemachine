using UnityEngine;
using UnityEngine.UI;

public class CambiarCamaraUI : MonoBehaviour
{
    public GameObject camara1;
    public GameObject camara2;
    public Button botonCamara1;
    public Button botonCamara2;

    void Start()
    {
        camara1.SetActive(true);
        camara2.SetActive(false);

        botonCamara1.onClick.AddListener(() => ActivarCamara(1));
        botonCamara2.onClick.AddListener(() => ActivarCamara(2));
    }

    void ActivarCamara(int numero)
    {
        if (numero == 1)
        {
            camara1.SetActive(true);
            camara2.SetActive(false);
        }
        else
        {
            camara1.SetActive(false);
            camara2.SetActive(true);
        }
    }
}
