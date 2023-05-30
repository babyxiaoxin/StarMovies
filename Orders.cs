namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            OrdersDetail = new HashSet<OrdersDetail>();
        }

        public int OrdersID { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        public decimal? Amount { get; set; }

        public int? CustomerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeliveryDate { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersDetail> OrdersDetail { get; set; }
    }
}
