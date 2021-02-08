using Api.Hotel.Items;
using Microsoft.Extensions.Logging;
using Server.Database;
using System.Threading.Tasks;

namespace Server.Hotel.Items
{
    public class ItemManager : IItemManager
    {
        private ILogger<IItemManager> logger { get; init; }
        private DatabaseContext databaseContext { get; init; }
        private IITemDataService itemDataService { get; init; }
        public ItemManager(
            ILogger<IItemManager> logger,
            DatabaseContext databaseContext,
            IITemDataService itemDataService)
        {
            this.logger = logger;
            this.databaseContext = databaseContext;
            this.itemDataService = itemDataService;
        }

        public async ValueTask Init()
        {
            await itemDataService.InitAsync();
        }
    }
}
