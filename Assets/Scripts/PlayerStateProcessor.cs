using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerStateProcessor : BaseStateProcessor
{
    /// <summary>プレイヤーの状態</summary>
    [SerializeField]
    private IPlayerState CurrentState;
    /// <summary>状態配列</summary>
    private IPlayerState[] states = new IPlayerState[Enum.GetNames(typeof(PlayerStateProcessor.STATE)).Length];

    /// <summary>
    /// 状態列挙
    /// </summary>
    public enum STATE
    {
        WAIT = 0,   // 待機
        JUMP,   // ジャンプ
        WALK,   // 歩き
    }


    // Use this for initialization
    void Start()
    {
        SetStates();
        SwitchState((int)STATE.WAIT);
    }

    // Update is called once per frame
    void Update()
    {
        // nullチェック
        if (CurrentState != null)
        {
            // nullでない場合

            CurrentState.Execute();
        }
    }


    /// <summary>
    /// 状態設定
    /// </summary>
    protected override void SetStates()
    {
        states[(int)STATE.WAIT] = new PlayerWaitState(this);
        states[(int)STATE.JUMP] = new PlayerJumpState(this);
        states[(int)STATE.WALK] = new PlayerWalkState(this);

    }

    /// <summary>
    /// 状態切替
    /// </summary>
    /// <param name="sNum">状態を表す数値</param>
    public override void SwitchState(int sNum)
    {
        CurrentState = null;
        CurrentState = states[sNum];

        // nullチェック
        if (CurrentState != null)
        {
            // 初期化
            CurrentState.Initialize();
        }
    }
}
