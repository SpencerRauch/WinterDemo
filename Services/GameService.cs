using Microsoft.EntityFrameworkCore;
using WinterDemo.Data;
using WinterDemo.Entity;

namespace WinterDemo.Services;

public class GameService : IGameService
{
    private DataContext _context;

    public GameService(DataContext context)
    {
        _context = context;
    }

    public async Task<Game> AddGame(Game game)
    {
        _context.Add(game);
        await _context.SaveChangesAsync();
        return game;
    }

    public async Task<List<Game>> GetAllGames()
    {
        List<Game> games = await _context.Games.ToListAsync();
        return games;
    }
}