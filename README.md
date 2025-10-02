# GDV Opdrachten

## Opdracht les 2.1

Goomba, coin en boo

![Peek 2025-10-02 13-01](https://github.com/user-attachments/assets/69118e65-fe42-4bf1-95ed-d48f69cc4712)



[Goomba script](https://github.com/Tom-De-Jong/Unity-readme/blob/main/Myproject/Assets/Scripts/goomba.cs)


[Boo script](https://github.com/Tom-De-Jong/Unity-readme/blob/main/Myproject/Assets/Scripts/booscript.cs)

Coin
[Coin script](https://github.com/Tom-De-Jong/Unity-readme/blob/main/Myproject/Assets/Scripts/RotationScript.cs)

------------------------------------------------------------

## opdracht les 2.2

### Virtual Pet

ik heb het template van de les gebruikt en mijn eigen code toegevoegd:
[Virtual pet script](https://github.com/Tom-De-Jong/Unity-readme/blob/main/Myproject/Assets/Scripts/simple%20pet.cs)

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





