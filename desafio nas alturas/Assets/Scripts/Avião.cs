using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avião : MonoBehaviour
{
    Rigidbody2D física;

    [SerializeField]

   private float forca = 10f;

    private void Awake()
    {
        //Debug.Log("Acordei");
        this.física = this.GetComponent<Rigidbody2D>();
    }

    private void Impulsionar()
    {
        this.física.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
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
