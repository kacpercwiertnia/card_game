using UnityEngine;

[System.Serializable] // Dzięki temu możemy widzieć dane w Inspectorze Unity
public class Card
{
    public string cardName;
    public int attack;
    public int defense;
    public string description;
    public Sprite artwork; // Obrazek karty

    // Konstruktor (opcjonalnie)
    public Card(string name, int atk, int def, string desc, Sprite img)
    {
        cardName = name;
        attack = atk;
        defense = def;
        description = desc;
        artwork = img;
    }
}