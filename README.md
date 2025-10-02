# GDV Opdrachten

## Opdracht les 2.1

Goomba, coin en boo

![Peek 2025-10-02 13-01](https://github.com/user-attachments/assets/69118e65-fe42-4bf1-95ed-d48f69cc4712)



[Goomba script](https://github.com/Tom-De-Jong/Unity-readme/blob/main/Myproject/Assets/Scripts/goomba.cs)


[Boo script](https://github.com/Tom-De-Jong/Unity-readme/blob/main/Myproject/Assets/Scripts/booscript.cs)


[Coin script](https://github.com/Tom-De-Jong/Unity-readme/blob/main/Myproject/Assets/Scripts/RotationScript.cs)

------------------------------------------------------------

## opdracht les 2.2

### Virtual Pet

ik heb het template van de les gebruikt en mijn eigen code toegevoegd:
[Virtual pet script](https://github.com/Tom-De-Jong/Unity-readme/blob/main/Myproject/Assets/Scripts/simple%20pet.cs)

------------------------------------------------------------

## Les 3.1

### Oefening 3.1A: Vallende bal met stuiter
![Peek 2025-10-02 13-08](https://github.com/user-attachments/assets/d8add085-835e-429a-9c2b-1b561ad56dbc)


### 3.1B: Foutieve physics verkennen
![Peek 2025-10-02 13-11](https://github.com/user-attachments/assets/f3edffb4-03f8-447b-9ac0-1d9c7abc2cf5)

 
dit is niet realistisch omdat de bal valt en niet stuitert

### 3.1C: Velocity, botsing en trigger-event
![Peek 2025-10-02 13-08](https://github.com/user-attachments/assets/c0af64d0-2cd8-45e9-b8da-8af4f88a76c1)

[Collision color change](https://github.com/Tom-De-Jong/Unity-readme/blob/main/Myproject/Assets/Scripts/collisionscript.cs)
[Bal force script](https://github.com/Tom-De-Jong/Unity-readme/blob/main/Myproject/Assets/Scripts/Ballshootwe.cs)
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





