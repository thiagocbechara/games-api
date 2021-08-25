using Games.Domain.Models;
using System;
using System.Threading.Tasks;

namespace Games.Infra.Repository.Interfaces
{
    public interface IGameResultRepository
    {
        Task SaveOrUpdateAsync(GameResult gameResult);
    }
}
