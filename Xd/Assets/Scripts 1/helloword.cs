using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloword : MonoBehaviour
{       
        double MileNaKilometry (double a)
    {
        a = a * 1.609344;
        print(a);
        return 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        MileNaKilometry(14.5);
        int min = 1;
        int max = 1000;
        print("witaj w liczbowym czarodzieju");
        print("wybierz liczbe z przedziału 1 do 100");
        print("maksymalna liczba jaka mozesz wybrac to" + max);
        print("minimalna liczba jaka mozesz wybrac to" + min);
        print ("czy twoja liczba jest mniejsza lub wieksza niz 500?")
            print ("nacisnij strzalke w gore aby odpowiedziec ze wieksza ")
            print("nacisnij strzalke w dol aby odpowiedziec ze mniejsza")
            print ("nacisnij enter aby potwierdzic ze komputer zgadl liczbe")

            if (Input.GetKeyDown(KeyCode))
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
