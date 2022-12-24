using System.Collections;
using UnityEngine.UI; 
using System.Collections.Generic;
using UnityEngine;

public class faseJogo : MonoBehaviour
{

    public Button       btnPlay;
    public Text         txtNomefase;
    public GameObject   infoTema;
    public Text         txtInfoTema;
    public Text         txtPonto;

    public string[]     nomeTema;
    public int          numeroQuestoes;
    public string[] Questoes;       //armazena quantas questoes tem
    private int idTema;
    
    private int idquestao;

    // Start is called before the first frame update
    void Start()
    {
        idTema = 0;
        txtNomefase.text = nomeTema[idTema];
        txtInfoTema.text = "Você acertou X de X questões";
        txtPonto.text = "Pontuação: X";
        infoTema.SetActive(false);  
        btnPlay.interactable = false;
    }

    public void selecioneTema (int i)
    {
        
        idTema = i;
        PlayerPrefs.SetInt("idTema", idTema);
        txtNomefase.text = nomeTema[idTema];
        
            int notaFinal = PlayerPrefs.GetInt("notaFinal"+idTema.ToString());
            int acertos = PlayerPrefs.GetInt("acertos"+idTema.ToString());
            int questoes = PlayerPrefs.GetInt("questoes"+idTema.ToString());

        txtInfoTema.text = "Você acertou "+acertos.ToString()+ " de "+questoes.ToString()+" questões!";   //numeroQuestoes.ToString()
        txtPonto.text = "Pontuação "+notaFinal.ToString();
        infoTema.SetActive(true);
        btnPlay.interactable = true;
    }

    public void jogar()
    {
        Application.LoadLevel("V"+idTema.ToString());

    }


}
