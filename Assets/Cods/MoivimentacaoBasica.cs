using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoivimentacaoBasica : MonoBehaviour
{
    public float Velocidade;
    public float Rotacao;
    void Start()
    {
        Velocidade = 20f;
        Rotacao = 100f;
    }
    void Update()
    {
        //GetAxis pega inputs do teclado ou joystick para uma movimentação mais fluida.
        //Utilize W e S para aplicar força e velocidade aquela direção
        float translate = (Input.GetAxis("Vertical") * Velocidade) * Time.deltaTime;

        //Utilize A e D para escolher a direção
        float rotate = (Input.GetAxis("Horizontal") * Rotacao) * Time.deltaTime;

        //transform do objeto
        transform.Translate(0, 0, translate);
        transform.Rotate(0, rotate, 0);
    }
}
