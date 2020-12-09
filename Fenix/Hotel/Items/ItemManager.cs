using System.Threading.Tasks;

using Api.Hotel.Items;

using Microsoft.Extensions.Logging;

using Server.Database;

namespace Server.Hotel.Items
{
    public class ItemManager : IItemManager
    {
        private ILogger<IItemManager> logger { get; init; }
        private DatabaseContext databaseContext { get; init; }
        private IItemDataRepository<IItemData, ushort> itemDataRepository { get; init; }
        public ItemManager(
            ILogger<IItemManager> logger,
            DatabaseContext databaseContext,
            IItemDataRepository<IItemData, ushort> itemDataRepository)
        {
            this.logger = logger;
            this.databaseContext = databaseContext;
            this.itemDataRepository = itemDataRepository;
        }

        public async ValueTask Init()
        {
            await itemDataRepository.InitAsync();
        }
    }
}
