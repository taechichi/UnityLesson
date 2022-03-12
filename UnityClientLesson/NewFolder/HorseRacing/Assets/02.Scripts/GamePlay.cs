using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    static public GamePlay instance;

    private void Awake()
    {
        instance = this;
    }

    public List<GameObject> players = new List<GameObject>();
    private List<Transform> finishedPlayers = new List<Transform>();
    public List<Transform> platforms = new List<Transform>();

    private int totalPlayers;
    private float playerStartZPos;
    public Transform goal;
    public bool onPlay = false;


    private void Start()
    {
        totalPlayers = players.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if(onPlay)
        {
            CheckPlayerReachedToGoalAndStopMove();
            CheckGameIsFinished();
        }
        
    }

    // 도착한 캐릭터 멈추게하는 거
    void CheckPlayerReachedToGoalAndStopMove()
    {
        for (int i = players.Count - 1; i > -1; i--)
        {
            PlayerMove playerMove = players[i].GetComponent<PlayerMove>();
            if (playerMove.distance > goal.position.z - playerStartZPos)
            {
                playerMove.doMove = false;
                finishedPlayers.Add(players[i].transform);
                players.Remove(players[i]);
            }
        }
    }

    void CheckGameIsFinished()
    {
        if(finishedPlayers.Count >= totalPlayers)
        {
            onPlay = false;

            for (int i = 0; i < platforms.Count; i++)
            {
                finishedPlayers[i].position = platforms[i].GetChild(0).position; // = platforms[i].Find("PlayerPoint").position; // (보정치가 있다면 +) +finishedPalyers[i].lossyScale.y/2; <-그런데 이건 y값이다 앞에있는것은 vector 값
                finishedPlayers[i].transform.rotation = Quaternion.Euler(0, 90, 0);// 따라서 + new Vector3(0,finishedPalyers[i].lossyScale.y/2 , 0);
            }
        }

        // 단상에 올리기
    }
    public void PlayGame()
    {
        onPlay = true;
        playerStartZPos = players[0].transform.position.z;
        foreach (var sub in players)
        {
            PlayerMove playerMove = sub.GetComponent<PlayerMove>();
            if (playerMove != null)
            {
                playerMove.doMove = true;
            }
        }
    }
}
