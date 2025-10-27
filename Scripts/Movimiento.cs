using UnityEngine;

public class JugadorMovimiento : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        float movimientoX = Input.GetAxis("Horizontal");
        float movimientoY = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoX, movimientoY, 0f);
        transform.position += movimiento * velocidad * Time.deltaTime;
    }
}