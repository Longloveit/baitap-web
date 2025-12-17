namespace WebApplication1.Models
{
    public class ProductViewModel
    {
        // ... Các thuộc tính hiện có ...
        public string Name { get; set; }
        public decimal Price { get; set; } // Giả sử đã chuyển sang decimal
        public decimal OldPrice { get; set; }
        public string Badge { get; set; }

        // IFormFile dùng cho việc tải lên (Upload)
        public IFormFile ImageUpload { get; set; }

        // 💥 THÊM THUỘC TÍNH IMAGEURL ĐỂ HIỂN THỊ
        /// <summary>
        /// Đường dẫn tương đối hoặc URL tuyệt đối của ảnh đã lưu (Dùng cho thẻ <img>)
        /// </summary>
        public string ImageUrl { get; set; }


    }
}
