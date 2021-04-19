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
    public int PointsFromDetonatedBombs { get => pointsFromDetonatedBombs; }
    public int PointsFromGoblins { get => pointsFromGoblins; }
    public int PointsFromKilledGoblins { get => pointsFromKilledGoblins; }
    public int PointsFromBookshelves { get => pointsFromBookshelves; }

    public void Add(int amount)
    {
        currentScore += amount;
    }

    public void AddDetonatedBomb(int amount)
    {
        pointsFromDetonatedBombs += amount;
        currentScore += amount;

    }

    public void AddGoblin(int amount)
    {
        pointsFromGoblins += amount;
        currentScore += amount;

    }
    public void AddKilledGoblin(int amount)
    {
        pointsFromKilledGoblins += amount;
        currentScore += amount;

    }
    public void AddBookShelves(int amount)
    {
        pointsFromBookshelves += amount;
        currentScore += amount;

    }
    public int GetObjectsDestroyed()
    {
        if (pointsFromBookshelves != 0)
        {
            return pointsFromBookshelves / 10;
        }
        else return pointsFromBookshelves;

    }
}
