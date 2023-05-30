namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdersDetail")]
    public partial class OrdersDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrdersID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string GoodsID { get; set; }

        public int? Quantity { get; set; }

        public decimal? Money { get; set; }

        public virtual Goods Goods { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
