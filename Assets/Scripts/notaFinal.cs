using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class notaFinal : MonoBehaviour
{

    private int idTema;

    public Text txtNota;
    public Text txtInfoTema;

    private int notaF;
    private int acertos;
    private int questoes;
    

    // Start is called before the first frame update
    void Start()
    {
        
        idTema = PlayerPrefs.GetInt("idTema");
        notaF = PlayerPrefs.GetInt("notaFinalTemp"+idTema.ToString());
        acertos  = PlayerPrefs.GetInt("acertosTemp"+idTema.ToString());
        questoes = PlayerPrefs.GetInt("questoes"+idTema.ToString());
        
        txtNota.text = notaF.ToString();
        txtInfoTema.text = "Você acertou "+acertos.ToString()+" de "+questoes.ToString()+" perguntas";
    }

public void jogarNovamente()
{
    Application.LoadLevel("L"+idTema.ToString());
}



}
