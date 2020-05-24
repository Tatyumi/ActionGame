using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : IPlayerState
{
    /// <summary>プレイヤーステートプロセッサー</summary>
    private PlayerStateProcessor pStateProcessor;
    /// <summary>経過時間</summary>
    private float deltaTime;
    /// <summary>ジャンプ時間</summary>
    private float JUMP_TIME = 2.0f;


    /// <summary>
    /// コンストラクタ
    /// </summary>
    public PlayerJumpState(PlayerStateProcessor pSp)
    {
        this.pStateProcessor = pSp;
        Debug.Log("Jump!!!!!");

        Initialize();
    }


    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Initialize()
    {
        deltaTime = 0.0f;

        Debug.Log("JumpExeCute");
    }

    /// <summary>
    /// ジャンプ状態で実行する処理
    /// </summary>
    public void Execute()
    {

        // 計測
        deltaTime += Time.deltaTime;

        // ジャンプ時間に達したか判別
        if(deltaTime > JUMP_TIME)
        {
            // 待機状態に切り替え
            pStateProcessor.SwitchState((int)PlayerStateProcessor.STATE.WAIT);
        }
    }
}
