using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : Singleton<Score>
{
    int currentScore = 0;

    int pointsFromDetonatedBombs = 0;
    int pointsFromGoblins = 0;
    int pointsFromKilledGoblins = 0;
    int pointsFromBookshelves = 0;

    public int Amount { get => currentScore; }


    public void Add(int amount)
    {
        currentScore += amount;
    }

    public void AddDetonatedBomb(int amount)
    {
        pointsFromDetonatedBombs += amount;
        currentScore += amount;
        Debug.Log("Added " + amount + " points!");

    }

    public void AddGoblin(int amount)
    {
        pointsFromGoblins += amount;
        currentScore += amount;

        Debug.Log("Added " + amount + " points!");
    }
    public void AddKilledGoblin(int amount)
    {
        pointsFromKilledGoblins += amount;
        currentScore += amount;
        Debug.Log("Added " + amount + " points!");

    }
    public void AddBookShelves(int amount)
    {
        pointsFromBookshelves += amount;
        currentScore += amount;
        Debug.Log("Added " + amount + " points!");

    }
}
