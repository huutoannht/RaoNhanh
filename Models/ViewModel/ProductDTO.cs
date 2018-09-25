using NetCore.Models.EntitiesFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NetCore.Models.ViewModel
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        [DisplayName("Tiêu đề tin")]
        public string Name { get; set; }
        [DisplayName("Mô tả")]
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public bool ShowOnHomePage { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        [DisplayName("Giá")]
        public decimal? Price { get; set; }
        [DisplayName("Giá cũ")]
        public decimal? OldPrice { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public string Picture { get; set; }
        public string ProductAlias { get; set; }
        public int? See { get; set; }
        public string PictureSmall { get; set; }
        [DisplayName("Tên công ty tuyển dụng")]
        public string NameCompany { get; set; }
        [DisplayName("Địa chỉ")]
        public int? AddressId { get; set; }
        public int? CapacityPeople { get; set; }
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }
        [DisplayName("Người tuyển dụng")]
        public string Recruiter { get; set; }
        [DisplayName("Diện tích")]
        public double? Area { get; set; }
        [DisplayName("Danh mục đăng tin")]
        public int? PostingCategoryId { get; set; }
        [DisplayName("Loại tin")]
        public int? ItemCategoryId { get; set; }
        [DisplayName("Người bán")]
        public string Seller { get; set; }
        [DisplayName("Tỉnh/Thành phố")]
        public int Provice { get; set; }
        [DisplayName("Quận/Huyện")]
        public int District { get; set; }
        [DisplayName("Địa chỉ")]
        [Required]
        public string NameAddress { get; set; }

        public Address Address { get; set; }
        public Category Category { get; set; }
        public ItemCategory ItemCategory { get; set; }
        public PostingCategory PostingCategory { get; set; }
        public ICollection<Picture> PictureNavigation { get; set; }
    }
}