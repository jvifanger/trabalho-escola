using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaInfoSolo : MonoBehaviour
{
    public int idTema;

    
    public GameObject orbe;

    private int notaFinal;

    // Start is called before the first frame update
    void Start()
    {
        
        orbe.SetActive(false);

        int notaFinal = PlayerPrefs.GetInt("notaFinalTemp"+idTema.ToString());
        
        if(notaFinal == 10)
        {
            
            orbe.SetActive(true);
        }else 
        {
            orbe.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
