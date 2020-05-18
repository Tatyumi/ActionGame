/// <summary>
/// プレイヤーの状態インターフェイス
/// </summary>
public interface IPlayerState
{
    /// <summary>
    /// 初期化
    /// </summary>
    void Initialize();

    /// <summary>
    /// 状態に応じて実行する処理
    /// </summary>
    void Execute();
}
