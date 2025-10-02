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
