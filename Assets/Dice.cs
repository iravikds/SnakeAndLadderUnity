using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour
{

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    public static int whosTurn = 1;
    private bool coroutineAllowed = true;


    // Use this for initialization
    private void Start()
    {
        whosTurn = 1;
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
    }

    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
            GetComponent<AudioSource>().Play();
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.01f);
        }

        GameControl.diceSideThrown = randomDiceSide + 1;
        //randomDiceSide = 5;

        //SWITCH
        switch (GameControl.nofPlayers)
        {
            case 1:
                whosTurn =1;
                GameControl.MovePlayer(1);
                break;
            case 2:
                if (randomDiceSide == 5)
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 1;
                        GameControl.MovePlayer(1);
                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 2;
                        GameControl.MovePlayer(2);
                    }
                    coroutineAllowed = true;
                }
                else
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 2;
                        GameControl.MovePlayer(1);

                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 1;
                        GameControl.MovePlayer(2);

                    }
                }
                break;
            case 3:
                if (randomDiceSide == 5)
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 1;
                        GameControl.MovePlayer(1);
                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 2;
                        GameControl.MovePlayer(2);
                    }else if(whosTurn == 3){
                        whosTurn =3;
                        GameControl.MovePlayer(3);
                    }
                    coroutineAllowed = true;
                }
                else
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 2;
                        GameControl.MovePlayer(1);

                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 3;
                        GameControl.MovePlayer(2);
                    }
                    else if(whosTurn == 3){
                        whosTurn = 1;
                        GameControl.MovePlayer(3);
                    }
                }
                break;
            case 4:
                if (randomDiceSide == 5)
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 1;
                        GameControl.MovePlayer(1);
                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 2;
                        GameControl.MovePlayer(2);
                    }else if(whosTurn == 3){
                        whosTurn =3;
                        GameControl.MovePlayer(3);
                    }
                    else if(whosTurn == 4){
                        whosTurn = 4;
                        GameControl.MovePlayer(4);
                    }
                    coroutineAllowed = true;
                }
                else
                {
                    if (whosTurn == 1)
                    {
                        whosTurn = 2;
                        GameControl.MovePlayer(1);

                    }
                    else if (whosTurn == 2)
                    {
                        whosTurn = 3;
                        GameControl.MovePlayer(2);
                    }
                    else if(whosTurn == 3){
                        whosTurn = 4;
                        GameControl.MovePlayer(3);
                    }else if(whosTurn == 4){
                        whosTurn = 1;
                        GameControl.MovePlayer(4);
                    }
                }
                break;
            

        }
        //END SWITCH

        /*  if (randomDiceSide == 5)
         {
             if (whosTurn == 1)
             {
                 whosTurn = 1;
                 GameControl.MovePlayer(1);
             }
             else if (whosTurn == 2)
             {
                 whosTurn = 2;
                 GameControl.MovePlayer(2);
             }
             coroutineAllowed = true;
         }
         else
         {
             if (whosTurn == 1)
             {
                 whosTurn = 2;
                 GameControl.MovePlayer(1);

             }
             else if (whosTurn == 2)
             {
                 whosTurn = 1;
                 GameControl.MovePlayer(2);

             }
         } */

        //
        //if 6 on the Dice
        /*         if (randomDiceSide == 5)
                {
                    for (int i = 1; i < 2; i++)
                    {
                        if (whosTurn == i)
                        {
                            GameControl.MovePlayer(i);
                            whosTurn = i;
                        }
                        else if (whosTurn == GameControl.nofPlayers)
                        {
                            GameControl.MovePlayer(GameControl.nofPlayers);
                            whosTurn = GameControl.nofPlayers;
                        }
                    }
                }
                else{
                //if 1 to 5 on Dice

                for (int i = 1; i < 2; i++)
                {
                    if (whosTurn == GameControl.nofPlayers)
                    {
                        GameControl.MovePlayer(GameControl.nofPlayers);
                        whosTurn = 1;
                        Debug.Log("this happens");
                    } 
                    else if (whosTurn == i)
                    {
                        Debug.Log("is this?");
                        GameControl.MovePlayer(i);
                        whosTurn = i + 1;
                    }
                }
                } */

        //Debug.Log(whosTurn);
        coroutineAllowed = true;

    }
}
