using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrosel : MonoBehaviour
{

    [SerializeField]

    private float velocidade;


    private Vector3 posicaoInicial;

    private float tamanhoRealDaImagem;


    private void Awake()
    {
        posicaoInicial = transform.localPosition;
        float tamanhoaDaImagem = GetComponent<SpriteRenderer>().size.x;
        float escala = transform.localScale.x;
        tamanhoRealDaImagem = tamanhoaDaImagem * escala;
        Debug.Log(tamanhoRealDaImagem);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(Time.time * velocidade, tamanhoRealDaImagem);
        transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
