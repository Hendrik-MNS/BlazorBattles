using BlazorBattles.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public interface IBattleService
    {
        BattleResults LastBattle { get; set; }
        IList<BattleHistoryEntry> History { get; set; }
        Task<BattleResults> StartBattle(int opponentId);
        Task GetHistory();
    }
}
