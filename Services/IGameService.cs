using WinterDemo.Entity;

namespace WinterDemo.Services;

public interface IGameService
{
    Task<List<Game>> GetAllGames();
    Task<Game> AddGame(Game game);
}