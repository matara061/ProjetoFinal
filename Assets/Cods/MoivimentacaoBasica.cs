using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoivimentacaoBasica : MonoBehaviour
{
    public float Velocidade;
    public float Rotacao;
    public Animator anim;
    void Start()
    {
        Velocidade = 5f;
        Rotacao = 150f;
    }
    void Update()
    {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical")) // Faz com que a personagem rode a anima��o de Andar quando aperta W, A, S, D
        {
            anim.SetBool("Andar", true);
            anim.SetBool("Parado", false);

        }
        else
        {
            anim.SetBool("Andar", false);
            anim.SetBool("Parado", true);
        }
        
        //GetAxis pega inputs do teclado ou joystick para uma movimenta��o mais fluida.
        //Utilize W e S para aplicar for�a e velocidade aquela dire��o
        float translate = (Input.GetAxis("Vertical") * Velocidade) * Time.deltaTime;
       

        //Utilize A e D para escolher a dire��o
        float rotate = (Input.GetAxis("Horizontal") * Rotacao) * Time.deltaTime;



        //transform do objeto
        transform.Translate(0, 0, translate);
        transform.Rotate(0, rotate, 0);

    }
}
