using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avião : MonoBehaviour
{
    Rigidbody2D física;

    [SerializeField]

   private float forca = 10f;

    [SerializeField]

    private Diretor diretor;

    private Vector3 posicaoInicial;

    private void Awake()
    {
        //Debug.Log("Acordei");
        this.física = this.GetComponent<Rigidbody2D>();
        diretor = GameObject.FindObjectOfType<Diretor>();
        posicaoInicial = this.transform.position;
    }

    public void Reiniciar()
    {
        this.transform.position = posicaoInicial;
        this.física.simulated = true;

    }

    private void Impulsionar()
    {
        this.física.velocity = Vector2.zero;
        this.física.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        física.simulated = false;
        diretor.FinalizarJogo();
       
    }


    // Update is called once per frame
    void Update()
    {
      if(Input.GetButtonDown("Fire1"))
        {
            // Debug.Log("Clicou");
            Impulsionar();
        }
    }
}
