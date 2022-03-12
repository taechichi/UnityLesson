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

    // ������ ĳ���� ���߰��ϴ� ��
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
                finishedPlayers[i].position = platforms[i].GetChild(0).position; // = platforms[i].Find("PlayerPoint").position; // (����ġ�� �ִٸ� +) +finishedPalyers[i].lossyScale.y/2; <-�׷��� �̰� y���̴� �տ��ִ°��� vector ��
                finishedPlayers[i].transform.rotation = Quaternion.Euler(0, 90, 0);// ���� + new Vector3(0,finishedPalyers[i].lossyScale.y/2 , 0);
            }
        }

        // �ܻ� �ø���
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
