using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class responder : MonoBehaviour
{

    private int idTema;

    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text infoRespostas;
    public GameObject botaoA;
    public GameObject botaoB;
    public GameObject botaoC;
    public GameObject botaoD;


    public string[] perguntas;      // armazena todas as perguntas
    public string[] alternativaA;   // armazena todas as alternativas A
    public string[] alternativaB;   // armazena todas as alternativas B
    public string[] alternativaC;   // armazena todas as alternativas C
    public string[] alternativaD;   // armazena todas as alternativas D
    public string[] corretas;       // armazena todas as alternativas corretas

    private int idPergunta;

    private float acertos;
    private float questoes;
    private float media;
    private int   confirma;
    private int   notaFinal;
    private int   Questoes;


    // Start is called before the first frame update
    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");
        idPergunta = 0;
        questoes = perguntas.Length;
        

        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        respostaD.text = alternativaD[idPergunta];

        if(alternativaA[idPergunta] == "")
        {
            botaoA.SetActive(false);
        }else 
        {
            botaoA.SetActive(true);
        }
        if(alternativaB[idPergunta] == "")
        {
            botaoB.SetActive(false);
        }else 
        {
            botaoB.SetActive(true);
        }
        if(alternativaC[idPergunta] == "")
        {
            botaoC.SetActive(false);
        }else 
        {
            botaoC.SetActive(true);
        }

        if(alternativaD[idPergunta] == "")
        {
            botaoD.SetActive(false);
        }else 
        {
            botaoD.SetActive(true);
        }

        infoRespostas.text = "Questão "+ (idPergunta + 1).ToString() +"/"+ questoes.ToString();
    }

    public void resposta (string alternativa){
        if(alternativa == "A")
        {
            if(alternativaA[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                
            }

        }
        else if(alternativa == "B")
        {
            if(alternativaB[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                
            }
        }
        else if(alternativa == "C")
        {
            if(alternativaC[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                
            }   
        
        }
        else if(alternativa == "D")
        {
            if(alternativaD[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
        }
        
        
            proximaPergunta();
        
        
    }


void proximaPergunta(){

    idPergunta += 1;

    if(idPergunta <= (questoes-1))
    {
    pergunta.text = perguntas[idPergunta];
    respostaA.text = alternativaA[idPergunta];
    respostaB.text = alternativaB[idPergunta];
    respostaC.text = alternativaC[idPergunta];
    respostaD.text = alternativaD[idPergunta];
    if(alternativaA[idPergunta] == "")
        {
            botaoA.SetActive(false);
        }else 
        {
            botaoA.SetActive(true);
        }
        if(alternativaB[idPergunta] == "")
        {
            botaoB.SetActive(false);
        }else 
        {
            botaoB.SetActive(true);
        }
        if(alternativaC[idPergunta] == "")
        {
            botaoC.SetActive(false);
        }else 
        {
            botaoC.SetActive(true);
        }

        if(alternativaD[idPergunta] == "")
        {
            botaoD.SetActive(false);
        }else 
        {
            botaoD.SetActive(true);
        }
        infoRespostas.text = "Questão "+ (idPergunta + 1).ToString() +"/"+ questoes.ToString();
    }
    else
    {
        
        media = 10 * (acertos / questoes);
        notaFinal = Mathf.RoundToInt(media);
        PlayerPrefs.SetInt("questoes"+idTema.ToString(), (int) questoes);
        if(notaFinal > PlayerPrefs.GetInt("notaFinal"+idTema.ToString()))
        {
            PlayerPrefs.SetInt("notaFinal"+idTema.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertos"+idTema.ToString(), (int) acertos);
        }


        PlayerPrefs.SetInt("notaFinalTemp"+idTema.ToString(), notaFinal);
        PlayerPrefs.SetInt("acertosTemp"+idTema.ToString(), (int) acertos);

        Application.LoadLevel("notaFinal");

    }
}
}
