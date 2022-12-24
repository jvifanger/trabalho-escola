using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaInfo : MonoBehaviour
{
    public int idTema;

    public GameObject barra;
    public GameObject orbe;

    private int notaFinal;

    // Start is called before the first frame update
    void Start()
    {
        
        barra.SetActive(false);
        orbe.SetActive(false);

        int notaFinal = PlayerPrefs.GetInt("notaFinalTemp"+idTema.ToString());
        
        if(notaFinal == 10)
        {
            barra.SetActive(true);
            orbe.SetActive(true);
        }else 
        {
            barra.SetActive(false);
            orbe.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
