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
    using System.Collections.Generic;
    
    public partial class Sales
    {
        public int id { get; set; }
        public int PurchaseQuantity { get; set; }
        public int totalCost { get; set; }
        public string DeliveryAddress { get; set; }
        public int idProducts { get; set; }
        public int idClient { get; set; }
        public int idPaymentForm { get; set; }
        public int idSupply { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual PaymentForm PaymentForm { get; set; }
        public virtual Supply Supply { get; set; }
        public virtual Products Products { get; set; }
    }
}
