//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppStoreAccounting.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StoreAccountingEntities : DbContext
    {
        public StoreAccountingEntities()
            : base("name=StoreAccountingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CardType> CardType { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientPerson> ClientPerson { get; set; }
        public virtual DbSet<LoadCategory> LoadCategory { get; set; }
        public virtual DbSet<PaymentForm> PaymentForm { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Supply> Supply { get; set; }
        public virtual DbSet<Products> Products { get; set; }
    }
}
