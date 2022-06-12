using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//OBS:O unity text está basicamente se tornando obsoleto, dessa forma, é sempre sempre sempre recomendado utilizar o unity text pro, que é meio q uma versão melhorada com mais opções de estilização e controle.
using TMPro;


public class Dialogo : MonoBehaviour
{
    public bool PlayerAreaDialogo;
    private bool DialogoIniciado;
    private int LinhaAtual;

    //Sistema padrão de dialogo. Utilizamos um array de strings.
    //O Serialize comporta um TextArea para aumentar o tamanho de palavras que pode conter.
     [SerializeField, TextArea(3,6)] private string[] LinhasDeDialogo;
     [SerializeField] private GameObject CaixaDeDialogo;
     [SerializeField] private TMP_Text TextoDaCaixa;
    void Start()
    {
        
    }

    void Update()
    {
        //OBS: Ajustar. Não quero que o player tenha que clicar para aparecer o dialogo.
        if(PlayerAreaDialogo && Input.GetButtonDown("Fire1"))
        {
            FindObjectOfType<AudioManager>().Play("Click");
            //para saber que deve seguir com o dialogo, pq ele já está iniciado.
            if(!DialogoIniciado)
            {
                IniciarDialogo();
            }

            else if(TextoDaCaixa.text == LinhasDeDialogo[LinhaAtual])
            {
                LinhaSeguinte();

            }
            
        }

        
    }


    void IniciarDialogo()
    {
        DialogoIniciado = true;
        CaixaDeDialogo.SetActive(true);
        StartCoroutine(EfeitoTexto());
        
        //Vai mostrar o que se encontra no primeiro elemento
        LinhaAtual = 0;
    }

    void LinhaSeguinte()
     {
        //Incrementa a linha atual para mostrar os demais elementos existentes
         LinhaAtual++;
         if(LinhaAtual < LinhasDeDialogo.Length)
         {
             StartCoroutine(EfeitoTexto());

         }
         else
         {
             //DialogoIniciado = false;
             CaixaDeDialogo.SetActive(false);
             Debug.Log("Para de Clicar");
         }
    }

    IEnumerator EfeitoTexto()
    {
        //Auxilia para mostrar letra por letra
        TextoDaCaixa.text = string.Empty;

        foreach(char ch in LinhasDeDialogo[LinhaAtual])
        {
            TextoDaCaixa.text += ch;
            yield return new WaitForSeconds(0.05f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Instanciar Efeito aqui

            PlayerAreaDialogo = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        PlayerAreaDialogo = false;
        
    }

    
}
