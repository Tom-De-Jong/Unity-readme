# GDV Opdrachten

## Opdracht les 2.1

Goomba, coin en boo

<img width="359" height="239" alt="image" src="https://github.com/user-attachments/assets/31b69bc8-b039-45ec-9687-0e22361c8cc6" />

Goomba
```
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
    }
```

Boo
```
    void Update()
    {

        transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
    }
```

Coin
```
    void Update()
    {
        transform.Rotate(Vector3.left, 60.0f * Time.deltaTime);
        Debug.Log("Rotating");
    }
```

------------------------------------------------------------

## opdracht les 2.2

### Virtual Pet

ik heb het template van de les gebruikt en mijn eigen code toegevoegd:

```
using UnityEngine;

public class simplepet : MonoBehaviour
{
    
 [Header("Pet Info")]
    public string petName = "Buddy";
    public string petType = "Dog";
    public int petAge = 1;

    [Header("Pet Needs")]
    public float hunger = 50f;      // 0-100
    public float happiness = 70f;   // 0-100
    public float energy = 80f;      // 0-100

    [Header("Pet Status")]
    public bool isSleeping = false;
    public bool isHungry = false;
    public string mood = "Happy";
    public int weight = 10; // Weight in kg
    public int ageInMonths = 15; // Age in months

    void Start()
    {
        Debug.Log("Meet your new pet: " + petName + " the " + petType);
        Debug.Log("Age: " + petAge + " years old");
        Debug.Log("Weight: " + weight + " KG");
        Debug.Log("Age in months: " + ageInMonths + " months");
        Debug.Log("Controls: F = Feed | P = Play | S = Sleep | I = Info");
        ShowPetInfo();
    }

    void Update()
    {
        // Check pet status
        if (hunger < 30)
        {
            isHungry = true;
            mood = "Hungry";
        }
        else if (energy < 20)
        {
            mood = "Tired";
        }
        else if (happiness > 80)
        {
            mood = "Very Happy";
        }
        else
        {
            mood = "Happy";
            isHungry = false;
        }

        // Input controls
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Feed pet
            if (hunger < 100)
            {
                hunger += 25;
                happiness += 10;
                Debug.Log("Fed " + petName + "! Hunger is now: " + hunger);

                if (hunger > 100) hunger = 100;
                if (happiness > 100) happiness = 100;
            }
            else
            {
                Debug.Log(petName + " is already full!");
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            // Play with pet
            if (!isSleeping && energy > 10)
            {
                happiness += 20;
                energy -= 15;
                hunger -= 10;
                Debug.Log("Played with " + petName + "! Happiness: " + happiness);

                if (happiness > 100) happiness = 100;
                if (energy < 0) energy = 0;
                if (hunger < 0) hunger = 0;
            }
            else if (isSleeping)
            {
                Debug.Log(petName + " is sleeping!");
            }
            else
            {
                Debug.Log(petName + " is too tired to play!");
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            // Toggle sleep
            isSleeping = !isSleeping;

            if (isSleeping)
            {
                Debug.Log(petName + " is now sleeping...");
                energy += 30;
                if (energy > 100) energy = 100;
            }
            else
            {
                Debug.Log(petName + " woke up!");
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            // Show pet info
            ShowPetInfo();
        }

        // de waardes gaan langzaam omlaag
        hunger -= 1.0f * Time.deltaTime;
        energy -= 0.5f * Time.deltaTime;
        happiness -= 0.2f * Time.deltaTime;
    }

    void ShowPetInfo()
    {
        Debug.Log("=== PET STATUS ===");
        Debug.Log("Name: " + petName);
        Debug.Log("Type: " + petType);
        Debug.Log("Age: " + petAge + " years");
        Debug.Log("Mood: " + mood);
        Debug.Log("Hunger: " + hunger + "/100");
        Debug.Log("Happiness: " + happiness + "/100");
        Debug.Log("Energy: " + energy + "/100");
        Debug.Log("Sleeping: " + isSleeping);
        Debug.Log("==================");
    }
}

```
------------------------------------------------------------

## Les 3.1

### Oefening 3.1A: Vallende bal met stuiter
<img width="904" height="408" alt="image" src="https://github.com/user-attachments/assets/26a76bee-c16f-464f-b293-d12dc02e5b74" />

### 3.1B: Foutieve physics verkennen
<img width="904" height="408" alt="image" src="https://github.com/user-attachments/assets/f6ef0455-a787-4928-9dad-d76fcda7185d" />

dit is niet realistisch omdat de bal valt en niet stuitert

### 3.1C: Velocity, botsing en trigger-event
<img width="830" height="458" alt="image" src="https://github.com/user-attachments/assets/93eae58a-a685-4dca-be9a-152382ab34ef" />

als de bal het blok raakt wordt hij rood

------------------------------------------------------------

## les 3.2

### Oefeningen Les 3.2: Functies, Argumenten en Return Types

ik heb een spell function gemaakt waarmee je met een functie spreuken in de console kan printen

<img width="754" height="37" alt="image" src="https://github.com/user-attachments/assets/d4d39346-8842-4356-9ca2-fed49ad40d5e" />

Code

```

    void Start()
    {
        string Spreuk(string Namestr, int ManaCostint, string Effectstr, bool CanCastbool)
        {

            string Name = Namestr;
            int ManaCost = ManaCostint;
            string Effect = Effectstr;
            bool CanCast = CanCastbool;

            return "spreuk naam: " + Name + " ManaCost: " + ManaCost + " Effect: " + Effect + " Can cast:  " + CanCast;

        }
        void printOut()
        {
            Debug.Log(Spreuk("oenkoeboenkoe", 35, "speelt een audiafragment (oenkoeboenkoe) af", true));
        }

        printOut();
    }

```

------------------------------------------------------------





