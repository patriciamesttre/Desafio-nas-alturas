using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{

    [SerializeField]

    private Text textoPontuacao;

    private int pontos;
    
   public void AdicionarPontos()
    {
        pontos += 1;
        AtualizarTexto();
    }

    private void AtualizarTexto()
    {
        textoPontuacao.text = pontos.ToString();
    }

    private void Reiniciar()
    {
        pontos = 0;
        AtualizarTexto();
    }


    }

