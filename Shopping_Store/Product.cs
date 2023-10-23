namespace Shopping_Store
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ProductId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public decimal? ProductSale { get; set; }

        public decimal? ProductPurchase { get; set; }

        [Column("fk catagory")]
        public int fk_catagory { get; set; }

        [StringLength(10)]
        public string Pro_Picture { get; set; }

        public virtual Catagory Catagory { get; set; }
    }
}
