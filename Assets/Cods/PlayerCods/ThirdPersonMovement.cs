using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public PlayerMenus Menu;

    public CharacterController charctrl;
    public Animator anim;
    Vector3 movaxis, turnaxis;
    public GameObject currentCamera;
    public float jumpspeed = 8;
    public float gravity = 20;

    float yresult;
   // public Transform rightHandObj, leftHandObj;
    bool jumpbtn = false;
    bool jumpbtnrelease = false;

    // Start is called before the first frame update
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked; // aperte esc para o cursor voltar
        currentCamera = Camera.main.gameObject;     //busca a camera do jogador
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))//se apertar pulo
        {
            yresult = jumpspeed;    //forca o pulo
           // transform.parent = null;     //desparenta forcado
            jumpbtn = true; //habilita abooleana de pulo

        }

        if(Menu.Pause)
        {
            Cursor.lockState = CursorLockMode.None;
        }else
            Cursor.lockState = CursorLockMode.Locked;


        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical")) // Faz com que a personagem rode a anima??o de Andar quando aperta W, A, S, D
        {
            anim.SetBool("Andar", true);
            anim.SetBool("Parado", false);

        }
        else
        {
            anim.SetBool("Andar", false);
            anim.SetBool("Parado", true);
        }

    }

    private void FixedUpdate()
    {
        movaxis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //captura o joystick e teclado
     
        

        yresult -= gravity * Time.fixedDeltaTime;   //gravidade fica pesada

        //calcula a direcao relativa do personagem em relacao ao mundo
        Vector3 relativedirection = currentCamera.transform.TransformVector(movaxis);
        relativedirection = new Vector3(relativedirection.x, yresult, relativedirection.z);
        //remove o y da altura do vetor
        Vector3 relativeDirectionWOy = relativedirection;
        relativeDirectionWOy = new Vector3(relativedirection.x, 0, relativedirection.z);

       // anim.SetFloat("Speed", charctrl.velocity.magnitude);//seta a animacao de velocidade

        //movimenta por character control
        charctrl.Move(relativedirection * 0.1f);
        //aplica a rotacao relativa
        Quaternion rottogo = Quaternion.LookRotation(relativeDirectionWOy * 2 + transform.forward);
        transform.rotation = Quaternion.Lerp(transform.rotation, rottogo, Time.fixedDeltaTime * 50);

        //se apertar o soco
        if (Input.GetButtonDown("Fire1"))
        {
           // anim.SetTrigger("PunchA"); //chama a animacao de soco
        }
        //se personagem est? no chao
        if (charctrl.isGrounded)
        {
            //anim.SetBool("Andar", false); // Faz com que a personagem rode a anima??o de Idle quando parado em um ponto
            yresult = 0;    //zera a gravidade (evita bug de quada muito rapida) 
        }
        //se ele est? no chao e apertou pulo
        if (charctrl.isGrounded && jumpbtn)
        {
           // Debug.Log("pula1");
           // anim.SetTrigger("Jump"); //chama animacao de pulo
            yresult = jumpspeed;  //aplica a forca de pulo
           

        }

        //raycast pra detectar o chao e fazer o pulo proporcional
        RaycastHit hit;
        if (Physics.Raycast(transform.position - (transform.forward * 0.1f) + transform.up * 0.3f, Vector3.down, out hit, 1000))
        {
           // anim.SetFloat("JumpHeight", hit.distance);
            if (hit.distance > 0.5f && jumpbtn)
            {
                yresult = .1f;
            
                jumpbtn = false;
                return;
            }
        }
        jumpbtn = false;
    }

    public void Damage()
    {
        // anima??o de dano (talvez)
    }


}
