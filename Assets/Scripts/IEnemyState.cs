/// <summary>
/// 敵の状態インターフェイス
/// </summary>
public interface IEnemyState
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
