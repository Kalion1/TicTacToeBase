using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : MonoBehaviour
{
    public Sprite playerOneCheckbox;
    public Sprite playerTwoCheckbox;

    //définition de l'enum (réutilisable par d'autres)
    public enum Content
    {
        None = 0,
        PlayerOne = 1,
        PlayerTwo = 2,

        Victory = 3,
        Defeat = 4,
    }

    // Variables de la classe
    public Content currentContent;
    public Content Victorious;

    public List<int> playerOneActions = new List<int>();
    public List<int> playerTwoActions = new List<int>();

    void Start()
    {
        currentContent = Content.PlayerOne;
    }

    
    //Changement de joueur et Victoire
    // on attribue un int à chaque checkbox
    //Check ligne 1 => if (1,2,3) => victory
    public void changePlayer(int _id)
    {
        if (currentContent == Content.PlayerOne)
        {
            currentContent = Content.PlayerTwo;
            playerOneActions.Add(_id);
        }
        else if (currentContent == Content.PlayerTwo)
        {
            currentContent = Content.PlayerOne;
            playerTwoActions.Add(_id);
        }
        checkVictory(playerOneActions);
        checkVictory(playerTwoActions);
    }

    void checkVictory(List<int> _listToCheck)
    {
        bool Victory = false;
        if (_listToCheck.Contains (1) && _listToCheck.Contains (2) && _listToCheck.Contains(3))
        {
            Victory = true;
        }

        else if (_listToCheck.Contains(4) && _listToCheck.Contains(5) && _listToCheck.Contains(6))
        {
            Victory = true;
        }

        else if (_listToCheck.Contains(7) && _listToCheck.Contains(8) && _listToCheck.Contains(9))
        {
            Victory = true;
        }
        else if (_listToCheck.Contains(1) && _listToCheck.Contains(4) && _listToCheck.Contains(7))
        {
            Victory = true;
        }

        else if (_listToCheck.Contains(2) && _listToCheck.Contains(5) && _listToCheck.Contains(8))
        {
            Victory = true;
        }

        else if (_listToCheck.Contains(3) && _listToCheck.Contains(6) && _listToCheck.Contains(9))
        {
            Victory = true;
        }
        else if (_listToCheck.Contains(1) && _listToCheck.Contains(5) && _listToCheck.Contains(9))
        {
            Victory = true;
        }

        else if (_listToCheck.Contains(3) && _listToCheck.Contains(5) && _listToCheck.Contains(7))
        {
            Victory = true;
        }

        if (Victory)
        {
            declareVictory(_listToCheck);
        }

    }

    void declareVictory(List<int> _listToCheck)
    {
        if (_listToCheck == playerOneActions) Victorious = Content.PlayerOne;
        if (_listToCheck == playerTwoActions) Victorious = Content.PlayerTwo;
        currentContent = Content.Victory;
        Debug.Log("VICTOIRE" + Victorious);
    }

    void declareDefeat()
    {

    }
    

}
