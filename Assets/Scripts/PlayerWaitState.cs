using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWaitState : IPlayerState
{
    /// <summary>プレイヤーステートプロセッサー</summary>
    private PlayerStateProcessor pStateProcessor;


    /// <summary>
    /// コンストラクタ
    /// </summary>
    public PlayerWaitState(PlayerStateProcessor pSp)
    {
        this.pStateProcessor = pSp;

        Initialize();
    }


    /// <summary>
    /// 初期化処理
    /// </summary>
    public void Initialize()
    {
        Debug.Log("WaitExe");
    }


    /// <summary>
    /// 待機状態での実行処理
    /// </summary>
    public void Execute()
    {
        // スペースキー入力判別
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 入力があった場合

            // ジャンプ状態に切り替え
            pStateProcessor.SwitchState((int)PlayerStateProcessor.STATE.JUMP);
        }

        // ←入力判別
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 入力があった場合

            // 歩き状態に切り替え
            pStateProcessor.SwitchState((int)PlayerStateProcessor.STATE.WALK);
        }
    }
}
