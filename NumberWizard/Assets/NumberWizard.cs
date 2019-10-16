using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;
    void Start()
    {
        print("Witaj u Liczbowego Czarodzieja");
        print("Pomyśl liczbę w głowie ale nie mów jej na głos");
        
        print("Największa liczba jaką możesz wybrać to:" + max);
        print("Najmniejsza liczba jaką możesz wybrać to:" + min);
        print("czy twoja liczba jest większa czy mniejsza od 500?");
        print("Aby odpowiedzieć na pytanie naciśnij: Górna strzałka = wyższa, Dolna strzałka = niższa, Naciśnij Enter = liczba którą wymyśliłeś");
      
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            min = guess;
            guess = (min + max) / 2;
            print("Czy twoja liczba jest mniejsza lub większa niż" + guess);
        }
            
        if (Input.GetKeyDown(KeyCode.DownArrow)) 
            {
            max = guess;
            guess = (min + min) / 2; ;


        print("czy twoja liczba jest większa lub mniejsza niż" +guess);
        }

        if (Input.GetKeyUp(KeyCode.Return))
        print("Haha zgadłem twoją liczbę!");



    }
}
