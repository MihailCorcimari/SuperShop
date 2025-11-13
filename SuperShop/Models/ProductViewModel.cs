using SuperShop.Data.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SuperShop.Models
{
    public class ProductViewModel : Product
    {

        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
