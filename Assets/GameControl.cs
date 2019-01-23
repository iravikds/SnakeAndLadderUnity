using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow, player1MoveText, player2MoveText,player3MoveText, player4MoveText;

    private static GameObject player1, player2, player3, player4;

    public static int nofPlayers;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public static int player3StartWaypoint = 0;
    public static int player4StartWaypoint = 0;

    public static bool gameOver = false;

    // Use this for initialization
    void Start () {

        diceSideThrown = 0;
        player1StartWaypoint = 0;
        player2StartWaypoint = 0;
        player2StartWaypoint = 0;
        player3StartWaypoint = 0;
        player4StartWaypoint = 0;
        gameOver = false;

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("P1Move");
        player2MoveText = GameObject.Find("P2Move");
        player3MoveText = GameObject.Find("P3Move");
        player4MoveText = GameObject.Find("P4Move");

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player3 = GameObject.Find("Player3");
        player4 = GameObject.Find("Player4");
        

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        player3.GetComponent<FollowThePath>().moveAllowed = false;
        player4.GetComponent<FollowThePath>().moveAllowed = false;

        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver){
            AdmobScript.instance.showInterstitialAd();
        }
        if(Dice.whosTurn == 1){
            player1MoveText.gameObject.SetActive(true);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
        }else if(Dice.whosTurn == 2){
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(false);
        }
        else if(Dice.whosTurn == 3){
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(true);
            player4MoveText.gameObject.SetActive(false);
        }
        else if(Dice.whosTurn == 4){
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            player3MoveText.gameObject.SetActive(false);
            player4MoveText.gameObject.SetActive(true);
        }
// Player 2
        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {
            if(player2StartWaypoint+diceSideThrown == 3){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[24].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 24;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 12){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[45].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 45;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 32){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[48].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 48;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 41){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[62].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 62;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 49){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[68].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 68;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 61){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[80].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 80;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 73){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[91].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 91;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 39){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[2].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 2;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 86){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[36].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 36;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 88){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[52].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 52;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 97){
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[40].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 40;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            player2.GetComponent<FollowThePath>().moveAllowed = false;            
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }
// ** PLAYER 1
        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            //Debug.Log(player1StartWaypoint+diceSideThrown);
            if(player1StartWaypoint+diceSideThrown == 3){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[24].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 24;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 12){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[45].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 45;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 32){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[48].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 48;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 41){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[62].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 62;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 49){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[68].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 68;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 61){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[80].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 80;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 73){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[91].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 91;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 39){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[2].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 2;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 86){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[36].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 36;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 88){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[52].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 52;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 97){
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[40].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 40;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            player1.GetComponent<FollowThePath>().moveAllowed = false;            
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

// ** Player 3
         if (player3.GetComponent<FollowThePath>().waypointIndex > 
            player3StartWaypoint + diceSideThrown)
        {
            //Debug.Log(player3StartWaypoint+diceSideThrown);
            if(player3StartWaypoint+diceSideThrown == 3){
                player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[24].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 24;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 12){
                player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[45].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 45;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 32){
                player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[48].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 48;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 41){
                player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[62].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 62;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 49){
                player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[68].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 68;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 61){
                player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[80].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 80;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 73){
                player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[91].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 91;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 39){
                player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[2].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 2;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 86){
                player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[36].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 36;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 88){
                player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[52].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 52;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            if(player3StartWaypoint+diceSideThrown == 97){
                player3.GetComponent<FollowThePath>().transform.position = player3.GetComponent<FollowThePath>().waypoints[40].transform.position;
                player3.GetComponent<FollowThePath>().waypointIndex = 40;
                player3.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(3);
            }
            player3.GetComponent<FollowThePath>().moveAllowed = false;            
            player3StartWaypoint = player3.GetComponent<FollowThePath>().waypointIndex - 1;
        }
//
        //Player4
        if (player4.GetComponent<FollowThePath>().waypointIndex > 
            player4StartWaypoint + diceSideThrown)
        {
            //Debug.Log(player4StartWaypoint+diceSideThrown);
            if(player4StartWaypoint+diceSideThrown == 3){
                player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[24].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 24;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 12){
                player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[45].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 45;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 32){
                player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[48].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 48;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 41){
                player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[62].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 62;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 49){
                player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[68].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 68;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 61){
                player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[80].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 80;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 73){
                player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[91].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 91;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 39){
                player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[2].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 2;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 86){
                player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[36].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 36;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 88){
                player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[52].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 52;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            if(player4StartWaypoint+diceSideThrown == 97){
                player4.GetComponent<FollowThePath>().transform.position = player4.GetComponent<FollowThePath>().waypoints[40].transform.position;
                player4.GetComponent<FollowThePath>().waypointIndex = 40;
                player4.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(4);
            }
            player4.GetComponent<FollowThePath>().moveAllowed = false;            
            player4StartWaypoint = player4.GetComponent<FollowThePath>().waypointIndex - 1;
        }
        //pl4


        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Count)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Count)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;
        }
        if (player3.GetComponent<FollowThePath>().waypointIndex ==
            player3.GetComponent<FollowThePath>().waypoints.Count)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 3 Wins";
            gameOver = true;
        }
        if (player4.GetComponent<FollowThePath>().waypointIndex ==
            player4.GetComponent<FollowThePath>().waypoints.Count)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 4 Wins";
            gameOver = true;
        }
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 3:
                player3.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 4:
                player4.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }
}
