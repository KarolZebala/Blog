using System;

namespace WebAPI.Controllers
{
    internal class SwaggerOparationAttribute : Attribute
    {
        public string Summary { get; set; }
    }
}