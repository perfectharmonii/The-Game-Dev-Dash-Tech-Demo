using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public List<Image> spaceList;
    public int P1Position;
    public int P2Position;
    public int P1Goal;
    public int P2Goal;
    public static GameManager Instance;
    public SpaceQueue P1Queue;
    public SpaceQueue P2Queue;
    public Image GetSpace(int index)
    {
        return spaceList[index % spaceList.Count];
    }
	// Use this for initialization
	void Start ()
    {
        if (GameManager.Instance == null)
        {
            GameManager.Instance = this;
        }
    }
	public void TakeTurnP1()
    {
        int P1Movement = 6;
        P1Goal = P1Position + P1Movement;
        P1Queue.Move(P1Position, P1Goal);
        P1Position = P1Goal;
    }
    public void TakeTurnP2()
    {
        int P2Movement = 3;
        P2Goal = P2Position + P2Movement;
        P2Queue.Move(P2Position, P2Goal);
        P2Position = P2Goal;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
