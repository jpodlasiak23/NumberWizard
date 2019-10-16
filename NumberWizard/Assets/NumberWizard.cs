using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Witaj u Liczbowego Czarodzieja");
        print("Pomyśl liczbę w głowie ale nie mów jej na głos");
        int min = 1;
        int max = 1000;
        print("Największa liczba jaką możesz wybrać to:" + max);
        print("Najmniejsza liczba jaką możesz wybrać to:" + min);
        print("czy twoja liczba jest większa czy mniejsza od 500?");
        print("Aby odpowiedzieć na pytanie naciśnij: Górna strzałka = wyższa, Dolna strzałka = niższa, Naciśnij Enter = liczba którą wymyśliłeś");
        if (Input.GetKeyDown( KeyCode.UpArrow)) ;
        if (Input.GetKeyUp(KeyCode.UpArrow)) ;

        print 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
