using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartas : MonoBehaviour
{
    string Txtnaipe;
    int naipe;
    int numero; 
 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Boas, estas pronto para esta incrivel jornada?");
        Debug.Log("Então carrega no espaço e eu vou-te atribuir uma carta que vai representar o teu futuro.");
        Debug.Log("Atreve-te!");

    }

    // Update is called once per frame
    void Update()
    {
        naipe = Random.Range(1, 5);
        numero = Random.Range(1, 15);
        
        if (naipe == 1) Txtnaipe = "Espadas";
        else if (naipe == 2) Txtnaipe = "Copas";
        else if (naipe == 3) Txtnaipe = "Ouros";
        else if (naipe == 4) Txtnaipe = "Paus";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Oh!");
            Debug.Log("Saiu esta carta...");
            if (numero == 1)
                Debug.Log("Ás de " + Txtnaipe + ". O que achas que significa?");
            else if (numero == 7)
                Debug.Log("Bisca de " + Txtnaipe + ". O que achas que significa?");
            else if (numero == 11)
                Debug.Log("Valete de " + Txtnaipe + ". O que achas que significa?");
            else if (numero == 12)
                Debug.Log("Dama de " + Txtnaipe + ". O que achas que significa?");
            else if (numero == 13)
                Debug.Log("Rei de " + Txtnaipe + ". O que achas que significa?");
            else if (numero == 14)
                Debug.Log("Jóquer. O que achas que significa?");
            else
                Debug.Log(numero + " de " + Txtnaipe + ". O que achas que significa?");
        }
    }


}


