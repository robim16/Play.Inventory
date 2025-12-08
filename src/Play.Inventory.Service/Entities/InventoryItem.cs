using System;
using Play.Common;

namespace Play.Inventory.Service.Entities
{
    public class InventoryItem : IEntity
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid CatalogItemId { get; set; }//referencia al item del catalogo

        public int Quantity { get; set; }
        
        public DateTimeOffset AcquiredDate { get; set; }
        
    }
}