using UnityEngine;
using System;

public class PlayerManager : MonoBehaviour
{
    /// <summary>現在の状態</summary>
    public IPlayerState CurrentState;


    /// <summary>状態配列</summary>
    private IPlayerState[] states = new IPlayerState[Enum.GetNames(typeof(PlayerManager.STATE)).Length];

    /// <summary>
    /// 状態列挙
    /// </summary>
    public enum STATE
    {
        WAIT,   // 待機
        JUMP,   // ジャンプ
        WALK,   // 歩き
    }

    // Use this for initialization
    private void Start()
    {
        SetStates();
        SwitchState(STATE.WAIT);
    }

    // Update is called once per frame
    private void Update()
    {
        // nullチェック
        if (CurrentState != null)
        {
            // nullでない場合

            CurrentState.Execute();
        }
    }

    /// <summary>
    /// 状態を格納
    /// </summary>
    private void SetStates()
    {
        states[(int)STATE.WAIT] = new PlayerWaitState(this);
        states[(int)STATE.JUMP] = new PlayerJumpState(this);    
        states[(int)STATE.WALK] = new PlayerWalkState(this);
    }

    /// <summary>
    /// 状態切替
    /// </summary>
    public void SwitchState(STATE state)
    {
        int sNum = (int)state;

        CurrentState = null;
        CurrentState = states[sNum];

        // nullチェック
        if(CurrentState != null)
        {
            // 初期化
            CurrentState.Initialize();
        }
    }
}
